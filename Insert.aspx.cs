using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace _3_TierP
{
    public partial class Insert : System.Web.UI.Page
    {
        InsCls objbll = new InsCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            int i = objbll.InsertDB(TextBox1.Text, Convert.ToInt32(TextBox2.Text), p, TextBox3.Text, TextBox4.Text);
            if (i != 0)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}