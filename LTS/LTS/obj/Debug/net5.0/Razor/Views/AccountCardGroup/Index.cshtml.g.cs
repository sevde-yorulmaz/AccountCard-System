#pragma checksum "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7aa11d19fc4d09d70983fd762aba51c661b7a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountCardGroup_Index), @"mvc.1.0.view", @"/Views/AccountCardGroup/Index.cshtml")]
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
#line 1 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\_ViewImports.cshtml"
using LTS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\_ViewImports.cshtml"
using LTS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd7aa11d19fc4d09d70983fd762aba51c661b7a5", @"/Views/AccountCardGroup/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f20d4872dfdee996573f436c6526528ba6720b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AccountCardGroup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AccountCardGroup>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountCardGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCardGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-orange btn-rounded waves-light waves-effect width-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Hesap Kart Grup</h1>
<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">

            <!-- start page title -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""page-title-box"">
                        <div class=""page-title-right"">
                            <ol class=""breadcrumb m-0"">
                                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd7aa11d19fc4d09d70983fd762aba51c661b7a55404", async() => {
                WriteLiteral("Hesap Kart Grup");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <h5 class=""header-title"">Hesap Kart Grup Listesi</h5>
                            <div class=""table-responsive"">

                                <br />
                                <table class=""table table-centered mb-0"" id=""btn-editable"">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Kart Grup Adı</th>
                                            <th>Durumu</th>
                                            <th>Düzenle</th>
                                            <th>Sil</th>
                                        </");
            WriteLiteral("tr>\r\n                                    </thead>\r\n\r\n                                    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 52 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 53 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
                                               Write(item.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 54 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                               \r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2316, "\"", 2363, 2);
            WriteAttributeValue("", 2323, "/AccountCardGroup/EditCardGroup/", 2323, 32, true);
#nullable restore
#line 56 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
WriteAttributeValue("", 2355, item.Id, 2355, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-icon waves-effect waves-light btn-warning\"> <i class=\"fas fa-wrench\"></i> </a></td>\r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2519, "\"", 2568, 2);
            WriteAttributeValue("", 2526, "/AccountCardGroup/DeleteCardGroup/", 2526, 34, true);
#nullable restore
#line 57 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
WriteAttributeValue("", 2560, item.Id, 2560, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-icon waves-effect waves-light btn-danger\"> <i class=\"fas fa-times\"></i> </a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd7aa11d19fc4d09d70983fd762aba51c661b7a510953", async() => {
                WriteLiteral("Yeni Hesap Kart Grup Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                            </div>
                            <!-- end .table-responsive-->
                        </div>
                        <!-- end card-body -->
                    </div>
                    <!-- end card -->
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->

        </div>
        <!-- end container-fluid -->

    </div>
    <!-- end content -->
    <!-- Footer Start -->
    <footer class=""footer"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    ");
#nullable restore
#line 86 "C:\Users\cemom\Desktop\LTS Yazılım\LTS\LTS\Views\AccountCardGroup\Index.cshtml"
               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &copy; Hesap Kart İşlemleri Sistemi <a href=\"#\">Sevde Yorulmaz</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n    <!-- end Footer -->\r\n\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AccountCardGroup>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591