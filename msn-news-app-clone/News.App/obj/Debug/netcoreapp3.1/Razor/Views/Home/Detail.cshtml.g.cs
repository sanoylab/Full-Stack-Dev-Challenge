#pragma checksum "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7958de864f8be58dd50f4ed706261bd9e2103aff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\_ViewImports.cshtml"
using News.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\_ViewImports.cshtml"
using News.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7958de864f8be58dd50f4ed706261bd9e2103aff", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f09b17159107837c344bde0aca195f1cdc1176", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News.Data.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml"
   
    ViewData["Title"] = @Html.DisplayFor(model => model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main>\r\n    <div class=\"position-relative overflow-hidden p-3 p-md-5  text-center bg-light\"");
            BeginWriteAttribute("style", "\r\n         style=\"", 198, "\"", 460, 13);
            WriteAttributeValue("", 216, "background-image:", 216, 17, true);
            WriteAttributeValue(" ", 233, "url(\'", 234, 6, true);
#nullable restore
#line 9 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 239, Html.DisplayFor(model => model.HeroImage), 239, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 281, "\');", 281, 3, true);
            WriteAttributeValue("\r\n        ", 284, "background-repeat:", 294, 28, true);
            WriteAttributeValue(" ", 312, "no-repeat;", 313, 11, true);
            WriteAttributeValue("\r\n        ", 323, "background-attachment:", 333, 32, true);
            WriteAttributeValue(" ", 355, "fixed;", 356, 7, true);
            WriteAttributeValue("\r\n        ", 362, "background-position:", 372, 30, true);
            WriteAttributeValue(" ", 392, "center;", 393, 8, true);
            WriteAttributeValue("\r\n        ", 400, "background-size:cover;", 410, 32, true);
            WriteAttributeValue("\r\n        ", 432, "min-height:", 442, 21, true);
            WriteAttributeValue(" ", 453, "500px;", 454, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"col-md-5 p-lg-5 mx-auto my-5\">\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n                <div class=\"row py-5\">\r\n                    <h1>");
#nullable restore
#line 30 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n\r\n                <article class=\"blog-post\">\r\n\r\n                    <p class=\"blog-post-meta\">");
#nullable restore
#line 35 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml"
                                         Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" by <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 944, "\"", 992, 1);
#nullable restore
#line 35 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 950, Html.DisplayFor(model => model.Publisher), 950, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a></p>\r\n\r\n                    <p style=\"white-space: pre-line\"> ");
#nullable restore
#line 37 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Home\Detail.cshtml"
                                                 Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </article><!-- /.blog-post -->\r\n\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n\r\n            </div>\r\n\r\n        </div><!-- /.row -->\r\n    </div>\r\n\r\n\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News.Data.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
