
namespace ReciteWords.vocabulary
{
    partial class FormDictionarySelect
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDictionary = new System.Windows.Forms.DataGridView();
            this.DictionaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DictionaryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DictionaryPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DictionarySelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxCondition);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 67);
            this.panel1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(273, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCondition.Location = new System.Drawing.Point(21, 23);
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(246, 21);
            this.textBoxCondition.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(440, 23);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "选定";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDictionary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 383);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewDictionary
            // 
            this.dataGridViewDictionary.AllowUserToAddRows = false;
            this.dataGridViewDictionary.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDictionary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DictionaryId,
            this.DictionaryName,
            this.DictionaryPublisher,
            this.DictionarySelected});
            this.dataGridViewDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDictionary.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDictionary.Name = "dataGridViewDictionary";
            this.dataGridViewDictionary.ReadOnly = true;
            this.dataGridViewDictionary.RowTemplate.Height = 23;
            this.dataGridViewDictionary.Size = new System.Drawing.Size(527, 383);
            this.dataGridViewDictionary.TabIndex = 0;
            // 
            // DictionaryId
            // 
            this.DictionaryId.DataPropertyName = "Id";
            this.DictionaryId.HeaderText = "";
            this.DictionaryId.Name = "DictionaryId";
            this.DictionaryId.ReadOnly = true;
            this.DictionaryId.Visible = false;
            // 
            // DictionaryName
            // 
            this.DictionaryName.DataPropertyName = "Name";
            this.DictionaryName.HeaderText = "字典";
            this.DictionaryName.Name = "DictionaryName";
            this.DictionaryName.ReadOnly = true;
            // 
            // DictionaryPublisher
            // 
            this.DictionaryPublisher.DataPropertyName = "Publisher";
            this.DictionaryPublisher.HeaderText = "出版社";
            this.DictionaryPublisher.Name = "DictionaryPublisher";
            this.DictionaryPublisher.ReadOnly = true;
            // 
            // DictionarySelected
            // 
            this.DictionarySelected.DataPropertyName = "Selected";
            this.DictionarySelected.FalseValue = "false";
            this.DictionarySelected.HeaderText = "已选定";
            this.DictionarySelected.Name = "DictionarySelected";
            this.DictionarySelected.ReadOnly = true;
            this.DictionarySelected.TrueValue = "true";
            // 
            // FormDictionarySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDictionarySelect";
            this.Text = "FormDictionarySelect";
            this.Load += new System.EventHandler(this.FormDictionarySelect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDictionary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.DataGridView dataGridViewDictionary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictionaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictionaryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictionaryPublisher;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DictionarySelected;
    }
}