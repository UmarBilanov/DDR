#pragma checksum "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307eb0a0f999944f25dc1403801a8b980e6140fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DiamondDrillingReport.Pages.Holes.Pages_Holes_Details), @"mvc.1.0.razor-page", @"/Pages/Holes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Holes/Details.cshtml", typeof(DiamondDrillingReport.Pages.Holes.Pages_Holes_Details), null)]
namespace DiamondDrillingReport.Pages.Holes
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
#line 3 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"307eb0a0f999944f25dc1403801a8b980e6140fb", @"/Pages/Holes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94caee2b91c2570f844f8f8eb5f0b7f24eeba70", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Holes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(142, 15, true);
            WriteLiteral("<div>\r\n    <h4>");
            EndContext();
            BeginContext(158, 17, false);
#line 6 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
   Write(Localizer["Hole"]);

#line default
#line hidden
            EndContext();
            BeginContext(175, 77, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(253, 49, false);
#line 10 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.HoleCode));

#line default
#line hidden
            EndContext();
            BeginContext(302, 64, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsHoleCode\">\r\n            ");
            EndContext();
            BeginContext(367, 45, false);
#line 13 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.HoleCode));

#line default
#line hidden
            EndContext();
            BeginContext(412, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(456, 52, false);
#line 16 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ProjectCode));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(552, 48, false);
#line 19 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ProjectCode));

#line default
#line hidden
            EndContext();
            BeginContext(600, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(644, 49, false);
#line 22 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.HoleZone));

#line default
#line hidden
            EndContext();
            BeginContext(693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(737, 50, false);
#line 25 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.HoleZone.Name));

#line default
#line hidden
            EndContext();
            BeginContext(787, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(831, 46, false);
#line 28 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.Drill));

#line default
#line hidden
            EndContext();
            BeginContext(877, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsDrill\">\r\n            ");
            EndContext();
            BeginContext(939, 52, false);
#line 31 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.Drill.DrillCode));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1035, 53, false);
#line 34 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.DrillProgram));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 68, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsDrillProgram\">\r\n            ");
            EndContext();
            BeginContext(1157, 54, false);
#line 37 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.DrillProgram.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1255, 50, false);
#line 40 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.HoleDepth));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 65, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsHoleDepth\">\r\n            ");
            EndContext();
            BeginContext(1371, 46, false);
#line 43 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.HoleDepth));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1461, 47, false);
#line 46 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.Azimut));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 58, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsAz\">\r\n            ");
            EndContext();
            BeginContext(1567, 43, false);
#line 49 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.Azimut));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1654, 44, false);
#line 52 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.Dip));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 59, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsDip\">\r\n            ");
            EndContext();
            BeginContext(1758, 40, false);
#line 55 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.Dip));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1842, 48, false);
#line 58 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.Section));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1934, 44, false);
#line 61 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.Section));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2022, 50, false);
#line 64 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ZeroDatum));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2116, 46, false);
#line 67 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ZeroDatum));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2206, 54, false);
#line 70 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.HoleStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 65, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsStartDate\">\r\n            ");
            EndContext();
            BeginContext(2326, 50, false);
#line 73 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.HoleStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2420, 51, false);
#line 76 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.HoleStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2471, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"DetailsStatus\">\r\n            ");
            EndContext();
            BeginContext(2534, 52, false);
#line 79 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.HoleStatus.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2630, 60, false);
#line 82 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ProjectCoordinatesX));

#line default
#line hidden
            EndContext();
            BeginContext(2690, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2734, 56, false);
#line 85 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ProjectCoordinatesX));

#line default
#line hidden
            EndContext();
            BeginContext(2790, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2834, 60, false);
#line 88 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ProjectCoordinatesY));

#line default
#line hidden
            EndContext();
            BeginContext(2894, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2938, 56, false);
#line 91 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ProjectCoordinatesY));

#line default
#line hidden
            EndContext();
            BeginContext(2994, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3038, 60, false);
#line 94 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ProjectCoordinatesZ));

#line default
#line hidden
            EndContext();
            BeginContext(3098, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3142, 56, false);
#line 97 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ProjectCoordinatesZ));

#line default
#line hidden
            EndContext();
            BeginContext(3198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3242, 58, false);
#line 100 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ActualCoordinateX));

#line default
#line hidden
            EndContext();
            BeginContext(3300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3344, 54, false);
#line 103 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ActualCoordinateX));

#line default
#line hidden
            EndContext();
            BeginContext(3398, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3442, 58, false);
#line 106 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ActualCoordinateY));

#line default
#line hidden
            EndContext();
            BeginContext(3500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3544, 54, false);
#line 109 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ActualCoordinateY));

#line default
#line hidden
            EndContext();
            BeginContext(3598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3642, 58, false);
#line 112 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hole.ActualCoordinateZ));

#line default
#line hidden
            EndContext();
            BeginContext(3700, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3744, 54, false);
#line 115 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hole.ActualCoordinateZ));

#line default
#line hidden
            EndContext();
            BeginContext(3798, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3845, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72474ef73e2b4a32a81cb17a3d443edf", async() => {
                BeginContext(3897, 17, false);
#line 120 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
                                                  Write(Localizer["Edit"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
                           WriteLiteral(Model.Hole.ID);

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
            BeginContext(3918, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3926, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b128720fdbc42a6bdd26840c838182e", async() => {
                BeginContext(3949, 25, false);
#line 121 "C:\Users\Askartec\Documents\diamonddrillingreport\Diamond_drilling_report\DiamondDrillingReport\Pages\Holes\Details.cshtml"
                     Write(Localizer["Back to List"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3978, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiamondDrillingReport.Pages.Holes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DiamondDrillingReport.Pages.Holes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DiamondDrillingReport.Pages.Holes.DetailsModel>)PageContext?.ViewData;
        public DiamondDrillingReport.Pages.Holes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
