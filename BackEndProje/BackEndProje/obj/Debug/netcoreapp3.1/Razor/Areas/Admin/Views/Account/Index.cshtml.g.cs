#pragma checksum "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4255495418082e7b5b8360197bd1938a069ce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProje.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProje.DATA;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4255495418082e7b5b8360197bd1938a069ce2", @"/Areas/Admin/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ffad9a2c1c50ff90e0fcb122c526ab213eb0e11", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bg-primary text-white p-1 m-1\">\r\n    <h2>User List</h2>\r\n</div>\r\n\r\n<table class=\"table table-bordered table-striped m-1 p-1\">\r\n    <tr>\r\n        <th> User Id</th>\r\n        <th> User Name</th>\r\n        <th> Email</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
     if (Model.Count()==0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td colspan=\"3\" class=\"text-center\">\r\n   No Users\r\n    </td>\r\n    \r\n    \r\n</tr>\r\n");
#nullable restore
#line 26 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
    }
    else
    {
        foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
   Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
   Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 37 "C:\Users\User\Desktop\Back-End Project\BackEndProje\BackEndProje\Areas\Admin\Views\Account\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
