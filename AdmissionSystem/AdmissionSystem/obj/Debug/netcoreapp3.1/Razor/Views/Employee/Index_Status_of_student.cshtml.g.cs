#pragma checksum "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626ad9a64d3845256106fd56a003ee03be86a119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdmissionSystem.Pages.Employee.Views_Employee_Index_Status_of_student), @"mvc.1.0.view", @"/Views/Employee/Index_Status_of_student.cshtml")]
namespace AdmissionSystem.Pages.Employee
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
#line 1 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using AdmissionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\_ViewImports.cshtml"
using AdmissionSystem.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626ad9a64d3845256106fd56a003ee03be86a119", @"/Views/Employee/Index_Status_of_student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792ef5c687352aadb354ab4da2dda25055305126", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index_Status_of_student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdmissionSystem.Model.Statues_Of_Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
  
    ViewData["Title"] = "Index_Status_of_student";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index_Status_of_student</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.Date_of_Acshiving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.Checked_recipet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.Checked_Identity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.Checked_city_certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.Checked_Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayNameFor(model => model.FK_Student_InfoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date_of_Acshiving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.Checked_recipet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.Checked_Identity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.Checked_city_certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.Checked_Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.DisplayFor(modelItem => item.FK_Student_InfoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.ActionLink("Edit", "Edit_Status_of_student", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 65 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 66 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\planet\Desktop\final project\Our_Project_love_you\AdmissionSystem\AdmissionSystem\Views\Employee\Index_Status_of_student.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdmissionSystem.Model.Statues_Of_Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591