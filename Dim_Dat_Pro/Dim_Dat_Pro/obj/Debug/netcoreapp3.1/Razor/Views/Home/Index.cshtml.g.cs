#pragma checksum "C:\Users\Francois Scholtz\Desktop\Practical Exercise\CMPG323 - Practical 2\CMPG323_Project2\Dim_Dat_Pro\Dim_Dat_Pro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9944261bd6b0c2ef5c08000447ffc993e3b7069"
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
#line 1 "C:\Users\Francois Scholtz\Desktop\Practical Exercise\CMPG323 - Practical 2\CMPG323_Project2\Dim_Dat_Pro\Dim_Dat_Pro\Views\_ViewImports.cshtml"
using Dim_Dat_Pro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Francois Scholtz\Desktop\Practical Exercise\CMPG323 - Practical 2\CMPG323_Project2\Dim_Dat_Pro\Dim_Dat_Pro\Views\_ViewImports.cshtml"
using Dim_Dat_Pro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9944261bd6b0c2ef5c08000447ffc993e3b7069", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55de3ca4a6e1f3f4e7fd0456eb0fcb2ccda2b6e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Francois Scholtz\Desktop\Practical Exercise\CMPG323 - Practical 2\CMPG323_Project2\Dim_Dat_Pro\Dim_Dat_Pro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\Francois Scholtz\Desktop\Practical Exercise\CMPG323 - Practical 2\CMPG323_Project2\Dim_Dat_Pro\Dim_Dat_Pro\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>
    The DimDatPro web application was developed as part of the CMPG323 Project 2 requirements. The system was developed
    using ASP.NET MVC core and a SQL Server Database was used to import the given CSV dataset from file. This database
    is lined to the application. A My SQL database was developed for the application to store users data. This site is
    hosted on Amazon Web Service and source code management was done using GitHub. Desing patters such as the NULL object
    pattern, ---insert various patterns here---. Architectural patterns such as  ---insert various patterns here---.
    SOLID principles were applied as:</p>
<p>
    * Single Responsibility ---enter more data here---
    * Open/Closed ---enter more data here---
    * Liskov Substitution ---enter more data here---
    * Interface Segregation ---enter more data here---
    * Dependency Inversion ---enter more data here---
</p>
<p>
    CRUD Functionality---enter more data here---
</p>
<p>
    Database security");
            WriteLiteral(" and access control---enter more data here---\r\n</p>");
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
