using ReciteWords.exercise;
using ReciteWords.recite;
using ReciteWords.review;
using ReciteWords.vocabulary;
using ReciteWords.words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuItemDictionary_Click(object sender, EventArgs e)
        {
            FormDictionary childForm = new FormDictionary();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuItemWords_Click(object sender, EventArgs e)
        {
            FormWords childForm = new FormWords();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemRecite_Click(object sender, EventArgs e)
        {
            FormRecite childForm = new FormRecite();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuItemReview_Click(object sender, EventArgs e)
        {
            FormReview childForm = new FormReview();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuItemExcise_Click(object sender, EventArgs e)
        {
            FormExercise childForm = new FormExercise();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
