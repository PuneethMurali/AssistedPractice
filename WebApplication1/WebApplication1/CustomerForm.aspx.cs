using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        protected void BtnReg_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                LblInfo.Text = "Registration Done !!! " + CompleteInformation();
                Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            }

        }
        private string CompleteInformation()
        {
            return "Customer Name: " + TxtName.Text + "<br />Mobile: " + TxtMobile.Text + "<br />Email: " + TxtEmail.Text;
        }
    }
}
