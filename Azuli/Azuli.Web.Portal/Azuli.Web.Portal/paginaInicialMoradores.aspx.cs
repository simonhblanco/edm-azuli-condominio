﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Azuli.Web.Portal
{
    public partial class paginaInicialMoradores : System.Web.UI.Page
    {
        Util.Util oUtil = new Util.Util();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (oUtil.validateSession())
            {
                if (!IsPostBack)
                {
                    lblMorador.Text = Session["Proprie1"].ToString();

                    Session["AP"].ToString();
                    Session["Bloco"].ToString();
                    Session["Proprie2"].ToString();

                }
            }

        }
    }
}