using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            test.InnerText = "Merhaba bu yazı code behind tarafından gönderildi";
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }
    }
}