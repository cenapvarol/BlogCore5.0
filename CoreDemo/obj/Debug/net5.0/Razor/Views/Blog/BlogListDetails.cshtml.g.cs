#pragma checksum "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d6a9213ef5eae43d79e9a50bdfa670a1507a4de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListDetails), @"mvc.1.0.view", @"/Views/Blog/BlogListDetails.cshtml")]
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
#line 1 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6a9213ef5eae43d79e9a50bdfa670a1507a4de", @"/Views/Blog/BlogListDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
  
    ViewData["Title"] = "BlogListDetails";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6a9213ef5eae43d79e9a50bdfa670a1507a4de5084", async() => {
                WriteLiteral(@"
    <!--//banner-->
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
");
#nullable restore
#line 19 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""blog-grid-top"">
                            <div class=""b-grid-top"">
                                <div class=""blog_info_left_grid"">
                                    <a href=""single.html"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d6a9213ef5eae43d79e9a50bdfa670a1507a4de6168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-info-middle"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 32 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
                                                                               Write(item.BlogCreateDate.ToString("MMMM .yyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </a>
                                        </li>
                                        <li class=""mx-2"">
                                            <a href=""#"">
                                                <i class=""far fa-thumbs-up""></i> 201 Beğeni
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-comment""></i> 15 Yorumlar
                                            </a>
                                        </li>

                                    </ul>
                                </div>
                            </div>

                            <h3>
                                ");
#nullable restore
#line 51 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
                           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 54 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
                           Write(item.BlogContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                            <a href=\"/Blog/Index\" class=\"btn btn-primary read-m\">Blog Listesi</a>\r\n                        </div>\r\n");
#nullable restore
#line 58 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
#nullable restore
#line 60 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlog",new {ViewBag.id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>

                <!--//left-->
                <!--right-->
                <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                    <div class=""right-blog-info text-left"">
                        <div class=""tech-btm"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d6a9213ef5eae43d79e9a50bdfa670a1507a4de11056", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 71 "D:\EgitimProjeleri\AspNetCore5Egitim\CoreDemo5\CoreDemo\Views\Blog\BlogListDetails.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""tech-btm"">
                            <h4>Categories</h4>
                            <ul class=""list-group single"">
                                <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                    Cras justo odio
                                    <span class=""badge badge-primary badge-pill"">14</span>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                    Dapibus ac facilisis in
                                    <span class=""badge badge-primary badge-pill"">2</span>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                    Morbi leo risus
                                    <span class=""badge badge-primary badge-pill"">1</span>
          ");
                WriteLiteral("                      </li>\r\n                            </ul>\r\n                        </div>\r\n");
                WriteLiteral(@"                        <div class=""single-gd my-5 tech-btm"">
                            <h4>Our Progress</h4>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
   ");
                WriteLiteral(@"                         </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                        </div>
                        <div class=""single-gd tech-btm"">
                            <h4>Recent Post</h4>
                            <div class=""blog-grids"">
                                <div class=""blog-grid-left"">
                                    <a href=""single.html"">
                                    ");
                WriteLiteral("    <img src=\"images/b1.jpg\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 6593, "\"", 6599, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-grid-right"">

                                    <h5>
                                        <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                    </h5>
                                </div>
                                <div class=""clearfix""> </div>
                            </div>
                        </div>
                    </div>

                </aside>
                <!--//right-->
            </div>
        </div>
    </section>
    <!--//main-->
    
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
