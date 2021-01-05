
namespace ReciteWords.exercise
{
    partial class FormExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonScore = new System.Windows.Forms.Button();
            this.buttonExercise = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewExercise = new System.Windows.Forms.DataGridView();
            this.ExerciseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerciseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerciseDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.ExerciseDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerciseId_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pronunciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonScore);
            this.panel1.Controls.Add(this.buttonExercise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 0;
            // 
            // buttonScore
            // 
            this.buttonScore.Location = new System.Drawing.Point(106, 22);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(92, 23);
            this.buttonScore.TabIndex = 1;
            this.buttonScore.Text = "测验结果输入";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // buttonExercise
            // 
            this.buttonExercise.Location = new System.Drawing.Point(25, 22);
            this.buttonExercise.Name = "buttonExercise";
            this.buttonExercise.Size = new System.Drawing.Size(75, 23);
            this.buttonExercise.TabIndex = 0;
            this.buttonExercise.Text = "今日测验";
            this.buttonExercise.UseVisualStyleBackColor = true;
            this.buttonExercise.Click += new System.EventHandler(this.buttonExercise_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewExercise);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 389);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewExercise
            // 
            this.dataGridViewExercise.AllowUserToAddRows = false;
            this.dataGridViewExercise.AllowUserToDeleteRows = false;
            this.dataGridViewExercise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExercise.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExercise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExerciseId,
            this.UserId,
            this.ExerciseTime,
            this.ExerciseDateTime,
            this.Score,
            this.Comment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExercise.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExercise.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExercise.Name = "dataGridViewExercise";
            this.dataGridViewExercise.ReadOnly = true;
            this.dataGridViewExercise.RowHeadersWidth = 50;
            this.dataGridViewExercise.RowTemplate.Height = 23;
            this.dataGridViewExercise.Size = new System.Drawing.Size(286, 389);
            this.dataGridViewExercise.TabIndex = 0;
            this.dataGridViewExercise.CurrentCellChanged += new System.EventHandler(this.dataGridViewExercise_CurrentCellChanged);
            this.dataGridViewExercise.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewExercise_RowStateChanged);
            // 
            // ExerciseId
            // 
            this.ExerciseId.DataPropertyName = "Id";
            this.ExerciseId.HeaderText = "Column1";
            this.ExerciseId.Name = "ExerciseId";
            this.ExerciseId.ReadOnly = true;
            this.ExerciseId.Visible = false;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "Column1";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // ExerciseTime
            // 
            this.ExerciseTime.DataPropertyName = "ExerciseTime";
            this.ExerciseTime.HeaderText = "Column1";
            this.ExerciseTime.Name = "ExerciseTime";
            this.ExerciseTime.ReadOnly = true;
            this.ExerciseTime.Visible = false;
            // 
            // ExerciseDateTime
            // 
            this.ExerciseDateTime.DataPropertyName = "ExerciseDateTime";
            this.ExerciseDateTime.HeaderText = "测验时间";
            this.ExerciseDateTime.Name = "ExerciseDateTime";
            this.ExerciseDateTime.ReadOnly = true;
            this.ExerciseDateTime.Width = 81;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "分数";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 57;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "备注";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 57;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewWords);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(286, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 389);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            this.dataGridViewWords.AllowUserToDeleteRows = false;
            this.dataGridViewWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWords.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExerciseDetailId,
            this.ExerciseId_,
            this.LineNumber,
            this.WordsId,
            this.Spelling,
            this.Pronunciation,
            this.Explanation,
            this.Correct});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWords.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.ReadOnly = true;
            this.dataGridViewWords.RowHeadersWidth = 50;
            this.dataGridViewWords.RowTemplate.Height = 23;
            this.dataGridViewWords.Size = new System.Drawing.Size(514, 389);
            this.dataGridViewWords.TabIndex = 0;
            this.dataGridViewWords.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewWords_RowStateChanged);
            // 
            // ExerciseDetailId
            // 
            this.ExerciseDetailId.DataPropertyName = "Id";
            this.ExerciseDetailId.HeaderText = "Column1";
            this.ExerciseDetailId.Name = "ExerciseDetailId";
            this.ExerciseDetailId.ReadOnly = true;
            this.ExerciseDetailId.Visible = false;
            // 
            // ExerciseId_
            // 
            this.ExerciseId_.DataPropertyName = "ExerciseId";
            this.ExerciseId_.HeaderText = "Column1";
            this.ExerciseId_.Name = "ExerciseId_";
            this.ExerciseId_.ReadOnly = true;
            this.ExerciseId_.Visible = false;
            // 
            // LineNumber
            // 
            this.LineNumber.DataPropertyName = "LineNumber";
            this.LineNumber.HeaderText = "Column1";
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.ReadOnly = true;
            this.LineNumber.Visible = false;
            // 
            // WordsId
            // 
            this.WordsId.DataPropertyName = "WordsId";
            this.WordsId.HeaderText = "Column1";
            this.WordsId.Name = "WordsId";
            this.WordsId.ReadOnly = true;
            this.WordsId.Visible = false;
            // 
            // Spelling
            // 
            this.Spelling.DataPropertyName = "Spelling";
            this.Spelling.HeaderText = "拼写";
            this.Spelling.Name = "Spelling";
            this.Spelling.ReadOnly = true;
            this.Spelling.Width = 57;
            // 
            // Pronunciation
            // 
            this.Pronunciation.DataPropertyName = "Pronunciation";
            this.Pronunciation.HeaderText = "发音";
            this.Pronunciation.Name = "Pronunciation";
            this.Pronunciation.ReadOnly = true;
            this.Pronunciation.Width = 57;
            // 
            // Explanation
            // 
            this.Explanation.DataPropertyName = "Explanation";
            this.Explanation.HeaderText = "释义";
            this.Explanation.Name = "Explanation";
            this.Explanation.ReadOnly = true;
            this.Explanation.Width = 57;
            // 
            // Correct
            // 
            this.Correct.DataPropertyName = "Correct";
            this.Correct.FalseValue = "0";
            this.Correct.HeaderText = "正确";
            this.Correct.Name = "Correct";
            this.Correct.ReadOnly = true;
            this.Correct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Correct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Correct.TrueValue = "1";
            this.Correct.Width = 57;
            // 
            // FormExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormExercise";
            this.Text = "测验";
            this.Load += new System.EventHandler(this.FormExercise_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Button buttonExercise;
        private System.Windows.Forms.DataGridView dataGridViewExercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridView dataGridViewWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseId_;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pronunciation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correct;
    }
}