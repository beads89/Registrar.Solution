#pragma checksum "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c530a4ea436580ee8242df8aff2617c00a331bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Create), @"mvc.1.0.view", @"/Views/Courses/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c530a4ea436580ee8242df8aff2617c00a331bdf", @"/Views/Courses/Create.cshtml")]
    public class Views_Courses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new course</h4>\n");
#nullable restore
#line 8 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.CourseNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.CourseNumber, null, new { type = "number"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add a new course\" />\n");
#nullable restore
#line 19 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 20 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.ActionLink("Show all courses", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
