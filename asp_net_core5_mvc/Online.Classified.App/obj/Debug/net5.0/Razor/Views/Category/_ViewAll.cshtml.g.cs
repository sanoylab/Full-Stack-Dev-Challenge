#pragma checksum "C:\Users\exper\Desktop\Dev\Full Stack Dev Challenge\Working\asp_net_core5\Online.Classified.App\Views\Category\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f5536c668dcd65ada388e6018e2c4b31ffb150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category__ViewAll), @"mvc.1.0.view", @"/Views/Category/_ViewAll.cshtml")]
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
using Online.Classified.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f5536c668dcd65ada388e6018e2c4b31ffb150", @"/Views/Category/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc09d3b60150697d8579e71d6e90f61c8b17349", @"/Views/_ViewImports.cshtml")]
    public class Views_Category__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br />
<div class=""col-12 border p-3"">
    <table id=""DT_load"" class=""table table-light table-striped table-hover"" style=""width: 100%;"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Status</th>
                <th>Category Image</th>


                <th> <a onclick=""showInPopup('/Category/Form','Add Category')"" style=""width: 100%;"" class=""btn btn-success text-white""><i class=""fas fa-random""></i> Add New Category</a></th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <th>Name</th>

                <th>Status</th>
                <th>Category Image</th>


                <th></th>
            </tr>
        </tfoot>
    </table>
</div>
");
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
