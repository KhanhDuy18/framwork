#pragma checksum "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b54370a9aaae424e6b250f4567caf971b2a74415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_LessonDetail), @"mvc.1.0.view", @"/Views/Lesson/LessonDetail.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54370a9aaae424e6b250f4567caf971b2a74415", @"/Views/Lesson/LessonDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Lesson_LessonDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lesson>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/LessonDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
  

    var id = Model.lessonId;
    int idLastlesson = Convert.ToInt32(TempData["NumberofLesson"]);
    int idmax = idLastlesson + 1;
    var idNext = id + 1;
    var idPre = id - 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b54370a9aaae424e6b250f4567caf971b2a744154628", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b54370a9aaae424e6b250f4567caf971b2a744155742", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container col-9 container-custom mb-5\">\r\n        <div class=\"lesson-title mt-4 p-4 pb-2 text-center\">");
#nullable restore
#line 15 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                                                       Write(Model.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"lesson-des pb-1 pt-3 p-4\">\r\n            <b>Mô tả:</b>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
          Write(Model.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"lesson-content mb-3 p-4 pb-2\">\r\n            <b>Nội dung:</b>\r\n            <p>\r\n                ");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
           Write(Model.content);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"lesson-exercise p-4 pt-0 pb-3\">\r\n            <b> <i class=\"fas fa-chalkboard\"></i> Bài tập</b>\r\n");
#nullable restore
#line 28 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
             foreach (var item in ViewBag.listExercise)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <ol>\r\n                    <i class=\"fas fa-pencil-alt\"></i>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 997, "\"", 1004, 0);
                EndWriteAttribute();
                WriteLiteral(">Bài tâp ");
#nullable restore
#line 32 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                                  Write(item.exerciseId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </ol>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div class=\"move-lesson p-4 pt-0\">\r\n");
#nullable restore
#line 38 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
              
                if (idPre == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"pre-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1276, "\"", 1314, 2);
                WriteAttributeValue("", 1283, "/lesson/LessonDetail?Id=", 1283, 24, true);
#nullable restore
#line 42 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1307, idNext, 1307, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Tiếp theo</a>\r\n                    </div>\r\n");
#nullable restore
#line 44 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                }
                else if (idNext == 3)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"next-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1532, "\"", 1569, 2);
                WriteAttributeValue("", 1539, "/lesson/LessonDetail?Id=", 1539, 24, true);
#nullable restore
#line 48 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1563, idPre, 1563, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"pre-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1768, "\"", 1806, 2);
                WriteAttributeValue("", 1775, "/lesson/LessonDetail?Id=", 1775, 24, true);
#nullable restore
#line 54 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1799, idNext, 1799, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Tiếp theo</a>\r\n                    </div>\r\n                    <div class=\"next-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1947, "\"", 1984, 2);
                WriteAttributeValue("", 1954, "/lesson/LessonDetail?Id=", 1954, 24, true);
#nullable restore
#line 57 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1978, idPre, 1978, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\framwork.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lesson> Html { get; private set; }
    }
}
#pragma warning restore 1591
