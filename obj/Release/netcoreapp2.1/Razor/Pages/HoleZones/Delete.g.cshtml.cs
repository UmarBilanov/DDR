#pragma checksum "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59f2216a92531d297b6b9bcbc35c62779778e6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DiamondDrillingReport.Pages.HoleZones.Pages_HoleZones_Delete), @"mvc.1.0.razor-page", @"/Pages/HoleZones/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/HoleZones/Delete.cshtml", typeof(DiamondDrillingReport.Pages.HoleZones.Pages_HoleZones_Delete), null)]
namespace DiamondDrillingReport.Pages.HoleZones
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\_ViewImports.cshtml"
using DiamondDrillingReport;

#line default
#line hidden
#line 3 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59f2216a92531d297b6b9bcbc35c62779778e6de", @"/Pages/HoleZones/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94caee2b91c2570f844f8f8eb5f0b7f24eeba70", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HoleZones_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 67, true);
            WriteLiteral("<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-sm-9\">\r\n        <h3>");
            EndContext();
            BeginContext(213, 50, false);
#line 8 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
       Write(Localizer["Are you sure you want to delete this?"]);

#line default
#line hidden
            EndContext();
            BeginContext(263, 38, true);
            WriteLiteral("</h3>\r\n        <div>\r\n            <h4>");
            EndContext();
            BeginContext(302, 21, false);
#line 10 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
           Write(Localizer["HoleZone"]);

#line default
#line hidden
            EndContext();
            BeginContext(323, 109, true);
            WriteLiteral("</h4>\r\n            <hr />\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(433, 49, false);
#line 14 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.HoleZone.Name));

#line default
#line hidden
            EndContext();
            BeginContext(482, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(550, 45, false);
#line 17 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
               Write(Html.DisplayFor(model => model.HoleZone.Name));

#line default
#line hidden
            EndContext();
            BeginContext(595, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(663, 51, false);
#line 20 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.HoleZone.AreaID));

#line default
#line hidden
            EndContext();
            BeginContext(714, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(782, 50, false);
#line 23 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
               Write(Html.DisplayFor(model => model.HoleZone.Area.Name));

#line default
#line hidden
            EndContext();
            BeginContext(832, 58, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n            ");
            EndContext();
            BeginContext(890, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ed5fc7efa74427bdf70dff8286fb27", async() => {
                BeginContext(910, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(928, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ac827bb569c4521bb40e58db41fcd6f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoleZone.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(973, 38, true);
                WriteLiteral("\r\n                <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1011, "\"", 1039, 1);
#line 29 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
WriteAttributeValue("", 1019, Localizer["Delete"], 1019, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1040, 41, true);
                WriteLiteral(" class=\"btn btn-default\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1088, 134, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-3\">\r\n        <button type=\"button\" id=\"btnQueryStringBack\" class=\"btn btn-block\">");
            EndContext();
            BeginContext(1223, 17, false);
#line 34 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\HoleZones\Delete.cshtml"
                                                                       Write(Localizer["BACK"]);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 43, true);
            WriteLiteral("</button><br /><br />\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1301, 31, true);
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiamondDrillingReport.Pages.HoleZones.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DiamondDrillingReport.Pages.HoleZones.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DiamondDrillingReport.Pages.HoleZones.DeleteModel>)PageContext?.ViewData;
        public DiamondDrillingReport.Pages.HoleZones.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
