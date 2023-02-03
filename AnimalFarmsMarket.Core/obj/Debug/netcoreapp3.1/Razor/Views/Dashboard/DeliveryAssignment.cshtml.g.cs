#pragma checksum "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a63d0b9ea5357c1c43c32c4b138f86443df7cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_DeliveryAssignment), @"mvc.1.0.view", @"/Views/Dashboard/DeliveryAssignment.cshtml")]
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
#line 1 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a63d0b9ea5357c1c43c32c4b138f86443df7cc", @"/Views/Dashboard/DeliveryAssignment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b5788d97abd233649efb838f59001af955b690", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_DeliveryAssignment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResponseDto<PaginatedResultDto<AssignmentDeliveryViewModel>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
  int count = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container p-5 ml-10 bg-light"">
    <div class=""mb-5"">
        <h2 class=""brand pl-0"" style=""color:#2078BF; "">Delivery Assignment</h2>
    </div>
    <div class=""mb-3"">
        <a class=""btn btn-warning   active"" role=""button"" onclick=""okayBtn(this)"" aria-pressed=""true"">Pending</a>
        <a id=""Accepted"" onclick=""acceptedBtn(this)"" class=""btn btn-primary active"" role=""button"" aria-pressed=""true"">Accepted</a>
    </div>

    <div id=""myInfo"">

        <div class=""d-flex justify-content-between col-12"">

            <div class=""container shadow rounded col-12 p-4"" style=""width"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28a63d0b9ea5357c1c43c32c4b138f86443df7cc6799", async() => {
                WriteLiteral("\r\n\r\n                    <table class=\"table table-borderless\">\r\n                        <thead>\r\n                            <tr");
                BeginWriteAttribute("class", " class=\"", 912, "\"", 920, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <th>S/N</th>\r\n                                <th>Order</th>\r\n");
#nullable restore
#line 28 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                 if ((await _authorization.AuthorizeAsync(User, "DeliveryRolePolicy")).Succeeded)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <th>Action</th>\r\n");
#nullable restore
#line 31 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <th>Status</th>\r\n");
#nullable restore
#line 35 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </tr>\r\n                        </thead>\r\n");
#nullable restore
#line 40 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                         if (Model != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 43 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                 foreach (var item in Model.Data.ResponseData)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr");
                BeginWriteAttribute("class", " class=\"", 1795, "\"", 1803, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <td>");
#nullable restore
#line 47 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1902, "\"", 1909, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n");
#nullable restore
#line 49 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                     if ((await _authorization.AuthorizeAsync(User, "DeliveryRolePolicy")).Succeeded)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>\r\n                                            <a id=\"acceptid\" data-delivery=\"");
#nullable restore
#line 52 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" onclick=\"acceptBtn(event)\" role=\"button\" class=\"btn btn-outline-success mr-1 \">\r\n                                                Accept\r\n\r\n                                            </a>\r\n                                        </td>\r\n");
#nullable restore
#line 57 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <td>
                                            <a id=""acceptid"" role=""button"" class=""btn btn-outline-success mr-1 "">
                                                pending

                                            </a>
                                        </td>
");
#nullable restore
#line 67 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </tr>\r\n");
#nullable restore
#line 70 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n");
#nullable restore
#line 73 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </table>\r\n");
#nullable restore
#line 77 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                     if (Model.Data.ResponseData.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div style=\"display:flex; justify-content:center;height:50px\">\r\n                            <p style=\"margin:7px auto;font-weight:bold\">NO RECORD FOUND</p>\r\n                        </div>\r\n");
#nullable restore
#line 82 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 86 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
         if (Model!=null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12\">\r\n                <ul class=\"pagination mt-3\">\r\n");
#nullable restore
#line 90 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                     for (int i = 1; i <= Model.Data.PageMetaData.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <button class=\"page-link btn btn-sm\"");
            BeginWriteAttribute("id", " id=\"", 3837, "\"", 3844, 1);
#nullable restore
#line 93 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
WriteAttributeValue("", 3842, i, 3842, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"okayBtn(this)\">");
#nullable restore
#line 93 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </li>\r\n");
#nullable restore
#line 95 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 98 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\DeliveryAssignment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService _authorization { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResponseDto<PaginatedResultDto<AssignmentDeliveryViewModel>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
