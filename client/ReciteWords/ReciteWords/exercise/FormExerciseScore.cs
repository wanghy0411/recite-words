using sdk;
using sdk.exercise;
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
    public partial class FormExerciseScore : Form
    {
        private long _exerciseId;
        private DataTable _dtExerciseWords;
        private NoodleTokenClient _noodleTokenClient;

        public FormExerciseScore(long exerciseId)
        {
            this._exerciseId = exerciseId;
            InitializeComponent();
        }

        private void FormExerciseScore_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            ExerciseWordsRequest request = new ExerciseWordsRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.ExerciseId = _exerciseId;
            List<ExerciseWordsDto> exerciseWordsList = _noodleTokenClient.DoPost(request);
            foreach (ExerciseWordsDto exerciseWordsDto in exerciseWordsList)
            {
                exerciseWordsDto.Correct = 1;
            }
            _dtExerciseWords = DataTableHelper.ToDataTable<ExerciseWordsDto>(exerciseWordsList);

            dataGridViewWords.DataSource = _dtExerciseWords;
        }

        private void dataGridViewWords_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            ExerciseScoreRequest request = new ExerciseScoreRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.Id = _exerciseId;

            List<ExerciseWords> exerciseWordsList = new List<ExerciseWords>();
            foreach (DataRow dr in _dtExerciseWords.Rows)
            {
                ExerciseWords exerciseWords = new ExerciseWords();
                exerciseWords.Id = (long) dr["Id"];
                exerciseWords.Correct = (int)dr["Correct"];

                exerciseWordsList.Add(exerciseWords);
            }
            request.ExerciseWords = exerciseWordsList;
            _noodleTokenClient.DoPost(request);

            MessageBox.Show("保存成功!", "提示信息");

            Refresh();
        }
    }
}
