#pragma checksum "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edf96a4635f0813d82858c6f23273d4204ccbd9"
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
#line 2 "C:\CSharp\Project_PostOffice\Views\_ViewImports.cshtml"
using post_office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edf96a4635f0813d82858c6f23273d4204ccbd9", @"/Views/Shared/_LayoutMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588a1dfcb2bfeaf48f347fc02a3c0bbb5285a5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .active-nav{\r\n        background:#7ac8ac;\r\n        border-left:5px solid #c2f3e2;\r\n    }\r\n</style>\r\n<div class=\"logo-details\"  >\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 151, "\"", 157, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""col-8 container"" width=""150"" />

</div>
<ul class=""nav-links"" style=""position:initial;margin-bottom:0"">
    <li style=""height: 65px; background-image: linear-gradient(rgb(249 126 54 / 0.29), rgb(249 126 54 / 0.69)) "">
        <div style=""height:inherit; padding:21px 8px; width:22%;float:left"">
            <span style=""padding: 12px 16px; border-radius: 50%; color: white; background: rgb(219 133 98 / 0.59)"">V</span>
        </div>
        <div style=""height:inherit; padding:11px 0 10px 5px; width:78%;float:left"">
            <span style=""font-size: 15px; color: #e1ddd7; font-weight: 500; float: left; font-family: system-ui"">Current username</span>
            <br>
            <span style=""font-size: 12px; color: #cec3c2; float: left; font-family: system-ui"">
                Current role
                <span>
                    <i style=""color:#e1d0be; cursor:pointer"" id=""mysetting"" class=""fa fa-cog""></i>
                </span>
            </span>

        </div>
    </li>
    </u");
            WriteLiteral(@"l>
<ul class=""nav-links"" style=""height:75vh;overflow-y:scroll;overflow-x:hidden"" id=""scroll-menu"">

    <li>
        <a href=""/"" id=""__dash"" class=""menu"">
            <i class=""fa fa-home icons""></i>
            <span class=""links_name"">Dashboard</span>
        </a>
    </li>

    <li>
        <a id=""__user""");
            BeginWriteAttribute("href", " href=\"", 1502, "\"", 1536, 1);
#nullable restore
#line 39 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 1509, Url.Action("Users","Auth"), 1509, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n            <i class=\"fa fa-user \"></i>\r\n            <span class=\"links_name\">Users</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1690, "\"", 1724, 1);
#nullable restore
#line 45 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 1697, Url.Action("Roles","Auth"), 1697, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"__role\" class=\"menu\">\r\n            <i class=\"fa fa-object-group icons\"></i>\r\n            <span class=\"links_name\">Roles</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__cus\"");
            BeginWriteAttribute("href", " href=\"", 1914, "\"", 1952, 1);
#nullable restore
#line 51 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 1921, Url.Action("Customers","Auth"), 1921, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-users \"></i>\r\n            <span class=\"links_name\">Customers</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__bills\"");
            BeginWriteAttribute("href", " href=\"", 2126, "\"", 2160, 1);
#nullable restore
#line 58 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2133, Url.Action("Bills","Auth"), 2133, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-file \"></i>\r\n            <span class=\"links_name\">Bills</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__branches\"");
            BeginWriteAttribute("href", " href=\"", 2332, "\"", 2369, 1);
#nullable restore
#line 65 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2339, Url.Action("Branches","Auth"), 2339, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-object-ungroup \"></i>\r\n            <span class=\"links_name\">Branches</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__svc\"");
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2585, 1);
#nullable restore
#line 72 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2556, Url.Action("Service","Auth"), 2556, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-truck \"></i>\r\n            <span class=\"links_name\">Services</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__pc\"");
            BeginWriteAttribute("href", " href=\"", 2755, "\"", 2799, 1);
#nullable restore
#line 79 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2762, Url.Action("ProductCategory","Auth"), 2762, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n            <i class=\"fa fa-th-large\"></i>\r\n            <span class=\"links_name\">Product categories</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__pd\"");
            BeginWriteAttribute("href", " href=\"", 2979, "\"", 3016, 1);
#nullable restore
#line 85 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 2986, Url.Action("Products","Auth"), 2986, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-product-hunt \"></i>\r\n            <span class=\"links_name\">Products</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__attr\"");
            BeginWriteAttribute("href", " href=\"", 3195, "\"", 3234, 1);
#nullable restore
#line 92 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 3202, Url.Action("Attributes","Auth"), 3202, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-flag \"></i>\r\n            <span class=\"links_name\">Attributes</span>\r\n        </a>\r\n    </li>\r\n    <li>\r\n        <a id=\"__spf\"");
            BeginWriteAttribute("href", " href=\"", 3406, "\"", 3445, 1);
#nullable restore
#line 99 "C:\CSharp\Project_PostOffice\Views\Shared\_LayoutMenu.cshtml"
WriteAttributeValue("", 3413, Url.Action("SettingFee","Auth"), 3413, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu\">\r\n\r\n            <i class=\"fa fa-balance-scale\"></i>\r\n            <span class=\"links_name\">Setting transport fee</span>\r\n        </a>\r\n    </li>\r\n   \r\n\r\n\r\n</ul>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n   \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
