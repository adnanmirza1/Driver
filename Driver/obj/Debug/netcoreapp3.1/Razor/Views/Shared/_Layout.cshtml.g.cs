#pragma checksum "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f858b4525b5e7f367d05f034d9a32f0e1550477", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn js-waves-off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DriverBasic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BrokerRequirement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TruckDriverRequirement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mod-bg-1 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b65962", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>ADSO</title>
    <meta name=""description"" content=""Page Titile"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no, user-scalable=no, minimal-ui"">
    <!-- Call App Mode on ios devices -->
    <meta name=""apple-mobile-web-app-capable"" content=""yes"" />
    <!-- Remove Tap Highlight on Windows Phone IE -->
    <meta name=""msapplication-tap-highlight"" content=""no"">
    <!-- base css -->
    <link rel=""stylesheet"" media=""screen, print"" href=""/css/fa-solid.css"">
    <link rel=""stylesheet"" media=""screen, print"" href=""/css/vendors.bundle.css"">
    <link rel=""stylesheet"" media=""screen, print"" href=""/css/app.bundle.css"">
    <!-- Place favicon.ico in the root directory -->
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""/img/favicon/apple-touch-icon.png"">
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/img/favicon/favicon-32x32.png"">
    <link rel=""m");
                WriteLiteral("ask-icon\" href=\"/img/favicon/safari-pinned-tab.svg\" color=\"#5bbad5\">\r\n    <link rel=\"stylesheet\" media=\"screen, print\" href=\"/css/styles.min.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b68202", async() => {
                WriteLiteral(@"
    <!-- DOC: script to save and load page settings -->
    <script src=""/js/load_script.js""></script>

    <!-- BEGIN Page Wrapper -->
    <div class=""page-wrapper"">
        <div class=""page-inner"">
            <!-- BEGIN Left Aside -->
            <aside class=""page-sidebar"">
                <div class=""page-logo"">
                    <a href=""#"" class=""page-logo-link press-scale-down d-flex align-items-center position-relative"">
                        <img src=""/img/logo.png"" alt=""SmartAdmin WebApp"" aria-roledescription=""logo"">
                        <span class=""page-logo-text mr-1"">ADSO</span>
                    </a>
                </div>
                <!-- BEGIN PRIMARY NAVIGATION -->
                <nav id=""js-primary-nav"" class=""primary-nav"" role=""navigation"">
                    <div class=""nav-filter"">
                        <div class=""position-relative"">
                            <input type=""text"" id=""nav_filter_input"" placeholder=""Filter menu"" class=""form-control"" t");
                WriteLiteral(@"abindex=""0"">
                            <a href=""#"" onclick=""return false;"" class=""btn-primary btn-search-close js-waves-off"" data-action=""toggle"" data-class=""list-filter-active"" data-target="".page-sidebar"">
                                <i class=""fal fa-chevron-up""></i>
                            </a>
                        </div>
                    </div>
                    <ul id=""js-nav-menu"" class=""nav-menu"">
                        <li>
                            <a href=""#"" title=""Quotations"" data-filter-tags=""quotations"">
                                <span class=""nav-link-text"">Quotation management</span>
                            </a>
                            <ul>
                                <li>
                                    <a href=""/views/quotations/quotations"" title=""Quotations"" data-filter-tags=""quotations"">
                                        <span class=""nav-link-text"">Quotations</span>
                                    </a>
                     ");
                WriteLiteral(@"           </li>
                                <li>
                                    <a href=""/views/quotations/consignment_type"" title=""Consigmnent type"" data-filter-tags=""consigmnent type"">
                                        <span class=""nav-link-text"">Quotation consigmnent type</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/quotations/customer_companies/"" title=""Customer companies"" data-filter-tags=""customer companies"">
                                        <span class=""nav-link-text"">Customer companies</span>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""/views/jobs/"" title=""Jobs"" data-filter-tags=""jobs"">
                                <span class=""nav-link-text"">Jobs management</span>
     ");
                WriteLiteral(@"                       </a>
                        </li>
                        <li>
                            <a href=""/views/transport"" title=""Transport"" data-filter-tags=""transport"">
                                <span class=""nav-link-text"">Transport management</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/views/freight_library/"" title=""Freight Library"" data-filter-tags=""freight library"">
                                <span class=""nav-link-text"">Freight project library</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" title=""Organization"" data-filter-tags=""organization"">
                                <span class=""nav-link-text"">Company setup</span>
                            </a>
                            <ul>
                                <li>
                                    <a href=""/views/c");
                WriteLiteral(@"ompany_setup/groups"" title=""Groups"" data-filter-tags=""groups"">
                                        <span class=""nav-link-text"">Groups</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/company_setup/companies"" title=""Companies"" data-filter-tags=""companies"">
                                        <span class=""nav-link-text"">Companies</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/company_setup/branches"" title=""Branches"" data-filter-tags=""branches"">
                                        <span class=""nav-link-text"">Branches</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/company_setup/working_regions"" title=""Working re");
                WriteLiteral(@"gions"" data-filter-tags=""working regions"">
                                        <span class=""nav-link-text"">Working regions</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/company_setup/ports"" title=""Ports"" data-filter-tags=""ports"">Ports</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#"" title=""HR management"" data-filter-tags=""hr management"">
                                <span class=""nav-link-text"">HR management</span>
                            </a>
                            <ul>
                                <li>
                                    <a href=""/views/hr_management/employees"" title=""Employees"" data-filter-tags=""employees"">
                                        <span class=""nav-link-text"">Employees</span>
              ");
                WriteLiteral(@"                      </a>
                                </li>
                                <li>
                                    <a href=""/views/hr_management/departments_designations"" title=""Departments / Designations"" data-filter-tags=""departments / designations"">
                                        <span class=""nav-link-text"">Departments / Designations</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/hr_management/users/"" title=""Users"" data-filter-tags=""users"">
                                        <span class=""nav-link-text"">Users</span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""/views/hr_management/roles/"" title=""Roles"" data-filter-tags=""roles"">
                                        <span class=""nav-link-text"">Roles</span>
         ");
                WriteLiteral(@"                           </a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#"" title=""General settings"" data-filter-tags=""general settings"">
                                <span class=""nav-link-text"">General setup</span>
                            </a>
                            <ul>
                                <li>
                                    <a href=""/views/general_settings/contracts_clauses"">Contracts and clauses</a>
                                </li>
                                <li>
                                    <a href=""/views/general_settings/weight_units"" title=""Weight units"" data-filter-tags=""weight units"">Weight units</a>
                                </li>
                                <li>
                                    <a href=""/views/general_settings/measurement_units"" title=""Measurement units"" data-filter-tags=""measuremen");
                WriteLiteral(@"t units"">Measurement units</a>
                                </li>
                                <li>
                                    <a href=""/views/general_settings/freight_attributes"" title=""Freight attributes"" data-filter-tags=""freight attributes"">Freight attributes</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#"" title=""Settings"" data-filter-tags=""settings"">
                                <span class=""nav-link-text"">Settings</span>
                            </a>
                        </li>
                    </ul>
                    <div class=""filter-message js-filter-message bg-success-600""></div>
                </nav>
                <!-- END PRIMARY NAVIGATION -->
            </aside>
            <!-- END Left Aside -->
            <div class=""page-content-wrapper"">
                <!-- BEGIN Page Header -->
                <header class=""pa");
                WriteLiteral(@"ge-header"" role=""banner"">
                    <!-- we need this logo when user switches to nav-function-top -->
                    <div class=""page-logo"">
                        <a href=""#"" class=""page-logo-link press-scale-down d-flex align-items-center position-relative"" data-toggle=""modal"" data-target=""#modal-shortcut"">
                            <img src=""/img/logo.png"" alt=""SmartAdmin WebApp"" aria-roledescription=""logo"">
                            <span class=""page-logo-text mr-1"">ADSO</span>
                            <span class=""position-absolute text-white opacity-50 small pos-top pos-right mr-2 mt-n2""></span>
                            <i class=""fal fa-angle-down d-inline-block ml-1 fs-lg color-primary-300""></i>
                        </a>
                    </div>
                    <!-- DOC: nav menu layout change shortcut -->
                    <div class=""hidden-md-down dropdown-icon-menu position-relative"">
                        <a href=""#"" class=""header-btn btn js-waves");
                WriteLiteral("-off\" data-action=\"toggle\" data-class=\"nav-function-hidden\" title=\"Hide Navigation\">\r\n                            <i class=\"ni ni-menu\"></i>\r\n                        </a>\r\n\r\n                    </div>\r\n\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b619578", async() => {
                    WriteLiteral("\r\n                        Home\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b621385", async() => {
                    WriteLiteral("\r\n                        Drivers\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b623191", async() => {
                    WriteLiteral("\r\n                        Broker\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc07cfd13356dc9ea1c3fa88988ea3de09bc3b624992", async() => {
                    WriteLiteral("\r\n                        TruckDriver\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                    <!-- DOC: mobile button appears during mobile width -->
                    <div class=""hidden-lg-up"">
                        <a href=""#"" class=""header-btn btn press-scale-down"" data-action=""toggle"" data-class=""mobile-nav-on"">
                            <i class=""ni ni-menu""></i>
                        </a>
                    </div>
                    <div class=""ml-auto d-flex"">
                        <!-- app settings -->
                        <div class=""hidden-md-down"">
                            <a href=""#"" class=""header-icon"" data-toggle=""modal"" data-target="".js-modal-settings"">
                                <i class=""fal fa-cog""></i>
                            </a>
                        </div>
                        <!-- app notification -->
                        <div>
                            <a href=""#"" class=""header-icon"" data-toggle=""dropdown"" title=""You got 11 notifications"">
                                <i class=""fal fa-bell""></i>
");
                WriteLiteral(@"                                <span class=""badge badge-icon"">11</span>
                            </a>
                        </div>
                        <!-- app user menu -->
                        <div>
                            <a href=""#"" data-toggle=""dropdown"" title=""drlantern@gotbootstrap.com"" class=""header-icon d-flex align-items-center justify-content-center ml-2"">
                                <img src=""/img/demo/avatars/avatar-admin.png"" class=""profile-image rounded-circle"" alt=""Dr. Codex Lantern"">
                                <!-- you can also add username next to the avatar with the codes below:
                <span class=""ml-1 mr-1 text-truncate text-truncate-header hidden-xs-down"">Me</span>
                <i class=""ni ni-chevron-down hidden-xs-down""></i> -->
                            </a>
                        </div>
                    </div>
                </header>
                <!-- END Page Header -->
                <!-- BEGIN Page Content -->
     ");
                WriteLiteral("           <!-- the #js-page-content id is needed for some plugins to initialize -->\r\n                <main id=\"js-page-content\" role=\"main\" class=\"page-content\">\r\n                    ");
#nullable restore
#line 246 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </main>
                <!-- this overlay is activated only when mobile menu is triggered -->
                <div class=""page-content-overlay"" data-action=""toggle"" data-class=""mobile-nav-on""></div> <!-- END Page Content -->
                <!-- BEGIN Page Footer -->
                <footer class=""page-footer"" role=""contentinfo"">
                    <div class=""d-flex align-items-center flex-1 text-muted"">
                        <span class=""hidden-md-down fw-700"">2019 © Alchemative</span>
                    </div>
                    <div>
                        <ul class=""list-table m-0"">
                            <li><a href=""intel_introduction.html"" class=""text-secondary fw-700"">About</a></li>
                            <li class=""pl-3""><a href=""info_app_licensing.html"" class=""text-secondary fw-700"">License</a></li>
                            <li class=""pl-3""><a href=""info_app_docs.html"" class=""text-secondary fw-700"">Documentation</a></li>
                        </ul");
                WriteLiteral(@">
                    </div>
                </footer>
                <!-- END Page Footer -->
                <!-- BEGIN Color profile -->
                <!-- this area is hidden and will not be seen on screens or screen readers -->
                <!-- we use this only for CSS color refernce for JS stuff -->
                <p id=""js-color-profile"" class=""d-none"">
                    <span class=""color-primary-50""></span>
                    <span class=""color-primary-100""></span>
                    <span class=""color-primary-200""></span>
                    <span class=""color-primary-300""></span>
                    <span class=""color-primary-400""></span>
                    <span class=""color-primary-500""></span>
                    <span class=""color-primary-600""></span>
                    <span class=""color-primary-700""></span>
                    <span class=""color-primary-800""></span>
                    <span class=""color-primary-900""></span>
                    <span class=""col");
                WriteLiteral(@"or-info-50""></span>
                    <span class=""color-info-100""></span>
                    <span class=""color-info-200""></span>
                    <span class=""color-info-300""></span>
                    <span class=""color-info-400""></span>
                    <span class=""color-info-500""></span>
                    <span class=""color-info-600""></span>
                    <span class=""color-info-700""></span>
                    <span class=""color-info-800""></span>
                    <span class=""color-info-900""></span>
                    <span class=""color-danger-50""></span>
                    <span class=""color-danger-100""></span>
                    <span class=""color-danger-200""></span>
                    <span class=""color-danger-300""></span>
                    <span class=""color-danger-400""></span>
                    <span class=""color-danger-500""></span>
                    <span class=""color-danger-600""></span>
                    <span class=""color-danger-700""></span>
  ");
                WriteLiteral(@"                  <span class=""color-danger-800""></span>
                    <span class=""color-danger-900""></span>
                    <span class=""color-warning-50""></span>
                    <span class=""color-warning-100""></span>
                    <span class=""color-warning-200""></span>
                    <span class=""color-warning-300""></span>
                    <span class=""color-warning-400""></span>
                    <span class=""color-warning-500""></span>
                    <span class=""color-warning-600""></span>
                    <span class=""color-warning-700""></span>
                    <span class=""color-warning-800""></span>
                    <span class=""color-warning-900""></span>
                    <span class=""color-success-50""></span>
                    <span class=""color-success-100""></span>
                    <span class=""color-success-200""></span>
                    <span class=""color-success-300""></span>
                    <span class=""color-success-400""></");
                WriteLiteral(@"span>
                    <span class=""color-success-500""></span>
                    <span class=""color-success-600""></span>
                    <span class=""color-success-700""></span>
                    <span class=""color-success-800""></span>
                    <span class=""color-success-900""></span>
                    <span class=""color-fusion-50""></span>
                    <span class=""color-fusion-100""></span>
                    <span class=""color-fusion-200""></span>
                    <span class=""color-fusion-300""></span>
                    <span class=""color-fusion-400""></span>
                    <span class=""color-fusion-500""></span>
                    <span class=""color-fusion-600""></span>
                    <span class=""color-fusion-700""></span>
                    <span class=""color-fusion-800""></span>
                    <span class=""color-fusion-900""></span>
                </p>
                <!-- END Color profile -->
            </div>
        </div>
    </div>");
                WriteLiteral(@"
    <!-- END Page Wrapper -->
    <!-- base vendor bundle:
         DOC: if you remove pace.js from core please note on Internet Explorer some CSS animations may execute before a page is fully loaded, resulting 'jump' animations
                    + pace.js (recommended)
                    + jquery.js (core)
                    + jquery-ui-cust.js (core)
                    + popper.js (core)
                    + bootstrap.js (core)
                    + slimscroll.js (extension)
                    + app.navigation.js (core)
                    + ba-throttle-debounce.js (core)
                    + waves.js (extension)
                    + smartpanels.js (extension)
                    + src/../jquery-snippets.js (core) -->
    <script src=""/js/vendors.bundle.js""></script>
    <script src=""/js/app.bundle.js""></script>
    <!--<script src=""js/../script.js""></script>
    <script>
        $(document).ready(function () {

        });
    </script>-->

    ");
#nullable restore
#line 356 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\Driver\Driver\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
