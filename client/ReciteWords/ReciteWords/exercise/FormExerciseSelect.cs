using sdk;
using sdk.exercise;
using sdk.id;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords.exercise
{
    public partial class FormExerciseSelect : Form
    {
        private DataTable _dtVocabulary;
        private NoodleTokenClient _noodleTokenClient;

        public FormExerciseSelect()
        {
            InitializeComponent();
        }

        private void FormExerciseSelect_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            RefreshData();
        }

        private void RefreshData()
        {
            ExerciseVocabularyListRequest request = new ExerciseVocabularyListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.PageNum = 1;
            request.PageSize = 50;
            List<ExerciseVocabularyDto> exerciseVocabularys = _noodleTokenClient.DoPost(request);
            _dtVocabulary = DataTableHelper.ToDataTable<ExerciseVocabularyDto>(exerciseVocabularys);

            dataGridViewVocabulary.DataSource = _dtVocabulary;

            textBoxNumber.Text = exerciseVocabularys.Count.ToString();
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
                MessageBox.Show("没有可测验的单词了", "提示信息");
                return;
            }

            if (wordsNumber == 0)
            {
                textBoxNumber.Focus();
                MessageBox.Show("请输入正确的数字", "提示信息");
                return;
            }

            //生成测验的单词列表
            if (_dtVocabulary.Rows.Count < wordsNumber)
            {
                wordsNumber = _dtVocabulary.Rows.Count;
            }
            List<long> vocabularyIds = new List<long>();
            for (int i = 0; i < wordsNumber; i++)
            {
                vocabularyIds.Add((long)_dtVocabulary.Rows[i]["VocabularyId"]);
            }

            //取唯一id
            NoodleIdGeneratorRequest noodleIdGeneratorRequest = new NoodleIdGeneratorRequest();
            noodleIdGeneratorRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            List<long> ids = _noodleTokenClient.DoPost(noodleIdGeneratorRequest);

            //生成测验记录
            ExerciseAddRequest exerciseAddRequest = new ExerciseAddRequest();
            exerciseAddRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            exerciseAddRequest.Id = ids[0];
            exerciseAddRequest.Comment = textBoxComment.Text.Trim();
            exerciseAddRequest.VocabularyIds = vocabularyIds;
            _noodleTokenClient.DoPost(exerciseAddRequest);

            //刷新数据
            MessageBox.Show("添加测验记录成功", "提示信息");
            DialogResult = DialogResult.OK;
        }

        private void dataGridViewVocabulary_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
