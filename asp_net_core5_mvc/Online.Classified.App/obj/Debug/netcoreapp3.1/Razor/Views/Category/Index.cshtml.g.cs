#pragma checksum "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91e31ba87849870035931152a99432ceaeaef77"
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
#line 1 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\_ViewImports.cshtml"
using Online.Classified.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\_ViewImports.cshtml"
using Online.Classified.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91e31ba87849870035931152a99432ceaeaef77", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080427a6a989d67895bfdcea91b54c090d9d6371", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Online.Classified.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2 class=\"display-4 text-center\">Categories</h2>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-4\">\r\n\r\n\r\n            <div class=\"card border-0\" style=\"width: 18rem;\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 397, "\"", 453, 1);
#nullable restore
#line 16 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
WriteAttributeValue(" ", 403, Html.DisplayFor(modelItem => item.CategoryImage), 404, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n\r\n                    \r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 674, 4);
            WriteAttributeValue("", 572, "/Classified/Index/", 572, 18, true);
#nullable restore
#line 20 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
WriteAttributeValue("", 590, Html.DisplayFor(modelItem => item.Id), 590, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 628, "?name=", 628, 6, true);
#nullable restore
#line 20 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
WriteAttributeValue("", 634, Html.DisplayFor(modelItem => item.Name), 634, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text text-center\">\r\n                        <p class=\"card-text text-center\"> ");
#nullable restore
#line 21 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                    </a>\r\n\r\n\r\n                        \r\n                   \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Online.Classified.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
