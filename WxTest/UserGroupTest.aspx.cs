﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxApi.UserManager;

namespace WxTest
{
    public partial class UserGroupTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var accessToken = AccessTokenBox.GetTokenValue("wxd7008116979a800d", "49523ae424f3d22b369c16f8738fecba");
            var ret = UserGroup.QueryAll(accessToken);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}