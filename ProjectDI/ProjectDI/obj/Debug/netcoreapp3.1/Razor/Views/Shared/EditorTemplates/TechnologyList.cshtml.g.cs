#pragma checksum "C:\Users\pca220\source\repos\ProjectDI\ProjectDI\Views\Shared\EditorTemplates\TechnologyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ce2dca268c58acdd352289b6b2c3d293ed4265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_TechnologyList), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/TechnologyList.cshtml")]
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
#line 1 "C:\Users\pca220\source\repos\ProjectDI\ProjectDI\Views\_ViewImports.cshtml"
using ProjectDI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pca220\source\repos\ProjectDI\ProjectDI\Views\_ViewImports.cshtml"
using ProjectDI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pca220\source\repos\ProjectDI\ProjectDI\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pca220\source\repos\ProjectDI\ProjectDI\Views\Shared\EditorTemplates\TechnologyList.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ce2dca268c58acdd352289b6b2c3d293ed4265", @"/Views/Shared/EditorTemplates/TechnologyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d2afd6f315b28c6396040d8e3ce41e27c2fd08f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_TechnologyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Int32>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pca220\source\repos\ProjectDI\ProjectDI\Views\Shared\EditorTemplates\TechnologyList.cshtml"
Write(Html.Kendo().DropDownListFor(m => m)
            .BindTo((IEnumerable)ViewBag.TechnologyDropDown)
            .OptionLabel("Select Technology")
            .DataValueField("TID")
            .DataTextField("TechnologyName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Int32> Html { get; private set; }
    }
}
#pragma warning restore 1591