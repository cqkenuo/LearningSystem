﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Song.Site.Manage.Sys
{
    public partial class Depart : Extend.CustomPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Redirect("../admin/departs.aspx");
        }
    }
}
