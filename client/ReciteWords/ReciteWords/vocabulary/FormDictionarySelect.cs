using sdk;
using sdk.dictionary.select;
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
    public partial class FormDictionarySelect : Form
    {
        private DataTable _dtDictionary;
        private NoodleTokenClient _noodleTokenClient;

        public FormDictionarySelect()
        {
            InitializeComponent();
        }

        private void FormDictionarySelect_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DictionarySearchPublicRequest request = new DictionarySearchPublicRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.NameCondition = textBoxCondition.Text.Trim();

            List<DictionarySearchPublicDto> dictionaries = _noodleTokenClient.DoPost(request);

            _dtDictionary = DataTableHelper.ToDataTable<DictionarySearchPublicDto>(dictionaries);

            dataGridViewDictionary.DataSource = _dtDictionary;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewDictionary.CurrentCell==null || dataGridViewDictionary.CurrentCell.RowIndex<0)
            {
                MessageBox.Show("请选择对应的字典", "提示信息");
                return;
            }

            DataRow dr = _dtDictionary.Rows[dataGridViewDictionary.CurrentCell.RowIndex];
            bool isSelected = (bool) dr["Selected"];
            if (isSelected)
            {
                MessageBox.Show("此字典已被选定, 不需要再次选定", "提示信息");
                return;
            }

            DictionarySelectRequest request = new DictionarySelectRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.DictionaryId = (long) dr["Id"];
            _noodleTokenClient.DoPost(request);

            dr["Selected"] = true;
            _dtDictionary.AcceptChanges();
        }
    }
}
