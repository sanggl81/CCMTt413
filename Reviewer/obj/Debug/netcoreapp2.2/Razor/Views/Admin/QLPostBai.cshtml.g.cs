#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71b7813d41dfa598fac3b04faafdb5717b48d02909128a15409bbe11998171d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QLPostBai), @"mvc.1.0.view", @"/Views/Admin/QLPostBai.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/QLPostBai.cshtml", typeof(AspNetCore.Views_Admin_QLPostBai))]
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
#line 1 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer.Models;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"71b7813d41dfa598fac3b04faafdb5717b48d02909128a15409bbe11998171d7", @"/Views/Admin/QLPostBai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QLPostBai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reviewer.Models.Data.PostBv>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left; margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XemPostBai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" float:left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XoaPostBai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Xác nhận duyệt bài thành công ?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DuyetPostBai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
  
    ViewData["Title"] = "QLPostBai";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(181, 433, true);
            WriteLiteral(@"
<h2 style=""text-align:center;color:black;"">Kiểm Duyệt Bài Đăng</h2>
<table id=""table_id"" class=""display"">
    <thead>
        <tr>
            <th>STT</th>
            <th>Tiêu đề bài viết</th>
            <th>Hình tiêu đề</th>
            <th>Ngày viết</th>
            <th>Mã tác giả</th>
            <th>Ngày duyệt bài</th>
            <th>Tình trạng</th>
            <th>Chức Năng</th>
        </tr>
    </thead>
");
            EndContext();
#line 22 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(655, 55, true);
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(711, 41, false);
#line 26 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaPost));

#line default
#line hidden
            EndContext();
            BeginContext(752, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(780, 41, false);
#line 27 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenBai));

#line default
#line hidden
            EndContext();
            BeginContext(821, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(870, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71b7813d41dfa598fac3b04faafdb5717b48d02909128a15409bbe11998171d79105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 880, "~/Img/SmartPhone/", 880, 17, true);
#line 29 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
AddHtmlAttributeValue("", 897, item.HinhAnhBv, 897, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(939, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(985, 43, false);
#line 31 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayViet));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1056, 45, false);
#line 32 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaReviewer));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1129, 47, false);
#line 33 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayGioDuyet));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 35 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                     if (item.TinhTrang == false)
                    {

#line default
#line hidden
            BeginContext(1279, 62, true);
            WriteLiteral("                        <p style=\"color:red\"> Chưa duyệt</p>\r\n");
            EndContext();
#line 38 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1413, 61, true);
            WriteLiteral("                        <p style=\"color:green\">Đã duyệt</p>\r\n");
            EndContext();
#line 42 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                    }

#line default
#line hidden
            BeginContext(1497, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
#line 44 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                 if (Context.Session.Get("Admin") != null)
                {


#line default
#line hidden
            BeginContext(1601, 124, true);
            WriteLiteral("                    <td>\r\n                        <div>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1725, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b7813d41dfa598fac3b04faafdb5717b48d02909128a15409bbe11998171d713813", async() => {
                BeginContext(1865, 3, true);
                WriteLiteral("Xem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                                                                                                                                                  WriteLiteral(item.MaPost);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1872, 105, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1977, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b7813d41dfa598fac3b04faafdb5717b48d02909128a15409bbe11998171d716789", async() => {
                BeginContext(2099, 3, true);
                WriteLiteral("Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                                                                                                                                WriteLiteral(item.MaPost);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2106, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 55 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                             if (item.NgayGioDuyet == null)
                            {

#line default
#line hidden
            BeginContext(2236, 75, true);
            WriteLiteral("                                <div>\r\n                                    ");
            EndContext();
            BeginContext(2311, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b7813d41dfa598fac3b04faafdb5717b48d02909128a15409bbe11998171d720103", async() => {
                BeginContext(2496, 5, true);
                WriteLiteral("Duyệt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                                                                                                                                                                                                   WriteLiteral(item.MaPost);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2505, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 60 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                            }

#line default
#line hidden
            BeginContext(2578, 59, true);
            WriteLiteral("                        </div>\r\n                    </td>\r\n");
            EndContext();
#line 63 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
                }

#line default
#line hidden
            BeginContext(2656, 37, true);
            WriteLiteral("            </tr>\r\n        </tbody>\r\n");
            EndContext();
#line 66 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLPostBai.cshtml"
    }

#line default
#line hidden
            BeginContext(2700, 355, true);
            WriteLiteral(@"

</table>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"">
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js""></script>
<script>
    $(document).ready(function () {
        $('#table_id').DataTable();
    });
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reviewer.Models.Data.PostBv>> Html { get; private set; }
    }
}
#pragma warning restore 1591
