#pragma checksum "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86577a076e681f5ab732ded1decb0bdcb7c581f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_All), @"mvc.1.0.view", @"/Views/Events/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/All.cshtml", typeof(AspNetCore.Views_Events_All))]
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
#line 1 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\_ViewImports.cshtml"
using Eventures;

#line default
#line hidden
#line 2 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\_ViewImports.cshtml"
using Eventures.Models;

#line default
#line hidden
#line 3 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\_ViewImports.cshtml"
using Eventures.ViewModels;

#line default
#line hidden
#line 2 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
using System.Globalization;

#line default
#line hidden
#line 3 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86577a076e681f5ab732ded1decb0bdcb7c581f2", @"/Views/Events/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a62c08dd5fe5c8dc8cbdbe88427d196a7dfdcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventures.ViewModels.Events.CreateEventOrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "TicketsCount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
  
    ViewData["Title"] = "All Events";

#line default
#line hidden
            BeginContext(168, 70, true);
            WriteLiteral("<div class=\"container\">\r\n    <h1 class=\"text-center\">All Events</h1>\r\n");
            EndContext();
#line 9 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
      var errors = ViewData.ModelState.Where(n => n.Value.Errors.Count > 0).ToList();

#line default
#line hidden
            BeginContext(326, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 10 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
     if (errors.Any())
    {
        foreach (var error in errors)
        {
            foreach (var valueError in error.Value.Errors)
            {

#line default
#line hidden
            BeginContext(482, 424, true);
            WriteLiteral(@"                <div class=""alert alert-danger half-width text-center mx-auto alert-dismissible fade show"" role=""alert"">
                    <hr class=""hr-2 bg-info"" />
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                    <strong>Something went wrong!</strong> ");
            EndContext();
            BeginContext(907, 23, false);
#line 21 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                                                      Write(valueError.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(930, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 23 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
            }
        }
    }

#line default
#line hidden
            BeginContext(989, 469, true);
            WriteLiteral(@"    <hr class=""hr-2 bg-info"" />
    <div class=""table-responsive"">
        <table class=""table"">
            <thead>
                <tr class=""font-weight-bold"">
                    <th scope=""col"">#</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Start</th>
                    <th scope=""col"">End</th>
                    <th scope=""col"">Actions</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 39 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                   var count = 1;

#line default
#line hidden
            BeginContext(1494, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 40 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                 foreach (var ev in Model.CreateEventViewModels)
                {

#line default
#line hidden
            BeginContext(1579, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1646, 5, false);
#line 43 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1651, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1687, 7, false);
#line 44 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                       Write(ev.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1694, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1730, 69, false);
#line 45 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                       Write(ev.Start.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1835, 67, false);
#line 46 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                       Write(ev.End.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1967, 979, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8c5cfd14f5498288d709044c83a430", async() => {
                BeginContext(2051, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2085, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf7f90e62e5b46428577f123756c8c72", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 49 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2145, 116, true);
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2261, "\"", 2314, 1);
#line 51 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
WriteAttributeValue("", 2268, nameof(Model.CreateOrderViewModel.CustomerId), 2268, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2315, "\"", 2371, 1);
#line 51 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
WriteAttributeValue("", 2323, User.FindFirst(ClaimTypes.NameIdentifier).Value, 2323, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2372, 61, true);
                WriteLiteral(" />\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2433, "\"", 2483, 1);
#line 52 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
WriteAttributeValue("", 2440, nameof(Model.CreateOrderViewModel.EventId), 2440, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2484, "\"", 2498, 1);
#line 52 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
WriteAttributeValue("", 2492, ev.Id, 2492, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2499, 41, true);
                WriteLiteral(" />\r\n                                    ");
                EndContext();
                BeginContext(2540, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce90b71f75524f79879f678f1b0905a7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 53 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CreateOrderViewModel.TicketsCount);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2631, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2669, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74bc25fae240486badcfe88a35cdb5e2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 54 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CreateOrderViewModel.TicketsCount);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2775, 164, true);
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn bg-info\">Order</button>\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2946, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 60 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Events\All.cshtml"
                    count++;
                }

#line default
#line hidden
            BeginContext(3055, 93, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <hr class=\"hr-2 bg-info\" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventures.ViewModels.Events.CreateEventOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591