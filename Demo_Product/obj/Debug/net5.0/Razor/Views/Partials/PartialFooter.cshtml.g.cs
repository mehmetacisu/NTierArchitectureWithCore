#pragma checksum "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Partials\PartialFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94024ec2e3bbb7f21393ca2f594ddfb328ee51b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_PartialFooter), @"mvc.1.0.view", @"/Views/Partials/PartialFooter.cshtml")]
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
#line 1 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94024ec2e3bbb7f21393ca2f594ddfb328ee51b0", @"/Views/Partials/PartialFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cfb9a0ef0ec1d3d285195ab224403920d5ac14", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_PartialFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"py-4 bg-light mt-auto\">\r\n\t<div class=\"container-fluid px-4\">\r\n\t\t<div class=\"d-flex align-items-center justify-content-between small\">\r\n\t\t\t<div class=\"text-muted\">\r\n\t\t\t\tCopyright &copy; Tüm hakları saklıdır ");
#nullable restore
#line 5 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Partials\PartialFooter.cshtml"
                                                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</footer>");
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
