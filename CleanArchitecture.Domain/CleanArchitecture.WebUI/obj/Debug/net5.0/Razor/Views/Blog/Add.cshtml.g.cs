#pragma checksum "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\Blog\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcd2df32ea3b7cf8faf25f76a49bc58d0d60cfb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Add), @"mvc.1.0.view", @"/Views/Blog/Add.cshtml")]
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
#line 1 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\_ViewImports.cshtml"
using CleanArchitecture.Application.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcd2df32ea3b7cf8faf25f76a49bc58d0d60cfb1", @"/Views/Blog/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f56d92f818448cac03a957582bfef1ee09528fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\Blog\Add.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <div class=\"form-group\">\r\n                <label>Başlık</label>\r\n                ");
#nullable restore
#line 9 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\Blog\Add.cshtml"
           Write(Html.TextBoxFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <div class=\"form-group\">\r\n                <label>Yazı</label>\r\n                ");
#nullable restore
#line 15 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\Blog\Add.cshtml"
           Write(Html.TextBoxFor(x => x.Article));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <div class=\"form-group\">\r\n                <label>Kategoriler</label>\r\n                ");
#nullable restore
#line 21 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\Blog\Add.cshtml"
           Write(Html.DropDownListFor(x => x.SelectedCategories, new MultiSelectList(ViewBag.Categories, "Id", "Name"), new { multiple = "multiple" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <input type=""hidden"" value=""1"" name=""UserId"" />
    <div class=""row"">
        <div class=""col-12"">
            <input type=""submit"" class=""btn btn-success"" value=""Kaydet"" />
        </div>
    </div>
");
#nullable restore
#line 31 "C:\Users\VNY005\OneDrive\Masaüstü\CleanArchitecture.Domain\CleanArchitecture.WebUI\Views\Blog\Add.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
