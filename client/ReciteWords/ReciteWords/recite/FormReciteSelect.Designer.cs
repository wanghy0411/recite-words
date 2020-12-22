
namespace ReciteWords.recite
{
    partial class FormReciteSelect
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewReciteWords = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReciteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pronunciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemoryLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReciteWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.textBoxComment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxMemoryLine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 96);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewReciteWords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 354);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewReciteWords
            // 
            this.dataGridViewReciteWords.AllowUserToAddRows = false;
            this.dataGridViewReciteWords.AllowUserToDeleteRows = false;
            this.dataGridViewReciteWords.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReciteWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReciteWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReciteWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ReciteId,
            this.WordsId,
            this.Spelling,
            this.Pronunciation,
            this.Explanation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReciteWords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReciteWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReciteWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReciteWords.Name = "dataGridViewReciteWords";
            this.dataGridViewReciteWords.ReadOnly = true;
            this.dataGridViewReciteWords.RowTemplate.Height = 23;
            this.dataGridViewReciteWords.Size = new System.Drawing.Size(692, 352);
            this.dataGridViewReciteWords.TabIndex = 0;
            this.dataGridViewReciteWords.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewReciteWords_RowStateChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ReciteId
            // 
            this.ReciteId.DataPropertyName = "ReciteId";
            this.ReciteId.HeaderText = "Column1";
            this.ReciteId.Name = "ReciteId";
            this.ReciteId.ReadOnly = true;
            this.ReciteId.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "记忆曲线节点:";
            // 
            // textBoxMemoryLine
            // 
            this.textBoxMemoryLine.Location = new System.Drawing.Point(146, 19);
            this.textBoxMemoryLine.Name = "textBoxMemoryLine";
            this.textBoxMemoryLine.Size = new System.Drawing.Size(104, 21);
            this.textBoxMemoryLine.TabIndex = 1;
            this.textBoxMemoryLine.Text = "1,7,30,90";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "今天我要背";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(365, 19);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(45, 21);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "个单词";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "备注:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(146, 54);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(316, 21);
            this.textBoxComment.TabIndex = 6;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(587, 52);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "确认";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormReciteSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReciteSelect";
            this.Text = "单词选择";
            this.Load += new System.EventHandler(this.FormReciteSelect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReciteWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewReciteWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pronunciation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMemoryLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirm;
    }
}