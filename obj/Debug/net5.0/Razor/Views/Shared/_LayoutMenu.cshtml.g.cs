#pragma checksum "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20591d365cff9963d4d9c482f108a082cebcaf6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutMenu), @"mvc.1.0.view", @"/Views/Shared/_LayoutMenu.cshtml")]
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
#line 3 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
using post_office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20591d365cff9963d4d9c482f108a082cebcaf6c", @"/Views/Shared/_LayoutMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c33bc81411c8478abb59bd49d3925a21ba29a7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/defaults/logo-light.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-9 container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:50%; width:38px;height:38px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .active-nav{\r\n        background:#7ac8ac;\r\n        border-left:5px solid #c2f3e2;\r\n    }\r\n</style>\r\n<div class=\"logo-details\"  >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20591d365cff9963d4d9c482f108a082cebcaf6c4819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>
<ul class=""nav-links"" style=""position:initial;margin-bottom:0"">
    <li style=""height: 65px; background-image: linear-gradient(rgb(255 230 114 / 0.75),rgb(251 211 31 / 0.96)) "">
        <div style=""height:inherit; padding:13px 10px; width:22%;float:left"">
");
#nullable restore
#line 15 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
               
                string temp = "default.png";
                if (AuthenticetionModel.avt != null && AuthenticetionModel.avt != "")
                    temp = AuthenticetionModel.avt;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20591d365cff9963d4d9c482f108a082cebcaf6c6636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 778, "~/img/AvtUser/", 778, 14, true);
#nullable restore
#line 21 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
AddHtmlAttributeValue("", 792, temp, 792, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </span>\r\n        </div>\r\n        <div style=\"height:inherit; padding:11px 0 10px 5px; width:78%;float:left\">\r\n            <span style=\"font-size: 15px; color: #faf6e1; font-weight: 500; float: left; font-family: system-ui\">");
#nullable restore
#line 25 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
                                                                                                            Write(post_office.Models.AuthenticetionModel.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br>\r\n            <span style=\"font-size: 12px; color: #faf4de; float: left; font-family: system-ui\">\r\n                ");
#nullable restore
#line 28 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
           Write(post_office.Models.AuthenticetionModel.roleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span");
            BeginWriteAttribute("onclick", " onclick=\"", 1344, "\"", 1408, 3);
            WriteAttributeValue("", 1354, "window.location.href=\'", 1354, 22, true);
#nullable restore
#line 29 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 1376, Url.Action("MyAccount","Auth"), 1376, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1407, "\'", 1407, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style="" cursor: pointer"">
                    <i style=""color: #f9f3de;"" id=""mysetting"" class=""fa fa-cog""></i>
                </span>
            </span>

        </div>
    </li>
    </ul>
<ul class=""nav-links"" style=""height:75vh;overflow-y:scroll;overflow-x:hidden"" id=""scroll-menu"">

    <li>
        <a");
            BeginWriteAttribute("href", " href=\"", 1728, "\"", 1766, 1);
#nullable restore
#line 40 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 1735, Url.Action("Dashboard","Auth"), 1735, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"__dash\" class=\"menu\">\r\n            <i class=\"fa fa-home icons\"></i>\r\n            <span class=\"links_name\">Dashboard</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 45 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_USER"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__user\"");
            BeginWriteAttribute("href", " href=\"", 2026, "\"", 2060, 1);
#nullable restore
#line 48 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2033, Url.Action("Users","Auth"), 2033, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n                <i class=\"fa fa-user \"></i>\r\n                <span class=\"links_name\">Users</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 53 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.roleName == "Super Admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2309, "\"", 2344, 1);
#nullable restore
#line 57 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2316, Url.Action("Roles", "Auth"), 2316, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"__role\" class=\"menu\">\r\n                <i class=\"fa fa-object-group icons\"></i>\r\n                <span class=\"links_name\">Roles</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 62 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_CUSTOMER"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__cus\"");
            BeginWriteAttribute("href", " href=\"", 2634, "\"", 2673, 1);
#nullable restore
#line 66 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2641, Url.Action("Customers", "Auth"), 2641, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-users \"></i>\r\n                <span class=\"links_name\">Customers</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 72 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_CONTACT"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__cont\"");
            BeginWriteAttribute("href", " href=\"", 2945, "\"", 2983, 1);
#nullable restore
#line 76 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2952, Url.Action("Contacts", "Auth"), 2952, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-address-book\"></i>\r\n                <span class=\"links_name\">Contacts</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 82 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_BILL"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__bills\"");
            BeginWriteAttribute("href", " href=\"", 3258, "\"", 3293, 1);
#nullable restore
#line 86 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 3265, Url.Action("Bills", "Auth"), 3265, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-file \"></i>\r\n                <span class=\"links_name\">Bills</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 92 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.roleName == "Super Admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__branches\"");
            BeginWriteAttribute("href", " href=\"", 3560, "\"", 3598, 1);
#nullable restore
#line 96 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 3567, Url.Action("Branches", "Auth"), 3567, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-object-ungroup \"></i>\r\n                <span class=\"links_name\">Branches</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 102 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_SERVICE"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__svc\"");
            BeginWriteAttribute("href", " href=\"", 3877, "\"", 3914, 1);
#nullable restore
#line 106 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 3884, Url.Action("Service", "Auth"), 3884, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-truck \"></i>\r\n                <span class=\"links_name\">Services</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 112 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_PRODUCT_CATEGORY"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__pc\"");
            BeginWriteAttribute("href", " href=\"", 4192, "\"", 4237, 1);
#nullable restore
#line 116 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 4199, Url.Action("ProductCategory", "Auth"), 4199, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n                <i class=\"fa fa-th-large\"></i>\r\n                <span class=\"links_name\">Product categories</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 121 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_PRODUCT"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__pd\"");
            BeginWriteAttribute("href", " href=\"", 4516, "\"", 4554, 1);
#nullable restore
#line 125 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 4523, Url.Action("Products", "Auth"), 4523, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-product-hunt \"></i>\r\n                <span class=\"links_name\">Products</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 131 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("VIEW_ATTRIBUTE"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__attr\"");
            BeginWriteAttribute("href", " href=\"", 4834, "\"", 4874, 1);
#nullable restore
#line 135 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 4841, Url.Action("Attributes", "Auth"), 4841, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-flag \"></i>\r\n                <span class=\"links_name\">Attributes</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 141 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
     if (AuthenticetionModel.hasPermission("SETTING_TRANSPORT_FEE"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a id=\"__spf\"");
            BeginWriteAttribute("href", " href=\"", 5154, "\"", 5194, 1);
#nullable restore
#line 145 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 5161, Url.Action("SettingFee", "Auth"), 5161, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n                <i class=\"fa fa-balance-scale\"></i>\r\n                <span class=\"links_name\">Setting transport fee</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 151 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n   \r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
