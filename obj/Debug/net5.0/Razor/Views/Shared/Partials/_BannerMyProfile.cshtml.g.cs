#pragma checksum "/Users/admin/c#/Project_PostOffice/Views/Shared/Partials/_BannerMyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcb6af7280392f4756b4a858fc87af74e2723250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__BannerMyProfile), @"mvc.1.0.view", @"/Views/Shared/Partials/_BannerMyProfile.cshtml")]
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
#line 1 "/Users/admin/c#/Project_PostOffice/Views/_ViewImports.cshtml"
using post_office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/c#/Project_PostOffice/Views/_ViewImports.cshtml"
using post_office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb6af7280392f4756b4a858fc87af74e2723250", @"/Views/Shared/Partials/_BannerMyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588a1dfcb2bfeaf48f347fc02a3c0bbb5285a5f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__BannerMyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admin/c#/Project_PostOffice/Views/Shared/Partials/_BannerMyProfile.cshtml"
  
    var bannerTitle = ViewData["BannerTitle"] ?? "My Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""themestek-titlebar-wrapper themestek-bg themestek-bgcolor-transparent themestek-titlebar-align-allleft themestek-textcolor-dark themestek-bgimage-yes""
    style=""background-image: none !important; background-color: #ffdc39 !important; height: 450px;"">
    <div class=""themestek-titlebar-wrapper-bg-layer themestek-bg-layer""></div>
    <div class=""themestek-titlebar entry-header"">
        <div class=""themestek-titlebar-inner-wrapper"">
            <div class=""themestek-titlebar-main"">
                <div class=""align-items-center container d-flex justify-content-between"">
                    <div class=""themestek-titlebar-main-inner"">
                        <div class=""entry-title-wrapper"">
                            <div class=""container"">
                                <h1 class=""entry-title"">");
#nullable restore
#line 14 "/Users/admin/c#/Project_PostOffice/Views/Shared/Partials/_BannerMyProfile.cshtml"
                                                   Write(bannerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                            </div>
                        </div>
                        <div class=""breadcrumb-wrapper"">
                            <div class=""container"">
                                <div class=""breadcrumb-wrapper-inner"">
                                    <!-- Breadcrumb NavXT output -->
                                    <span><a title=""Go to MoversCO Demo 6."" href=""https://localhost:5001/"" class=""home"">
                                            <span>Post Office</span>
                                        </a>
                                    </span>
                                    <span class=""sep"">-</span>
                                    <span>
                                        <span class=""post post-page current-item"">");
#nullable restore
#line 27 "/Users/admin/c#/Project_PostOffice/Views/Shared/Partials/_BannerMyProfile.cshtml"
                                                                             Write(bannerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div><!-- .themestek-titlebar-main -->
        </div><!-- .themestek-titlebar-inner-wrapper -->
    </div><!-- .themestek-titlebar -->
</div>");
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
