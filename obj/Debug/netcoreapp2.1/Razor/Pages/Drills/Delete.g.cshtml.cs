#pragma checksum "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432d8ab95e33b1f9753ff3a9920c38577288715f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DiamondDrillingReport.Pages.Drills.Pages_Drills_Delete), @"mvc.1.0.razor-page", @"/Pages/Drills/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Drills/Delete.cshtml", typeof(DiamondDrillingReport.Pages.Drills.Pages_Drills_Delete), null)]
namespace DiamondDrillingReport.Pages.Drills
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
#line 3 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432d8ab95e33b1f9753ff3a9920c38577288715f", @"/Pages/Drills/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94caee2b91c2570f844f8f8eb5f0b7f24eeba70", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Drills_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(142, 67, true);
            WriteLiteral("<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-sm-9\">\r\n        <h3>");
            EndContext();
            BeginContext(210, 50, false);
#line 8 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
       Write(Localizer["Are you sure you want to delete this?"]);

#line default
#line hidden
            EndContext();
            BeginContext(260, 38, true);
            WriteLiteral("</h3>\r\n        <div>\r\n            <h4>");
            EndContext();
            BeginContext(299, 18, false);
#line 10 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
           Write(Localizer["Drill"]);

#line default
#line hidden
            EndContext();
            BeginContext(317, 109, true);
            WriteLiteral("</h4>\r\n            <hr />\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(427, 51, false);
#line 14 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Drill.DrillCode));

#line default
#line hidden
            EndContext();
            BeginContext(478, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(546, 47, false);
#line 17 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Drill.DrillCode));

#line default
#line hidden
            EndContext();
            BeginContext(593, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(661, 50, false);
#line 20 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Drill.DrillNum));

#line default
#line hidden
            EndContext();
            BeginContext(711, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(779, 46, false);
#line 23 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Drill.DrillNum));

#line default
#line hidden
            EndContext();
            BeginContext(825, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(893, 53, false);
#line 26 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Drill.DrillColour));

#line default
#line hidden
            EndContext();
            BeginContext(946, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1014, 49, false);
#line 29 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Drill.DrillColour));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1131, 54, false);
#line 32 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Drill.Modification));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1253, 50, false);
#line 35 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Drill.Modification));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1371, 51, false);
#line 38 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Drill.DrillName));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1490, 47, false);
#line 41 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Drill.DrillName));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1605, 47, false);
#line 44 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Drill.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1720, 43, false);
#line 47 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Drill.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 58, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n            ");
            EndContext();
            BeginContext(1821, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b63d33476428480b9637df829c6e4328", async() => {
                BeginContext(1841, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1859, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb0b863161bc427991e849f24cab62f6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 52 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Drill.ID);

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
                BeginContext(1901, 38, true);
                WriteLiteral("\r\n                <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1939, "\"", 1967, 1);
#line 53 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
WriteAttributeValue("", 1947, Localizer["Delete"], 1947, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1968, 41, true);
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
            BeginContext(2016, 134, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-3\">\r\n        <button type=\"button\" id=\"btnQueryStringBack\" class=\"btn btn-block\">");
            EndContext();
            BeginContext(2151, 17, false);
#line 58 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Drills\Delete.cshtml"
                                                                       Write(Localizer["BACK"]);

#line default
#line hidden
            EndContext();
            BeginContext(2168, 43, true);
            WriteLiteral("</button><br /><br />\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2229, 31, true);
                WriteLiteral("\r\n    <script>\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(2263, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiamondDrillingReport.Pages.Drills.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DiamondDrillingReport.Pages.Drills.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DiamondDrillingReport.Pages.Drills.DeleteModel>)PageContext?.ViewData;
        public DiamondDrillingReport.Pages.Drills.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
