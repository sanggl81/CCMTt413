#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Partials\ThemAd.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1f34eb10920ee03034da98b93bc2d2f45c0e6ece46be0d5b031578ad81e5dc11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials_ThemAd), @"mvc.1.0.view", @"/Views/Shared/Partials/ThemAd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/ThemAd.cshtml", typeof(AspNetCore.Views_Shared_Partials_ThemAd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1f34eb10920ee03034da98b93bc2d2f45c0e6ece46be0d5b031578ad81e5dc11", @"/Views/Shared/Partials/ThemAd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials_ThemAd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 137, true);
            WriteLiteral("<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\" style=\"margin-bottom: 10px\">Thêm</button>\r\n");
            EndContext();
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Partials\ThemAd.cshtml"
 using (Html.BeginForm("ThemAd", "Admin", FormMethod.Post, new { @enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(243, 2431, true);
            WriteLiteral(@"    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm quản trị </h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">UserName</label>
                        <input type=""text"" class=""form-control"" placeholder=""Username"" aria-label=""Username"" name=""UsernameAd"" aria-describedby=""basic-addon1"">
                    </div>
                    <div class=""form-group"">
                        <label for");
            WriteLiteral(@"=""exampleInputPassword1"">Password</label>
                        <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"" name=""PasswordAd"">
                    </div>
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">FullName</label>
                        <input type=""text"" class=""form-control"" placeholder=""FullName"" aria-label=""FullName"" aria-describedby=""basic-addon1"" name=""FullnameAd"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Email</label>
                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter email"" name=""EmailAd"">
                    </div>
                    <div class=""group"">
                        <label for=""recipient-name"" class=""col-form-label"">Avatar</label>
                        <input type=""file"" name=""");
            WriteLiteral(@"AvatarAd"" id=""fileToUpload"">
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Add</button>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 42 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Partials\ThemAd.cshtml"
}

#line default
#line hidden
            BeginContext(2677, 82, true);
            WriteLiteral("<script src=\"https://cdn.ckeditor.com/4.11.3/standard/ckeditor.js\"></script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
