#pragma checksum "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c61d8bcd4ea09f2d296fecce7c5631966750b0611563b98706231901831c15f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard__AgentOrderPartialView), @"mvc.1.0.view", @"/Views/Dashboard/_AgentOrderPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c61d8bcd4ea09f2d296fecce7c5631966750b0611563b98706231901831c15f2", @"/Views/Dashboard/_AgentOrderPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1abf33fb34761471a30fc6064deab2dc7a3bd0194151b0dbda1995dae112fc29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard__AgentOrderPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedResultDto<ShapedListOfOrderItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
  
    if (ViewBag.isDashboard == null)
    {
        ViewBag.isDashboard = false;
    }
    bool isDashboard = ViewBag.isDashboard;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"mb-5\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 224, "\"", 232, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""mt-5"">
            <h2 class=""brand pl-0"" style=""color:#2078BF;"">Orders</h2>
        </div>

        <div class=""d-flex justify-content-center mt-4"">
            <div class=""bg-white col-sm-12 text-center p-4 table-responsive-sm"" id=""table-container"">
                <table class=""table table-borderless"">
");
#nullable restore
#line 20 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                     if (Model.ResponseData.Count() < 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"brand pl-0\" style=\"color:#2078BF; \">No Order Record</h2>\r\n");
#nullable restore
#line 23 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                    }
                    else
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <thead>
                            <tr>
                                <th id=""product-detail"">Product Details</th>
                                <th>DeliveryStatus</th>
                                <th>Amount</th>
                                <th>payment Status</th>
                            </tr>
                        </thead>
");
            WriteLiteral("                        <tbody id=\"table-body\">\r\n");
#nullable restore
#line 38 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                             if (Model != null)
                            {
                                var count = 0;
                                foreach (var item in Model.ResponseData)
                                {
                                    if (isDashboard && count >= 5)
                                    {
                                        break;
                                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td id=\"product-detail\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c61d8bcd4ea09f2d296fecce7c5631966750b0611563b98706231901831c15f28310", async() => {
                WriteLiteral("\r\n                                                <div id=\"product-detail-text\" class=\"text-left\">\r\n                                                    <h6 class=\"mb-0\"><small>");
#nullable restore
#line 52 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></h6>\r\n                                                    <h6 class=\"mt-0\"><small>");
#nullable restore
#line 53 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                       Write(item.DateCreated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></h6>\r\n                                                </div>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                         if (item.Status == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-warning\">Pending</i></td>\r\n");
#nullable restore
#line 63 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-success\">Delivered</i></td>\r\n");
#nullable restore
#line 67 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <td>");
#nullable restore
#line 69 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                   Write(string.Format(new CultureInfo("ng-NG"), "{0:c}", item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                         if (item.AgentPaid == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-warning\">Pending</i></td>\r\n");
#nullable restore
#line 77 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-success\">Payment Received</i></td>\r\n");
#nullable restore
#line 81 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tr>\r\n");
#nullable restore
#line 84 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"

                                    count++;
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n");
#nullable restore
#line 90 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 97 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
         if (Model != null && !isDashboard)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12\">\r\n                <ul class=\"pagination mt-3\">\r\n");
#nullable restore
#line 102 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                     for (int i = 1; i <= Model.PageMetaData.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <button class=\"page-link btn btn-sm\"");
            BeginWriteAttribute("id", " id=\"", 4533, "\"", 4540, 1);
#nullable restore
#line 105 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
WriteAttributeValue("", 4538, i, 4538, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"OrderBtn(this)\">");
#nullable restore
#line 105 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </li>\r\n");
#nullable restore
#line 107 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 111 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedResultDto<ShapedListOfOrderItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591