#pragma checksum "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b53a5ea732b311965be810cb62a9b72a9c5d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_UpdateProduct), @"mvc.1.0.view", @"/Views/Product/UpdateProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b53a5ea732b311965be810cb62a9b72a9c5d64", @"/Views/Product/UpdateProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cfb9a0ef0ec1d3d285195ab224403920d5ac14", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_UpdateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
  
	ViewData["Title"] = "UpdateProduct";
	Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ürün Güncelleme Formu</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b53a5ea732b311965be810cb62a9b72a9c5d643888", async() => {
                WriteLiteral("\r\n\t");
#nullable restore
#line 10 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.HiddenFor(x=>x.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t");
#nullable restore
#line 12 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.Label("Ürün Adı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t");
#nullable restore
#line 13 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.TextBoxFor(x=>x.Name,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t");
#nullable restore
#line 15 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.Label("Ürün Stok Bilgisi"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t");
#nullable restore
#line 16 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.TextBoxFor(x=>x.Stock,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t");
#nullable restore
#line 18 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.Label("Ürün Fiyatı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t");
#nullable restore
#line 19 "C:\Users\Mehmet\source\repos\Demo_Product\Demo_Product\Views\Product\UpdateProduct.cshtml"
Write(Html.TextBoxFor(x=>x.Price,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\t<button class=\"btn btn-warning\">Güncelle</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
