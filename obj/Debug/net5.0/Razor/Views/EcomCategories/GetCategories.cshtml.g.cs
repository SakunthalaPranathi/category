#pragma checksum "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6066eff16fec7e08cafcdacbfe4ed834632337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EcomCategories_GetCategories), @"mvc.1.0.view", @"/Views/EcomCategories/GetCategories.cshtml")]
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
#line 1 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\_ViewImports.cshtml"
using cateringdatasample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\_ViewImports.cshtml"
using cateringdatasample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6066eff16fec7e08cafcdacbfe4ed834632337", @"/Views/EcomCategories/GetCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e99e9a3ff47852c97bb65d86f57edfd69d94c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_EcomCategories_GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cateringdemosample.Models.EcomCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
  
    ViewData["Title"] = "GetCategories";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>GetCategories</h1>\r\n");
#nullable restore
#line 11 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
Write(TempData["food"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <!--<thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
           Write(Html.DisplayNameFor(Model => Model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>-->\r\n");
            WriteLiteral("    <!--</tr>\r\n    </thead>-->\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 704, "\"", 746, 3);
#nullable restore
#line 31 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
WriteAttributeValue("", 711, Url.Action("FoodList"), 711, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 734, "?id=", 734, 4, true);
#nullable restore
#line 31 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
WriteAttributeValue("", 738, item.id, 738, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">  ");
#nullable restore
#line 31 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\GetCategories.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cateringdemosample.Models.EcomCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
