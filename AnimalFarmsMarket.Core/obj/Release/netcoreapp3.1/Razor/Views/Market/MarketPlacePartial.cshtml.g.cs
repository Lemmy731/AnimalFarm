#pragma checksum "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9193e02bb1bd7f524c88e6a34f0a346c05ee9f69f61f1552ed53a524fdbdcfec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Market_MarketPlacePartial), @"mvc.1.0.view", @"/Views/Market/MarketPlacePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9193e02bb1bd7f524c88e6a34f0a346c05ee9f69f61f1552ed53a524fdbdcfec", @"/Views/Market/MarketPlacePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1abf33fb34761471a30fc6064deab2dc7a3bd0194151b0dbda1995dae112fc29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Market_MarketPlacePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedResultDto<ShapedListOfLivestockVm>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Market", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"col-12 \">\r\n    <div class=\"d-flex flex-wrap flex-sm-wrap col-lg-12 col-sm-12\">\r\n");
#nullable restore
#line 7 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
         foreach (var item in @Model.ResponseData)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-sm-6 p-lg-2 p-sm-2 p-4\">\r\n                <div class=\"card hover hover-2 text-white rounded\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9193e02bb1bd7f524c88e6a34f0a346c05ee9f69f61f1552ed53a524fdbdcfec5954", async() => {
                WriteLiteral("\r\n                        <img style=\"border-radius: 5px; width: 98%; min-height: 180px; max-height: 180px; margin: 5px auto; margin-left: 2px;\"");
                BeginWriteAttribute("src", " src=\"", 574, "\"", 591, 1);
#nullable restore
#line 12 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
WriteAttributeValue("", 580, item.Photo, 580, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 592, "\"", 606, 1);
#nullable restore
#line 12 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
WriteAttributeValue("", 598, item.Id, 598, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"300\" width=\"300\">\r\n                    ");
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
#line 11 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"hover-overlay\"></div>\r\n                    <div class=\"hover-2-content px-5 py-4\">\r\n                        <h3 class=\"hover-2-title text-capitalize font-weight-light mb-0\">Animal-Id: ");
#nullable restore
#line 16 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
                                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h3 class=\"hover-2-price text-white font-weight-light mb-0\"> ");
#nullable restore
#line 17 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
                                                                                Write(String.Format(new System.Globalization.CultureInfo("en-NG"), "{0:C}", @item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <a class=\"addBtn hover-2-description text-uppercase mb-4\" data-price=\"");
#nullable restore
#line 19 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quantity=\"1\" data-item-id=\"");
#nullable restore
#line 19 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
                                                                                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"addToCart(event)\">Add to Cart</a>\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 1306, "\"", 1337, 1);
#nullable restore
#line 20 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
WriteAttributeValue("", 1313, Model.PageMetaData.Page, 1313, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"prev\"");
            BeginWriteAttribute("value", " value=\"", 1348, "\"", 1380, 1);
#nullable restore
#line 20 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
WriteAttributeValue("", 1356, Model.PageMetaData.Page, 1356, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 1430, "\"", 1461, 1);
#nullable restore
#line 21 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
WriteAttributeValue("", 1437, Model.PageMetaData.Page, 1437, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"nxt\"");
            BeginWriteAttribute("value", " value=\"", 1471, "\"", 1503, 1);
#nullable restore
#line 21 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
WriteAttributeValue("", 1479, Model.PageMetaData.Page, 1479, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\hp\Desktop\AnimalFarmMarket\AnimalFarmsMarket.Core\Views\Market\MarketPlacePartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedResultDto<ShapedListOfLivestockVm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591