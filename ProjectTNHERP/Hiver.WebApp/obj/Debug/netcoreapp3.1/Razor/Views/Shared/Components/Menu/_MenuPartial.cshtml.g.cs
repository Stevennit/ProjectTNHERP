#pragma checksum "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f3bab25f0a7c5d1d00df55ad18ef11204294cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu__MenuPartial), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/_MenuPartial.cshtml")]
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
#line 1 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3bab25f0a7c5d1d00df55ad18ef11204294cce", @"/Views/Shared/Components/Menu/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ab81aed2705cb0866e47e37bd3e126a1d736ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hiver.ViewModels.Common.MenuViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Components/Menu/_MenuPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
 foreach (var menu in Model)
{
    if (menu.Children.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a href=\"#\" class=\"nav-link\">\r\n            <i class=\"nav-icon fas fa-copy\"></i>\r\n            <p>\r\n                ");
#nullable restore
#line 11 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
           Write(menu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"fas fa-angle-left right\"></i>\r\n                <span class=\"badge badge-info right\">6</span>\r\n            </p>\r\n        </a>\r\n        <ul class=\"nav nav-treeview\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f3bab25f0a7c5d1d00df55ad18ef11204294cce4503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = menu.Children;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </ul>\r\n    </li>\r\n");
#nullable restore
#line 20 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n");
#nullable restore
#line 24 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
              
                if (string.IsNullOrEmpty(menu.Url))   //Add either onclick event or href.
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"nav-link\">\r\n                        <i class=\"nav-icon far fa-image\"></i>\r\n                        <p>\r\n                            ");
#nullable restore
#line 30 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
                       Write(menu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </a>\r\n");
#nullable restore
#line 33 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1093, "\"", 1109, 1);
#nullable restore
#line 36 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
WriteAttributeValue("", 1100, menu.Url, 1100, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                        <i class=\"nav-icon far fa-image\"></i>\r\n                        <p>\r\n                            ");
#nullable restore
#line 39 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
                       Write(menu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </a>\r\n");
#nullable restore
#line 42 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n");
#nullable restore
#line 45 "E:\Project\TNH\Web\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\Components\Menu\_MenuPartial.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hiver.ViewModels.Common.MenuViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
