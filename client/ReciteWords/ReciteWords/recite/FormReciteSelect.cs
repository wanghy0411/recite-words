using sdk;
using sdk.id;
using sdk.recite.add;
using sdk.recite.words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReciteWords.recite
{
    public partial class FormReciteSelect : Form
    {
        private NoodleTokenClient _noodleTokenClient;

        public FormReciteSelect()
        {
            InitializeComponent();
        }

        private void FormReciteSelect_Load(object sender, EventArgs e)
        {
            _noodleTokenClient = new NoodleTokenClient(Config.Url, UserInfo.Token, UserInfo.Id);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxMemoryLine.Text==null || textBoxMemoryLine.Text.Trim().Length==0)
            {
                textBoxMemoryLine.Focus();
                throw new ArgumentException("请输入正确的记忆曲线节点信息");
            }
            if (textBoxNumber.Text == null || textBoxNumber.Text.Trim().Length == 0)
            {
                textBoxNumber.Focus();
                throw new ArgumentException("请输入正确的单词数量");
            }

            int wordsNumber = 0;
            if (!int.TryParse(textBoxNumber.Text.Trim(), out wordsNumber))
            {
                textBoxNumber.Focus();
                throw new ArgumentException("请输入正确的单词数量");
            }

            //解析记忆曲线
            string[] memoryLineArray = textBoxMemoryLine.Text.Trim().Split(',');
            if (memoryLineArray.Length < 4)
            {
                textBoxMemoryLine.Focus();
                throw new ArgumentException("请输入正确的记忆曲线节点信息");
            }

            int schedule1 = 0;
            if (!int.TryParse(memoryLineArray[0], out schedule1))
            {
                textBoxMemoryLine.Focus();
                throw new ArgumentException("请输入正确的记忆曲线节点信息");
            }

            int schedule2 = 0;
            if (!int.TryParse(memoryLineArray[1], out schedule2))
            {
                textBoxMemoryLine.Focus();
                throw new ArgumentException("请输入正确的记忆曲线节点信息");
            }

            int schedule3 = 0;
            if (!int.TryParse(memoryLineArray[2], out schedule3))
            {
                textBoxMemoryLine.Focus();
                throw new ArgumentException("请输入正确的记忆曲线节点信息");
            }

            int schedule4 = 0;
            if (!int.TryParse(memoryLineArray[3], out schedule4))
            {
                textBoxMemoryLine.Focus();
                throw new ArgumentException("请输入正确的记忆曲线节点信息");
            }

            //取唯一id
            NoodleIdGeneratorRequest noodleIdGeneratorRequest = new NoodleIdGeneratorRequest();
            noodleIdGeneratorRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            List<long> ids = _noodleTokenClient.DoPost(noodleIdGeneratorRequest);

            //生成背诵记录
            ReciteAddRequest reciteAddRequest = new ReciteAddRequest();
            reciteAddRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            reciteAddRequest.Id = ids[0];
            reciteAddRequest.Comment = textBoxComment.Text;
            reciteAddRequest.WordsNumber = wordsNumber;
            reciteAddRequest.Schedule1 = schedule1;
            reciteAddRequest.Schedule2 = schedule4;
            reciteAddRequest.Schedule3 = schedule3;
            reciteAddRequest.Schedule4 = schedule4;
            _noodleTokenClient.DoPost(reciteAddRequest);

            //查询生成的结果
            ReciteWordsRequest reciteWordsRequest = new ReciteWordsRequest();
            reciteWordsRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            reciteWordsRequest.ReciteId = ids[0];
            List<ReciteWordsDto> reciteWordsDtos = _noodleTokenClient.DoPost(reciteWordsRequest);

            DataTable dtReciteWords = DataTableHelper.ToDataTable<ReciteWordsDto>(reciteWordsDtos);

            dataGridViewReciteWords.DataSource = dtReciteWords;
        }

        private void dataGridViewReciteWords_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //添加每行的行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
