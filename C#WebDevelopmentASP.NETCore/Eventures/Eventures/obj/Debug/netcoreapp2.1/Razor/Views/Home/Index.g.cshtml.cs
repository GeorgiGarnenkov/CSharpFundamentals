#pragma checksum "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f525401d058ce736f73afc20391310e54a72f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f525401d058ce736f73afc20391310e54a72f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a62c08dd5fe5c8dc8cbdbe88427d196a7dfdcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(113, 103, true);
            WriteLiteral("    <div class=\"container jumbotron mt-4 bg-info text-center\">\r\n        <h1>Greetings, Administrator - ");
            EndContext();
            BeginContext(217, 18, false);
#line 8 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
                                  Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(235, 84, true);
            WriteLiteral("!</h1>\r\n        <hr class=\"hr-2\" />\r\n        <h3>Enjoy your work.</h3>\r\n    </div>\r\n");
            EndContext();
#line 12 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
}
else if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(366, 85, true);
            WriteLiteral("    <div class=\"container jumbotron mt-4 bg-info text-center\">\r\n        <h1>Welcome, ");
            EndContext();
            BeginContext(452, 18, false);
#line 16 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
                Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(470, 112, true);
            WriteLiteral("!</h1>\r\n        <hr class=\"hr-2\" />\r\n        <h3>Eventures wishes you an exciting experience!</h3>\r\n    </div>\r\n");
            EndContext();
#line 20 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(594, 206, true);
            WriteLiteral("    <div class=\"container jumbotron mt-4 bg-info\">\r\n        <h1>Eventures - The best ticket service in the world.</h1>\r\n        <hr class=\"hr-2 bg-dark\" />\r\n        <div>\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(800, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c4a7b069e754efda09d641557c596ac", async() => {
                BeginContext(864, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(873, 107, true);
            WriteLiteral(" to start \"eventing\".\r\n            </h3>\r\n        </div>\r\n        <div>\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(980, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a570281cb06a4f13a8e6aa8df67a47df", async() => {
                BeginContext(1047, 8, true);
                WriteLiteral("Register");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1059, 79, true);
            WriteLiteral(" if you don\'t have an account.\r\n            </h3>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 37 "D:\SOFTUNI\RepoFolder\C#WebDevelopment\C#WebDevelopmentASP.NETCore\Eventures\Eventures\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
