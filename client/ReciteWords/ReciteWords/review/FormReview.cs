using sdk;
using sdk.review;
using sdk.review.list;
using sdk.review.words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords.review
{
    public partial class FormReview : Form
    {
        private DataTable _dtReview;
        private DataTable _dtReviewWords;
        private NoodleTokenClient _noodleTokenClient;

        public FormReview()
        {
            InitializeComponent();
        }

        private void FormReview_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            refreshData();
        }

        private void refreshData()
        {
            ReviewListRequest request = new ReviewListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");

            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            request.StartTimestamp = Convert.ToInt64(ts.TotalMilliseconds) - 60L * 24 * 60 * 60 * 1000;

            List<Review> reviews = _noodleTokenClient.DoPost(request);
            reviews.Sort((x, y) => y.ReviewTime.CompareTo(x.ReviewTime));

            foreach (Review review in reviews)
            {
                review.ReviewDateTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddMilliseconds(review.ReviewTime);
            }
            _dtReview = DataTableHelper.ToDataTable<Review>(reviews);


            dataGridViewReview.DataSource = _dtReview;
        }

        private void dataGridViewReview_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewReview.CurrentCell == null)
            {
                return;
            }
            int currentRowIndex = dataGridViewReview.CurrentCell.RowIndex;
            DataRow currentDataRow = _dtReview.Rows[currentRowIndex];
            if (currentDataRow.RowState.Equals(DataRowState.Detached))
            {
                return;
            }

            ReviewWordsRequest request = new ReviewWordsRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.ReviewId = (long)currentDataRow["Id"];
            List<ReviewWordsDto> reviewWordsDtos = _noodleTokenClient.DoPost(request);

            _dtReviewWords = DataTableHelper.ToDataTable<ReviewWordsDto>(reviewWordsDtos);

            dataGridViewReviewWords.DataSource = _dtReviewWords;
        }

        private void dataGridViewReview_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dataGridViewReviewWords_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            //判断1个小时内是否有背诵记录
            if (dataGridViewReview.Rows.Count > 0)
            {
                long reviewTime = (long)_dtReview.Rows[0]["ReviewTime"];
                long nowTimestamp = Convert.ToInt64((DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalMilliseconds);

                if (nowTimestamp - reviewTime < 60 * 60 * 1000)
                {
                    if (MessageBox.Show("刚刚已经复习过单词了，是否要再来一批？", "提示信息", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            FormReviewSelect form = new FormReviewSelect();
            form.ShowDialog(this);

            refreshData();
        }
    }
}
