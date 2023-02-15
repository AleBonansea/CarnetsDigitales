using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    [Authorize]
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}