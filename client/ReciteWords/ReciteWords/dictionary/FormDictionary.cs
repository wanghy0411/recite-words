using sdk;
using sdk.dictionary.delete;
using sdk.dictionary.list;
using sdk.dictionary.save;
using sdk.id;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords.vocabulary
{
    public partial class FormDictionary : Form
    {
        private DataTable _dtDictionary;
        private long _currentDictionaryId;
        private NoodleTokenClient _noodleTokenClient;

        public FormDictionary()
        {
            InitializeComponent();
        }

        private void FormVocabulary_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            DictionaryListRequest request = new DictionaryListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");

            List<Dictionary> dictionaries = _noodleTokenClient.DoPost(request);
            _dtDictionary = DataTableHelper.ToDataTable<Dictionary>(dictionaries);

            dataGridViewDictionary.DataSource = _dtDictionary;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //填充Dictionary对象
            Dictionary dictionary = new Dictionary();
            DataRow dr;
            if (_currentDictionaryId == 0)
            {
                NoodleIdGeneratorRequest noodleIdGeneratorRequest = new NoodleIdGeneratorRequest();
                noodleIdGeneratorRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
                List<long> ids = _noodleTokenClient.DoPost(noodleIdGeneratorRequest);
                _currentDictionaryId = ids[0];

                dr = _dtDictionary.NewRow();
                dr["Id"] = _currentDictionaryId;
                dr["PublicFlag"] = UserInfo.AdminFlag > 0 ? "Y" : "N";
            }
            else
            {
                DataRow[] drs = _dtDictionary.Select("Id = " + _currentDictionaryId);
                dr = drs[0];
            }

            dr["Name"] = textBoxDictionary.Text;
            dr["Publisher"] = textBoxPublisher.Text;
            dr["ValidFlag"] = checkBoxValidFlag.Checked ? "Y" : "N";
            if (dr.RowState.Equals(DataRowState.Detached))
            {
                _dtDictionary.Rows.Add(dr);
            }
            _dtDictionary.AcceptChanges();

            dictionary.Id = (long) dr["Id"];
            dictionary.Name = textBoxDictionary.Text;
            dictionary.Publisher = textBoxPublisher.Text;
            dictionary.ValidFlag = (string)dr["ValidFlag"];
            dictionary.PublicFlag = (string)dr["PublicFlag"];

            DictionarySaveRequest request = new DictionarySaveRequest();
            request.Dictionary = dictionary;
            _noodleTokenClient.DoPost(request);

        }

        private void dataGridViewDictionary_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewDictionary.CurrentCell == null)
            {
                return;
            }
            int currentRowIndex = dataGridViewDictionary.CurrentCell.RowIndex;
            DataRow currentDataRow = _dtDictionary.Rows[currentRowIndex];
            if (currentDataRow.RowState.Equals(DataRowState.Detached))
            {
                return;
            }

            _currentDictionaryId = (long)currentDataRow["Id"];
            textBoxDictionary.Text = currentDataRow["Name"]==null?null: currentDataRow["Name"].ToString();
            textBoxPublisher.Text = currentDataRow["Publisher"] == null ? null : currentDataRow["Publisher"].ToString();
            checkBoxValidFlag.Checked = "Y".Equals(currentDataRow["ValidFlag"].ToString());

            if (UserInfo.AdminFlag <= 0 && "Y".Equals(currentDataRow["PublicFlag"].ToString()))
            {
                textBoxDictionary.Enabled = false;
                textBoxPublisher.Enabled = false;
                checkBoxValidFlag.Enabled = false;
            }
            else
            {
                textBoxDictionary.Enabled = true;
                textBoxPublisher.Enabled = true;
                checkBoxValidFlag.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addDictionary();
        }

        private void addDictionary()
        {
            _currentDictionaryId = 0;

            textBoxDictionary.Text = "";
            textBoxPublisher.Text = "";
            checkBoxValidFlag.Checked = true;

            textBoxDictionary.Focus();
        }

        private void dataGridViewDictionary_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_currentDictionaryId == 0)
            {
                return;
            }

            if (MessageBox.Show("是否真的删除字典?", "提示信息", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DictionaryDeleteRequest request = new DictionaryDeleteRequest();
            request.DictionaryId = _currentDictionaryId;
            _noodleTokenClient.DoPost(request);

            DataRow[] drs = _dtDictionary.Select("Id = " + _currentDictionaryId);
            _dtDictionary.Rows.Remove(drs[0]);
            _dtDictionary.AcceptChanges();

            if (_dtDictionary.Rows.Count==0)
            {
                addDictionary();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            FormDictionarySelect form = new FormDictionarySelect();
            form.ShowDialog(this);

            DictionaryListRequest request = new DictionaryListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");

            List<Dictionary> dictionaries = _noodleTokenClient.DoPost(request);
            _dtDictionary = DataTableHelper.ToDataTable<Dictionary>(dictionaries);

            dataGridViewDictionary.DataSource = _dtDictionary;
        }
    }
}
