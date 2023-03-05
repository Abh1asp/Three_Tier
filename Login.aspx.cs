using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace _3_TierP
{
    public partial class Login : System.Web.UI.Page
    {
        LogCls objbll = new LogCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = objbll.LogDB(TextBox1.Text, TextBox2.Text);
            if (cid == "1")
            {
                Label1.Text = "Logged In";
            }
            else
            {
                Label1.Text = "Register";
            }
        }
    }
}