using System;


namespace MillionaireGame
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnLogin.Click += btnLogin_Click;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["userName"] = tbName.Text;
            Response.Redirect("~/Index.aspx");
        }
    }
}