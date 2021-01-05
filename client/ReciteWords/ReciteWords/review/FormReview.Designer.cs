
namespace ReciteWords.review
{
    partial class FormReview
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
            this.buttonReview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewReview = new System.Windows.Forms.DataGridView();
            this.ReviewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewReviewWords = new System.Windows.Forms.DataGridView();
            this.ReviewWordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewId_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pronunciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewWords)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReview
            // 
            this.buttonReview.Location = new System.Drawing.Point(12, 12);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(75, 23);
            this.buttonReview.TabIndex = 0;
            this.buttonReview.Text = "今日复习";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewReview
            // 
            this.dataGridViewReview.AllowUserToAddRows = false;
            this.dataGridViewReview.AllowUserToDeleteRows = false;
            this.dataGridViewReview.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewId,
            this.ReviewDateTime,
            this.ReviewTime,
            this.ReviewComment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReview.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReview.Name = "dataGridViewReview";
            this.dataGridViewReview.ReadOnly = true;
            this.dataGridViewReview.RowHeadersWidth = 50;
            this.dataGridViewReview.RowTemplate.Height = 23;
            this.dataGridViewReview.Size = new System.Drawing.Size(269, 399);
            this.dataGridViewReview.TabIndex = 0;
            this.dataGridViewReview.CurrentCellChanged += new System.EventHandler(this.dataGridViewReview_CurrentCellChanged);
            this.dataGridViewReview.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewReview_RowStateChanged);
            // 
            // ReviewId
            // 
            this.ReviewId.DataPropertyName = "Id";
            this.ReviewId.HeaderText = "";
            this.ReviewId.Name = "ReviewId";
            this.ReviewId.ReadOnly = true;
            this.ReviewId.Visible = false;
            // 
            // ReviewDateTime
            // 
            this.ReviewDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReviewDateTime.DataPropertyName = "ReviewDateTime";
            this.ReviewDateTime.HeaderText = "背诵日期";
            this.ReviewDateTime.Name = "ReviewDateTime";
            this.ReviewDateTime.ReadOnly = true;
            this.ReviewDateTime.Width = 81;
            // 
            // ReviewTime
            // 
            this.ReviewTime.DataPropertyName = "ReviewTime";
            this.ReviewTime.HeaderText = "背诵时间";
            this.ReviewTime.Name = "ReviewTime";
            this.ReviewTime.ReadOnly = true;
            this.ReviewTime.Visible = false;
            // 
            // ReviewComment
            // 
            this.ReviewComment.DataPropertyName = "Comment";
            this.ReviewComment.HeaderText = "备注";
            this.ReviewComment.Name = "ReviewComment";
            this.ReviewComment.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewReview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 401);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewReviewWords);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(271, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 401);
            this.panel3.TabIndex = 4;
            // 
            // dataGridViewReviewWords
            // 
            this.dataGridViewReviewWords.AllowUserToAddRows = false;
            this.dataGridViewReviewWords.AllowUserToDeleteRows = false;
            this.dataGridViewReviewWords.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReviewWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReviewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewWordsId,
            this.ReviewId_,
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
            this.dataGridViewReviewWords.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReviewWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReviewWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReviewWords.Name = "dataGridViewReviewWords";
            this.dataGridViewReviewWords.ReadOnly = true;
            this.dataGridViewReviewWords.RowHeadersWidth = 50;
            this.dataGridViewReviewWords.RowTemplate.Height = 23;
            this.dataGridViewReviewWords.Size = new System.Drawing.Size(529, 401);
            this.dataGridViewReviewWords.TabIndex = 1;
            this.dataGridViewReviewWords.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewReviewWords_RowStateChanged);
            // 
            // ReviewWordsId
            // 
            this.ReviewWordsId.DataPropertyName = "Id";
            this.ReviewWordsId.HeaderText = "";
            this.ReviewWordsId.Name = "ReviewWordsId";
            this.ReviewWordsId.ReadOnly = true;
            this.ReviewWordsId.Visible = false;
            // 
            // ReviewId_
            // 
            this.ReviewId_.DataPropertyName = "ReviewId";
            this.ReviewId_.HeaderText = "";
            this.ReviewId_.Name = "ReviewId_";
            this.ReviewId_.ReadOnly = true;
            this.ReviewId_.Visible = false;
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
            // FormReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReview";
            this.Text = "复习";
            this.Load += new System.EventHandler(this.FormReview_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewReview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewReviewWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewWordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewId_;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pronunciation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
    }
}