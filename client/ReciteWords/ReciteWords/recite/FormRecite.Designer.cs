
namespace ReciteWords.recite
{
    partial class FormRecite
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
            this.buttonRecite = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRecite = new System.Windows.Forms.DataGridView();
            this.ReciteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciteDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciteComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewReciteWords = new System.Windows.Forms.DataGridView();
            this.ReciteWordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciteId_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pronunciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecite)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReciteWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRecite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // buttonRecite
            // 
            this.buttonRecite.Location = new System.Drawing.Point(12, 12);
            this.buttonRecite.Name = "buttonRecite";
            this.buttonRecite.Size = new System.Drawing.Size(75, 23);
            this.buttonRecite.TabIndex = 0;
            this.buttonRecite.Text = "今日背诵";
            this.buttonRecite.UseVisualStyleBackColor = true;
            this.buttonRecite.Click += new System.EventHandler(this.buttonRecite_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewRecite);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 401);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewRecite
            // 
            this.dataGridViewRecite.AllowUserToAddRows = false;
            this.dataGridViewRecite.AllowUserToDeleteRows = false;
            this.dataGridViewRecite.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciteId,
            this.ReciteDateTime,
            this.ReciteTime,
            this.ReciteComment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecite.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRecite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecite.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecite.Name = "dataGridViewRecite";
            this.dataGridViewRecite.ReadOnly = true;
            this.dataGridViewRecite.RowHeadersWidth = 50;
            this.dataGridViewRecite.RowTemplate.Height = 23;
            this.dataGridViewRecite.Size = new System.Drawing.Size(269, 399);
            this.dataGridViewRecite.TabIndex = 0;
            this.dataGridViewRecite.CurrentCellChanged += new System.EventHandler(this.dataGridViewRecite_CurrentCellChanged);
            this.dataGridViewRecite.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewRecite_RowStateChanged);
            // 
            // ReciteId
            // 
            this.ReciteId.DataPropertyName = "Id";
            this.ReciteId.HeaderText = "";
            this.ReciteId.Name = "ReciteId";
            this.ReciteId.ReadOnly = true;
            this.ReciteId.Visible = false;
            // 
            // ReciteDateTime
            // 
            this.ReciteDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReciteDateTime.DataPropertyName = "ReciteDateTime";
            this.ReciteDateTime.HeaderText = "背诵日期";
            this.ReciteDateTime.Name = "ReciteDateTime";
            this.ReciteDateTime.ReadOnly = true;
            this.ReciteDateTime.Width = 81;
            // 
            // ReciteTime
            // 
            this.ReciteTime.DataPropertyName = "ReciteTime";
            this.ReciteTime.HeaderText = "背诵时间";
            this.ReciteTime.Name = "ReciteTime";
            this.ReciteTime.ReadOnly = true;
            this.ReciteTime.Visible = false;
            // 
            // ReciteComment
            // 
            this.ReciteComment.DataPropertyName = "Comment";
            this.ReciteComment.HeaderText = "备注";
            this.ReciteComment.Name = "ReciteComment";
            this.ReciteComment.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridViewReciteWords);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(271, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 401);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewReciteWords
            // 
            this.dataGridViewReciteWords.AllowUserToAddRows = false;
            this.dataGridViewReciteWords.AllowUserToDeleteRows = false;
            this.dataGridViewReciteWords.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReciteWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReciteWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReciteWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciteWordsId,
            this.ReciteId_,
            this.WordsId,
            this.Spelling,
            this.Pronunciation,
            this.Explanation});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReciteWords.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReciteWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReciteWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReciteWords.Name = "dataGridViewReciteWords";
            this.dataGridViewReciteWords.ReadOnly = true;
            this.dataGridViewReciteWords.RowHeadersWidth = 50;
            this.dataGridViewReciteWords.RowTemplate.Height = 23;
            this.dataGridViewReciteWords.Size = new System.Drawing.Size(527, 399);
            this.dataGridViewReciteWords.TabIndex = 0;
            this.dataGridViewReciteWords.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewReciteWords_RowStateChanged);
            // 
            // ReciteWordsId
            // 
            this.ReciteWordsId.DataPropertyName = "Id";
            this.ReciteWordsId.HeaderText = "";
            this.ReciteWordsId.Name = "ReciteWordsId";
            this.ReciteWordsId.ReadOnly = true;
            this.ReciteWordsId.Visible = false;
            // 
            // ReciteId_
            // 
            this.ReciteId_.DataPropertyName = "ReciteId";
            this.ReciteId_.HeaderText = "";
            this.ReciteId_.Name = "ReciteId_";
            this.ReciteId_.ReadOnly = true;
            this.ReciteId_.Visible = false;
            // 
            // WordsId
            // 
            this.WordsId.DataPropertyName = "WordsId";
            this.WordsId.HeaderText = "";
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
            // 
            // Pronunciation
            // 
            this.Pronunciation.DataPropertyName = "Pronunciation";
            this.Pronunciation.HeaderText = "发音";
            this.Pronunciation.Name = "Pronunciation";
            this.Pronunciation.ReadOnly = true;
            // 
            // Explanation
            // 
            this.Explanation.DataPropertyName = "Explanation";
            this.Explanation.HeaderText = "释义";
            this.Explanation.Name = "Explanation";
            this.Explanation.ReadOnly = true;
            // 
            // FormRecite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRecite";
            this.Text = "背诵";
            this.Load += new System.EventHandler(this.FormRecite_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecite)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReciteWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRecite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewRecite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewReciteWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteWordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteId_;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pronunciation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteComment;
    }
}