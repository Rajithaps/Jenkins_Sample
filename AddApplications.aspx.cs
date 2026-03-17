using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using Npgsql;
using NpgsqlTypes;
using DataAccessLayer;
using System.Data;
using System.Xml;
using MSXML2;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace Cast_Dashboard
{
    public partial class AddApplications : System.Web.UI.Page
    {
        DataAccessLayer.DataAccessLayer Dal = new DataAccessLayer.DataAccessLayer();
        BusinessObjects.Application app = new Application();
        ApplicationDashboards appDashboard = new ApplicationDashboards();
        ApplicationUsers appuser = new ApplicationUsers();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //GetBuNames();
                //GetSBUNames();
                GetSBULists();
                GetIndustrySectorNames();
                GetIndustrySubSectorNames();
                GetIndustrySpecializationNames();
                GetApplicationRetentionNames();
                GetApplicationGroupNames();
                GetApplicationOwnerShip();
                GetSectors();
                GetApplicationNames();
                if (Session["loginuser"] == null)
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }
        //private void GetBuNames()
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        ds = Dal.GetBuName();
        //        ddlBu.DataSource = ds;
        //        ddlBu.DataValueField = "bu_Id";
        //        ddlBu.DataTextField = "bu_name";
        //        ddlBu.DataBind();
        //        ddlBu.Items.Insert(0, new ListItem("Select Strategic BU", "0"));
        //    }
        //    catch (Exception ex)
        //    {
        //        //Response.Write(ex.Message);
        //        //Response.Redirect("~/Error.aspx");
        //        ExceptionLogging.SendErrorToText(ex);
        //        ShowMessage(ex.Message, MessageType.Error);
        //    }
        //}
        //private void GetSBUNames()
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        ds = Dal.GetSBUNames();
        //        ddlSBBU.DataSource = ds;
        //        ddlSBBU.DataValueField = "sbbu_Id";
        //        ddlSBBU.DataTextField = "sbbu_name";
        //        ddlSBBU.DataBind();
        //        ddlSBBU.Items.Insert(0, new ListItem("Select Businees Unit", "0"));
        //        ddlBu.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        //Response.Write(ex.Message);
        //        //Response.Redirect("~/Error.aspx");
        //        ExceptionLogging.SendErrorToText(ex);
        //        ShowMessage(ex.Message, MessageType.Error);
        //    }
        //}
        private void GetSBULists()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Dal.GetSBUList();
                ddlsbulist.DataSource = ds;
                ddlsbulist.DataValueField = "sbu_id";
                ddlsbulist.DataTextField = "sbu_name";
                ddlsbulist.DataBind();
                ddlsbulist.Items.Insert(0, new ListItem("Select Strategic BU", "0"));
                //ddlBu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        private void GetIndustrySectorNames()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Dal.GetIndustrySectorNames();
                ddlIndustrySector.DataSource = ds;
                ddlIndustrySector.DataValueField = "is_id";
                ddlIndustrySector.DataTextField = "is_name";
                ddlIndustrySector.DataBind();
                ddlIndustrySector.Items.Insert(0, new ListItem("Select Industry Sector", "0"));
            }
            catch (Exception ex)
            {
                //Response.Write(ex.Message);
                //Response.Redirect("~/Error.aspx");
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }
        private void GetIndustrySubSectorNames()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Dal.GetIndustrySubSectorNames();
                ddlIndustrySubSector.DataSource = ds;
                ddlIndustrySubSector.DataValueField = "isbs_Id";
                ddlIndustrySubSector.DataTextField = "isbs_name";
                ddlIndustrySubSector.DataBind();
                ddlIndustrySubSector.Items.Insert(0, new ListItem("Select Industry Sub Sector", "0"));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }
        private void GetIndustrySpecializationNames()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Dal.GetIndustrySpecializationNames();
                ddlIndustrySpecializtion.DataSource = ds;
                ddlIndustrySpecializtion.DataValueField = "isp_id";
                ddlIndustrySpecializtion.DataTextField = "isp_Name";
                ddlIndustrySpecializtion.DataBind();
                ddlIndustrySpecializtion.Items.Insert(0, new ListItem("Select Industry Specializtion", "0"));
            }
            catch (Exception ex)
            {
                //Response.Write(ex.Message);
                //Response.Redirect("~/Error.aspx");
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }
        private void GetApplicationRetentionNames()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Dal.GetApplicationRetentionNames();
                ddlApplcationRetentionName.DataSource = ds;
                ddlApplcationRetentionName.DataValueField = "app_retention_id";
                ddlApplcationRetentionName.DataTextField = "app_retention_name";
                ddlApplcationRetentionName.DataBind();
                ddlApplcationRetentionName.Items.Insert(0, new ListItem("Select Application Retention", "0"));
            }
            catch (Exception ex)
            {
                //Response.Write(ex.Message);
                //Response.Redirect("~/Error.aspx");
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        private void GetApplicationGroupNames()
        {
            try
            {


                DataTable dt = Dal.getapplicationgroups();
                ddlAppGroup.DataSource = dt;
                ddlAppGroup.DataValueField = "app_group_id";
                ddlAppGroup.DataTextField = "app_group_name";
                ddlAppGroup.DataBind();
                ddlAppGroup.Items.Insert(0, new ListItem("Select Application Group", "0"));
            }

            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        private void GetApplicationOwnerShip()

        {

            try
            {


                DataTable dt = Dal.getApplicationOwnerShip();
                ddlApplicationOwnership.DataSource = dt;
                ddlApplicationOwnership.DataValueField = "app_ownership_id";
                ddlApplicationOwnership.DataTextField = "app_ownership";
                ddlApplicationOwnership.DataBind();
                ddlApplicationOwnership.Items.Insert(0, new ListItem("Select Application OwnerShip", "0"));
            }

            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }

        }

        private void GetSectors()
        {
            try
            {

                DataTable dt = Dal.getSectors();
                ddlSectors.DataSource = dt;
                ddlSectors.DataValueField = "sectro_id";
                ddlSectors.DataTextField = "sector";
                ddlSectors.DataBind();
                ddlSectors.Items.Insert(0, new ListItem("Select Sector", "0"));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }
        private void GetApplicationNames()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Dal.GetApplicationNames();
                ddlApplicationName.DataSource = ds;
                ddlApplicationName.DataValueField = "app_id";
                ddlApplicationName.DataTextField = "app_name";
                ddlApplicationName.DataBind();
                ddlApplicationName.Items.Insert(0, new ListItem("Select Application", "0"));
            }
            catch (Exception ex)
            {
                //Response.Write(ex.Message);
                //Response.Redirect("~/Error.aspx");
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        protected void ddldomaingroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddldomaingroup.SelectedIndex != 0)
                {
                    appDashboard.appdomain = ddldomaingroup.SelectedItem.Text;
                    //appuser.App_Name = ddlApplicationDomains.SelectedItem.Text;
                    //DataTable dt1 = Dal.GetApplicationDomaindetails(appDashboard);
                    //gridViewDomain.DataSource = dt1;
                    //gridViewDomain.DataBind();
                    DataSet ds = new DataSet();
                    ds = Dal.GetApplicationDomaindetails(appDashboard);
                    ddldomaingroupname.DataSource = ds;
                    ddldomaingroupname.DataTextField = "appdomainname";
                    ddldomaingroupname.DataValueField = "domainid";
                    ddldomaingroupname.DataBind();
                    ddldomaingroupname.Items.Insert(0, new ListItem("Select Application Domain", "0"));

                }
                else
                {
                    ShowMessage("Please select Application Domain", MessageType.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        protected void ddlsbbulist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlsbulist.SelectedIndex != 0)
                {
                    app.SBU_Id = Convert.ToInt32(ddlsbulist.SelectedValue);
                    DataSet ds = new DataSet();
                    ds = Dal.GetBuList(app);
                    ddlbulist.DataSource = ds;
                    ddlbulist.DataTextField = "bu_name";
                    ddlbulist.DataValueField = "bu_id";
                    ddlbulist.DataBind();
                    ddlbulist.Items.Insert(0, new ListItem("Select Businees Unit", "0"));

                }
                else
                {
                    ShowMessage("Please select Bus Unit", MessageType.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }
        /*protected void ddldomaingroupname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddldomaingroupname.SelectedIndex != 0)
                {
                    appDashboard.appdomainname = ddldomaingroupname.SelectedItem.Text;
                    //appuser.App_Name = ddlApplicationDomains.SelectedItem.Text;
                    DataTable dt1 = Dal.GetAppDomainnameDetails(appDashboard);
                    ddldomaingroupname.DataSource = dt1;
                    ddldomaingroupname.DataBind();

                }
                else
                {
                    ShowMessage("Please select Application Domain Name", MessageType.Error);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, MessageType.Error);
            }
        }*/
        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        protected void txtCopy_Click(object sender, EventArgs e)
        {
            GetApplicationDeatils();
        }

        private void GetApplicationDeatils()
        {
            try
            {
                if (ddlApplicationName.SelectedIndex != 0)
                {
                    app.App_Name = ddlApplicationName.SelectedItem.Text;
                    //XmlDocument doc = new XmlDocument(); /*this is commented ---Displaying APP Id*/
                    //doc.Load(@"C:\inetpub\wwwroot\index.xml");


                    //XmlNodeList xNodeList = doc.GetElementsByTagName("entry");
                    //if (xNodeList != null)
                    //{
                    //    foreach (XmlNode curr in xNodeList)
                    //    {
                    //        if (curr.InnerText == ddlApplicationName.SelectedItem.Text)
                    //        {
                    //            //       Console.WriteLine(curr.InnerText);
                    //            //String[] id = curr.Attributes["key"].Value.ToString().Split('_');
                    //            //txtApplicationId.Text = id[0];

                    //        }
                    //    }
                    //}
                    DataTable dt = Dal.GetApplicationDetails(app);
                    //for (int j = 0; j < dt.Rows.Count; j++)
                    //{
                    //    for (int i = 0; i < dt.Columns.Count; i++)
                    //    {
                    //        Console.Write(dt.Columns[i].ColumnName + " ");
                    //        Console.WriteLine(dt.Rows[j].ItemArray[i]);
                    //    }
                    //}

                    if (dt.Rows != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {

                            //Console.WriteLine(dr);
                            if (dr["APPLICATIONName"] != DBNull.Value)
                            {
                                txtApplicationName.Text = Convert.ToString(dr["APPLICATIONName"]);
                            }
                            if (dr["ApplicationGroupName"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["ApplicationGroupName"]);
                                foreach (ListItem li in ddlAppGroup.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlAppGroup.SelectedIndex = ddlAppGroup.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlAppGroup.SelectedIndex = 0;
                            }


                            //if (dr["BU_Name"] != DBNull.Value)
                            //{
                            //    string value = Convert.ToString(dr["BU_Name"]);

                            //    foreach (ListItem li in ddlBu.Items)
                            //    {
                            //        if (li.Text.Equals(value))
                            //        {
                            //            ddlBu.SelectedIndex = ddlBu.Items.IndexOf(li);
                            //        }
                            //    }
                            //}
                            //else
                            //{
                            //    ddlBu.SelectedIndex = 0;
                            //}
                            //if (dr["SBU_Name"] != DBNull.Value)
                            //{
                            //    string value = Convert.ToString(dr["SBU_Name"]);
                            //    foreach (ListItem li in ddlSBBU.Items)
                            //    {
                            //        if (li.Text.Equals(value))
                            //        {
                            //            ddlSBBU.SelectedIndex = ddlSBBU.Items.IndexOf(li);
                            //        }
                            //    }
                            //}
                            //else
                            //{
                            //    ddlSBBU.SelectedIndex = 0;
                            //}

                            if (dr["SBU_Name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["SBU_Name"]);
                                foreach (ListItem li in ddlsbulist.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlsbulist.SelectedIndex = ddlsbulist.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlsbulist.SelectedIndex = 0;
                            }
                            if (dr["BU_Name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["BU_Name"]);
                                app.SBU_Id = Convert.ToInt32(ddlsbulist.SelectedValue);
                                DataSet ds = new DataSet();
                                ds = Dal.GetBuList(app);
                                ddlbulist.DataSource = ds;
                                ddlbulist.DataTextField = "bu_name";
                                ddlbulist.DataValueField = "bu_id";
                                ddlbulist.DataBind();
                                foreach (ListItem li in ddlbulist.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlbulist.SelectedIndex = ddlbulist.Items.IndexOf(li);
                                        
                                    }
                                }
                            }
                            else
                            {
                                ddlbulist.SelectedIndex = 0;
                            }
                            

                            if (dr["Industry_Sector_Name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["Industry_Sector_Name"]);
                                foreach (ListItem li in ddlIndustrySector.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlIndustrySector.SelectedIndex = ddlIndustrySector.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlIndustrySector.SelectedIndex = 0;
                            }
                            if (dr["Industry_Sub_Sector_Name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["Industry_Sub_Sector_Name"]);
                                foreach (ListItem li in ddlIndustrySubSector.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlIndustrySubSector.SelectedIndex = ddlIndustrySubSector.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlIndustrySubSector.SelectedIndex = 0;
                            }
                            if (dr["Industry_Specialization_Name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["Industry_Specialization_Name"]);
                                foreach (ListItem li in ddlIndustrySpecializtion.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlIndustrySpecializtion.SelectedIndex = ddlIndustrySpecializtion.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlIndustrySpecializtion.SelectedIndex = 0;
                            }
                            if (dr["Application_Retention_Name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["Application_Retention_Name"]);
                                foreach (ListItem li in ddlApplcationRetentionName.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlApplcationRetentionName.SelectedIndex = ddlApplcationRetentionName.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlApplcationRetentionName.SelectedIndex = 0;
                            }
                            if (dr["sector_name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["sector_name"]);
                                foreach (ListItem li in ddlSectors.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {

                                        ddlSectors.SelectedIndex = ddlSectors.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlSectors.SelectedIndex = 0;
                            }
                            if (dr["app_ownership_name"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["app_ownership_name"]);
                                foreach (ListItem li in ddlApplicationOwnership.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlApplicationOwnership.SelectedIndex = ddlApplicationOwnership.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlApplicationOwnership.SelectedIndex = 0;
                            }
                            /*if (dr["port"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["port"]);
                                foreach (ListItem li in ddlPort.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlPort.SelectedIndex = ddlPort.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlPort.SelectedIndex = 0;
                            }*/

                            txtFunctionalPurpose.Text = dr["_functional_purpose"] != DBNull.Value ? dr["_functional_purpose"].ToString() : "";
                            txtApplicationUserSProfile.Text = dr["_app_user_profile"] != DBNull.Value ? dr["_app_user_profile"].ToString() : "";
                            if (dr["jira_projname_app_team"] != DBNull.Value)
                            {
                                txtjiraprojnameappteam.Text = dr["jira_projname_app_team"].ToString();
                            }
                            else
                            {
                                txtjiraprojnameappteam.Text = "";
                            }
                            if(dr["castepicname"] !=DBNull.Value)
                            {
                                txtepiccreate.Text = dr["castepicname"].ToString();
                            }
                            else
                            {
                                txtepiccreate.Text = "";
                            }
                            if (dr["NO_OF_Clients"] != DBNull.Value)
                            {
                                txtNoOfClients.Text = dr["NO_OF_Clients"].ToString();
                            }
                            else
                            {
                                txtNoOfClients.Text = "";
                            }
                            if (dr["Development_Team_Size"] != DBNull.Value)
                            {
                                txtDevelopmentTeamSize.Text = dr["Development_Team_Size"].ToString();
                            }
                            else
                            {
                                txtDevelopmentTeamSize.Text = null;
                            }
                            if (dr["QA_Team_Size"] != DBNull.Value)
                            {
                                txtQATeamSize.Text = dr["QA_Team_Size"].ToString();
                            }
                            else
                            {
                                txtQATeamSize.Text = "";
                            }
                            if (dr["Lines_Of_Code"] != DBNull.Value)
                            {
                                txtLinesOfCode.Text = dr["Lines_Of_Code"].ToString();
                            }
                            else
                            {
                                txtLinesOfCode.Text = "";
                            }
                            if (dr["NO_OF_Classes"] != DBNull.Value)
                            {
                                txtNoOfClasses.Text = dr["NO_OF_Classes"].ToString();
                            }
                            else
                            {
                                txtNoOfClasses.Text = "";
                            }
                            if (dr["NO_OF_Tables"] != DBNull.Value)
                            {
                                txtNoOfTables.Text = dr["NO_OF_Tables"].ToString();
                            }
                            else
                            {
                                txtNoOfTables.Text = "";
                            }
                            if (dr["NO_OF_Files"] != DBNull.Value)
                            {
                                txtNoOfFiles.Text = dr["NO_OF_Files"].ToString();
                            }
                            else
                            {
                                txtNoOfFiles.Text = "";
                            }
                            if (dr["Platform_Model"] != DBNull.Value)
                            {
                                txtPaltFormModel.Text = dr["Platform_Model"].ToString();
                            }
                            else
                            {
                                txtPaltFormModel.Text = "";
                            }
                            if (dr["Aplication_Classification"] != DBNull.Value)
                            {
                                txtApplicationClassification.Text = dr["Aplication_Classification"].ToString();
                            }
                            else
                            {
                                txtApplicationClassification.Text = "";
                            }
                            if (dr["Programming_Languages"] != DBNull.Value)
                            {
                                txtProgrammingLanguages.Text = dr["Programming_Languages"].ToString();
                            }
                            else
                            {
                                txtProgrammingLanguages.Text = "";
                            }
                            if (dr["Frameworks"] != DBNull.Value)
                            {
                                txtFrameWorks.Text = dr["Frameworks"].ToString();
                            }
                            else
                            {
                                txtFrameWorks.Text = "";
                            }
                            if (dr["MiddleWare"] != DBNull.Value)
                            {
                                txtMiddleware.Text = dr["MiddleWare"].ToString();
                            }
                            else
                            {
                                txtMiddleware.Text = "";
                            }
                            if (dr["Database_USED"] != DBNull.Value)
                            {
                                txtDatabaseUsed.Text = dr["Database_USED"].ToString();
                            }
                            else
                            {
                                txtDatabaseUsed.Text = "";
                            }
                            if (dr["ThirdParty_SoftWare"] != DBNull.Value)
                            {
                                txtThirdPartySoftware.Text = dr["ThirdParty_SoftWare"].ToString();
                            }
                            else
                            {
                                txtThirdPartySoftware.Text = "";
                            }
                            if (dr["Build_Integration_Tool"] != DBNull.Value)
                            {
                                txtBuildIntegrationTool.Text = dr["Build_Integration_Tool"].ToString();
                            }
                            else
                            {
                                txtBuildIntegrationTool.Text = "";
                            }
                            if (dr["Versioning_Tool"] != DBNull.Value)
                            {
                                txtVersioningTool.Text = dr["Versioning_Tool"].ToString();
                            }
                            else
                            {
                                txtVersioningTool.Text = "";
                            }
                            if (dr["Methodology"] != DBNull.Value)
                            {
                                txtMethodology.Text = dr["Methodology"].ToString();
                            }
                            else
                            {
                                txtMethodology.Text = "";
                            }
                            if (dr["Lifecycle"] != DBNull.Value)
                            {
                                txtLifeCycle.Text = dr["Lifecycle"].ToString();
                            }
                            else
                            {
                                txtLifeCycle.Text = "";
                            }


                            if (dr["Process"] != DBNull.Value)
                            {
                                txtProcess.Text = dr["Process"].ToString();
                            }
                            else
                            {
                                txtProcess.Text = "";
                            }
                            if (dr["ISSystem_Generated_Code"] != DBNull.Value)
                            {
                                string value = dr["ISSystem_Generated_Code"].ToString();
                                foreach (ListItem li in ddlIsSystemgenerateCode.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlIsSystemgenerateCode.SelectedIndex = ddlIsSystemgenerateCode.Items.IndexOf(li);
                                    }
                                }


                            }
                            else
                            {
                                ddlIsSystemgenerateCode.SelectedIndex = 0;
                            }



                            if (dr["Status"] != DBNull.Value)
                            {
                                string value = dr["Status"].ToString();
                                foreach (ListItem li in ddlStatus.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlStatus.SelectedIndex = ddlStatus.Items.IndexOf(li);
                                    }
                                }
                            }

                            if (dr["licensetype"] != DBNull.Value)

                            {
                                string value = Convert.ToString(dr["licensetype"]);
                                foreach (ListItem li in ddlLicenseType.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlLicenseType.SelectedIndex = ddlLicenseType.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlLicenseType.SelectedIndex = 0;
                            }

                            /*if (dr["dbserver"] != DBNull.Value)
                            {
                                string value = Convert.ToString(dr["dbserver"]);
                                foreach (ListItem li in ddlDbserver.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlDbserver.SelectedIndex = ddlDbserver.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlDbserver.SelectedIndex = 0;
                            }*/

                            if (dr["Group_Name"] != DBNull.Value)
                            {
                                txtGroup.Text = dr["Group_Name"].ToString();
                            }
                            else
                            {
                                txtGroup.Text = "";
                            }
                            /*if (dr["agdDatabase"] != DBNull.Value)
                            {
                                txtADGDatabase.Text = dr["agdDatabase"].ToString();
                            }
                            else
                            {
                                txtADGDatabase.Text = "";
                            }*/

                            if (dr["_gdc"] != DBNull.Value)
                            {
                                txtGDC.Text = dr["_gdc"].ToString();
                            }
                            else
                            {
                                txtGDC.Text = "";
                            }



                            if (dr["_tcc_application"] != DBNull.Value)
                            {
                                string result = dr["_tcc_application"].ToString();
                                string value = "";
                                if (result == "True")
                                {
                                    value = "Yes";
                                }
                                else
                                {
                                    value = "No";
                                }

                                foreach (ListItem li in ddlTCCApplication.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlTCCApplication.SelectedIndex = ddlTCCApplication.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlTCCApplication.SelectedIndex = 0;
                            }

                            if (dr["onboardimgngapp"] != DBNull.Value)
                            {
                                string result = dr["onboardimgngapp"].ToString();
                                string value = "";
                                if (result == "Yes")
                                {
                                    value = "Yes";

                                    if (dr["imagingdevcount"] != DBNull.Value)
                                    {
                                        txtImgngdevcount.Text = dr["imagingdevcount"].ToString();
                                    }
                                    else
                                    {
                                        txtImgngdevcount.Text = "";
                                    }
                                    if (dr["imagingftecount"] != DBNull.Value)
                                    {
                                        txtImgngFTEcount.Text = dr["imagingftecount"].ToString();
                                    }
                                    else
                                    {
                                        txtImgngFTEcount.Text = "";
                                    }
                                    if (dr["imaginguseraccesscount"] != DBNull.Value)
                                    {
                                        txtImgngUsercount.Text = dr["imaginguseraccesscount"].ToString();
                                    }
                                    else
                                    {
                                        txtImgngUsercount.Text = "";
                                    }

                                    
                                }
                                if (result == "No")
                                {
                                    value = "No";

                                }

                                foreach (ListItem li in ddlonboardImgng.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddlonboardImgng.SelectedIndex = ddlonboardImgng.Items.IndexOf(li);
                                    }
                                }
                            }
                            else
                            {
                                ddlonboardImgng.SelectedIndex = 0;
                            }

                            //Value measurement field Added
                            if (dr["NewDevelopment"] != DBNull.Value)
                            {
                                txtnewdevelopment.Text = dr["NewDevelopment"].ToString();
                            }
                            else
                            {
                                txtnewdevelopment.Text = "";
                            }

                            if (dr["MinorEnhancement"] != DBNull.Value)
                            {
                                txtMinorEnhancement.Text = dr["MinorEnhancement"].ToString();
                            }
                            else
                            {
                                txtMinorEnhancement.Text = "";
                            }

                            if (dr["Maintenance"] != DBNull.Value)
                            {
                                txtMaintenance.Text = dr["Maintenance"].ToString();
                            }
                            else
                            {
                                txtMaintenance.Text = "";
                            }

                            if (dr["releasesperyear"] != DBNull.Value)
                            {
                                txtrelease.Text = dr["releasesperyear"].ToString();
                            }
                            else
                            {
                                txtrelease.Text = "";
                            }

                            if (dr["buildfrequency"] != DBNull.Value)
                            {
                                txtFreq.Text = dr["buildfrequency"].ToString();
                            }
                            else
                            {
                                txtFreq.Text = "";
                            }

                            if (dr["defectssit"] != DBNull.Value)
                            {
                                txtDefsit.Text = dr["defectssit"].ToString();
                            }
                            else
                            {
                                txtDefsit.Text = "";
                            }
                            if (dr["defectsuat"] != DBNull.Value)
                            {
                                txtDefuat.Text = dr["defectsuat"].ToString();
                            }
                            else
                            {
                                txtDefuat.Text = "";
                            }

                            if (dr["productiontesting"] != DBNull.Value)
                            {
                                txtprod.Text = dr["productiontesting"].ToString();
                            }
                            else
                            {
                                txtprod.Text = "";
                            }
                            if (dr["codechange"] != DBNull.Value)
                            {
                                txtcodechange.Text = dr["codechange"].ToString();
                            }
                            else
                            {
                                txtcodechange.Text = "";
                            }
                            if (dr["domain_name"] != DBNull.Value)

                            {
                                string value = Convert.ToString(dr["domain_name"]);
                                foreach (ListItem li in ddldomaingroup.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddldomaingroup.SelectedIndex = ddldomaingroup.Items.IndexOf(li);
                                    }
                                }
                                getgroupdetails(ddldomaingroup.SelectedItem.Text);
                            }
                            else
                            {
                                ddldomaingroup.SelectedIndex = 0;
                            }

                            if (dr["Group_Name"] != DBNull.Value)

                            {
                                string value = Convert.ToString(dr["Group_Name"]);
                                foreach (ListItem li in ddldomaingroupname.Items)
                                {
                                    if (li.Text.Equals(value))
                                    {
                                        ddldomaingroupname.SelectedIndex = ddldomaingroupname.Items.IndexOf(li);
                                    }
                                }

                            }
                            else
                            {
                                ddldomaingroupname.SelectedIndex = 0;
                            }

                            //------------------------------



                            /*if (dr[""] != DBNull.Value)
                            {
                                txtgroupusername.Text = dr[""].ToString();
                            }
                            else
                            {
                                txtgroupusername.Text = "";
                            }


                            if (dr[""] != DBNull.Value)
                            {
                                txtgrouppswd.Text = dr[""].ToString();
                            }
                            else
                            {
                                txtgrouppswd.Text = "";
                            }*/

                        }


                        ShowMessage("Data Populated", MessageType.Success);

                    }
                }


                else
                {
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Select Application Name to search')", true);
                    ShowMessage("Please select Application Name to search ", MessageType.Error);
                }
            }


            catch (Exception ex)
            {
                //Response.Write(ex.Message);
                //Response.Redirect("~/Error.aspx");
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            InsertApplicationDetails();
        }
        private void InsertApplicationDetails()
        {
            try
            {
                app.App_Name = txtApplicationName.Text;
                //app.App_Name_Externalinfra = txtexternalinfraApplicationName.Text;
                DataTable dt = Dal.GetApplicationDetails(app);
                if (dt.Rows.Count > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Already Exists')", true);
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtApplicationName.Text))
                    {
                        app.App_Name = txtApplicationName.Text;
                    }

                    //if (!String.IsNullOrEmpty(txtexternalinfraApplicationName.Text))
                    //{
                    //    app.App_Name_Externalinfra = txtexternalinfraApplicationName.Text;
                    //}
                    //if (ddlBu.SelectedIndex != 0)
                    //{
                    //    app.BU_Name = ddlBu.SelectedItem.Text;
                    //}
                    //if (ddlSBBU.SelectedIndex != 0)
                    //{
                    //    app.SBBU_Name = ddlSBBU.SelectedItem.Text;
                    //}
                    if (ddlsbulist.SelectedIndex != 0)
                    {
                        app.SBU_List = ddlsbulist.SelectedItem.Text;
                    }
                    if (ddlbulist.SelectedIndex != 0)
                    {
                        app.BU_List = ddlbulist.SelectedItem.Text;
                    }
                    if (ddlIndustrySector.SelectedIndex != 0)
                    {
                        app.Is_Name = ddlIndustrySector.SelectedItem.Text;
                    }
                    else
                    {
                        app.Is_Name = null;
                    }
                    if (ddlIndustrySubSector.SelectedIndex != 0)
                    {
                        app.ISBS_Name = ddlIndustrySubSector.SelectedItem.Text;
                    }
                    else
                    {
                        app.ISBS_Name = null;
                    }
                    if (ddlIndustrySpecializtion.SelectedIndex != 0)
                    {
                        app.ISP_Name = ddlIndustrySpecializtion.SelectedItem.Text;
                    }
                    else
                    {
                        app.ISP_Name = null;
                    }
                    if (ddlApplcationRetentionName.SelectedIndex != 0)
                    {
                        app.App_Retention_Name = ddlApplcationRetentionName.SelectedItem.Text;
                    }
                    else
                    {
                        app.App_Retention_Name = null;
                    }
                    if (!String.IsNullOrEmpty(txtjiraprojnameappteam.Text))
                    {
                        app.Jira_Projname_App_Team = txtjiraprojnameappteam.Text;
                        //Session["CASTEpicName"] = txtjiraprojnameappteam.Text;
                        //var item = addJiraIssue();

                    }
                    else
                    {
                        app.Jira_Projname_App_Team = "None";
                    }
                    if(!string.IsNullOrEmpty(txtepiccreate.Text))
                    {
                        app.EpicCreation = txtepiccreate.Text;
                        Session["CASTEpicName"] = txtepiccreate.Text;
                        //var item = addJiraIssue();
                    }
                    else
                    {
                        app.EpicCreation = "None";
                    }
                    if (!String.IsNullOrEmpty(txtNoOfClients.Text))
                    {
                        app.No_of_Clients = txtNoOfClients.Text;
                    }
                    else
                    {
                        app.No_of_Clients = "None";
                    }
                    if (!String.IsNullOrEmpty(txtDevelopmentTeamSize.Text))
                    {
                        app.Development_Team_Size = txtDevelopmentTeamSize.Text;
                    }
                    else
                    {
                        app.Development_Team_Size = "None";
                    }
                    if (!String.IsNullOrEmpty(txtQATeamSize.Text))
                    {
                        app.QA_Team_Size = txtQATeamSize.Text;
                    }
                    else
                    {
                        app.QA_Team_Size = "None";
                    }
                    if (!String.IsNullOrEmpty(txtLinesOfCode.Text))
                    {
                        app.Lines_Of_code = txtLinesOfCode.Text;
                    }
                    else
                    {
                        app.Lines_Of_code = "None";
                    }
                    if (!String.IsNullOrEmpty(txtNoOfClasses.Text))
                    {
                        app.No_Of_Classes = txtNoOfClasses.Text;
                    }
                    else
                    {
                        app.No_Of_Classes = "None";
                    }
                    if (!String.IsNullOrEmpty(txtNoOfTables.Text))
                    {
                        app.No_Of_Tables = txtNoOfTables.Text;
                    }
                    else
                    {
                        app.No_Of_Tables = "None";
                    }
                    if (!String.IsNullOrEmpty(txtNoOfFiles.Text))
                    {
                        app.No_Of_Files = txtNoOfFiles.Text;
                    }
                    else
                    {
                        app.No_Of_Files = "None";
                    }
                    if (!String.IsNullOrEmpty(txtPaltFormModel.Text))
                    {
                        app.Paltform_Model = txtPaltFormModel.Text;
                    }
                    else
                    {
                        app.Paltform_Model = "None";
                    }
                    if (!String.IsNullOrEmpty(txtApplicationClassification.Text))
                    {
                        app.Application_Classification = txtApplicationClassification.Text;
                    }
                    else
                    {
                        app.Application_Classification = "None";
                    }
                    if (!String.IsNullOrEmpty(txtProgrammingLanguages.Text))
                    {
                        app.Programming_Languages = txtProgrammingLanguages.Text;
                    }
                    else
                    {
                        app.Programming_Languages = "None";
                    }
                    if (!String.IsNullOrEmpty(txtFrameWorks.Text))
                    {
                        app.Frameworks = txtFrameWorks.Text;
                    }
                    else
                    {
                        app.Frameworks = "None";
                    }
                    if (!String.IsNullOrEmpty(txtMiddleware.Text))
                    {
                        app.Middeleware = txtMiddleware.Text;

                    }
                    else
                    {
                        app.Middeleware = "None";
                    }
                    if (!String.IsNullOrEmpty(txtDatabaseUsed.Text))
                    {
                        app.Database_Used = txtDatabaseUsed.Text;
                    }
                    else
                    {
                        app.Database_Used = "None";
                    }
                    if (!String.IsNullOrEmpty(txtThirdPartySoftware.Text))
                    {
                        app.ThridParty_software = txtThirdPartySoftware.Text;
                    }
                    else
                    {
                        app.ThridParty_software = "None";
                    }
                    if (!String.IsNullOrEmpty(txtBuildIntegrationTool.Text))
                    {
                        app.Build_Integration_Tool = txtBuildIntegrationTool.Text;
                    }
                    else
                    {
                        app.Build_Integration_Tool = "None";
                    }
                    if (!String.IsNullOrEmpty(txtVersioningTool.Text))
                    {
                        app.Versioning_Tool = txtVersioningTool.Text;
                    }
                    else
                    {
                        app.Versioning_Tool = "None";
                    }

                    if (!String.IsNullOrEmpty(txtMethodology.Text))
                    {
                        app.Methodology = txtMethodology.Text;
                    }
                    else
                    {
                        app.Methodology = "None";
                    }

                    if (!String.IsNullOrEmpty(txtLifeCycle.Text))
                    {
                        app.Lifecycle = txtLifeCycle.Text;
                    }
                    else
                    {
                        app.Lifecycle = "None";
                    }


                    //Added for value measurement fields
                    if (!String.IsNullOrEmpty(txtnewdevelopment.Text))
                    {
                        app.NewDevelopment = txtnewdevelopment.Text;
                    }
                    else
                    {
                        app.NewDevelopment = "None";
                    }

                    if (!String.IsNullOrEmpty(txtMinorEnhancement.Text))
                    {
                        app.MinorEnhancement = txtMinorEnhancement.Text;
                    }
                    else
                    {
                        app.MinorEnhancement = "None";
                    }

                    if (!String.IsNullOrEmpty(txtMaintenance.Text))
                    {
                        app.Maintenance = txtMaintenance.Text;
                    }
                    else
                    {
                        app.Maintenance = "None";
                    }

                    if (!String.IsNullOrEmpty(txtrelease.Text))
                    {
                        app.releasesperyear = txtrelease.Text;
                    }
                    else
                    {
                        app.releasesperyear = "None";
                    }

                    if (!String.IsNullOrEmpty(txtFreq.Text))
                    {
                        app.buildfrequency = txtFreq.Text;
                    }
                    else
                    {
                        app.buildfrequency = "None";
                    }

                    if (!String.IsNullOrEmpty(txtDefsit.Text))
                    {
                        app.defectssit = txtDefsit.Text;
                    }
                    else
                    {
                        app.defectssit = "None";
                    }

                    if (!String.IsNullOrEmpty(txtDefuat.Text))
                    {
                        app.defectsuat = txtDefuat.Text;
                    }
                    else
                    {
                        app.defectsuat = "None";
                    }


                    if (!String.IsNullOrEmpty(txtprod.Text))
                    {
                        app.productiontesting = txtprod.Text;
                    }
                    else
                    {
                        app.productiontesting = "None";
                    }

                    if (!String.IsNullOrEmpty(txtcodechange.Text))
                    {
                        app.codechange = txtcodechange.Text;
                    }
                    else
                    {
                        app.codechange = "None";
                    }



                    //------------------------------------
                    if (!String.IsNullOrEmpty(txtProcess.Text))
                    {
                        app.Process = txtProcess.Text;
                    }
                    else
                    {
                        app.Process = "None";
                    }
                    app.IsSystem_Generated_Code = ddlIsSystemgenerateCode.SelectedItem.Text;
                    if (ddlStatus.SelectedIndex != 0)
                    {
                        app.Status = ddlStatus.SelectedItem.Text;
                    }
                    /*if (!String.IsNullOrEmpty(txtGroup.Text))
                    {
                        app.Group = txtGroup.Text;
                    }
                    else
                    {
                        app.Group = "None";
                    }*/
                    if (ddldomaingroupname.SelectedIndex != 0)
                    {
                        app.Group = ddldomaingroupname.SelectedItem.Text;
                    }
                    if (ddldomaingroup.SelectedIndex != 0)
                    {
                        app.App_Domain_Name = ddldomaingroup.SelectedItem.Text;
                    }
                    if (!String.IsNullOrEmpty(txtADGDatabase.Text))
                    {
                        app.agdDatabase = txtADGDatabase.Text;
                    }
                    else
                    {
                        app.agdDatabase = "None";
                    }

                    if (ddlAppGroup.SelectedIndex != 0)
                    {
                        app.App_Group_Name = ddlAppGroup.SelectedItem.Text;
                    }
                    if (ddlSectors.SelectedIndex != 0)
                    {
                        app.setcor = ddlSectors.SelectedItem.Text;
                    }
                    if (ddlApplicationOwnership.SelectedIndex != 0)
                    {
                        app.Application_Ownership = ddlApplicationOwnership.SelectedItem.Text;
                    }
                    if (ddlLicenseType.SelectedIndex != 0)
                    {
                        app.licensetype = ddlLicenseType.SelectedItem.Text;
                    }

                    if (ddlDbserver.SelectedIndex != 0)
                    {
                        app.dbserver = ddlDbserver.SelectedItem.Text;
                    }

                    app.Function_Purpose = !String.IsNullOrEmpty(txtFunctionalPurpose.Text) ? txtFunctionalPurpose.Text : "None";
                    app.Application_users_profiles = !String.IsNullOrEmpty(txtApplicationUserSProfile.Text) ? txtApplicationUserSProfile.Text : "None";
                    app.GDC = !String.IsNullOrEmpty(txtGDC.Text) ? txtGDC.Text : "None";
                    app.Application_State = txtApplicationState.Text;
                    app.TCCApplication = ddlTCCApplication.SelectedItem.Text;

                    if(ddlonboardImgng.SelectedIndex!=0)
                    {
                        app.OnboardImaging = ddlonboardImgng.SelectedItem.Text;

                        if(app.OnboardImaging=="Yes")
                        {
                            if (!String.IsNullOrEmpty(txtImgngdevcount.Text))
                            {
                                app.ImgngDevCount = txtImgngdevcount.Text;
                            }
                            if (!String.IsNullOrEmpty(txtImgngFTEcount.Text))
                            {
                                app.ImgngFTECount = txtImgngFTEcount.Text;
                            }
                            if (!String.IsNullOrEmpty(txtImgngUsercount.Text))
                            {
                                app.ImgngUserAccessCount = txtImgngUsercount.Text;
                            }
                            else
                            {
                                app.ImgngDevCount = "None";
                                app.ImgngFTECount = "None";
                                app.ImgngUserAccessCount = "None";
                            }
                        }
                        else
                        {
                            app.OnboardImaging = ddlonboardImgng.SelectedItem.Text;
                            app.ImgngDevCount = "None";
                            app.ImgngFTECount = "None";
                            app.ImgngUserAccessCount = "None";
                        }
                    }
                    else
                    {
                        app.OnboardImaging = "None";
                        app.ImgngDevCount = "None";
                        app.ImgngFTECount = "None";
                        app.ImgngUserAccessCount = "None";
                    }

                    if (ddlPort.SelectedIndex != 0)
                    {
                        app.port = Convert.ToInt32(ddlPort.SelectedItem.Text);
                    }
                    if (String.IsNullOrEmpty(txtApplicationName.Text))
                    {
                        ShowMessage("Please fill the Mandatory Field Application Name", MessageType.Error);
                        txtApplicationName.Focus();
                    }
                    //else if (ddlBu.SelectedIndex == 0)
                    //{
                    //    ShowMessage("Please fill the Mandatory Field Strategic Business Unit", MessageType.Error);
                    //    ddlBu.Focus();
                    //}
                    //else if (ddlSBBU.SelectedIndex == 0)
                    //{
                    //    ShowMessage("Please fill the Mandatory Field Business Unit", MessageType.Error);
                    //    ddlSBBU.Focus();
                    //}
                    else if (ddlsbulist.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Strategic Business Unit", MessageType.Error);
                        ddlsbulist.Focus();
                    }
                    else if (ddlbulist.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Business Unit", MessageType.Error);
                        ddlbulist.Focus();
                    }
                    else if (ddlStatus.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Status", MessageType.Error);
                        ddlStatus.Focus();
                    }
                    else if (ddlIndustrySector.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Industry Sector", MessageType.Error);
                        ddlIndustrySector.Focus();
                    }
                    else if (ddlIndustrySpecializtion.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Industry Specialization", MessageType.Error);
                        ddlIndustrySpecializtion.Focus();
                    }
                    else if (ddlIndustrySubSector.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Industry SUB Sector", MessageType.Error);
                        ddlIndustrySubSector.Focus();
                    }
                    else if (ddlApplcationRetentionName.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Application Retention", MessageType.Error);
                        ddlApplcationRetentionName.Focus();
                    }
                    else if (ddlAppGroup.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Application Group", MessageType.Error);
                        ddlAppGroup.Focus();
                    }
                    else if (ddlSectors.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Sector", MessageType.Error);
                        ddlSectors.Focus();
                    }
                    else if (ddlApplicationOwnership.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Application Ownership", MessageType.Error);
                        ddlApplicationOwnership.Focus();
                    }
                    else if (ddlLicenseType.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field License Type", MessageType.Error);
                        ddlLicenseType.Focus();
                    }
                    else if (ddlDbserver.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Database Server", MessageType.Error);
                        ddlDbserver.Focus();
                    }
                    else if (ddlPort.SelectedIndex == 0)
                    {
                        ShowMessage("Please fill the Mandatory Field Port Status", MessageType.Error);
                        ddlPort.Focus();
                    }
                    else
                    {
                        Dal.InsertApplicationDetails(app);
                        //ValidateDomain("BU",ddlSBBU.SelectedItem.Text);
                        //ValidateDomain("SBU", ddlBu.SelectedItem.Text);
                        ValidateDomain("SBULIST", ddlsbulist.SelectedItem.Text);
                        ValidateDomain("BULIST", ddlbulist.SelectedItem.Text);
                        ValidateDomain("Sector", ddlSectors.SelectedItem.Text);
                        ValidateDomain("Application Group", ddlAppGroup.SelectedItem.Text);
                       // ValidateDomain('Industry', ddlSBBU.SelectedItem.Text);
                        ClearData();
                        ShowMessage("Data Inserted Successfully", MessageType.Success);

                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
          //  Boolean validation = GetValidate();
        }

        public string addJiraIssue()
        {
            XMLHTTP60 JiraService = new XMLHTTP60();
            JiraService.open("POST", "https://proactionca.ent.cgi.com/jira/rest/api/2/issue/");
            ///JiraService.open(api);
            JiraService.setRequestHeader("Content-Type", "application/json");
            JiraService.setRequestHeader("Accept", "application/json");
            JiraService.setRequestHeader("X-Atlassian-Token", "nocheck");
            //JiraService.setRequestHeader(" 'X-Atlassian-Token': 'nocheck'");
            JiraService.setRequestHeader("Authorization", "Basic " + GetEncodedCredentials());
            // string JiraJson;
            string EpicName = Session["CASTEpicName"].ToString();

            Project project = new Project();
            project.setKey("CASTC");

            Issuetype issuetype = new Issuetype();
            issuetype.setName("Epic");

            Fields fields = new Fields();
            fields.setProject(project);
            fields.setcustomfield_10003(EpicName);
            fields.setsummary(EpicName);
            fields.setdescription(EpicName);
            fields.setIssuetype(issuetype);


            EpicCreationRequest epiccreation = new EpicCreationRequest();
            epiccreation.setFields(fields);

            var JiraJson = new JavaScriptSerializer().Serialize(epiccreation);
            //ecr.field(fields.ToString());


            //JiraApiObject.Project proj = new JiraApiObject.Project();
            //JiraApiObject.Project.key("CASTC");
            //proj.key = "CASTC";

            //JiraApiObject.Fields fields = new JiraApiObject.Fields();
            //fields.project.key=("CASTC");
            //fields.issuetype.name = (Session["JiraEpicName"]).ToString();
            //fields.summary= (Session["JiraEpicName"]).ToString();
            //fields.customfield_10003= (Session["JiraEpicName"]).ToString();

            //JiraApiObject jao = new JiraApiObject();
            //JiraApiObject.Fields(fields);

            //string JiraJson = @"{""fields"":{""project"":{""key"":""CASTC""},""summary"": ""Onboard 0CGI-1USCSG-2USIS-3UEA-4TestAppCUP-5TestCUPJIRApp"",""customfield_10003"":""Onboard 0CGI-1USCSG-2USIS-3UEA-4TestAppCUP-5TestCUPJIRDEVOPS"",""issuetype"": {""name"": ""Epic""}}}";

            //string JiraJson = @"{""fields"":{""project"":{""key"":""CASTC""},""summary"": EpicName ,""customfield_10003"": EpicName ,""issuetype"": {""name"": ""Epic""}}}";
            // EpicCreationRequest epicCreation = new EpicCreationRequest();
            JiraService.send(JiraJson);
            String response = JiraService.responseText;
            JiraService.abort();
            return response;
        }

        public class JiraApiObject
        {
            public class Project
            {
                public string key { get; set; }
            }

            public class Issuetype
            {
                public string name { get; set; }
            }

            public class Fields
            {
                public Project project { get; set; }
                public Issuetype issuetype { get; set; }
                public string summary { get; set; }
                public string customfield_10003 { get; set; }
            }

            public class RootObject
            {
                public Fields fields { get; set; }
            }
        }

        public class Project
        {
            public string key { get; set; }

            public string getKey()
            {
                return this.key;
            }
            public void setKey(string key)
            {
                this.key = key;
            }
        }

        public class Issuetype
        {
            public string name { get; set; }

            public string getName()
            {
                return this.name;
            }
            public void setName(string name)
            {
                this.name = name;
            }
        }

        public class Fields
        {
            public Project project { get; set; }
            public Issuetype issuetype { get; set; }
            public string summary { get; set; }
            public string customfield_10003 { get; set; }
            public string description { get; set; }

            public Project getProject()
            {
                return this.project;
            }
            public void setProject(Project project)
            {
                this.project = project;
            }
            public string getcustomfield_10003()
            {
                return this.customfield_10003;
            }
            public void setcustomfield_10003(string customfield_10003)
            {
                this.customfield_10003 = customfield_10003;
            }
            public string getsummary()
            {
                return this.summary;
            }
            public void setsummary(string summary)
            {
                this.summary = summary;
            }
            public string getdescription()
            {
                return this.description;
            }
            public void setdescription(string description)
            {
                this.description = description;
            }
            public Issuetype getIssuetype()
            {
                return this.issuetype;
            }
            public void setIssuetype(Issuetype issuetype)
            {
                this.issuetype = issuetype;
            }
        }

        public class EpicCreationRequest
        {
            public Fields fields { get; set; }

            public Fields getFields()
            {
                return this.fields;
            }
            public void setFields(Fields fields)
            {
                this.fields = fields;
            }
        }

        public string CreateJiraRequest()
        {
            //string EpicoldName = Session["CASTEpicName"].ToString();

            //if(EpicoldName==Session["CASTEpicName"].ToString())
            //{

            //}

            XMLHTTP60 JiraService = new XMLHTTP60();
            JiraService.open("POST", "https://proactionca.ent.cgi.com/jira/rest/api/2/issue/");
            ///JiraService.open(api);
            JiraService.setRequestHeader("Content-Type", "application/json");
            JiraService.setRequestHeader("Accept", "application/json");
            JiraService.setRequestHeader("X-Atlassian-Token", "nocheck");
            //JiraService.setRequestHeader(" 'X-Atlassian-Token': 'nocheck'");
            JiraService.setRequestHeader("Authorization", "Basic" + GetEncodedCredentials());
            // string JiraJson;
            string EpicName = Session["CASTEpicName"].ToString();

            Project project = new Project();
            project.setKey("CASTC");

            Issuetype issuetype = new Issuetype();
            issuetype.setName("Epic");

            Fields fields = new Fields();
            fields.setProject(project);
            fields.setcustomfield_10003(EpicName);
            fields.setsummary(EpicName);
            fields.setdescription(EpicName);
            fields.setIssuetype(issuetype);


            EpicCreationRequest epiccreation = new EpicCreationRequest();
            epiccreation.setFields(fields);

            var JiraJson = new JavaScriptSerializer().Serialize(epiccreation);

            JiraService.send(JiraJson);
            String response = JiraService.responseText;
            JiraService.abort();
            return response;

        }

        public string GetEncodedCredentials()
        {
            string jusername = "sathishkumar.p@cgi.com";
            string jpassword = "Avengers@hulk94";
            string mergedCredentials = string.Format("{0}:{1}", jusername, jpassword);
            byte[] byteCredentials = UTF8Encoding.UTF8.GetBytes(mergedCredentials);
            return Convert.ToBase64String(byteCredentials);

        }


        private void ValidateDomain(string category, string group_name)
        {
            try
            {

                DataTable dt = Dal.Getgrouplevelusers(group_name, category);
                //dt = Dal.Getgrouplevelusers(group_name, category);
               
               string appname;
                if (dt.Rows != null)
                {
                    int i = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        //appname = new string[1];
                        //appuser.App_Name = txtApplicationName.Text;
                        appname= txtApplicationName.Text;
                        appuser.Role_Name = dr["role_name"].ToString();
                        appuser.User_email = dr["user_name"].ToString(); 
                        appuser.isAAD_User = Convert.ToBoolean(dr["isaad_user"].ToString());
                        appuser.isAED_user = Convert.ToBoolean(dr["isaed_user"].ToString());
                        Dal.InsertApplicationUser(appname, appuser);
                        i++;
                    }
                   
                }
            }


            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
            

        }
        private void getgroupdetails(string value)
        {
            try
            {
                appDashboard.appdomain = value;
                //appuser.App_Name = ddlApplicationDomains.SelectedItem.Text;
                //DataTable dt1 = Dal.GetApplicationDomaindetails(appDashboard);
                //gridViewDomain.DataSource = dt1;
                //gridViewDomain.DataBind();
                DataSet ds = new DataSet();
                ds = Dal.GetApplicationDomaindetails(appDashboard);
                ddldomaingroupname.DataSource = ds;
                ddldomaingroupname.DataTextField = "appdomainname";
                ddldomaingroupname.DataValueField = "domainid";
                ddldomaingroupname.DataBind();
                ddldomaingroupname.Items.Insert(0, new ListItem("Select Application Domain", "0"));

            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ShowMessage(ex.Message, MessageType.Error);
            }
        }
        private void ClearData()
        {
            try
            {
                txtADGDatabase.Text = "";
                ddlAppGroup.SelectedIndex = 0;
                txtApplicationClassification.Text = "";
                txtApplicationName.Text = "";
                txtBuildIntegrationTool.Text = "";
                txtDatabaseUsed.Text = "";
                txtDevelopmentTeamSize.Text = "";
                txtFrameWorks.Text = "";
                txtGroup.Text = "";
                txtLifeCycle.Text = "";
                txtLinesOfCode.Text = "";
                txtMethodology.Text = "";
                txtMiddleware.Text = "";
                txtNoOfClasses.Text = "";
                txtNoOfClients.Text = "";
                txtNoOfFiles.Text = "";
                txtNoOfTables.Text = "";
                txtPaltFormModel.Text = "";
                txtProcess.Text = "";
                txtProgrammingLanguages.Text = "";
                txtQATeamSize.Text = "";
                txtThirdPartySoftware.Text = "";
                txtVersioningTool.Text = "";
                ddlApplcationRetentionName.SelectedIndex = 0;
                //ddlBu.SelectedIndex = 0;
                ddlIndustrySector.SelectedIndex = 0;
                ddlIndustrySpecializtion.SelectedIndex = 0;
                ddlIndustrySubSector.SelectedIndex = 0;
                ddlIsSystemgenerateCode.SelectedIndex = 0;
                //ddlSBBU.SelectedIndex = 0;
                ddlsbulist.SelectedIndex = 0;
                ddlbulist.SelectedIndex = 0;
                ddlStatus.SelectedIndex = 0;
                ddlSectors.SelectedIndex = 0;
                ddlApplicationOwnership.SelectedIndex = 0;
                txtApplicationUserSProfile.Text = "";
                txtFunctionalPurpose.Text = "";
                ddlPort.SelectedIndex = 0;
                ddlLicenseType.SelectedIndex = 0;
                ddlDbserver.SelectedIndex = 0;
                ddlTCCApplication.SelectedIndex = 0;
                //txtexternalinfraApplicationName.Text = "";
                txtnewdevelopment.Text = "";
                txtMinorEnhancement.Text = "";
                txtMaintenance.Text = "";
                txtrelease.Text = "";
                txtFreq.Text = "";
                txtDefsit.Text = "";
                txtDefuat.Text = "";
                txtprod.Text = "";
                txtcodechange.Text = "";
                txtepiccreate.Text = "";





            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}