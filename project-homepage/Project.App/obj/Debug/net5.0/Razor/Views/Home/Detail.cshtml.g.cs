#pragma checksum "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5aa50693bbe75e8aba42c42514746bb17069453"
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
#line 1 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\_ViewImports.cshtml"
using Project.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5aa50693bbe75e8aba42c42514746bb17069453", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc709bdff7da43ebaa4c5872fbedfad9350f364", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Data.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = @Html.DisplayFor(model => model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main>\r\n    <!--\r\n    <div class=\"position-relative overflow-hidden p-3 p-md-5  text-center bg-light\"\r\n         style=\"background-image: url(\'");
#nullable restore
#line 11 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
                                  Write(Html.DisplayFor(model => model.Thumbnail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-position: center;
        background-size:cover;
        min-height: 500px;"">
        <div class=""col-md-5 p-lg-5 mx-auto my-5"">

        </div>

    </div>
    -->




    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""row py-5"">
                    <h1>");
#nullable restore
#line 32 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n\r\n                <article class=\"blog-post\">\r\n                    <p style=\"white-space: pre-line\"> ");
#nullable restore
#line 36 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
                                                 Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1006, "\"", 1055, 1);
#nullable restore
#line 38 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1012, Html.DisplayFor(model => model.Screenshot), 1012, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%;"" />
                    </p>


                </article><!-- /.blog-post -->

            </div>

            <div class=""col-md-4 mt-5"">
                <div class=""row"">
                    <div class=""position-relative overflow-hidden p-3 p-md-5  text-center bg-light""");
            BeginWriteAttribute("style", "\r\n                         style=\"", 1358, "\"", 1599, 11);
            WriteAttributeValue("", 1392, "background-image:", 1392, 17, true);
            WriteAttributeValue(" ", 1409, "url(\'", 1410, 6, true);
#nullable restore
#line 49 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1415, Html.DisplayFor(model => model.Thumbnail), 1415, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1457, "\');", 1457, 3, true);
            WriteAttributeValue("\r\n        ", 1460, "background-repeat:", 1470, 28, true);
            WriteAttributeValue(" ", 1488, "no-repeat;", 1489, 11, true);
            WriteAttributeValue("\r\n\r\n        ", 1499, "background-position:", 1511, 32, true);
            WriteAttributeValue(" ", 1531, "center;", 1532, 8, true);
            WriteAttributeValue("\r\n        ", 1539, "background-size:cover;", 1549, 32, true);
            WriteAttributeValue("\r\n        ", 1571, "min-height:", 1581, 21, true);
            WriteAttributeValue(" ", 1592, "200px;", 1593, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"col-md-5 p-lg-5 mx-auto my-5\">\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 62 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
                     if (Model.Link != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"mt-5 btn btn-primary btn-lg btn-block\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1951, "\"", 1970, 2);
#nullable restore
#line 64 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1958, Model.Link, 1958, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1969, ")", 1969, 1, true);
            EndWriteAttribute();
            WriteLiteral(">DEMO</a>\r\n");
#nullable restore
#line 65 "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\FullStackDevChallenge\Project.App\Views\Home\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n               \r\n            </div>\r\n\r\n        </div><!-- /.row -->\r\n    </div>\r\n\r\n\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Data.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
