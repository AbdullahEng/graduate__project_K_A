#pragma checksum "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20ddafe0a73affd9109afb06f625921d8c84b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdmissionSystem.Pages.Studen.Views_Studen_Index), @"mvc.1.0.view", @"/Views/Studen/Index.cshtml")]
namespace AdmissionSystem.Pages.Studen
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
#line 1 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using AdmissionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using AdmissionSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20ddafe0a73affd9109afb06f625921d8c84b1e", @"/Views/Studen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792ef5c687352aadb354ab4da2dda25055305126", @"/Views/_ViewImports.cshtml")]
    public class Views_Studen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdmissionSystem.Model.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20ddafe0a73affd9109afb06f625921d8c84b1e4383", async() => {
#nullable restore
#line 14 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
                      Write(localizer["Create New"]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.high_school_certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Father_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grandfather_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mother_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Father_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grandfather_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mother_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nick_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Marital_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Civil_Registriation_City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Civil_Registrition_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Passport_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Identity_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Full_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Current_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Home_s_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Identity_front_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Identity_back_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 101 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.high_school_certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.First_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Father_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grandfather_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mother_Name_AR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.First_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 126 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Father_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 129 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grandfather_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 132 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mother_Name_EN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 135 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nick_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 138 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 141 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 144 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 147 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Marital_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 150 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civil_Registriation_City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 153 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civil_Registrition_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 156 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Passport_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 159 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Identity_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 162 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Full_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 165 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 168 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Current_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 171 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mobile_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 174 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Home_s_Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 177 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Identity_front_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 180 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Identity_back_image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 183 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 184 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 185 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                    ");
#nullable restore
#line 186 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
               Write(Html.ActionLink("WishesSelection", "WishesSelection", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 189 "C:\Users\Abdullah Darwish\Desktop\tesss4\khaloooooood\AdmissionSystem\AdmissionSystem\Views\Studen\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdmissionSystem.Model.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
