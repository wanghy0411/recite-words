using sdk;
using sdk.dictionary.list;
using sdk.id;
using sdk.words;
using sdk.words.delete;
using sdk.words.list;
using sdk.words.save;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords.words
{
    public partial class FormWords : Form
    {
        private NoodleTokenClient _noodleTokenClient;

        private DataTable _dtDictionary;
        private long _currentDictionaryId;

        private DataTable _dtWords;
        private long _currentWordsId;

        private int pageSize = 50000;

        public FormWords()
        {
            InitializeComponent();
        }

        private void FormWords_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            DictionaryListRequest request = new DictionaryListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");

            List<Dictionary> dictionaries = _noodleTokenClient.DoPost(request);
            _dtDictionary = DataTableHelper.ToDataTable<Dictionary>(dictionaries);

            comboBoxDictionary.DataSource = _dtDictionary;
            comboBoxDictionary.DisplayMember = "Name";
        }

        private void FormWords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    saveWords();
                }
                else if (e.KeyCode == Keys.I)
                {
                    addWords();
                }
            }
        }

        private void comboBoxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDictionary.SelectedIndex<0)
            {
                return;
            }
            textBoxSpelling.Text = "";
            textBoxPronunciation.Text = "";
            textBoxExplanation.Text = "";

            DataRow dr = _dtDictionary.Rows[comboBoxDictionary.SelectedIndex];
            _currentDictionaryId = (long) dr["Id"];
            if (UserInfo.AdminFlag <= 0 && "Y".Equals(dr["PublicFlag"].ToString()))
            {
                textBoxSpelling.ReadOnly = true;
                textBoxPronunciation.ReadOnly = true;
                textBoxExplanation.ReadOnly = true;
            }
            else
            {
                textBoxSpelling.ReadOnly = false;
                textBoxPronunciation.ReadOnly = false;
                textBoxExplanation.ReadOnly = false;
            }

            WordsListRequest request = new WordsListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.DictionaryId = _currentDictionaryId;
            request.PageNum = 1;
            request.PageSize = pageSize;

            List<Words> wordsList = _noodleTokenClient.DoPost(request);
            _dtWords = DataTableHelper.ToDataTable<Words>(wordsList);

            dataGridViewWords.DataSource = _dtWords;
        }

        private void dataGridViewWords_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dataGridViewWords_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewWords.CurrentCell == null)
            {
                return;
            }
            int currentRowIndex = dataGridViewWords.CurrentCell.RowIndex;
            DataRow currentDataRow = _dtWords.Rows[currentRowIndex];
            if (currentDataRow.RowState.Equals(DataRowState.Detached))
            {
                return;
            }

            _currentWordsId = (long)currentDataRow["Id"];
            textBoxSpelling.Text = currentDataRow["Spelling"] == null ? null : currentDataRow["Spelling"].ToString();
            textBoxPronunciation.Text = currentDataRow["Pronunciation"] == null ? null : currentDataRow["Pronunciation"].ToString();
            textBoxExplanation.Text = currentDataRow["Explanation"] == null ? null : currentDataRow["Explanation"].ToString();

        }

        private void addWords()
        {
            _currentWordsId = 0;

            textBoxSpelling.Text = "";
            textBoxPronunciation.Text = "";
            textBoxExplanation.Text = "";

            textBoxSpelling.Focus();
        }

        private void saveWords()
        {
            //填充Words对象
            Words words = new Words();
            DataRow dr;

            int focusRow;
            if (_currentWordsId == 0)
            {
                NoodleIdGeneratorRequest noodleIdGeneratorRequest = new NoodleIdGeneratorRequest();
                noodleIdGeneratorRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
                List<long> ids = _noodleTokenClient.DoPost(noodleIdGeneratorRequest);
                _currentWordsId = ids[0];

                dr = _dtWords.NewRow();
                dr["Id"] = _currentWordsId;
                dr["DictionaryId"] = _currentDictionaryId;

                focusRow = _dtWords.Rows.Count;
            }
            else
            {
                DataRow[] drs = _dtWords.Select("Id = " + _currentWordsId);
                dr = drs[0];

                focusRow = dataGridViewWords.CurrentCell.RowIndex;
            }

            dr["Spelling"] = textBoxSpelling.Text;
            dr["Pronunciation"] = textBoxPronunciation.Text;
            dr["Explanation"] = textBoxExplanation.Text;
            if (dr.RowState.Equals(DataRowState.Detached))
            {
                _dtWords.Rows.Add(dr);
            }
            _dtWords.AcceptChanges();

            dataGridViewWords.CurrentCell = dataGridViewWords.Rows[focusRow].Cells["Spelling"];

            words.Id = (long)dr["Id"];
            words.DictionaryId = (long)dr["DictionaryId"];
            words.Spelling = textBoxSpelling.Text;
            words.Pronunciation = textBoxPronunciation.Text;
            words.Explanation = textBoxExplanation.Text;

            WordsSaveRequest request = new WordsSaveRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.Words = words;
            _noodleTokenClient.DoPost(request);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addWords();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveWords();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_currentWordsId == 0)
            {
                return;
            }

            if (MessageBox.Show("是否真的删除单词?", "提示信息", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            WordsDeleteRequest request = new WordsDeleteRequest();
            request.WordsId = _currentWordsId;
            _noodleTokenClient.DoPost(request);

            DataRow[] drs = _dtWords.Select("Id = " + _currentWordsId);
            _dtWords.Rows.Remove(drs[0]);
            _dtWords.AcceptChanges();

            if (_dtWords.Rows.Count == 0)
            {
                addWords();
            }
        }
    }
}
