using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BasicASP
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Sample Product",
                Price = 19.99
            };
            
        }
    }
}