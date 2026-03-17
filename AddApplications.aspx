<%@ Page Title="" Language="C#" MasterPageFile="~/CastDashboard.Master" AutoEventWireup="true" CodeBehind="AddApplications.aspx.cs" Inherits="Cast_Dashboard.AddApplications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="ApplicationDetails.css" rel="stylesheet" />
    <script src="Validation.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <div class="messagealert" id="divAlter">
    </div>
    <div class="container" id="Title">
        <div class="Header">
            <b>Add Application details</b>
        </div>
    </div>
    <br />
    <div class="container-fluid" id="container1">
        <div class="row">
            <div class="col-xs-12">
                <div id="searchDiv">
                    <b>Select Application Name</b><span style="color: red">*</span>
                    &nbsp
                    <asp:DropDownList ID="ddlApplicationName" runat="server" CssClass="SearchTextBox"></asp:DropDownList>
                    <%--&nbsp--%>
                    <span class="glyphicon glyphicon-search"></span>
                    <asp:Button ID="txtCopy" runat="server" CssClass="btn btn-primary" Text="Copy" OnClick="txtCopy_Click" />
                </div>
            </div>
        </div>
        <br />
        <br />
        <div class="container-fluid" id="container2">
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <label for="txtApplicationName">Application Name</label>
                        <span style="color: red">*</span>
                        <asp:TextBox ID="txtApplicationName" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                    </div>

                    <%--   External Users ---Adding Application--%>
                    <%-- <div class="form-group">
                    <label for="txtexternalinfraApplicationName">Application Name(external Uers)</label>
                    <%--<span style="color: red">*</span>--%>
                    <%-- <asp:TextBox ID="txtexternalinfraApplicationName" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                </div>--%>

                    <div class="form-group">
                        <label for="ddlAppGroup">Application Group</label>
                        <span style="color: red">*</span>
                        <asp:DropDownList ID="ddlAppGroup" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <%--<div class="form-group">
                    <label for="ddlBu">Strategic Business Unit </label>
                    <span style="color: red">*</span>
                    <asp:DropDownList ID="ddlBu" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>--%>
                    <%--<div class="form-group">
                    <label for="ddlSBBU">Business Unit </label>
                    <span style="color: red">*</span>
                    <asp:DropDownList ID="ddlSBBU" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>--%>
                    <div class="form-group">
                        <label for="ddlsbulist">SBU List</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlsbulist" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlsbbulist_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddlbulist">BU List</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlbulist" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtGDC">GDC</label>
                        <asp:TextBox ID="txtGDC" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ddlSectors">Sector</label>
                        <span style="color: red">*</span>
                        <asp:DropDownList ID="ddlSectors" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddlIndustrySector">Industry Sector</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlIndustrySector" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddlIndustrySubSector">Industry SUB Sector</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlIndustrySubSector" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddlIndustrySpecializtion">Industry Specialization </label>
                        <span style="color: red">*</span>
                        <asp:DropDownList ID="ddlIndustrySpecializtion" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Application Ownership</label>
                        <span style="color: red">*</span>
                        <asp:DropDownList ID="ddlApplicationOwnership" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddlApplcationRetentionName">Application Retention</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlApplcationRetentionName" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtFunctionalPurpose">Functional Purpose</label>
                        <asp:TextBox ID="txtFunctionalPurpose" runat="server" CssClass="form-control" TextMode="MultiLine" MaxLength="1000" Height="60"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Application users Profile/number</label>
                        <asp:TextBox ID="txtApplicationUserSProfile" runat="server" CssClass="form-control" TextMode="MultiLine" MaxLength="1000" Height="60"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtjiraprojnameappteam">Jira Project Name of the Application Team</label>
                        <asp:TextBox ID="txtjiraprojnameappteam" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtNoOfClients">No Of Clients</label>
                        <asp:TextBox ID="txtNoOfClients" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtDevelopmentTeamSize">No Of Developers</label>
                        <asp:TextBox ID="txtDevelopmentTeamSize" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtQATeamSize">QA Team Size</label>
                        <asp:TextBox ID="txtQATeamSize" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtLinesOfCode">Lines Of Code</label>
                        <asp:TextBox ID="txtLinesOfCode" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtNoOfClasses">No Of Classes</label>
                        <asp:TextBox ID="txtNoOfClasses" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtNoOfTables">No Of Tables</label>
                        <asp:TextBox ID="txtNoOfTables" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="ddlTCCApplication">Is TCC/Enlighten installed in ODC</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlTCCApplication" runat="server" CssClass="form-control">
                            <asp:ListItem Value="0" Text="No"></asp:ListItem>
                            <asp:ListItem Value="1" Text="Yes"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtNoOfFiles">No Of Files</label>
                        <asp:TextBox ID="txtNoOfFiles" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtepiccreate">CAST Epic Title</label>
                        <asp:TextBox ID="txtepiccreate" runat="server" CssClass="form-control" placeholder="Onboard 0CGI-1SBU-2BU-3Sector-4AppGroup-5ApplicationName"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <%--<label for="onboardedImaging">Application Onboarded into Imaging</label>--%>
                        <div id="menuimg">
                            <h3><b>Application Onboarded to Imaging</b></h3>
                            <div>
                                <div class="form-group">
                                    <label for="ddlonboardImgng">onboarded into Imaging</label>
                                    <asp:DropDownList ID="ddlonboardImgng" runat="server" CssClass="form-control">
                                        <asp:ListItem Text="Please Select the Status" Value="Please Select the Status" Enabled="true"></asp:ListItem>
                                        <asp:ListItem Value="No" Text="No"></asp:ListItem>
                                        <asp:ListItem Value="Yes" Text="Yes"></asp:ListItem>
                                        <%--<asp:ListItem Value="0" Text="No"></asp:ListItem>--%>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <%--<label ID="lblImgngdevcount">Total No of Developers where Imaging Training is required</label>--%>
                                    <asp:Label ID="lblImgngdevcount" runat="server" AssociatedControlID="txtImgngdevcount" Text="Total No of Developers where Imaging Training is required"></asp:Label>
                                    <asp:TextBox ID="txtImgngdevcount" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblImgngFTEcount" runat="server" AssociatedControlID="txtImgngFTEcount" Text="Total No of FTE in the Application"></asp:Label>
                                    <asp:TextBox ID="txtImgngFTEcount" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <%--<label for="lblImgngUsercount">Total No of Users where Access Enabled</label>--%>
                                    <asp:Label ID="lblImgngUsercount" runat="server" AssociatedControlID="txtImgngUsercount" Text="Total No of Users where Access Enabled"></asp:Label>
                                    <asp:TextBox ID="txtImgngUsercount" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6">

                    <div class="form-group">
                        <label for="txtPaltFormModel">Platform Model</label>
                        <asp:TextBox ID="txtPaltFormModel" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtApplicationClassification">Application Classification</label>
                        <asp:TextBox ID="txtApplicationClassification" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtProgrammingLanguages">Programming Languages</label>
                        <asp:TextBox ID="txtProgrammingLanguages" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtFrameWorks">Frameworks</label>
                        <asp:TextBox ID="txtFrameWorks" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtMiddleware">Middleware</label>
                        <asp:TextBox ID="txtMiddleware" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtDatabaseUsed">Database</label>
                        <asp:TextBox ID="txtDatabaseUsed" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtThirdPartySoftware">Third Party Software</label>
                        <asp:TextBox ID="txtThirdPartySoftware" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ddlIsSystemgenerateCode">Is System Generated Code</label>
                        <asp:DropDownList runat="server" ID="ddlIsSystemgenerateCode" CssClass="form-control">
                            <asp:ListItem Value="0" Text="False"></asp:ListItem>
                            <asp:ListItem Value="1" Text="True"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtBuildIntegrationTool">Build Integration Tool</label>
                        <asp:TextBox ID="txtBuildIntegrationTool" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtVersioningTool">Versioning Tool</label>
                        <asp:TextBox ID="txtVersioningTool" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtMethodology">Methodology</label>
                        <asp:TextBox ID="txtMethodology" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtLifeCycle">Life Cycle</label>
                        <asp:TextBox ID="txtLifeCycle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtProcess">Process</label>
                        <asp:TextBox ID="txtProcess" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="ddlStatus">Status</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Please Select Status" Value="Please Select Status" Enabled="true">
                            </asp:ListItem>
                            <asp:ListItem Text="On Boarded" Value="On Boarded"></asp:ListItem>
                            <asp:ListItem Text="Open" Value="Open"></asp:ListItem>
                            <asp:ListItem Text="Closed" Value="Closed"></asp:ListItem>
                            <asp:ListItem Text="Hold" Value="Hold"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Application State</label>
                        <asp:TextBox ID="txtApplicationState" runat="server" Text="Un Stabilized" Enabled="false" CssClass="disabled form-control"></asp:TextBox>
                    </div>
                    <div class="form-group" style="display: None;">
                        <label for="txtGroup">Group</label>
                        <asp:TextBox ID="txtGroup" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ddldomaingroup">Domain Group</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddldomaingroup" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddldomaingroup_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Text="Select Domain Group" Value="Select Domain Group" Enabled="true"></asp:ListItem>
                            <asp:ListItem Text="AICP1" Value="AICP1"></asp:ListItem>
                            <asp:ListItem Text="AICP2" Value="AICP2"></asp:ListItem>
                            <asp:ListItem Text="AICP3" Value="AICP3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddldomaingroupname">Domain Group Name</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddldomaingroupname" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtADGDatabase">ADG Database</label><span style="color: red">*</span>
                        <asp:TextBox ID="txtADGDatabase" runat="server" CssClass="form-control" onkeyup="this.value = this.value.toLowerCase();"
                            Style="text-transform: lowercase;"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ddlPort">Port</label>
                        <label for="ddlStatus">Status</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlPort" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Select Port" Value="Select Port" Enabled="true"></asp:ListItem>
                            <asp:ListItem Text="2280" Value="2280"></asp:ListItem>
                            <asp:ListItem Text="2281" Value="2281"></asp:ListItem>
                            <asp:ListItem Text="2282" Value="2282"></asp:ListItem>
                            <asp:ListItem Text="2283" Value="2283"></asp:ListItem>
                            <asp:ListItem Text="2285" Value="2285"></asp:ListItem>
                            <asp:ListItem Text="2286" Value="2286"></asp:ListItem>
                            <asp:ListItem Text="2287" Value="2287"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="ddlLicenseType">LicenseType</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlLicenseType" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Select LicenseType" Value="Select LicenseType" Enabled="true"></asp:ListItem>
                            <asp:ListItem Text="N" Value="N"></asp:ListItem>
                            <asp:ListItem Text="N+1" Value="N+1"></asp:ListItem>
                            <asp:ListItem Text="N-1" Value="N-1"></asp:ListItem>
                            <asp:ListItem Text="N-2" Value="N-2"></asp:ListItem>
                            <asp:ListItem Text="N-8" Value="N-8"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <%--  Added For value Measurement--%>
                    <div class="form-group">
                        <label for="ddlDbserver">Database Server</label><span style="color: red">*</span>
                        <asp:DropDownList ID="ddlDbserver" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Select Database Server" Value="Select Database Server" Enabled="true"></asp:ListItem>
                            <asp:ListItem Text="DB1" Value="DB1"></asp:ListItem>
                            <asp:ListItem Text="DB2" Value="DB2"></asp:ListItem>

                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="ddlAutomation">Value Measurement</label>
                        <div id="menu">
                            <h3><b>Activity Breakdown(Release data out of 100%)</b></h3>
                            <div>
                                <div class="form-group">
                                    <label for="txtnewdevelopment">Large Enhancement/New Development</label>
                                    <asp:TextBox ID="txtnewdevelopment" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtMinorEnhancement">Minor Enhancement</label>
                                    <asp:TextBox ID="txtMinorEnhancement" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtMaintenance">Maintenance</label>
                                    <asp:TextBox ID="txtMaintenance" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group"></div>
                        <div id="menu2">
                            <h3><b>Quality Monitoring (Release Data)</b></h3>
                            <div>

                                <div class="form-group">
                                    <label for="txtrelease">Total Number of releases per year</label>
                                    <asp:TextBox ID="txtrelease" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtFreq">Release/Build Frequency</label>
                                    <asp:TextBox ID="txtFreq" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtDefsit">Number of Defects in SIT</label>
                                    <asp:TextBox ID="txtDefsit" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtDefuat">Number of Defects in UAT</label>
                                    <asp:TextBox ID="txtDefuat" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtprod">Number of Defects in Production Testing</label>
                                    <asp:TextBox ID="txtprod" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtcodechange">Number of Tickets with Code Change</label>
                                    <asp:TextBox ID="txtcodechange" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>

                <div class="form-group">
                    <div class="pull-right">
                        <asp:Button ID="btnInsert" runat="server" Text="Submit" CssClass="btn btn-primary btn-lg" OnClick="btnInsert_Click" />
                        &nbsp &nbsp &nbsp
                    </div>
                </div>
            </div>
        </div>

    </div>

    <script>

        $(document).ready(function () {

            $("#menu").accordion({ collapsible: true, active: false });

        });
    </script>
    <script>

        $(document).ready(function () {

            $("#menu2").accordion({ collapsible: true, active: false });

        });
    </script>
    <script>

        $(document).ready(function () {

            $("#menuimg").accordion({ collapsible: true, active: false });

        });
    </script>




    <%--<script>
        $(document).ready(function () {
            var txtimgdevcount = $("#<%= txtImgngdevcount.ClientID %>");
            var txtimgftecount = $("#<%= txtImgngFTEcount.ClientID %>");
            var txtimgusercount = $("#<%= txtImgngUsercount.ClientID %>");
            var lblimgdevcount = $("#<%= lblImgngdevcount.ClientID %>");
            var lblimgftecount = $("#<%= lblImgngFTEcount.ClientID %>");
            var lblimgusercount = $("#<%= lblImgngUsercount.ClientID %>");

            // Hide text boxes initially
            txtimgdevcount.hide();
            txtimgftecount.hide();
            txtimgusercount.hide();
            lblimgdevcount.hide();
            lblimgftecount.hide();
            lblimgusercount.hide();

            // Handle DropDownList change event
            $("#<%= ddlonboardImgng.ClientID %>").change(function () {
                var selectedValue = $(this).val();

                if (selectedValue === "1") {
                    txtimgdevcount.show();
                    txtimgftecount.show();
                    txtimgusercount.show();
                    lblimgdevcount.show();
                    lblimgftecount.show();
                    lblimgusercount.show();
                } else {
                    txtimgdevcount.hide();
                    txtimgftecount.hide();
                    txtimgusercount.hide();
                    lblimgdevcount.hide();
                    lblimgftecount.hide();
                    lblimgusercount.hide();
                }
            });

            
        });
    </script>--%>

    <script>
        $(document).ready(function () {
             var txtimgdevcount = $("#<%= txtImgngdevcount.ClientID %>");
             var txtimgftecount = $("#<%= txtImgngFTEcount.ClientID %>");
             var txtimgusercount = $("#<%= txtImgngUsercount.ClientID %>");
             var lblimgdevcount = $("#<%= lblImgngdevcount.ClientID %>");
             var lblimgftecount = $("#<%= lblImgngFTEcount.ClientID %>");
             var lblimgusercount = $("#<%= lblImgngUsercount.ClientID %>");

             // Hide text boxes initially
             txtimgdevcount.hide();
             txtimgftecount.hide();
             txtimgusercount.hide();
             lblimgdevcount.hide();
             lblimgftecount.hide();
             lblimgusercount.hide();

             function updateTextBoxesVisibility(selectedValue) {
                 if (selectedValue === "Yes") {
                     txtimgdevcount.show();
                     txtimgftecount.show();
                     txtimgusercount.show();
                     lblimgdevcount.show();
                     lblimgftecount.show();
                     lblimgusercount.show();
                 } else {
                     txtimgdevcount.hide();
                     txtimgftecount.hide();
                     txtimgusercount.hide();
                     lblimgdevcount.hide();
                     lblimgftecount.hide();
                     lblimgusercount.hide();
                 }
             }

             // Trigger the change event manually after initializing
             $("#<%= ddlonboardImgng.ClientID %>").change(function () {
                 updateTextBoxesVisibility($(this).val());
             }).change(); // Manually trigger the change event immediately
        });
    </script>
    

    <%--<script>
        $(document).ready(function () {
            debugger;
            $('#ddlsbulist,#ddlbulist').on('change', UpdateEpicTextBox());
            debugger;
            function UpdateEpicTextBox() {
                debugger;
                var selectedValue1 = $('#ddlsbulist option:selected').text();
                var selectedValue2 = $('#ddlbulist option:selected').text();
                $('#txtepiccreate').val(selectedValue1 + ' ' + selectedValue2);
            }
        })
    </script>--%>

    <%--<script>
        $(document).ready(function () {
            debugger;
            $('#ddlsbulist,#ddlbulist').on('change', UpdateEpicTextBox());
            debugger;
            function UpdateEpicTextBox() {
                debugger;
                var selectedValue1 = $('#ddlsbulist option:selected').text();
                var selectedValue2 = $('#ddlbulist option:selected').text();
                $('#txtepiccreate').val(selectedValue1 + ' ' + selectedValue2);
            }
        })
    </script>--%>

    <%--<script>
        //Current Usage
        $(document).ready(function () {
            debugger;
            $('#<%= ddlsbulist.ClientID %>,#<%= ddlbulist.ClientID %>').on('change', UpdateEpicTextBox());
            debugger;
            function UpdateEpicTextBox() {
                debugger;
                var selectedValue1 = $('#<%= ddlsbulist.ClientID %> option:selected').text();
                var selectedValue2 = $('#<%= ddlbulist.ClientID %> option:selected').text();
                $('#<%= txtepiccreate.ClientID %>').val(selectedValue1 + ' ' + selectedValue2);
            }
        })
    </script>--%>

    <%--<script>
        //Latest one Used
        // Get references to the dropdowns and the textbox
        var dropdown1 = document.getElementById("<%= ddlsbulist.ClientID %>");
        var dropdown2 = document.getElementById("<%= ddlbulist.ClientID %>");
        var resultTextbox = document.getElementById("<%= txtepiccreate.ClientID %>");

        // Add event listeners to the dropdowns
        dropdown1.addEventListener("change", updateResultTextbox);
        dropdown2.addEventListener("change", updateResultTextbox);

        // Function to update the result textbox
        function updateResultTextbox() {
            debugger;
            var value1 = dropdown1.value;
            var value2 = dropdown2.value;

            // Combine the selected values and update the textbox
            var combinedValue = value1 + " " + value2;
            resultTextbox.value = combinedValue;
        }
    </script>--%>

    <%-- <script>
        $(document).ready(function () {
            //Latest semi-Working
            // Get references to the dropdowns and the text box
            var dropdown1 = $("#<%= ddlsbulist.ClientID %>");
            var dropdown2 = $("#<%= ddlbulist.ClientID %>");
            var resultTextbox = $("#<%= txtepiccreate.ClientID %>");

            // Function to update the text box with the selected text from the dropdowns
            function updateTextbox() {
                var selectedText1 = dropdown1.find(":selected").text();
                var selectedText2 = dropdown2.find(":selected").text();
                var result = selectedText1 + " " + selectedText2;
                resultTextbox.val(result);
            }

            // Call the function initially to set the initial value
            updateTextbox();

            // Add event listeners to the dropdowns to update the text box when the selection changes
            dropdown1.change(updateTextbox);
            dropdown2.change(updateTextbox);

            $("#<%= txtApplicationName.ClientID %>").on("keyup", function () {
                // Fetch the text from the input box
                var inputText = $(this).val();

                // Set the value of the output box with the input text
                $("#<%= txtepiccreate.ClientID %>").val(inputText);
            }); 
        });
    </script>--%>

    <%--<script>
        $(document).ready(function () {

            var dropdown1 = $("#<%= ddlsbulist.ClientID %>");
            var dropdown2 = $("#<%= ddlbulist.ClientID %>");
            var dropdown3 = $("#<%= ddlSectors.ClientID %>");
            var dropdown4 = $("#<%= ddlAppGroup.ClientID %>");

            //var resultTextbox = $("#<%= txtepiccreate.ClientID %>");
            // Function to update the combined text box
            function updateCombinedText() {
                var dropdown1Value = dropdown1.find(":selected").text();
                var dropdown2Value = dropdown2.find(":selected").text();
                var dropdown3Value = dropdown3.find(":selected").text();
                var dropdown4Value = dropdown4.find(":selected").text();
                var enteredText = $("#<%= txtApplicationName.ClientID %>").val();

                var combinedText = "Onboard 0CGI" + "-1" + dropdown1Value + "-2" + dropdown2Value + "-3" + dropdown3Value + "-4" + dropdown4Value + "-5" + enteredText;
                $("#<%= txtepiccreate.ClientID %>").val(combinedText);
            }

            // Bind event handlers to update the combined text when any input changes
            $("#<%= ddlsbulist.ClientID %>, #<%= ddlbulist.ClientID %>,#<%= ddlSectors.ClientID %>,#<%= ddlAppGroup.ClientID %>").on("change", function () {
                updateCombinedText();
            });

            $("#<%= txtApplicationName.ClientID %>").on("keyup", function () {
                updateCombinedText();
            });

            // Initial update when the page loads
            //updateCombinedText();
        });
    </script>--%>

    <script>
        $(document).ready(function () {

            var dropdown1 = $("#<%= ddlsbulist.ClientID %>");
            var dropdown2 = $("#<%= ddlbulist.ClientID %>");
            var dropdown3 = $("#<%= ddlSectors.ClientID %>");
            var dropdown4 = $("#<%= ddlAppGroup.ClientID %>");

            //var resultTextbox = $("#<%= txtepiccreate.ClientID %>");
            // Function to update the combined text box
            function updateCombinedText() {
                var dropdown1Value = dropdown1.find(":selected").text();
                var dropdown2Value = dropdown2.find(":selected").text();
                var dropdown3Value = dropdown3.find(":selected").text();
                var dropdown4Value = dropdown4.find(":selected").text();
                var enteredText = $("#<%= txtApplicationName.ClientID %>").val();

                var combinedText = "Onboard 0CGI" + "-1" + dropdown1Value;
                if (dropdown2Value !== "") {
                    combinedText += "-2" + dropdown2Value;
                }
                if (dropdown3Value !== "") {
                    combinedText += "-3" + dropdown3Value;
                }
                if (dropdown4Value !== "") {
                    combinedText += "-4" + dropdown4Value;
                }
                if (enteredText !== "") {
                    combinedText += "-5" + enteredText;
                }

                $("#<%= txtepiccreate.ClientID %>").val(combinedText);

                // Disable the textbox after updating its value
                $("#<%= txtepiccreate.ClientID %>").prop("readonly", true);

            }

            // Bind event handlers to update the combined text when any input changes
            $("#<%= ddlsbulist.ClientID %>, #<%= ddlbulist.ClientID %>,#<%= ddlSectors.ClientID %>,#<%= ddlAppGroup.ClientID %>").on("change", function () {
                updateCombinedText();
            });

            $("#<%= txtApplicationName.ClientID %>").on("keyup", function () {
                updateCombinedText();
            });

            // Initial update when the page loads
            //updateCombinedText();
        });
    </script>

    <%--<script>

         // Bind change event to the dropdown lists
            $("#<%= ddlsbulist.ClientID %>, #<%= ddlbulist.ClientID %>").change(function () {
                debugger;
                // Get the selected values from both dropdown lists
                var selectedValue1 = $("#<%= ddlsbulist.ClientID %>").val();
                var selectedValue2 = $("#<%= ddlbulist.ClientID %>").val();

                // Concatenate the selected values and display in the textbox
                $("#<%= txtepiccreate.ClientID %>").val(selectedValue1 + " " + selectedValue2);
            });
        
    </script>--%>

    <%--<script>
        
            // Bind change event to the dropdown lists
        $("#ddlsbulist, #ddlbulist").change(function () {
            debugger;
                // Get the selected values from both dropdown lists
                var selectedValue1 = $("#ddlsbulist").val();
                var selectedValue2 = $("#ddlbulist").val();

                // Concatenate the selected values and display in the textbox
                $("#txtepiccreate").val(selectedValue1 + " " + selectedValue2);
        });
        
    </script>--%>

    <script>
        function createEpic(castEpicName) {

            let ajaxJiraUrl = 'https://proactionca.ent.cgi.com/jira/rest/api/2/issue/';

            $.ajax({
                url: 'EpicCreationController',
                type: 'POST',
                data: {
                    apiUrl: ajaxJiraUrl,
                    txtjiraprojnameappteam: castEpicName

                },
                success: function (result) {
                    console.log(result);
                    hideBlockMessage();
                    if (result !== undefined && result !== null && result !== '') {
                        setTimeout(function () {
                            showAlertNotification(result.key + ' Created Successfully', 'success');
                            setTimeout(function () {
                            }, 1000);
                        }, 100);
                    }
                },
                error: function () {
                    showAlertNotification('There is some error', 'error');
                }
            });
            return;
        }
    </script>



</asp:Content>
