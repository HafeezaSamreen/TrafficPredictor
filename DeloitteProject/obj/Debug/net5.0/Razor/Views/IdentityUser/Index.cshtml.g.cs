#pragma checksum "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\IdentityUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eebdb3ac1c722ce0e79b9fa5c47013815885c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IdentityUser_Index), @"mvc.1.0.view", @"/Views/IdentityUser/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\_ViewImports.cshtml"
using DeloitteProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\_ViewImports.cshtml"
using DeloitteProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eebdb3ac1c722ce0e79b9fa5c47013815885c52", @"/Views/IdentityUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1c3c888827366f7100326d0290b44c7c6a64b2", @"/Views/_ViewImports.cshtml")]
    public class Views_IdentityUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\IdentityUser\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\IdentityUser\Index.cshtml"
 if (TempData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissable\">\r\n        <strong>");
#nullable restore
#line 9 "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\IdentityUser\Index.cshtml"
           Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>");
#nullable restore
#line 10 "C:\Users\User\Desktop\.net core mvc authentication\DeloitteProject\DeloitteProject\Views\IdentityUser\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591