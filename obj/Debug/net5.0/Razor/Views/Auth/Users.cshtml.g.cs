#pragma checksum "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cf9e19c707dcd3fb80c7474a026eee47ee3130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Users), @"mvc.1.0.view", @"/Views/Auth/Users.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cf9e19c707dcd3fb80c7474a026eee47ee3130", @"/Views/Auth/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588a1dfcb2bfeaf48f347fc02a3c0bbb5285a5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<post_office.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
  
    ViewData["Title"] = "User management";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-12"" style=""display: table; background: white; top: 20px;box-shadow: rgb(248 242 225 / 0.92) 10px 10px 20px 5px; padding:20px"">
    <div style=""height:50px;position:relative; padding:0"">
        <button class=""btn-action delete"" id=""btnDelete"" style=""float:left;margin-right:2vw"">Delete</button>
        <input class=""input-search form-control"" style=""float:left;width:380px;"" type=""text"" placeholder=""Search by code, name"" />
        <button class=""btn-action save"" id=""btnCreate"" style=""float:right;"">Create</button>

    </div>
    <table class=""table"" style="" border:2px solid #ddd;width:inherit"" id=""table-id"">
        <tr style=""color: white; background: #747583"">
            <th><input type=""checkbox"" id=""check-all"" onclick=""SelectAll(this)"" /></th>
            <th>#</th>
            <th>Code</th>
            <th>Fullname</th>
            <th>Phone</th>
            <th>Role</th>
            <th>Branch</th>
            <th>Status</th>
            <th>Action</th>
        </tr>
 ");
            WriteLiteral(@"       <tr class=""table-item"">
            <td class=""tbl-20""><input type=""checkbox"" class=""sub-check"" post-item=""post-"" /></td>
            <td class=""tbl-30"">1</td>
            <td class=""tbl-200"">12345678987654321</td>
            <td class=""tbl-200"">User user user</td>
            <td class=""tbl-150"">03866622145</td>
            <td class=""tbl-150"">Admin</td>
            <td class=""tbl-120"">HCM City </td>
            <td class=""sts-item tbl-40"" id=""sts-""></td>
            <td class=""tbl-180"">
                <span oid=""object-1"" class=""action-icon edit edit-user"" style=""padding:10px 5px 10px 10px"">
                    <i class=""fa fa-edit""></i>
                </span>

                <span oid=""object-1"" class=""action-icon delete delete-user"">
                    <i class=""fa fa-trash""></i>
                </span>
            </td>
        </tr>


    </table>
    <div class=""pagination-container"" style=""cursor:pointer"">
        <nav aria-label=""Page navigation example"" style=""posi");
            WriteLiteral("tion:unset;box-shadow:none; background:none;padding:0\">\r\n            <ul class=\"pagination\" id=\"paginations\">\r\n                <li class=\"page-item page-link\" data-page=\"prev\">&lt;</li>\r\n");
#nullable restore
#line 54 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                 for (int i = 1; i <= ViewBag.pagi; i++)
                {
                    if (i == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item page-link\" data-page=\"page-1\" style=\"background:#ddd\">");
#nullable restore
#line 58 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 59 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item page-link\" data-page=\"page-");
#nullable restore
#line 63 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 63 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 64 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""page-item page-link"" data-page=""next"">&gt;</li>
            </ul>
        </nav>
    </div>
</div>
<div id=""view-main"">
    <div id=""view-sub"" class=""col-11"">
        <div class=""col-12"" id=""view-title"">
            <label></label>
            <span style=""float:right; cursor:pointer"" id=""CloseForm"">
                <i class=""fa fa-window-close"" style=""pointer-events:none;font-size:38px""></i>
            </span>
        </div>
        <div id=""content"">
");
#nullable restore
#line 80 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
             using (Html.BeginForm("UserCU", "User", FormMethod.Post, new { @id = "form-user" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\" style=\"padding:20px;min-height:450px;display:table;\">\r\n                    <div class=\"col-6\" style=\"border-right:3px solid #f4e8e4;min-height:inherit;float:left\">\r\n                        ");
#nullable restore
#line 84 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <label class=""text-color"">
                            Code:
                            <span class=""text-readonly"">12345678987654321</span>
                        </label>
                        <br/>
                        <label class=""text-color"">Full name:</label>
                        ");
#nullable restore
#line 91 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.TextBoxFor(d => d.fullName, new { @class = "input-form-cu", @type = "text", @placeholder = "full name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 92 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.ValidationMessageFor(d => d.fullName, "", new { @class = "_error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <label class=\"text-color\">Phone:</label>\r\n                        ");
#nullable restore
#line 95 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.TextBoxFor(d => d.phone, new { @class = "input-form-cu", @type = "text", @placeholder = "phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 96 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.ValidationMessageFor(d => d.phone, "", new { @class = "_error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <label class=\"text-color\">Password:</label>\r\n                        ");
#nullable restore
#line 99 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.PasswordFor(d => d.password, new { @class = "input-form-cu",  @placeholder = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 100 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.ValidationMessageFor(d => d.password, "", new { @class = "_error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <br />
                      </div>
                    <div class=""col-6"" style=""min-height:inherit;float:left"">
                        <br/>
                        <label class=""text-color mt-3"">Role:</label>
                        ");
#nullable restore
#line 106 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.DropDownListFor(m => m.roleId, (IEnumerable<SelectListItem>)ViewBag.role_ls, null, new { @class = "dropdownlist" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <label class=\"text-color\">Branch:</label>\r\n                        ");
#nullable restore
#line 109 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.DropDownListFor(m => m.branchId, (IEnumerable<SelectListItem>)ViewBag.role_ls, null, new { @class = "dropdownlist" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <label class=\"text-color\">Status:</label>\r\n                        ");
#nullable restore
#line 112 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
                   Write(Html.DropDownListFor(model => model.status, new SelectList(ViewBag.ls_sts, "Key", "Value"), new { @class = "dropdownlist" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </div>
                </div>
                <div class=""col-12"" style="" min-height: 70px; border-radius: 0 0 5px 5px; text-align:center"">
                    <button id=""btnUserSave"" type=""submit"" class=""save btn-action pl-4 pr-4 pt-2 pb-2"">Save</button>
                    <a id=""btnUserCancel"" onclick=""ResetForm()"" class=""cancel btn-action ml-1"" style=""cursor:pointer; padding:12px 25px"">Cancel</a>
                </div>
");
#nullable restore
#line 121 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>

<script type=""text/javascript"">

    $(""#btnCreate"").click(function () {
        OpenForm(""Create user"",0);
    });
    $("".edit-user"").click(function () {
        var id = $(this).attr(""oid"").replace(""object-"", """");
        OpenForm(""Update user"",id)
    });
    function OpenForm(type, id) {
        $(""#content"").append('');
        $(""#view-main"").css(""display"", ""block"");
        document.getElementById(""view-title"").children[0].innerHTML = type;
        $("".sidebar"").css(""pointer-events"", ""none"")


    }
    $(""#CloseForm"").click(function () {
        ResetForm();
    });

    function ResetForm() {
        CloseForm();
");
#nullable restore
#line 151 "C:\CSharp\Project_PostOffice\Views\Auth\Users.cshtml"
          post_office.Controllers.Administrator.UserController.id = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        er = document.getElementsByClassName(""_error"");
        for (var i = 0; i < er.length; i++) {
            $(er).html("""");
        }
        $(""#form-user"").trigger(""reset"");

    }
    $('#btnUserSave').click(function () {
        er = document.getElementsByClassName(""_error"");
        for (var i = 0; i < er.length; i++) {
            if ($(er[i]).length > 0) {
                $(er[i]).shake();
            }
        }
    });

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<post_office.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
