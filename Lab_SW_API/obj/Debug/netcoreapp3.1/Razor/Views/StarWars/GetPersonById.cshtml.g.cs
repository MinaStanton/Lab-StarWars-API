#pragma checksum "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b911a2e384d4d522e73c40ca2a00a0ef31b3b2da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_GetPersonById), @"mvc.1.0.view", @"/Views/StarWars/GetPersonById.cshtml")]
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
#line 1 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\_ViewImports.cshtml"
using Lab_SW_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\_ViewImports.cshtml"
using Lab_SW_API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b911a2e384d4d522e73c40ca2a00a0ef31b3b2da", @"/Views/StarWars/GetPersonById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306e3255b42858ebff13666cdd69f169be3cf389", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_GetPersonById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Result>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
  
    ViewData["Title"] = "GetPersonById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Get Person By Id</h1>\r\n\r\n");
            WriteLiteral(@"
<table class=""table"">
    <tr>
        <th>Name</th>
        <th>Height</th>
        <th>Hair Color</th>
        <th>Eye Color</th>
        <th>Birth Year</th>
        <th>Gender</th>
        <th>Home World</th>
      
    </tr>
    <tr>
        <td>");
#nullable restore
#line 22 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.hair_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.eye_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.eye_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.birth_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\stant\Documents\GC_CSHARP_BOOTCAMP\Labs\Lab_SW_API\Lab_SW_API\Views\StarWars\GetPersonById.cshtml"
       Write(Model.homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       \r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Result> Html { get; private set; }
    }
}
#pragma warning restore 1591
