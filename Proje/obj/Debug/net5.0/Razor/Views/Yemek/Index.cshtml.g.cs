#pragma checksum "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0283b8fbeb397b972f3998cb1b2fcfda4e472601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yemek_Index), @"mvc.1.0.view", @"/Views/Yemek/Index.cshtml")]
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
#line 1 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\_ViewImports.cshtml"
using Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\_ViewImports.cshtml"
using Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0283b8fbeb397b972f3998cb1b2fcfda4e472601", @"/Views/Yemek/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e37cf2bec43e5c361f9f4588e9dc3e4cf719ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Yemek_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proje.Models.Yemek>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0283b8fbeb397b972f3998cb1b2fcfda4e4726014974", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tarif));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Resim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KacKisilik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HazirlikSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PisirmeSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YuklemeTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 37 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kategori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 43 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tarif));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0283b8fbeb397b972f3998cb1b2fcfda4e4726019541", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
              WriteLiteral(Url.Content(item.Resim));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 53 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KacKisilik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HazirlikSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 62 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PisirmeSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 65 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YuklemeTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 68 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kategori.KategoriAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0283b8fbeb397b972f3998cb1b2fcfda4e47260113206", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0283b8fbeb397b972f3998cb1b2fcfda4e47260115358", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0283b8fbeb397b972f3998cb1b2fcfda4e47260117516", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 76 "C:\Users\elifr\Desktop\web\web-proje\Proje\Views\Yemek\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    function SetCulture(selectedValue) {
        alert(selectedValue);
        var url = window.location.href.split('?')[0];
        var culture = ""?culture="" + selectedValue + ""&ui-culture="" + selectedValue;
        window.location.href = url + culture;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proje.Models.Yemek>> Html { get; private set; }
    }
}
#pragma warning restore 1591
