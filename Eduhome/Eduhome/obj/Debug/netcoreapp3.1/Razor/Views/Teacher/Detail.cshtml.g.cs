#pragma checksum "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b63841c95bfa98e3007b0d1954e286e7fdbdb812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.Data.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63841c95bfa98e3007b0d1954e286e7fdbdb812", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf61a6619d3d28cc774772d50ab531f5189c14a", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b63841c95bfa98e3007b0d1954e286e7fdbdb8124812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 933, "~/uploads/teachers/", 933, 19, true);
#nullable restore
#line 30 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 952, Model.Teacher.Photo, 952, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                   Write(Model.Teacher.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                   Write(Model.Teacher.TeachingStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 38 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                  Write(Model.Teacher.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                            Write(Model.Teacher.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                Write(Model.Teacher.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Teacher.Hobby);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Teacher.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 52 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                         Write(Model.Teacher.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 53 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Teacher.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
#nullable restore
#line 54 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                       Write(Model.Teacher.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2231, "\"", 2264, 1);
#nullable restore
#line 56 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2238, Model.Teacher.FacebookUrl, 2238, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2341, "\"", 2375, 1);
#nullable restore
#line 57 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2348, Model.Teacher.PinterestUrl, 2348, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2453, "\"", 2483, 1);
#nullable restore
#line 58 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2460, Model.Teacher.VimeoUrl, 2460, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2557, "\"", 2589, 1);
#nullable restore
#line 59 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2564, Model.Teacher.TwitterUrl, 2564, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3242, "\"", 3390, 11);
            WriteAttributeValue("", 3250, "width:", 3250, 6, true);
#nullable restore
#line 73 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3256, Model.Teacher.LanguagePercentage, 3257, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3290, "%;", 3290, 2, true);
            WriteAttributeValue(" ", 3292, "visibility:", 3293, 12, true);
            WriteAttributeValue(" ", 3304, "visible;", 3305, 9, true);
            WriteAttributeValue(" ", 3313, "animation-duration:", 3314, 20, true);
            WriteAttributeValue(" ", 3333, "1.5s;", 3334, 6, true);
            WriteAttributeValue(" ", 3339, "animation-delay:", 3340, 17, true);
            WriteAttributeValue(" ", 3356, "1.2s;", 3357, 6, true);
            WriteAttributeValue(" ", 3362, "animation-name:", 3363, 16, true);
            WriteAttributeValue(" ", 3378, "fadeInLeft;", 3379, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 74 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Teacher.LanguagePercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4015, "\"", 4165, 11);
            WriteAttributeValue("", 4023, "width:", 4023, 6, true);
#nullable restore
#line 83 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 4029, Model.Teacher.TeamLeaderPercentage, 4030, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4065, "%;", 4065, 2, true);
            WriteAttributeValue(" ", 4067, "visibility:", 4068, 12, true);
            WriteAttributeValue(" ", 4079, "visible;", 4080, 9, true);
            WriteAttributeValue(" ", 4088, "animation-duration:", 4089, 20, true);
            WriteAttributeValue(" ", 4108, "1.5s;", 4109, 6, true);
            WriteAttributeValue(" ", 4114, "animation-delay:", 4115, 17, true);
            WriteAttributeValue(" ", 4131, "1.2s;", 4132, 6, true);
            WriteAttributeValue(" ", 4137, "animation-name:", 4138, 16, true);
            WriteAttributeValue(" ", 4153, "fadeInLeft;", 4154, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\"> ");
#nullable restore
#line 84 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                           Write(Model.Teacher.TeamLeaderPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4793, "\"", 4945, 11);
            WriteAttributeValue("", 4801, "width:", 4801, 6, true);
#nullable restore
#line 93 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("  ", 4807, Model.Teacher.DevelopmentPercentage, 4809, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4845, "%;", 4845, 2, true);
            WriteAttributeValue(" ", 4847, "visibility:", 4848, 12, true);
            WriteAttributeValue(" ", 4859, "visible;", 4860, 9, true);
            WriteAttributeValue(" ", 4868, "animation-duration:", 4869, 20, true);
            WriteAttributeValue(" ", 4888, "1.5s;", 4889, 6, true);
            WriteAttributeValue(" ", 4894, "animation-delay:", 4895, 17, true);
            WriteAttributeValue(" ", 4911, "1.2s;", 4912, 6, true);
            WriteAttributeValue(" ", 4917, "animation-name:", 4918, 16, true);
            WriteAttributeValue(" ", 4933, "fadeInLeft;", 4934, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\"> ");
#nullable restore
#line 94 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                           Write(Model.Teacher.DevelopmentPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 5569, "\"", 5716, 11);
            WriteAttributeValue("", 5577, "width:", 5577, 6, true);
#nullable restore
#line 103 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("  ", 5583, Model.Teacher.DesignPercentage, 5585, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5616, "%;", 5616, 2, true);
            WriteAttributeValue(" ", 5618, "visibility:", 5619, 12, true);
            WriteAttributeValue(" ", 5630, "visible;", 5631, 9, true);
            WriteAttributeValue(" ", 5639, "animation-duration:", 5640, 20, true);
            WriteAttributeValue(" ", 5659, "1.5s;", 5660, 6, true);
            WriteAttributeValue(" ", 5665, "animation-delay:", 5666, 17, true);
            WriteAttributeValue(" ", 5682, "1.2s;", 5683, 6, true);
            WriteAttributeValue(" ", 5688, "animation-name:", 5689, 16, true);
            WriteAttributeValue(" ", 5704, "fadeInLeft;", 5705, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\"> ");
#nullable restore
#line 104 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                           Write(Model.Teacher.DesignPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6339, "\"", 6490, 11);
            WriteAttributeValue("", 6347, "width:", 6347, 6, true);
#nullable restore
#line 113 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("  ", 6353, Model.Teacher.InnovationPercentage, 6355, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6390, "%;", 6390, 2, true);
            WriteAttributeValue(" ", 6392, "visibility:", 6393, 12, true);
            WriteAttributeValue(" ", 6404, "visible;", 6405, 9, true);
            WriteAttributeValue(" ", 6413, "animation-duration:", 6414, 20, true);
            WriteAttributeValue(" ", 6433, "1.5s;", 6434, 6, true);
            WriteAttributeValue(" ", 6439, "animation-delay:", 6440, 17, true);
            WriteAttributeValue(" ", 6456, "1.2s;", 6457, 6, true);
            WriteAttributeValue(" ", 6462, "animation-name:", 6463, 16, true);
            WriteAttributeValue(" ", 6478, "fadeInLeft;", 6479, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\"> ");
#nullable restore
#line 114 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                           Write(Model.Teacher.InnovationPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 7120, "\"", 7274, 11);
            WriteAttributeValue("", 7128, "width:", 7128, 6, true);
#nullable restore
#line 123 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("  ", 7134, Model.Teacher.CommunicationPercentage, 7136, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7174, "%;", 7174, 2, true);
            WriteAttributeValue(" ", 7176, "visibility:", 7177, 12, true);
            WriteAttributeValue(" ", 7188, "visible;", 7189, 9, true);
            WriteAttributeValue(" ", 7197, "animation-duration:", 7198, 20, true);
            WriteAttributeValue(" ", 7217, "1.5s;", 7218, 6, true);
            WriteAttributeValue(" ", 7223, "animation-delay:", 7224, 17, true);
            WriteAttributeValue(" ", 7240, "1.2s;", 7241, 6, true);
            WriteAttributeValue(" ", 7246, "animation-name:", 7247, 16, true);
            WriteAttributeValue(" ", 7262, "fadeInLeft;", 7263, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\"> ");
#nullable restore
#line 124 "C:\Users\HP\Desktop\p120_backend_project-AsimanAlili\Eduhome\Eduhome\Views\Teacher\Detail.cshtml"
                                                           Write(Model.Teacher.CommunicationPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
