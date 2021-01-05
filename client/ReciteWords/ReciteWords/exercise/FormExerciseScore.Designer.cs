
namespace ReciteWords.exercise
{
    partial class FormExerciseScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerciseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pronunciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewWords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 384);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            this.dataGridViewWords.AllowUserToDeleteRows = false;
            this.dataGridViewWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWords.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ExerciseId,
            this.LineNumber,
            this.WordsId,
            this.Spelling,
            this.Pronunciation,
            this.Explanation,
            this.Correct});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.RowHeadersWidth = 50;
            this.dataGridViewWords.RowTemplate.Height = 23;
            this.dataGridViewWords.Size = new System.Drawing.Size(800, 384);
            this.dataGridViewWords.TabIndex = 0;
            this.dataGridViewWords.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewWords_RowStateChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ExerciseId
            // 
            this.ExerciseId.DataPropertyName = "ExerciseId";
            this.ExerciseId.HeaderText = "exerciseId";
            this.ExerciseId.Name = "ExerciseId";
            this.ExerciseId.Visible = false;
            // 
            // LineNumber
            // 
            this.LineNumber.DataPropertyName = "LineNumber";
            this.LineNumber.HeaderText = "lineNumber";
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.Visible = false;
            // 
            // WordsId
            // 
            this.WordsId.DataPropertyName = "WordsId";
            this.WordsId.HeaderText = "wordsId";
            this.WordsId.Name = "WordsId";
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
            this.Correct.HeaderText = "对错";
            this.Correct.Name = "Correct";
            this.Correct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Correct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Correct.TrueValue = "1";
            this.Correct.Width = 57;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 66);
            this.panel2.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(713, 20);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormExerciseScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormExerciseScore";
            this.Text = "测验评分";
            this.Load += new System.EventHandler(this.FormExerciseScore_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pronunciation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correct;
    }
}