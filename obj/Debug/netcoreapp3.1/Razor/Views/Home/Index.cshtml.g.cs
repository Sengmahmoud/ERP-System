#pragma checksum "D:\bacup\Projects\ERP\ERP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af125b431c68dd55662f0703662b6f5487715bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\bacup\Projects\ERP\ERP\Views\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\bacup\Projects\ERP\ERP\Views\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af125b431c68dd55662f0703662b6f5487715bbb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a75ba6acbf59262aafe8919fa59d5c332bbb5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERP.ViewModels.AccountViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ClientsList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AccountId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("selectClient show-tick form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("run3()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\bacup\Projects\ERP\ERP\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "_Layout";
    decimal totalcridit = 0;
    decimal totaldepit = 0;
    decimal total = totalcridit - totaldepit;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-6\">\r\n            <label>Clients</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af125b431c68dd55662f0703662b6f5487715bbb4921", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af125b431c68dd55662f0703662b6f5487715bbb5197", async() => {
                    WriteLiteral("اختر الحساب");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 17 "D:\bacup\Projects\ERP\ERP\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.Accounts, "AccountId", "AcNameAr" ));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n           \r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label>الرصيد الكلى</label>\r\n            <input disabled id=\"tot\" type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 774, "\"", 782, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""form-group row"">

        <div class=""col-md-6"">
            <label>من</label>
            <input id=""ffdate""  name=""fromdate"" type=""date"" class=""form-control""  onchange=""run1()"" />
        
        </div>
        <div class=""col-md-6"">
            <label>إلى</label>
            <input id=""ttdate"" name=""todate"" type=""date"" class=""form-control"" onchange=""run2()""/>
           
        </div>
    </div>

    <div class=""form-group row"">

        <div class=""col-md-6"">
            <button type=""button"" class=""btn btn-outline-primary""><a href=""javascript:void(0);"" class=""anchorDetail"">عرض التفاصيل</a></button>
          
        </div>
        <div class=""col-md-6"">

        </div>
    </div>




<div class=""col-md-12"">
    <table id=""dtBasicExample"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
                
                <th class=""th-sm"">
                  ");
            WriteLiteral(@" التاريخ

                </th>
                <th class=""th-sm"">
                   الرصيد

                </th>

                <th class=""th-sm"">
                  مدين

                </th>
                <th class=""th-sm"">
                    دائن

                </th>
            </tr>
        </thead>
        <tbody>
          
        </tbody>
        <tfoot>
            <tr>
                <th class=""th-sm"">


                </th>
                <th class=""th-sm"">


                </th>
               
                    <th class=""th-sm"">
                        ");
#nullable restore
#line 95 "D:\bacup\Projects\ERP\ERP\Views\Home\Index.cshtml"
                   Write(totaldepit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </th>\r\n                    <th class=\"th-sm\">\r\n\r\n                      \r\n                    </th>\r\n                \r\n                </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

     

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.12/js/select2.full.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.12/css/select2.min.css"" />
    <script>
        $(document).ready(function () {
            $(""#ClientsList"").select2();
            });
    </script>

    <script>
          $("".anchorDetail"").click(function () {
            var _AccountId = document.getElementById(""ClientsList"").value;
            var _fromdate = document.getElementById(""ffdate"").value;
            var _todate = document.getElementById(""ttdate"").value;
            $('#dtBasicExample').DataTable({
                ""ajax"": {
                    'type': 'POST',
                    'data': { AccountId: _AccountId, fromdate: _fromdate, todate: _todate },
                    'dataType': ""json"",
                    ""url"": """);
#nullable restore
#line 132 "D:\bacup\Projects\ERP\ERP\Views\Home\Index.cshtml"
                       Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    ""dataSrc"": function (result) {
                        return result;
                    }
                },
                ""columns"": [
                    { ""data"": ""DueDate"" },
                    { ""data"": ""Notes"" },
                    { ""data"": ""Debit"" },
                    { ""data"": ""Credit"" }


                ],
                ""footerCallback"": function (tfoot, data, start, end, display) {
                    var api = this.api();
                    var p = api.column(3).data().reduce(function (a, b) {
                        return a + b;
                    }, 0)
                    $(api.column(3).footer()).html(p);

                    var t = api.column(2).data().reduce(function (c, d) {
                        return c + d;
                    }, 0)
                    $(api.column(2).footer()).html(t);
                    document.getElementById(""tot"").value = p - t;
                }
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERP.ViewModels.AccountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
