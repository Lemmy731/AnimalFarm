#pragma checksum "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Log.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a88d8df9acaeb450deefd992d271d61f9a33675f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Log), @"mvc.1.0.view", @"/Views/Dashboard/Log.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a88d8df9acaeb450deefd992d271d61f9a33675f", @"/Views/Dashboard/Log.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b5788d97abd233649efb838f59001af955b690", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Log : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-12 track-order\" id=\"divtwo\" style=\"padding-top: 70px\">\r\n\r\n    <div>\r\n        <h1 class=\"track-header\">Log Info <span>");
#nullable restore
#line 6 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Log.cshtml"
                                           Write(ViewData["file"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h1>
    </div>
    <div class="" col-sm-10 rounded mx-auto p-5 mb-5"" style=""background-color: #FFFFFF; box-shadow: rgba(32, 120, 191, 0.35) 0px 5px 15px;"">
        <div class=""row"" style=""height: 500px; overflow-y: scroll;"">
            <div class=""col"">

");
#nullable restore
#line 12 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Log.cshtml"
                 foreach (var d in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <code>");
#nullable restore
#line 14 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Log.cshtml"
                     Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code><br/>\r\n");
#nullable restore
#line 15 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Log.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
