#pragma checksum "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a5f2814959629b0bf788be440005f49b52bd4a6073de47c5ef37a4a34138c178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_XoaAd), @"mvc.1.0.view", @"/Views/Admin/XoaAd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/XoaAd.cshtml", typeof(AspNetCore.Views_Admin_XoaAd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a5f2814959629b0bf788be440005f49b52bd4a6073de47c5ef37a4a34138c178", @"/Views/Admin/XoaAd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_XoaAd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reviewer.Models.Data.Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
  
    ViewData["Title"] = "XoaAd";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(128, 141, true);
            WriteLiteral("<h2> Xoá ADMIN</h2>\r\n<div>\r\n    <h3>Bạn có chắc chắn muốn xoá???</h3>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(270, 46, false);
#line 12 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.UsernameAd));

#line default
#line hidden
            EndContext();
            BeginContext(316, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(362, 42, false);
#line 16 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayFor(model => model.UsernameAd));

#line default
#line hidden
            EndContext();
            BeginContext(404, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(450, 46, false);
#line 20 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordAd));

#line default
#line hidden
            EndContext();
            BeginContext(496, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(542, 42, false);
#line 24 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayFor(model => model.PasswordAd));

#line default
#line hidden
            EndContext();
            BeginContext(584, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(630, 46, false);
#line 28 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.FullnameAd));

#line default
#line hidden
            EndContext();
            BeginContext(676, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(722, 42, false);
#line 32 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayFor(model => model.FullnameAd));

#line default
#line hidden
            EndContext();
            BeginContext(764, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(810, 43, false);
#line 36 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAd));

#line default
#line hidden
            EndContext();
            BeginContext(853, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(899, 39, false);
#line 40 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayFor(model => model.EmailAd));

#line default
#line hidden
            EndContext();
            BeginContext(938, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(984, 44, false);
#line 44 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.AvatarAd));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 64, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <img />\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1093, 43, false);
#line 50 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1182, 39, false);
#line 54 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayFor(model => model.IsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1267, 43, false);
#line 58 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayNameFor(model => model.Allowed));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1356, 39, false);
#line 62 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.DisplayFor(model => model.Allowed));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 32, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
            EndContext();
#line 67 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
     using (Html.BeginForm("XoaAd", "Admin", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(1507, 23, false);
#line 69 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1534, 135, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(1670, 40, false);
#line 73 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 75 "C:\Users\admin\Desktop\Đồ Án Cơ Sở\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\XoaAd.cshtml"
    }

#line default
#line hidden
            BeginContext(1735, 16, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reviewer.Models.Data.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
