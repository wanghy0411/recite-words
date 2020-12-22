using sdk;
using sdk.id;
using sdk.review;
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
    public partial class FormReviewSelect : Form
    {
        private DataTable _dtVocabulary;
        private NoodleTokenClient _noodleTokenClient;

        public FormReviewSelect()
        {
            InitializeComponent();
        }

        private void FormReviewSelect_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            RefreshData();
        }

        private void RefreshData()
        {
            ReviewVocabularyListRequest request = new ReviewVocabularyListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.PageNum = 1;
            request.PageSize = 50;
            List<ReviewVocabularyDto> ReviewVocabularys = _noodleTokenClient.DoPost(request);
            _dtVocabulary = DataTableHelper.ToDataTable<ReviewVocabularyDto>(ReviewVocabularys);

            dataGridViewVocabulary.DataSource = _dtVocabulary;

            textBoxNumber.Text = ReviewVocabularys.Count.ToString();
        }

        private void dataGridViewVocabulary_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int wordsNumber = 0;
            if (!int.TryParse(textBoxNumber.Text.Trim(), out wordsNumber))
            {
                textBoxNumber.Focus();
                MessageBox.Show("请输入正确的数字", "提示信息");
                return;
            }

            if (_dtVocabulary.Rows.Count == 0)
            {
                MessageBox.Show("没有可复习的单词了", "提示信息");
                return;
            }

            if (wordsNumber == 0)
            {
                textBoxNumber.Focus();
                MessageBox.Show("请输入正确的数字", "提示信息");
                return;
            }

            //生成复习的单词列表
            if (_dtVocabulary.Rows.Count<wordsNumber)
            {
                wordsNumber = _dtVocabulary.Rows.Count;
            }
            List<long> vocabularyIds = new List<long>();
            for (int i=0;i< wordsNumber; i++)
            {
                vocabularyIds.Add((long)_dtVocabulary.Rows[i]["VocabularyId"]);
            }

            //取唯一id
            NoodleIdGeneratorRequest noodleIdGeneratorRequest = new NoodleIdGeneratorRequest();
            noodleIdGeneratorRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            List<long> ids = _noodleTokenClient.DoPost(noodleIdGeneratorRequest);

            //生成复习记录
            ReviewAddRequest reviewAddRequest = new ReviewAddRequest();
            reviewAddRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            reviewAddRequest.Id = ids[0];
            reviewAddRequest.Comment = textBoxComment.Text.Trim();
            reviewAddRequest.VocabularyIds = vocabularyIds;
            _noodleTokenClient.DoPost(reviewAddRequest);

            //刷新数据
            RefreshData();
        }
    }
}
