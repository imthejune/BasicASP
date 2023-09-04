using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicASP
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                database database = new database();
                string query = "SELECT * FROM Member";
                DataTable dataTable = database.ExecuteQuery(query);

                // Bind the DataTable to a GridView or another control to display the data
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }
    }
}