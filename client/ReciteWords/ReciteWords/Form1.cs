using sdk;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoodleTokenClient noodleTokenClient = new NoodleTokenClient(Config.Url, null);

            UserInfoQueryRequest request = new UserInfoQueryRequest();
            request.ClientRequestNo = Guid.NewGuid().ToString("N");
            request.Nick = "wangyx";
            NoodleResponse<UserInfoQueryDto> response = noodleTokenClient.DoPost(request);

            label1.Text = Newtonsoft.Json.JsonConvert.SerializeObject(response);
        }
    }
}
