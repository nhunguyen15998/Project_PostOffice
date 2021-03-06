#pragma checksum "C:\CSharp\Project_PostOffice\Views\Customer\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42daff29cd4795444740e4953ad7c50fe5067c63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_MyAccount), @"mvc.1.0.view", @"/Views/Customer/MyAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42daff29cd4795444740e4953ad7c50fe5067c63", @"/Views/Customer/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c33bc81411c8478abb59bd49d3925a21ba29a7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Bill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\CSharp\Project_PostOffice\Views\Customer\MyAccount.cshtml"
  
    ViewData["Title"] = "Profile";
    ViewData["BannerTitle"] = "My Profile";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
<style>
    .nav-pills .nav-link.active,
    .nav-pills .show>.nav-link {
        color: #ffdc39 !important;
        background-color: transparent !important;
        border-bottom: 2px solid #ffdc39 !important;
        border-radius: 0 !important;
    }

    .dropdown-toggle::after {
        right: 0px !important;
        position: absolute !important;
        top: 20px !important;
    }

    .nav-link {
        color: #111 !important;
    }

    .nav-link:focus,
    .nav-link:hover {
        color: #ffdc39 !important;
    }

    .carousel-control-prev-icon {
        background-image: url('../../img/defaults/previous-page.png') !important;
    }

    .carousel-control-next-icon {
        background-image: url('../../img/defaults/next-page.png') !important;
    }
    .btn:hover {
        color: white !important;
        background-color: #ffdc39 !important;
    }

    .table-warning {
        --bs-table-bg: #ffdc39 !important;
    }
</style>
");
            }
            );
            WriteLiteral(@"<div id=""content-wrapper"" class=""site-content-wrapper"">
    <div id=""content"" class=""site-content "">
        <div id=""content-inner"" class=""site-content-inner "">
            <div id=""primary"" class=""content-area  "">
                <main id=""main"" class=""site-main"">
                    <div data-vc-full-width=""true"" data-vc-full-width-init=""true""
                        style=""position: relative; left: 0px; box-sizing: border-box; width: 1440px; padding-left: 0px; padding-right: 0px;"">
                        <div class=""vc_row container""
                            style=""margin-bottom: 150px !important; margin: auto"">
                            <!--menu-->
                            <ul class=""nav nav-pills mb-5"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" aria-current=""page"" href=""#"">Profile</a>
                                </li>
                                <li class=""nav-item dropdown"">
                      ");
            WriteLiteral(@"              <a class=""nav-link dropdown-toggle"" data-bs-toggle=""dropdown"" href=""#"" role=""button""
                                        aria-expanded=""false"">Send</a>
                                    <ul class=""dropdown-menu"">
                                        <li><a class=""dropdown-item"" href=""#"">Bills</a></li>
                                        <li><a class=""dropdown-item"" href=""#"">Orders</a></li>
                                        <li><a class=""dropdown-item"" href=""#"">Purchased Products</a></li>
                                    </ul>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Receive</a>
                                </li>
                            </ul>
                            <!--end menu-->
                            <div style=""height: fit-content;width: 100%;"">
                                <!--profile-->
");
            WriteLiteral("                                <!--send - bill-->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42daff29cd4795444740e4953ad7c50fe5067c637395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <!--receive-->\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </main><!-- #main .site-main -->
            </div><!-- #primary .content-area -->
        </div><!-- .site-content-inner -->
    </div><!-- .site-content -->
</div>");
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
