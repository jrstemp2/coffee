#pragma checksum "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa397ab26c685c1c485f4a869f4a2cde13aa097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductIndex), @"mvc.1.0.view", @"/Views/Product/ProductIndex.cshtml")]
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
#line 1 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa397ab26c685c1c485f4a869f4a2cde13aa097", @"/Views/Product/ProductIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
  
    ViewData["Title"] = "ProductIndex";
    List<Product> Products = (List<Product>)ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Products Available</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
     foreach (Product p in Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 13 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 13 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
                Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 13 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
                             Write(p.Temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
                                            Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $");
#nullable restore
#line 13 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
                                                            Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\ProductIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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