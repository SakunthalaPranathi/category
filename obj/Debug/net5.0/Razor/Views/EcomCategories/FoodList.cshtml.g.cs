#pragma checksum "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37fa4ceede97b5cfeef81ad7d6ba7382ab09ac3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EcomCategories_FoodList), @"mvc.1.0.view", @"/Views/EcomCategories/FoodList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37fa4ceede97b5cfeef81ad7d6ba7382ab09ac3d", @"/Views/EcomCategories/FoodList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e99e9a3ff47852c97bb65d86f57edfd69d94c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_EcomCategories_FoodList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cateringdemosample.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
  
    ViewData["Title"] = "FoodList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FoodList</h1>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 16 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
   Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!--<table class=\"table table-striped\">-->\r\n            \r\n");
            WriteLiteral("            <!--<tbody>\r\n");
#nullable restore
#line 40 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
                       Write(Html.HiddenFor(e=>item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>-->\r\n");
            WriteLiteral("                        <!--<td>\r\n                            ");
#nullable restore
#line 57 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
                       Write(Html.CheckBoxFor(modelItem => item.check));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>-->\r\n");
            WriteLiteral("                   --></tr>\r\n");
#nullable restore
#line 65 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>-->\r\n    </div> \r\n</div>\r\n<input type=\"submit\" value=\"submit\"/>\r\n");
#nullable restore
#line 71 "C:\Users\SAKUNTALA PRANATHI\Desktop\Doctor\cateringdatasample\cateringdatasample\Views\EcomCategories\FoodList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cateringdemosample.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591