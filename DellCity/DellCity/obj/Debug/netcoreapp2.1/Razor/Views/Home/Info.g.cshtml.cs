#pragma checksum "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3eb93d047b920d68e969c68079a230e560fc0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\_ViewImports.cshtml"
using DellCity;

#line default
#line hidden
#line 2 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\_ViewImports.cshtml"
using DellCity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3eb93d047b920d68e969c68079a230e560fc0f", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f315792fe5efe5d7613fbe3735b6594b24e41f2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessLayer.Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Population", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
            BeginContext(71, 25, true);
            WriteLiteral("\r\n<h3 class=\"text-center\"");
            EndContext();
            BeginWriteAttribute("style", "  style=\"", 96, "\"", 159, 1);
#line 7 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
WriteAttributeValue("", 105, Model.Gender ==true?"color:lightcoral":"color:blue", 105, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(160, 23, true);
            WriteLiteral(">Information about <b> ");
            EndContext();
            BeginContext(184, 15, false);
#line 7 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
                                                                                                         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(199, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(201, 14, false);
#line 7 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
                                                                                                                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(215, 113, true);
            WriteLiteral("</b></h3>\r\n<br />\r\n<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(329, 45, false);
#line 15 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(374, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(430, 44, false);
#line 18 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(530, 45, false);
#line 21 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(575, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(631, 41, false);
#line 24 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(672, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(728, 40, false);
#line 27 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(768, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(824, 43, false);
#line 30 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(867, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(923, 47, false);
#line 33 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(970, 111, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1082, 45, false);
#line 40 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1183, 44, false);
#line 43 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1283, 45, false);
#line 46 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1384, 41, false);
#line 49 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1481, 40, false);
#line 52 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1577, 43, false);
#line 55 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1676, 47, false);
#line 58 "C:\Users\Comp\Desktop\LT\DellCity\DellCity\Views\Home\Info.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 99, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<br />\r\n<div class=\"text-center\">\r\n    ");
            EndContext();
            BeginContext(1822, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ec3c3a84404d229d7e76bbfa8d8180", async() => {
                BeginContext(1849, 14, true);
                WriteLiteral("Back to people");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1867, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessLayer.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
