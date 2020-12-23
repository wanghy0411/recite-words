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
    public partial class FormExercise : Form
    {
        private DataTable _dtExercise;
        private DataTable _dtExerciseWords;
        private NoodleTokenClient _noodleTokenClient;

        public FormExercise()
        {
            InitializeComponent();
        }

        private void FormExercise_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);

            refreshData();
        }

        private void refreshData()
        {
            ExerciseListRequest request = new ExerciseListRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");

            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            request.StartTimestamp = Convert.ToInt64(ts.TotalMilliseconds) - 60L * 24 * 60 * 60 * 1000;

            List<Exercise> exercises = _noodleTokenClient.DoPost(request);
            exercises.Sort((x, y) => y.ExerciseTime.CompareTo(x.ExerciseTime));

            foreach (Exercise exercise in exercises)
            {
                exercise.ExerciseDateTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddMilliseconds(exercise.ExerciseTime);
            }
            _dtExercise = DataTableHelper.ToDataTable<Exercise>(exercises);


            dataGridViewExercise.DataSource = _dtExercise;
        }

        private void dataGridViewExercise_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewExercise.CurrentCell == null)
            {
                return;
            }
            int currentRowIndex = dataGridViewExercise.CurrentCell.RowIndex;
            DataRow currentDataRow = _dtExercise.Rows[currentRowIndex];
            if (currentDataRow.RowState.Equals(DataRowState.Detached))
            {
                return;
            }

            ExerciseWordsRequest request = new ExerciseWordsRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.ExerciseId = (long)currentDataRow["Id"];
            List<ExerciseWordsDto> exerciseWordsDtos = _noodleTokenClient.DoPost(request);

            _dtExerciseWords = DataTableHelper.ToDataTable<ExerciseWordsDto>(exerciseWordsDtos);

            dataGridViewWords.DataSource = _dtExerciseWords;
        }

        private void dataGridViewExercise_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dataGridViewWords_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void buttonExercise_Click(object sender, EventArgs e)
        {
            //判断1个小时内是否有背诵记录
            if (dataGridViewExercise.Rows.Count > 0)
            {
                long exerciseTime = (long)_dtExercise.Rows[0]["ExerciseTime"];
                long nowTimestamp = Convert.ToInt64((DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1))).TotalMilliseconds);

                if (nowTimestamp - exerciseTime < 60 * 60 * 1000)
                {
                    if (MessageBox.Show("刚刚已经测验过单词了，是否要再来一批？", "提示信息", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            FormExerciseSelect form = new FormExerciseSelect();
            form.ShowDialog(this);

            refreshData();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            if (dataGridViewExercise.Rows.Count <= 0)
            {
                return;
            }

            if (dataGridViewExercise.CurrentCell == null)
            {
                return;
            }
            int currentRowIndex = dataGridViewExercise.CurrentCell.RowIndex;
            DataRow currentDataRow = _dtExercise.Rows[currentRowIndex];
            if (currentDataRow.RowState.Equals(DataRowState.Detached))
            {
                return;
            }

            long exerciseId = (long)currentDataRow["Id"];

            FormExerciseScore form = new FormExerciseScore(exerciseId);
            form.ShowDialog(this);

            refreshData();
        }
    }
}
