#pragma checksum "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480937e9250a5ffa63127aa32fc76db79001c9ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_ViewDetails), @"mvc.1.0.view", @"/Views/Event/ViewDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480937e9250a5ffa63127aa32fc76db79001c9ba", @"/Views/Event/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0211f9d72631223032da6e09ac446c40a55c130a", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookReading.Event.Models.EventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<div class=\"col-md-12\" align=\"center\">\r\n    <div class=\"card bg-light mb-12 shadow-sm\" style=\"width: 50%;\" align=\"center\">\r\n        <div class=\"card-body fw-bold\">\r\n            <h3 class=\"card-title text-primary\"><b>Book Title:</b> ");
#nullable restore
#line 6 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 8 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                 if (Model.Description != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-success d-inline\">Description :</p> ");
#nullable restore
#line 11 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 13 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-success d-inline\">Venue</p> : ");
#nullable restore
#line 15 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                  Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-success d-inline\">Event Date</p> : ");
#nullable restore
#line 19 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                       Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-success d-inline\">Start Time :</p> ");
#nullable restore
#line 23 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                       Write(Model.StartTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                 if (Model.Duration != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-success d-inline\">Duration :</p> ");
#nullable restore
#line 28 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                         Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 30 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                 if (Model.Invitees != null)
                {
                    var count = Model.Invitees.Split(',').Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-success d-inline\">Total Invitees :</p> ");
#nullable restore
#line 36 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div>It\'s a <p class=\"font-weight-bold d-inline text-primary\">");
#nullable restore
#line 44 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                             Write(Model.EventType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>Event</div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div>Organised by <p class=\"font-weight-bold d-inline text-danger\">");
#nullable restore
#line 47 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                                  Write(Model.Organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                </div>\r\n            </div>\r\n            <p></p>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480937e9250a5ffa63127aa32fc76db79001c9ba11124", async() => {
                WriteLiteral("<p class=\"fw-bold d-inline\">Back to Event Page</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <p></p>\r\n\r\n    <hr style=\"height:2px; width:80%; border-width:0; color:black; background-color:black\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-12\" align=\"center\" style=\"width: 50%;\">\r\n");
#nullable restore
#line 61 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
             using (Html.BeginForm("PostComment", "Comment", new { EventId = Model.ID }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group"">
                    <div class=""row"">
                        <div class=""col-sm-3"">

                            <img src=""https://image.ibb.co/jw55Ex/def_face.jpg"" class=""img img-rounded img-fluid"" />
                            <p>
                                <strong class=""text-success"">Anonymous</strong>
                            </p>
                        </div>

                        <div class=""col-sm-9"">
                            <textarea class=""form-control"" name=""comment"" id=""comment"" rows=""5"" placeholder=""Write your comment here....""></textarea>
                        </div>
                    </div>

                </div>
                <div class=""form-group"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button class=""btn btn-success btn-circle text-uppercase"" type=""submit"" value=""Post"" id=""submitComment""><span class=""glyphicon glyphicon-send""></span> Post comment</button>
       ");
            WriteLiteral("             </div>\r\n                </div>\r\n                <br />\r\n");
#nullable restore
#line 85 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
 if (@Model.Comments.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"display-4 text-danger\">Previous Comments!!</h4>\r\n");
#nullable restore
#line 93 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
     foreach (var i in Model.Comments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""card mb-12 shadow-sm"" style=""width: 50%;"" align=""center"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-2"">
                            <img src=""https://image.ibb.co/jw55Ex/def_face.jpg"" class=""img img-rounded img-fluid"" />
                            <p>
                               <strong class=""text-danger float-start"">Anonymous</strong>
                            </p>
                        </div>
                        <div class=""col-md-10"">
                            <p>");
#nullable restore
#line 106 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                          Write(i.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <small class=\"float-end fw-bold\">Last Comment At: ");
#nullable restore
#line 109 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
                                                                 Write(i.TimeStamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n\r\n            </div>\r\n            \r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 116 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\arvindtiwari\Downloads\BookReading.Event_DesignPattern\BookReading.Event_DesignPattern\Views\Event\ViewDetails.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookReading.Event.Models.EventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
