using sdk;
using sdk.user.password;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";

            NoodleTokenClient noodleTokenClient = new NoodleTokenClient(Config.Url, null, 0);

            UserPasswordCheckRequest userPasswordCheckRequest = new UserPasswordCheckRequest();
            userPasswordCheckRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            userPasswordCheckRequest.Nick = textBoxUser.Text;
            userPasswordCheckRequest.Password = textBoxPassword.Text;
            long userId = noodleTokenClient.DoPost(userPasswordCheckRequest);
            noodleTokenClient = new NoodleTokenClient(Config.Url, null, userId);
            UserInfoQueryRequest userInfoQueryRequest = new UserInfoQueryRequest();
            userInfoQueryRequest.ClientRequestNo = Guid.NewGuid().ToString("N");
            UserInfoQueryDto userInfoQueryDto = noodleTokenClient.DoPost(userInfoQueryRequest);

            //记录登录用户信息
            initUserInfo(userInfoQueryDto);

            //关闭登录窗口
            this.DialogResult = DialogResult.OK;
        }

        private void initUserInfo(UserInfoQueryDto dto)
        {
            UserInfo.Id = dto.Id;
            UserInfo.Name = dto.Name;
            UserInfo.Nick = dto.Nick;
            UserInfo.AdminFlag = dto.AdminFlag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "wangyx";
            textBoxPassword.Text = "wangyx20170817";
        }
    }
}
