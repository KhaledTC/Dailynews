#pragma checksum "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d216f7fef4f53fadc22db86cc2a6e023eb541c0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\_ViewImports.cshtml"
using Dailynews.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d216f7fef4f53fadc22db86cc2a6e023eb541c0b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b3c89f42ae18d187f7440850b980d4be9661702", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Dailynews";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive"" >
    <table class=""table table-dark"" id=""newsTable"">
        <thead>
            <tr>
                <th scope=""col"">Title</th>
                <th scope=""col"">Content</th>
                <th scope=""col"">Datetime</th>
                <th scope=""col"">Rating</th>
                <th scope=""col"">Source</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
             foreach (var n in Model)
            {
                foreach (var m in n.latestnews)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
                       Write(m.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
                       Write(m.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
                       Write(m.datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
                       Write(m.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
                       Write(m.source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Naruto\source\repos\Dailynews\Dailynews\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script>
    $(document).ready(function () {
        $(""#newsTable"").DataTable({
            searching: false,
            paging: false,
            info: false,
            aoColumns: [
                { bSortable: false },
                { bSortable: false },
                { bSortable: true },
                { bSortable: true },
                { bSortable: false }
            ]
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
