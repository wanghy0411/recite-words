
namespace ReciteWords.vocabulary
{
    partial class FormDictionary
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
            this.dataGridViewDictionary = new System.Windows.Forms.DataGridView();
            this.DictionaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DictionaryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DictionaryPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DictionaryValidFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DictionaryPublicFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxValidFlag = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDictionary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDictionary)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.DictionaryValidFlag,
            this.DictionaryPublicFlag});
            this.dataGridViewDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDictionary.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDictionary.Name = "dataGridViewDictionary";
            this.dataGridViewDictionary.ReadOnly = true;
            this.dataGridViewDictionary.RowTemplate.Height = 23;
            this.dataGridViewDictionary.Size = new System.Drawing.Size(480, 343);
            this.dataGridViewDictionary.TabIndex = 0;
            this.dataGridViewDictionary.CurrentCellChanged += new System.EventHandler(this.dataGridViewDictionary_CurrentCellChanged);
            this.dataGridViewDictionary.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewDictionary_RowStateChanged);
            // 
            // DictionaryId
            // 
            this.DictionaryId.DataPropertyName = "Id";
            this.DictionaryId.HeaderText = "DictionaryId";
            this.DictionaryId.Name = "DictionaryId";
            this.DictionaryId.ReadOnly = true;
            this.DictionaryId.Visible = false;
            // 
            // DictionaryName
            // 
            this.DictionaryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DictionaryName.DataPropertyName = "Name";
            this.DictionaryName.HeaderText = "词典";
            this.DictionaryName.Name = "DictionaryName";
            this.DictionaryName.ReadOnly = true;
            this.DictionaryName.Width = 54;
            // 
            // DictionaryPublisher
            // 
            this.DictionaryPublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DictionaryPublisher.DataPropertyName = "Publisher";
            this.DictionaryPublisher.HeaderText = "出版社";
            this.DictionaryPublisher.Name = "DictionaryPublisher";
            this.DictionaryPublisher.ReadOnly = true;
            this.DictionaryPublisher.Width = 66;
            // 
            // DictionaryValidFlag
            // 
            this.DictionaryValidFlag.DataPropertyName = "ValidFlag";
            this.DictionaryValidFlag.FalseValue = "N";
            this.DictionaryValidFlag.HeaderText = "启用";
            this.DictionaryValidFlag.Name = "DictionaryValidFlag";
            this.DictionaryValidFlag.ReadOnly = true;
            this.DictionaryValidFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DictionaryValidFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DictionaryValidFlag.TrueValue = "Y";
            // 
            // DictionaryPublicFlag
            // 
            this.DictionaryPublicFlag.DataPropertyName = "PublicFlag";
            this.DictionaryPublicFlag.FalseValue = "N";
            this.DictionaryPublicFlag.HeaderText = "公用";
            this.DictionaryPublicFlag.Name = "DictionaryPublicFlag";
            this.DictionaryPublicFlag.ReadOnly = true;
            this.DictionaryPublicFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DictionaryPublicFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DictionaryPublicFlag.TrueValue = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 50);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(643, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "增加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(724, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDictionary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 343);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxValidFlag);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxPublisher);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxDictionary);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(480, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 343);
            this.panel3.TabIndex = 3;
            // 
            // checkBoxValidFlag
            // 
            this.checkBoxValidFlag.AutoSize = true;
            this.checkBoxValidFlag.Location = new System.Drawing.Point(84, 109);
            this.checkBoxValidFlag.Name = "checkBoxValidFlag";
            this.checkBoxValidFlag.Size = new System.Drawing.Size(15, 14);
            this.checkBoxValidFlag.TabIndex = 5;
            this.checkBoxValidFlag.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "启用";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(84, 65);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(235, 21);
            this.textBoxPublisher.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "出版社";
            // 
            // textBoxDictionary
            // 
            this.textBoxDictionary.Location = new System.Drawing.Point(84, 26);
            this.textBoxDictionary.Name = "textBoxDictionary";
            this.textBoxDictionary.Size = new System.Drawing.Size(235, 21);
            this.textBoxDictionary.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字典";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(93, 12);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "公用字典";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // FormDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 393);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "字典";
            this.Load += new System.EventHandler(this.FormVocabulary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDictionary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDictionary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxValidFlag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDictionary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictionaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictionaryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DictionaryPublisher;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DictionaryValidFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DictionaryPublicFlag;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
    }
}