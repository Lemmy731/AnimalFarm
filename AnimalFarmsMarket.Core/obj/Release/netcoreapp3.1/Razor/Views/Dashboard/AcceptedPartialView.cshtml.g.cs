#pragma checksum "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d21a9b61a3c2ff1cb5ec5330cbe5e86de9517fa5d8c44e1168989a339b254041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_AcceptedPartialView), @"mvc.1.0.view", @"/Views/Dashboard/AcceptedPartialView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d21a9b61a3c2ff1cb5ec5330cbe5e86de9517fa5d8c44e1168989a339b254041", @"/Views/Dashboard/AcceptedPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1abf33fb34761471a30fc6064deab2dc7a3bd0194151b0dbda1995dae112fc29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_AcceptedPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResponseDto<PaginatedResultDto<AssignmentDeliveryViewModel>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
  int count =0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
 if (Model!=null)
{
    if (Model.Data.PageMetaData.Page == 1)
    {
        count = 0;
    }
    else
    {
        count =( Model.Data.PageMetaData.Page -1)* Model.Data.PageMetaData.PerPage;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"d-flex justify-content-between col-12\">\r\n\r\n    <div class=\"container shadow rounded col-12 p-4\" style=\"width;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d21a9b61a3c2ff1cb5ec5330cbe5e86de9517fa5d8c44e1168989a339b2540416401", async() => {
                WriteLiteral("\r\n            <table class=\"table table-borderless\">\r\n                <thead>\r\n                    <tr");
                BeginWriteAttribute("class", " class=\"", 589, "\"", 597, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <th>S/N</th>\r\n                        <th>Order</th>\r\n                        <th>Status</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n");
#nullable restore
#line 30 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                 if (Model.Data.ResponseData.Count() > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tbody>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                         foreach (var item in Model.Data.ResponseData)
                        {
                            count++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr");
                BeginWriteAttribute("class", " class=\"", 1052, "\"", 1060, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                               Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><a");
                BeginWriteAttribute("href", " href=\"", 1151, "\"", 1158, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                                          Write(item.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                <td><a class=\"btn btn-success btn-sm mr-1 text-light\">Accepted<span class=\"badge badge-light ml-1\">✔</span></a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n");
#nullable restore
#line 49 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                  else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tbody>\r\n                        </tbody>\r\n");
#nullable restore
#line 54 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </table>\r\n");
#nullable restore
#line 58 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
             if (Model.Data.ResponseData.Count() == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div style=\"display:flex; justify-content:center;height:50px\">\r\n                    <p style=\"margin:7px auto;font-weight:bold\">NO RECORD FOUND</p>\r\n                </div>\r\n");
#nullable restore
#line 63 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 68 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
 if (Model!=null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 text-center justify-content-center\">\r\n        <ul class=\"pagination mt-3\">\r\n\r\n");
#nullable restore
#line 74 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
             for (int i = 1; i <= Model.Data.PageMetaData.TotalPages; i++)
            {

                var disabled = Model.Data.PageMetaData.Page == i ? "disabled" : "";



#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <button");
            BeginWriteAttribute("class", " class=\"", 2323, "\"", 2361, 4);
            WriteAttributeValue("", 2331, "page-link", 2331, 9, true);
            WriteAttributeValue(" ", 2340, "btn", 2341, 4, true);
            WriteAttributeValue(" ", 2344, "btn-sm", 2345, 7, true);
#nullable restore
#line 81 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
WriteAttributeValue(" ", 2351, disabled, 2352, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2362, "\"", 2369, 1);
#nullable restore
#line 81 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
WriteAttributeValue("", 2367, i, 2367, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"acceptedBtn(this)\">");
#nullable restore
#line 81 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </li>\r\n");
#nullable restore
#line 83 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 86 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\AcceptedPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
