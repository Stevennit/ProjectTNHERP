#pragma checksum "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\CustomLayout\_SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4903031072e5dec2012f243c8b22784621b22388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomLayout__SideMenu), @"mvc.1.0.view", @"/Views/Shared/CustomLayout/_SideMenu.cshtml")]
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
#line 1 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\_ViewImports.cshtml"
using Hiver.AdminUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\_ViewImports.cshtml"
using Hiver.AdminUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4903031072e5dec2012f243c8b22784621b22388", @"/Views/Shared/CustomLayout/_SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca4fa29163665a8ecb0495907d593510b7bc3207", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomLayout__SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"sidebar\" class=\"sidebar\">\r\n    <!-- begin sidebar scrollbar -->\r\n    <div data-scrollbar=\"true\" data-height=\"100%\">\r\n        <!-- begin sidebar nav -->\r\n        <ul class=\"nav\">\r\n            <li class=\"nav-header\">Navigation</li>\r\n            ");
#nullable restore
#line 7 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\CustomLayout\_SideMenu.cshtml"
        Write(await Component.InvokeAsync("Menu", new { parentId = -1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <li><a href=""javascript:;"" class=""sidebar-minify-btn"" data-click=""sidebar-minify""><i class=""fa fa-angle-double-left""></i></a></li>
            <!-- end sidebar minify button -->
        </ul>
        <!-- end sidebar nav -->
    </div>
    <!-- end sidebar scrollbar -->
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
