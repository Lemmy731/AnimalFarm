#pragma checksum "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "caa610356cb82ba452cf79f27cbd1f6476ecaa4d3fec1b95d2240c42ddcd893e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_PaymentHistory), @"mvc.1.0.view", @"/Views/Dashboard/PaymentHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"caa610356cb82ba452cf79f27cbd1f6476ecaa4d3fec1b95d2240c42ddcd893e", @"/Views/Dashboard/PaymentHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1abf33fb34761471a30fc6064deab2dc7a3bd0194151b0dbda1995dae112fc29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_PaymentHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedResultDto<OrderDetailsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
  
    if(ViewBag.isDashboard == null){
        ViewBag.isDashboard = false;
    }
    bool isDashboard = ViewBag.isDashboard;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container p-5 ml-10 bg-light\">\r\n    <div class=\"mb-5\">\r\n        <h2 class=\"pl-0 brand\" style=\"color:#2078BF; \">Payment History</h2>\r\n    </div>\r\n    <div class=\"mt-4 justify-content-center\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
         if (Model.ResponseData.Count() > 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"p-4 text-center bg-white rounded shadow col-sm-12 table-responsive-sm\" id=\"tbody\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                 if (User.IsInRole("Admin"))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-borderless"">

                        <thead>
                            <tr class=""justify-content-between"">
                                <th>Customer Id</th>
                                <th>Order Details</th>
                                <th>Amount</th>
                                <th>Date</th>
                                <th>Status</th>

                            </tr>
                        </thead>


                        <tbody id=""paymentInfo"">

");
#nullable restore
#line 40 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                             foreach (var item in Model.ResponseData)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr class=""justify-content-between"">

                                    <td>
                                        <a href=""#exampleModal"" id=""product-detail-link"" data-toggle=""modal"" data-target=""#exampleModal"" class=""text-decoration-none displayModal"">
                                            <p class=""mb-0""");
            BeginWriteAttribute("id", " id=\"", 1632, "\"", 1649, 1);
#nullable restore
#line 47 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
WriteAttributeValue("", 1637, item.UserId, 1637, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"displayData(this)\">");
#nullable restore
#line 47 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                     Write(item.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                                          Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                        </a>
                                    </td>
                                    <td id=""product-detail"">
                                        
                                            <div id=""product-detail-text"" class=""text-left"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caa610356cb82ba452cf79f27cbd1f6476ecaa4d3fec1b95d2240c42ddcd893e9693", async() => {
#nullable restore
#line 53 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                     \r\n                                    </td>\r\n                                    <td>NGN ");
#nullable restore
#line 58 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                       Write(item.PaymentAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                   Write(DateTime.Parse(item.DateCreated).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 60 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                     if (item.PaymentStatus == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><i class=\"badge badge-pill badge-success w-100\">Paid</i></td>\r\n");
#nullable restore
#line 63 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                    }
                                    else if (item.PaymentStatus == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><i class=\"badge badge-pill badge-warning w-100\">Pending</i></td>\r\n");
#nullable restore
#line 67 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                                </tr>\r\n");
#nullable restore
#line 70 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 73 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-borderless"">

                        <thead>
                            <tr class=""justify-content-between"">
                                <th class=""text-align-left"">Order Details</th>
                                <th>Amount</th>
                                <th>Date</th>
                                <th>Status</th>

                            </tr>
                        </thead>


                        <tbody id=""paymentInfo "">

");
#nullable restore
#line 92 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                             foreach (var item in Model.ResponseData)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr class=""justify-content-between"">
                                    <td id=""product-detail"">
                                        
                                            <div id=""product-detail-text"" class=""text-left"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caa610356cb82ba452cf79f27cbd1f6476ecaa4d3fec1b95d2240c42ddcd893e16327", async() => {
#nullable restore
#line 98 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        \r\n                                    </td>\r\n                                    <td>NGN ");
#nullable restore
#line 102 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                       Write(item.PaymentAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 103 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                   Write(DateTime.Parse(item.DateCreated).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 104 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                     if (item.PaymentStatus == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><i class=\"badge badge-pill badge-success w-75\">Paid</i></td>\r\n");
#nullable restore
#line 107 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                    }
                                    else if (item.PaymentStatus == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><i class=\"badge badge-pill badge-warning w-75\">Pending</i></td>\r\n");
#nullable restore
#line 111 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  \r\n\r\n                                </tr>\r\n");
#nullable restore
#line 115 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 118 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"flex-wrap d-flex flex-sm-wrap col-lg-12 col-sm-12 justify-content-center\" style=\"margin-top:2.5em; margin-bottom:2em\">\r\n\r\n                <nav aria-label=\"Page navigation\">\r\n                    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 128 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                         for (int i = 1; i <= Model.PageMetaData.TotalPages; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <button class=\"page-link\" href=\"#\" aria-label=\"current\"");
            BeginWriteAttribute("id", " id=\"", 5780, "\"", 5787, 1);
#nullable restore
#line 131 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
WriteAttributeValue("", 5785, i, 5785, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"curBtnPayment(this)\">");
#nullable restore
#line 131 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            </li>\r\n");
#nullable restore
#line 133 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n");
#nullable restore
#line 139 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"

        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""d-flex justify-content-center align-content-center"">
        <div class=""bg-white col-sm-12 text-center p-4 table-responsive-sm"" id=""table-container"">
            <table class=""table table-borderless"">
                <tbody class=""text-center"">
                    <tr class=""mb-5 text-center p-4"">
                        <td colspan=""5"">
                            <h2 class=""brand p-4"" style=""color:#2078BF; "">No Payment Record</h2>
                        </td>
                    </tr>
                </tbody>
            </table>
            </div>
        </div>
");
#nullable restore
#line 157 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Dashboard\PaymentHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
        

    </div>






<div class=""modal fade "" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel""> User Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""parent"">
                    <div class=""box-one font-weight-normal"" style=""font-size:22px;"">
                        <h5>
                            <span");
            BeginWriteAttribute("class", " class=\"", 7465, "\"", 7473, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"role\" style=\"font-size:30px;\">>Agent</span><br />\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 7563, "\"", 7571, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"fullName\">\r\n                                Name:  FirstName LastName\r\n                            </span>\r\n                            <br />\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 7754, "\"", 7762, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"email\" style=\"font-size:20px;\">Email: myUser@gmail.com</span>\r\n                        </h5>\r\n                        <h5>\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 7925, "\"", 7933, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""businessLocation"">Business Location</span>
                            <br />
                        </h5>
                        
                    </div>
                    <div class=""box-two"">
                        <div class=""my-image"">
                            <img id=""user-image"" class=""myimg""");
            BeginWriteAttribute("src", " src=\"", 8257, "\"", 8263, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedResultDto<OrderDetailsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
