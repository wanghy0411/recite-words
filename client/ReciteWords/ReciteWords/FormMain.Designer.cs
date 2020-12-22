
namespace ReciteWords
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuVocabulary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrintSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExcise = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVocabulary,
            this.menuRecite});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuVocabulary
            // 
            this.menuVocabulary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDictionary,
            this.menuItemWords,
            this.toolStripSeparator3,
            this.menuItemPrint,
            this.menuItemPreview,
            this.menuItemPrintSetup,
            this.toolStripSeparator5,
            this.menuItemExit});
            this.menuVocabulary.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuVocabulary.Name = "menuVocabulary";
            this.menuVocabulary.Size = new System.Drawing.Size(44, 21);
            this.menuVocabulary.Text = "词汇";
            // 
            // menuItemDictionary
            // 
            this.menuItemDictionary.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemDictionary.Name = "menuItemDictionary";
            this.menuItemDictionary.Size = new System.Drawing.Size(159, 22);
            this.menuItemDictionary.Text = "字典";
            this.menuItemDictionary.Click += new System.EventHandler(this.menuItemDictionary_Click);
            // 
            // menuItemWords
            // 
            this.menuItemWords.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemWords.Name = "menuItemWords";
            this.menuItemWords.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemWords.Size = new System.Drawing.Size(159, 22);
            this.menuItemWords.Text = "单词";
            this.menuItemWords.Click += new System.EventHandler(this.menuItemWords_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Image = ((System.Drawing.Image)(resources.GetObject("menuItemPrint.Image")));
            this.menuItemPrint.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemPrint.Name = "menuItemPrint";
            this.menuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuItemPrint.Size = new System.Drawing.Size(159, 22);
            this.menuItemPrint.Text = "打印(&P)";
            // 
            // menuItemPreview
            // 
            this.menuItemPreview.Image = ((System.Drawing.Image)(resources.GetObject("menuItemPreview.Image")));
            this.menuItemPreview.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemPreview.Name = "menuItemPreview";
            this.menuItemPreview.Size = new System.Drawing.Size(159, 22);
            this.menuItemPreview.Text = "打印预览(&V)";
            // 
            // menuItemPrintSetup
            // 
            this.menuItemPrintSetup.Name = "menuItemPrintSetup";
            this.menuItemPrintSetup.Size = new System.Drawing.Size(159, 22);
            this.menuItemPrintSetup.Text = "打印设置";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(159, 22);
            this.menuItemExit.Text = "退出(&X)";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuRecite
            // 
            this.menuRecite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRecite,
            this.menuItemReview,
            this.toolStripSeparator6,
            this.menuItemExcise});
            this.menuRecite.Name = "menuRecite";
            this.menuRecite.Size = new System.Drawing.Size(56, 21);
            this.menuRecite.Text = "背单词";
            // 
            // menuItemRecite
            // 
            this.menuItemRecite.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemRecite.Name = "menuItemRecite";
            this.menuItemRecite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItemRecite.Size = new System.Drawing.Size(180, 22);
            this.menuItemRecite.Text = "背诵";
            this.menuItemRecite.Click += new System.EventHandler(this.menuItemRecite_Click);
            // 
            // menuItemReview
            // 
            this.menuItemReview.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemReview.Name = "menuItemReview";
            this.menuItemReview.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuItemReview.Size = new System.Drawing.Size(180, 22);
            this.menuItemReview.Text = "复习";
            this.menuItemReview.Click += new System.EventHandler(this.menuItemReview_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItemExcise
            // 
            this.menuItemExcise.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemExcise.Name = "menuItemExcise";
            this.menuItemExcise.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemExcise.Size = new System.Drawing.Size(180, 22);
            this.menuItemExcise.Text = "测验";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 396);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "背单词";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuVocabulary;
        private System.Windows.Forms.ToolStripMenuItem menuItemDictionary;
        private System.Windows.Forms.ToolStripMenuItem menuItemWords;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuRecite;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecite;
        private System.Windows.Forms.ToolStripMenuItem menuItemReview;
        private System.Windows.Forms.ToolStripMenuItem menuItemExcise;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrint;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreview;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrintSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}



