#pragma checksum "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d562e6a676d6b4e90f2e81e2492adb59aa643c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Posts), @"mvc.1.0.view", @"/Views/Home/Posts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d562e6a676d6b4e90f2e81e2492adb59aa643c6", @"/Views/Home/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f09b17159107837c344bde0aca195f1cdc1176", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<News.Data.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
  
    ViewData["Title"] = ViewData["Category"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main>\r\n    <div class=\"position-relative overflow-hidden p-3 p-md-5  text-center bg-light\"");
            BeginWriteAttribute("style", "\r\n         style=\"", 196, "\"", 434, 13);
            WriteAttributeValue("", 214, "background-image:", 214, 17, true);
            WriteAttributeValue(" ", 231, "url(\'", 232, 6, true);
#nullable restore
#line 9 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 237, ViewData["Image"], 237, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 255, "\');", 255, 3, true);
            WriteAttributeValue("\r\n        ", 258, "background-repeat:", 268, 28, true);
            WriteAttributeValue(" ", 286, "no-repeat;", 287, 11, true);
            WriteAttributeValue("\r\n        ", 297, "background-attachment:", 307, 32, true);
            WriteAttributeValue(" ", 329, "fixed;", 330, 7, true);
            WriteAttributeValue("\r\n        ", 336, "background-position:", 346, 30, true);
            WriteAttributeValue(" ", 366, "center;", 367, 8, true);
            WriteAttributeValue("\r\n        ", 374, "background-size:cover;", 384, 32, true);
            WriteAttributeValue("\r\n        ", 406, "min-height:", 416, 21, true);
            WriteAttributeValue(" ", 427, "500px;", 428, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"col-md-5 p-lg-5 mx-auto my-5\">\r\n            <h1 class=\"title\" style=\"font-size: 70px;\">");
#nullable restore
#line 16 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                                                  Write(ViewData["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"container py-1\">\r\n        <div class=\"row py-5\">\r\n          \r\n            <p>Total ");
#nullable restore
#line 25 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                Write(ViewData["TotalPosts"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" news</p>\r\n        </div>\r\n        <div class=\"row\" data-masonry=\'{\"percentPosition\": true }\'>\r\n");
#nullable restore
#line 28 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
               int counter = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
             foreach (var item in Model)
            {
                /*
                if (counter != 0 && counter % 3 == 0)
                {
                    @:</div>
                    @:<div class="row" data-masonry='{"percentPosition": true }'>
                }
                */


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-4 col-lg-3 mb-4\">\r\n                    <div class=\"card\">\r\n                        <img class=\"card-img-top thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1318, "\"", 1365, 1);
#nullable restore
#line 41 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 1324, Html.DisplayFor(modelItem => item.Image), 1324, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1366, "\"", 1413, 1);
#nullable restore
#line 41 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 1372, Html.DisplayFor(modelItem => item.Title), 1372, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n\r\n                            <h5 class=\"card-title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1555, "\"", 1660, 4);
            WriteAttributeValue("", 1562, "/Home/Detail/", 1562, 13, true);
#nullable restore
#line 45 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 1575, Html.DisplayFor(modelItem => item.Id), 1575, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1613, "?name=", 1613, 6, true);
#nullable restore
#line 45 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 1619, Html.DisplayFor(modelItem => item.Title), 1619, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text text-center\">\r\n                                    ");
#nullable restore
#line 46 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h5>\r\n                            <p>");
#nullable restore
#line 49 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                          Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"d-inline-block text-truncate\" style=\"max-width: 250px;\"> ");
#nullable restore
#line 50 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2110, "\"", 2161, 1);
#nullable restore
#line 51 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 2116, Html.DisplayFor(modelItem => item.Publisher), 2116, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                //counter++;

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<News.Data.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
