#pragma checksum "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7151e642c594f7655949087e77918c5f336a4695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DriverBasic_Details), @"mvc.1.0.view", @"/Views/DriverBasic/Details.cshtml")]
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
#line 1 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\_ViewImports.cshtml"
using Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\_ViewImports.cshtml"
using Driver.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7151e642c594f7655949087e77918c5f336a4695", @"/Views/DriverBasic/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f858b4525b5e7f367d05f034d9a32f0e1550477", @"/Views/_ViewImports.cshtml")]
    public class Views_DriverBasic_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Driver.Models.ViewModels.DriverBasicDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary waves-effect waves-themed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<main id=""js-page-content"" role=""main"" class=""page-content"">
    <ol class=""breadcrumb page-breadcrumb"">
        <li class=""breadcrumb-item"">Transport</li>
        <li class=""breadcrumb-item"">Drivers</li>
        <li class=""breadcrumb-item active"">Details</li>
    </ol>
    <div class=""subheader"">
        <h1 class=""subheader-title"">Driver details</h1>
        <div class=""subheader-block"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7151e642c594f7655949087e77918c5f336a46954574", async() => {
                WriteLiteral("Close");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""accordion accordion-outline"" id=""accordion-driver-form"">
                <div class=""card"">
                    <div class=""card-header"">
                        <a href=""javascript:void(0);"" class=""card-title"" data-toggle=""collapse"" data-target=""#accordion-basic-details"" aria-expanded=""true"">
                            Basic details
                            <span class=""ml-auto"">
                                <span class=""collapsed-reveal"">
                                    <i class=""fal fa-chevron-up fs-xl""></i>
                                </span>
                                <span class=""collapsed-hidden"">
                                    <i class=""fal fa-chevron-down fs-xl""></i>
                                </span>
                            </span>
                        </a>
                    </div>
                    <div id=""accordion-basic-details"" cla");
            WriteLiteral(@"ss=""collapse show"" data-parent=""#accordion-driver-form"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-2"">
                                    <img src=""https://digitalrightsmonitor.pk/wp-content/uploads/2019/02/xuG6FTGt_400x400-300x300.jpg"" class=""rounded w-100 mb-3"" />
                                </div>
                                <div class=""col-sm"">
                                    <div class=""row form-group"">
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 104 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 107 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                            
                                        </div>
                                        <div class=""col-sm"">
                                            
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 116 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 119 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 126 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 129 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 137 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.EmiratesId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 140 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.EmiratesId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 147 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.WhatsappNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 150 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.WhatsappNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                            
                                        </div>
                                    </div>
                                    <div class=""row form-group"">
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 160 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.MobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 163 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.MobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 170 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.InternationalNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 173 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.InternationalNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 180 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 183 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 190 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 193 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                        <div class=""col-sm"">
                                            <dl class=""row"">
                                                <dt class=""col-sm-2"">
                                                    ");
#nullable restore
#line 200 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </dt>\r\n                                                <dd class=\"col-sm-10\">\r\n                                                    ");
#nullable restore
#line 203 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.DriverBasic.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </dd>
                                            </dl>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-sm"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 214 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.DateOfJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 217 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.DateOfJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 224 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.PassportNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 227 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.PassportNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 234 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.PassportExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 237 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.PassportExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 244 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.VisaExpiry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 247 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.VisaExpiry));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a href=""javascript:void(0);"" class=""card-title collapsed"" data-toggle=""collapse"" data-target=""#accordion-residence"" aria-expanded=""false"">
                            Residence
                            <span class=""ml-auto"">
                                <span class=""collapsed-reveal"">
                                    <i class=""fal fa-chevron-up fs-xl""></i>
                                </span>
                                <span class=""collapsed-hidden"">
                                    <i class=""fal fa-chevron-down fs-xl""></i>
                                </span>
                            </span>
                        </a>");
            WriteLiteral(@"
                    </div>
                    <div id=""accordion-residence"" class=""collapse"" data-parent=""#accordion-driver-form"">
                        <div class=""card-body"">
                            <div class=""row form-group"">
                                <div class=""col-sm-2"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 275 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.ResidenceCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 278 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.ResidenceCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm-2"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 285 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.CityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 288 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.CityName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 295 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 298 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 305 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 308 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a href=""javascript:void(0);"" class=""card-title collapsed"" data-toggle=""collapse"" data-target=""#accordion-company-profile"" aria-expanded=""false"">
                            Company profile
                            <span class=""ml-auto"">
                                <span class=""collapsed-reveal"">
                                    <i class=""fal fa-chevron-up fs-xl""></i>
                                </span>
                                <span class=""collapsed-hidden"">
                                    <i class=""fal fa-chevron-down fs-xl""></i>
                                </span>
                            </span>
                ");
            WriteLiteral(@"        </a>
                    </div>
                    <div id=""accordion-company-profile"" class=""collapse"" data-parent=""#accordion-driver-form"">
                        <div class=""card-body"">
                            <div class=""row form-group"">
                                <div class=""col-sm-3"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 336 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.DriverType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 339 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.DriverType));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                                <div class=""col-sm-3"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 346 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 349 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\DriverBasic\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DriverBasic.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Driver.Models.ViewModels.DriverBasicDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
