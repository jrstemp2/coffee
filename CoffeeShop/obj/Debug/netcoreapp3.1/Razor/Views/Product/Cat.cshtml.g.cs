#pragma checksum "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ebf1fe432bdfa424afa0dd295244a7392cccd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cat), @"mvc.1.0.view", @"/Views/Product/Cat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ebf1fe432bdfa424afa0dd295244a7392cccd7", @"/Views/Product/Cat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Cat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- there\'s a little lie here -->\r\n");
#nullable restore
#line 3 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml"
    List<Product> Products = (List<Product>)ViewData["Products"];
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h1>");
#nullable restore
#line 6 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <ul>\r\n");
#nullable restore
#line 8 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml"
             foreach (Product p in Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 278, 2);
            WriteAttributeValue("", 257, "/Product/Detail/", 257, 16, true);
#nullable restore
#line 10 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml"
WriteAttributeValue("", 273, p.Id, 273, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml"
                                           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 11 "C:\Users\JSTEMPOWSKI\OneDrive - Knex\Desktop\CoffeeShop\CoffeeShop\Views\Product\Cat.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
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
