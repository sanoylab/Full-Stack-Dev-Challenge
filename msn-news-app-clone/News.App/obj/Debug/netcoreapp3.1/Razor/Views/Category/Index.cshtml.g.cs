#pragma checksum "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72050cf354ab6a2f5e286bee6c0722a4a79dee04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72050cf354ab6a2f5e286bee6c0722a4a79dee04", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f09b17159107837c344bde0aca195f1cdc1176", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<News.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "News Category";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container py-5\">\r\n\r\n    <div class=\"row\" data-masonry=\'{\"percentPosition\": true }\'>\r\n");
#nullable restore
#line 9 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
           int counter = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 640, "\"", 691, 1);
#nullable restore
#line 22 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
WriteAttributeValue("", 646, Html.DisplayFor(modelItem => item.Thumbnail), 646, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 692, "\"", 738, 1);
#nullable restore
#line 22 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
WriteAttributeValue("", 698, Html.DisplayFor(modelItem => item.Name), 698, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n\r\n                        <h5 class=\"card-title\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 868, "\"", 971, 4);
            WriteAttributeValue("", 875, "/Home/Posts/", 875, 12, true);
#nullable restore
#line 26 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
WriteAttributeValue("", 887, Html.DisplayFor(modelItem => item.Id), 887, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 925, "?name=", 925, 6, true);
#nullable restore
#line 26 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
WriteAttributeValue("", 931, Html.DisplayFor(modelItem => item.Name), 931, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text text-center\">\r\n                                ");
#nullable restore
#line 27 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\exper\Desktop\Dev\Simple Blog\SimpleBlog\News.App\Views\Category\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<News.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591