#pragma checksum "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4a3a2ff9d0a356630851197a981d60e72e8e4e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4a3a2ff9d0a356630851197a981d60e72e8e4e", @"/Views/Home/Posts.cshtml")]
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"container py-1\">\r\n    <div class=\"row py-5\"><h1>");
#nullable restore
#line 9 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                         Write(ViewData["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div>\r\n    <div class=\"row\" data-masonry=\'{\"percentPosition\": true }\'>\r\n");
#nullable restore
#line 11 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
           int counter = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
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
            WriteLiteral("            <div class=\"col-sm-4 col-lg-3 mb-4\">\r\n                <div class=\"card\">\r\n                    <img class=\"card-img-top thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 707, "\"", 754, 1);
#nullable restore
#line 24 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 713, Html.DisplayFor(modelItem => item.Image), 713, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 755, "\"", 802, 1);
#nullable restore
#line 24 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 761, Html.DisplayFor(modelItem => item.Title), 761, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n\r\n                        <h5 class=\"card-title\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 1037, 4);
            WriteAttributeValue("", 939, "/Home/Detail/", 939, 13, true);
#nullable restore
#line 28 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 952, Html.DisplayFor(modelItem => item.Id), 952, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 990, "?name=", 990, 6, true);
#nullable restore
#line 28 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 996, Html.DisplayFor(modelItem => item.Title), 996, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text text-center\">\r\n                                ");
#nullable restore
#line 29 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </h5>\r\n                        <p>");
#nullable restore
#line 32 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                      Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"d-inline-block text-truncate\" style=\"max-width: 250px;\"> ");
#nullable restore
#line 33 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1463, "\"", 1514, 1);
#nullable restore
#line 34 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
WriteAttributeValue("", 1469, Html.DisplayFor(modelItem => item.Publisher), 1469, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core_newsapp\News.App\Views\Home\Posts.cshtml"
            //counter++;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
