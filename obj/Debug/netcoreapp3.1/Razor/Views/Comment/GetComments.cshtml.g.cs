#pragma checksum "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a17193f8c6d9c6c12a6aea37b294181af3a970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_GetComments), @"mvc.1.0.view", @"/Views/Comment/GetComments.cshtml")]
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
#line 1 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\_ViewImports.cshtml"
using BookReading.Event;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\_ViewImports.cshtml"
using BookReading.Event.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a17193f8c6d9c6c12a6aea37b294181af3a970", @"/Views/Comment/GetComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0211f9d72631223032da6e09ac446c40a55c130a", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_GetComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookReading.Event.Models.CommentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
  
    ViewData["Title"] = "FetchComment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Comment\GetComments.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookReading.Event.Models.CommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
