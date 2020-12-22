using sdk;
using sdk.recite;
using sdk.recite.list;
using sdk.recite.words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords.recite
{
    public partial class FormRecite : Form
    {
        private DataTable _dtRecite;
        private DataTable _dtReciteWords;
        private NoodleTokenClient _noodleTokenClient;

        public FormRecite()
        {
            InitializeComponent();
        }

        private void FormRecite_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            refreshData();
        }

        private void refreshData()
        {
            ReciteListRequest request = new ReciteListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");

            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            request.StartTimestamp = Convert.ToInt64(ts.TotalMilliseconds) - 60L * 24 * 60 * 60 * 1000;

            List<Recite> recites = _noodleTokenClient.DoPost(request);
            recites.Sort((x, y) => y.ReciteTime.CompareTo(x.ReciteTime));

            foreach (Recite recite in recites)
            {
                recite.ReciteDateTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddMilliseconds(recite.ReciteTime);
            }
            _dtRecite = DataTableHelper.ToDataTable<Recite>(recites);


            dataGridViewRecite.DataSource = _dtRecite;
        }

        private void dataGridViewRecite_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewRecite.CurrentCell == null)
            {
                return;
            }
            int currentRowIndex = dataGridViewRecite.CurrentCell.RowIndex;
            DataRow currentDataRow = _dtRecite.Rows[currentRowIndex];
            if (currentDataRow.RowState.Equals(DataRowState.Detached))
            {
                return;
            }

            ReciteWordsRequest request = new ReciteWordsRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.ReciteId = (long)currentDataRow["Id"];
            List<ReciteWordsDto> reciteWordsDtos = _noodleTokenClient.DoPost(request);

            _dtReciteWords = DataTableHelper.ToDataTable<ReciteWordsDto>(reciteWordsDtos);

            dataGridViewReciteWords.DataSource = _dtReciteWords;
        }

        private void dataGridViewRecite_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dataGridViewReciteWords_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void buttonRecite_Click(object sender, EventArgs e)
        {
            //判断1个小时内是否有背诵记录
            if (dataGridViewRecite.Rows.Count>0)
            {
                long reciteTime = (long) _dtRecite.Rows[0]["ReciteTime"];
                long nowTimestamp = Convert.ToInt64((DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalMilliseconds);
                
                if (nowTimestamp - reciteTime < 60 * 60 * 1000)
                {
                    if (MessageBox.Show("刚刚已经背过单词了，是否要再背一批？","提示信息",MessageBoxButtons.YesNo)==DialogResult.No)
                    {
                        return;
                    }
                }

                FormReciteSelect form = new FormReciteSelect();
                form.ShowDialog(this);

                refreshData();
            }
        }
    }
}
