#pragma checksum "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e18a545a87bf9b98e58453ce22d6c05b06a7a7"
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
#line 1 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\_ViewImports.cshtml"
using News.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\_ViewImports.cshtml"
using News.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e18a545a87bf9b98e58453ce22d6c05b06a7a7", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f09b17159107837c344bde0aca195f1cdc1176", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
  

    News.Data.Models.Post News = ViewData["News"] as News.Data.Models.Post;
    IEnumerable<News.Data.Models.Post> RelatedNews = ViewData["RelatedNews"] as IEnumerable<News.Data.Models.Post>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = News.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main>\r\n    <div class=\"position-relative overflow-hidden p-3 p-md-5  text-center bg-light\"");
            BeginWriteAttribute("style", "\r\n         style=\"", 342, "\"", 577, 13);
            WriteAttributeValue("", 360, "background-image:", 360, 17, true);
            WriteAttributeValue(" ", 377, "url(\'", 378, 6, true);
#nullable restore
#line 13 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 383, News.HeroImage, 383, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 398, "\');", 398, 3, true);
            WriteAttributeValue("\r\n        ", 401, "background-repeat:", 411, 28, true);
            WriteAttributeValue(" ", 429, "no-repeat;", 430, 11, true);
            WriteAttributeValue("\r\n        ", 440, "background-attachment:", 450, 32, true);
            WriteAttributeValue(" ", 472, "fixed;", 473, 7, true);
            WriteAttributeValue("\r\n        ", 479, "background-position:", 489, 30, true);
            WriteAttributeValue(" ", 509, "center;", 510, 8, true);
            WriteAttributeValue("\r\n        ", 517, "background-size:cover;", 527, 32, true);
            WriteAttributeValue("\r\n        ", 549, "min-height:", 559, 21, true);
            WriteAttributeValue(" ", 570, "500px;", 571, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"col-md-5 p-lg-5 mx-auto my-5\">\r\n            <h1 class=\"title\">");
#nullable restore
#line 20 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
                          Write(News.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

        </div>

    </div>




    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-8"">
               

                <article class=""blog-post py-5"">

                    <p class=""blog-post-meta"">
                        <i class=""fas fa-calendar-week""></i>&nbsp;");
#nullable restore
#line 38 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
                                                              Write(News.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1061, "\"", 1082, 1);
#nullable restore
#line 38 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1067, News.Publisher, 1067, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    </p>\r\n\r\n                    <p style=\"white-space: pre-line\"> ");
#nullable restore
#line 41 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
                                                 Write(News.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </article><!-- /.blog-post -->

            </div>

            <div class=""col-md-4 related"">
                <div class=""row "">
                    <h2>Related News</h2>
                </div>
                <ul class=""list-group"">
");
#nullable restore
#line 51 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
                     foreach (News.Data.Models.Post news in RelatedNews)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n\r\n                        <a class=\"navbar-brand\"");
            BeginWriteAttribute("href", " href=\"", 1646, "\"", 1661, 1);
#nullable restore
#line 55 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1653, news.Id, 1653, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
                                                           Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <span class=\"badge bg-primary rounded-pill\"><i class=\"fas fa-calendar-week\"></i>&nbsp;");
#nullable restore
#line 56 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"
                                                                                                         Write(news.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                    </li>\r\n");
#nullable restore
#line 59 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Detail.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n</div>\r\n\r\n        </div><!-- /.row -->\r\n    </div>\r\n\r\n\r\n\r\n</main>");
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
