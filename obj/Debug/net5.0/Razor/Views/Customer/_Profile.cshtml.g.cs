#pragma checksum "C:\CSharp\Project_PostOffice\Views\Customer\_Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cbd1b94e4637b215b1b6d88c5fb7f5c3ec2244d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer__Profile), @"mvc.1.0.view", @"/Views/Customer/_Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cbd1b94e4637b215b1b6d88c5fb7f5c3ec2244d", @"/Views/Customer/_Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c33bc81411c8478abb59bd49d3925a21ba29a7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer__Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--info-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cbd1b94e4637b215b1b6d88c5fb7f5c3ec2244d4384", async() => {
                WriteLiteral(@"
    <h3 class=""mb-4"">Information</h3>
    <div class=""col-lg-8"">
        <div class=""row"">
            <div class=""col-lg-6 form-group"" style=""margin-bottom: 30px;"">
                <input name=""first-name"" class=""form-control form-control-user"" id=""first-name""
                    aria-describedby=""firstName"" placeholder=""First name""
                    style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: none;outline-color: transparent;height: 50px;"">
            </div>
            <div class=""col-lg-6 form-group"" style=""margin-bottom: 30px;"">
                <input name=""last-name"" class=""form-control form-control-user"" id=""last-name""
                    aria-describedby=""lastName"" placeholder=""Last name""
                    style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: none;outline-color: transparent;height: 50px;"">
            </div>
        </div>
        <div class=""row"">
            <");
                WriteLiteral(@"div class=""col-lg-6 form-group"" style=""margin-bottom: 30px;"">
                <input name=""phone"" class=""form-control form-control-user"" id=""phone"" aria-describedby=""phone""
                    placeholder=""Phone""
                    style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: none;outline-color: transparent;height: 50px;"">
            </div>
            <div class=""col-lg-6 form-group"" style=""margin-bottom: 30px;"">
                <input name=""email"" class=""form-control form-control-user"" id=""email"" aria-describedby=""email""
                    placeholder=""Email""
                    style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: none;outline-color: transparent;height: 50px;"">
            </div>
        </div>
        <div class=""mb-3 row"">
            <div class=""col-lg-6"">
                <label style=""font-size: 14px;"" class=""align-items-center d-flex""><input type=""checkbox"">Change
  ");
                WriteLiteral(@"                  password?</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""form-group"" style=""margin-bottom: 30px;"">
                    <input name=""old-password"" class=""form-control form-control-user"" id=""old-password""
                        aria-describedby=""old-password"" placeholder=""Old password""
                        style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: none;outline-color: transparent;height: 50px;"">
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""form-group"" style=""margin-bottom: 30px;"">
                    <input name=""password"" class=""form-control form-control-user"" id=""password""
                        aria-describedby=""password"" placeholder=""New password""
                        style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: n");
                WriteLiteral(@"one;outline-color: transparent;height: 50px;"">
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""form-group"" style=""margin-bottom: 30px;"">
                    <input name=""repeat-password"" class=""form-control form-control-user"" id=""repeat-password""
                        aria-describedby=""repeatPassword"" placeholder=""Repeat new password""
                        style=""padding: 15px 20px;font-size: 13px;border-radius: 50px;background-color: transparent;outline: none;outline-color: transparent;height: 50px;"">
                </div>
            </div>
        </div>
        <a id=""btn-sign-up"" class=""btn btn-block btn-user""
            style=""background-color: transparent;color: #ffdc39;border: 1px solid #ffdc39;border-radius: 50px;padding: 10px 20px;margin: 0 auto;"">Update</a>
    </div>
    <!--photo-->
    <div class=""align-items-center col-lg-4 d-flex flex-column"">
        <div style=""position: relative;width: 100%;height: 170px;"" class=");
                WriteLiteral(@"""d-flex justify-content-center"">
            <img src=""../../img/defaults/no-avatar.jpeg"" width=""150"" height=""150""
                style=""border-radius: 50%;position: absolute;"">
            <div style=""position: absolute;right: 120px;bottom: 25px;"">
                <button class=""align-items-center btn btn-secondary d-flex justify-content-center""
                    style=""border-radius: 50%;height: 30px;width: 30px;font-size: 12px;"">
                    <i class=""fa-solid fa-camera""></i>
                </button>
            </div>
        </div>
        <p style=""font-size: 30px;"" class=""mb-0"">
            Nhu Nguyen</p>
        <p");
                BeginWriteAttribute("class", " class=\"", 4811, "\"", 4819, 0);
                EndWriteAttribute();
                WriteLiteral(">Customer</p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!--end info-->\r\n<!--address book-->\r\n<div class=\"row\">\r\n    <h3>Address book</h3>\r\n    <div style=\"padding: 30px 50px;\">\r\n        <div id=\"addressBook\" class=\"carousel slide\" data-bs-ride=\"carousel\"");
            BeginWriteAttribute("style", " style=\"", 5055, "\"", 5063, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <div class=""justify-content-around row"" style=""padding: 10px;"">
                        <div
                            style=""background-color: white;height: fit-content;width: 48%;border-radius: 10px;box-shadow: 0 3px 10px rgb(0 0 0 / 0.2);position: relative;"">
                            <div style=""position: absolute;right: 15px;top: 15px;"">
                                <img src=""../../img/defaults/pin-address.png"" width=""30"">
                            </div>
                            <div class=""row"" style=""padding: 30px 20px;font-size: 13px;"">
                                <h5 class=""mb-2"">Nhu Nguyen</h5>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Phone: 0987654322
             ");
            WriteLiteral(@"                       </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-envelope""></i></span>
                                        Email: aishiteru1509@gmail.com
                                    </p>
                                </div>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-briefcase""></i></span>
                                        Co. name: Amazon
                                    </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Co. phone: 0987654321
                                    </p>
                                </div>
                                <p class=""mb-0"">
                                    <span><i class=""fa-so");
            WriteLiteral(@"lid fa-location-dot""></i></span>
                                    Address: 214 Nguyen Dinh Chieu, Ward 6, District 3,
                                    HCMC
                                </p>
                            </div>
                        </div>
                        <div
                            style=""background-color: white;height: fit-content;width: 48%;border-radius: 10px;box-shadow: 0 3px 10px rgb(0 0 0 / 0.2);position: relative;"">
                            <div style=""position: absolute;right: 15px;top: 15px;"">
                                <img src=""../../img/defaults/pin-address.png"" width=""30"">
                            </div>
                            <div class=""row"" style=""padding: 30px 20px;font-size: 13px;"">
                                <h5 class=""mb-2"">Nhu Nguyen</h5>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-pho");
            WriteLiteral(@"ne""></i></span>
                                        Phone: 0987654322
                                    </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-envelope""></i></span>
                                        Email: aishiteru1509@gmail.com
                                    </p>
                                </div>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-briefcase""></i></span>
                                        Co. name: Amazon
                                    </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Co. phone: 0987654321
                                    </p>
                                </div>
                  ");
            WriteLiteral(@"              <p class=""mb-0"">
                                    <span><i class=""fa-solid fa-location-dot""></i></span>
                                    Address: 214 Nguyen Dinh Chieu, Ward 6, District 3,
                                    HCMC
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <div class=""justify-content-around row"" style=""padding: 10px;"">
                        <div
                            style=""background-color: white;height: fit-content;width: 48%;border-radius: 10px;box-shadow: 0 3px 10px rgb(0 0 0 / 0.2);position: relative;"">
                            <div style=""position: absolute;right: 15px;top: 15px;"">
                                <img src=""../../img/defaults/pin-address.png"" width=""30"">
                            </div>
                            <div class=""row"" style=""padding: 30px 2");
            WriteLiteral(@"0px;font-size: 13px;"">
                                <h5 class=""mb-2"">Nhu Nguyen</h5>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Phone: 0987654322
                                    </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-envelope""></i></span>
                                        Email: aishiteru1509@gmail.com
                                    </p>
                                </div>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-briefcase""></i></span>
                                        Co. name: Amazon
                                    </p>
                                  ");
            WriteLiteral(@"  <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Co. phone: 0987654321
                                    </p>
                                </div>
                                <p class=""mb-0"">
                                    <span><i class=""fa-solid fa-location-dot""></i></span>
                                    Address: 214 Nguyen Dinh Chieu, Ward 6, District 3,
                                    HCMC
                                </p>
                            </div>
                        </div>
                        <div
                            style=""background-color: white;height: fit-content;width: 48%;border-radius: 10px;box-shadow: 0 3px 10px rgb(0 0 0 / 0.2);position: relative;"">
                            <div style=""position: absolute;right: 15px;top: 15px;"">
                                <img src=""../../img/defaults/pin-address.png"" width=""30"">
              ");
            WriteLiteral(@"              </div>
                            <div class=""row"" style=""padding: 30px 20px;font-size: 13px;"">
                                <h5 class=""mb-2"">Nhu Nguyen</h5>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Phone: 0987654322
                                    </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-envelope""></i></span>
                                        Email: aishiteru1509@gmail.com
                                    </p>
                                </div>
                                <div class=""col-lg-6"">
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-briefcase""></i></span>
                                        Co. n");
            WriteLiteral(@"ame: Amazon
                                    </p>
                                    <p class=""mb-0"">
                                        <span><i class=""fa-solid fa-phone""></i></span>
                                        Co. phone: 0987654321
                                    </p>
                                </div>
                                <p class=""mb-0"">
                                    <span><i class=""fa-solid fa-location-dot""></i></span>
                                    Address: 214 Nguyen Dinh Chieu, Ward 6, District 3,
                                    HCMC
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#addressBook"" data-bs-slide=""prev""
                style=""left: -110px;"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true"">");
            WriteLiteral(@"</span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#addressBook"" data-bs-slide=""next""
                style=""right: -110px;"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>
    </div>
</div>
<!--end address book-->
");
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
