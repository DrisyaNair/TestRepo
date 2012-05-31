using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IHealth
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        private void change()
        {
            String a = "hi";
            String b = "all";
            String c = a + b;
            Label1.Text = c;
            
        }
    }
}