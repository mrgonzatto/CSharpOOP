#pragma checksum "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd41a92fb7866c5d3b5e3dcf52e26ab2f3fcc95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\_ViewImports.cshtml"
using ACMWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\_ViewImports.cshtml"
using ACMWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\_ViewImports.cshtml"
using ACM.BL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd41a92fb7866c5d3b5e3dcf52e26ab2f3fcc95", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b087a178aba09ff3322d062e8b004dfaf1712021", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\Product\Index.cshtml"
 foreach( var p in Model )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 9 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\Product\Index.cshtml"
       Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 10 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\Product\Index.cshtml"
      Write(p.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h4>");
#nullable restore
#line 11 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\Product\Index.cshtml"
       Write(p.CurrentPrice.Value.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\GitHub\CSharpOOP\ACM\ACMWeb\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
