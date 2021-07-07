#pragma checksum "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\Shared\_Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ff7a873650e5991217d335cb659547ee727cefe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Categories), @"mvc.1.0.view", @"/Views/Shared/_Categories.cshtml")]
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
#line 1 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\_ViewImports.cshtml"
using ETicaret.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\_ViewImports.cshtml"
using ETicaret.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\_ViewImports.cshtml"
using ETicaret.Application.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff7a873650e5991217d335cb659547ee727cefe", @"/Views/Shared/_Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb223b2e3b0b20e56621b113592db0fb868cd1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryViewDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<div class=\"col-lg-3\">\r\n    <h1 class=\"h2 pb-4\">Kategoriler</h1>\r\n    ");
#nullable restore
#line 31 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\Shared\_Categories.cshtml"
Write(RenderMenu(Model.Where(x => x.ParentCategory == null).ToList()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\Shared\_Categories.cshtml"
           

    Microsoft.AspNetCore.Html.IHtmlContent RenderMenu(List<CategoryViewDto> list)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<ul>");
        foreach (var menu in list)
        {
            sb.Append("<li>");
            sb.Append($"<a name='{menu.Id}' href='/product/index/{menu.Id}'>{menu.Name}</a>");
            if (menu.SubCategories.Any())
            {
                sb.Append(RenderMenu(menu.SubCategories.ToList()).ToString());
            }
            sb.Append("</li>");
        }
        sb.Append("</ul>");
        return Html.Raw(sb.ToString());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryViewDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
