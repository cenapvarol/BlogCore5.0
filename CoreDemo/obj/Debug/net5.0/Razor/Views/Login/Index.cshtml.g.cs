#pragma checksum "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "564fdc7c390393986c01173a3af0a7984c72a0e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564fdc7c390393986c01173a3af0a7984c72a0e7", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--\r\n    Author: W3layouts\r\n    Author URL: http://w3layouts.com\r\n    License: Creative Commons Attribution 3.0 Unported\r\n    License URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "564fdc7c390393986c01173a3af0a7984c72a0e73546", async() => {
                WriteLiteral("\r\n    <section class=\"main-content-w3layouts-agileits\">\r\n        <div class=\"container\">\r\n            <h3 class=\"tittle\">Oturum Aç</h3>\r\n            <div class=\"row inner-sec\">\r\n                <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 24 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                    using (Html.BeginForm("Index", "Login", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 27 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   Write(Html.Label("Mail Adresi"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 29 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.WriterMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <small id=\"emailHelp\" class=\"form-text text-muted\">Biz mail adresini  kimseyle paylaşmayacağız.</small>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 35 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   Write(Html.Label("Şifre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 37 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   Write(Html.PasswordFor(x=>x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.WriterPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                        <div class=""form-check mb-2"">
                            <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                            <label class=""form-check-label"" for=""exampleCheck1"">Beni hatorla</label>
                        </div>
                        <button type=""submit"" class=""btn btn-primary submit mb-4"">Giriş Yap</button>
                        <p><a href=""/Register/Index/"">Bir hesabın yok mu?</a></p>
");
#nullable restore
#line 46 "D:\EgitimProjeleri\AspNetCore5.0\CoreDemo\Views\Login\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!--//main-->\r\n    <script src=\"js/bootstrap.js\"></script>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
