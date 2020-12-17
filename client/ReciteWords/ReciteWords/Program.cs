using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReciteWords
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //登录
            using (FormLogin formLogin = new FormLogin())
            {
                if (formLogin.ShowDialog() != DialogResult.OK)
                    return;
            }

            //运行
            Application.Run(new FormMain());
        }
    }
}
