#pragma checksum "D:\RokonoControl\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc5da162875f1710d203595f85d7022137bb90c"
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
#line 1 "D:\RokonoControl\Views\_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RokonoControl\Views\_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc5da162875f1710d203595f85d7022137bb90c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Logo/logo_transparent.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\RokonoControl\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Authenticationw card start -->
<div class=""login-card card-block auth-body"" style=""padding: 23%; margin-left:15%; margin-right:15%;"">

    <div class=""auth-box"" style=""background-color:#3553575c; padding:5%;"">
        <div class=""row"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bdc5da162875f1710d203595f85d7022137bb90c4133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <hr />
        <div class=""input-group"" style=""display: inline;"">
            <input id=""exampleEmail11"" type=""email"" class=""form-control"" placeholder=""Your Email Address"" style=""color:red;border-color:red; background-color:#123f56;"">
            <span class=""md-line""></span>
        </div>
        <div class=""input-group"" style=""display: inline;"">
            <input id=""examplePassword11"" type=""password"" class=""form-control"" placeholder=""Password"" style=""color:red;border-color:red; background-color:#123f56;"">
            <span class=""md-line""></span>
        </div>
        <div class=""row m-t-25 text-left"">
            <div class=""col-sm-7 col-xs-12"">
                <div class=""checkbox-fade fade-in-primary"">
                    <label>
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1203, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color:azure;"">
                        <span class=""cr""><i class=""cr-icon icofont icofont-ui-check txt-primary""></i></span>
                        <span class=""text-inverse"" style=""color:azure;"">Remember me</span>
                    </label>
                </div>
            </div>

        </div>
        <div class=""row m-t-30"">
            <div class=""col-md-12"" style=""text-align:center;"">
                <button type=""button"" id=""loginBtn"" onclick=""LoginUser()"">Sign in</button>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-md-10"">
                <p class=""text-inverse text-left m-b-0"" style=""text-align:center;color: azure;"">Thank you and enjoy our website.</p>
                <p class=""text-inverse text-left"" style=""text-align:center;color: azure;""><b>Your Autentification Team</b></p>
            </div>

        </div>

    </div>

    <!-- end of form -->
</div>
<!-- Authentication card end -->
<style>
    .e-");
            WriteLiteral(@"float-input e-control-wrapper e-outline {
        color: red;
    }

    .form-control e-control e-textbox e-lib {
        border: 0;
        border-width: 0;
        color: red;
    }
</style>
<script>
    var loginBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    loginBtn.appendTo('#loginBtn');

    var exampleEmail11 = new ej.inputs.TextBox({
        placeholder: 'Email',
        cssClass: 'e-outline',
        floatLabelType: 'Auto'
    });
    exampleEmail11.appendTo('#exampleEmail11');
    var examplePassword11 = new ej.inputs.TextBox({
        placeholder: 'Password',
        cssClass: 'e-outline',
        floatLabelType: 'Auto'
    });
    examplePassword11.appendTo('#examplePassword11');
    $(document).ready(function () {
        $.ajax({
            type: 'GET',
            url: '/Authenication/GetUsers',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
    ");
            WriteLiteral(@"            LoadAccounts(response);
            },
            error: function (xhr, status, error) {

            }
        });

    });
    function LoginUser() {
        console.log(""In"");
        var dto = {
            ""Email"": $(""#exampleEmail11"").val(),
            ""Password"": $(""#examplePassword11"").val(),

        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Authenication/Login',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                window.location = '/Dashboard/Index';
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
