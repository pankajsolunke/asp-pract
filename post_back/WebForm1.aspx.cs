using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace post_back
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bind1();
            bind2();
        }

        protected void bind1()
        {
            ListItem l1 = new ListItem("california");
            ListItem l2 = new ListItem("LA");
            ListItem l3 = new ListItem("New York");
            DropDownList3.Items.Add(l1);
            DropDownList3.Items.Add(l2);
            DropDownList3.Items.Add(l3);
        }
        protected void bind2()
        {
            ListItem l1 = new ListItem("california");
            ListItem l2 = new ListItem("LA");
            ListItem l3 = new ListItem("New York");
            DropDownList4.Items.Add(l1);
            DropDownList4.Items.Add(l2);
            DropDownList4.Items.Add(l3);
        }
      

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}

















