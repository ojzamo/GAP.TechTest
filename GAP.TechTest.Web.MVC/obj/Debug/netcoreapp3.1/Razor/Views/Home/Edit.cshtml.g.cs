#pragma checksum "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "200244203ef8922325853760d161a8042ae28413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\_ViewImports.cshtml"
using GAP.TechTest.Web.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\_ViewImports.cshtml"
using GAP.TechTest.Web.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200244203ef8922325853760d161a8042ae28413", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5285d942ae68650ec02d37af295a5af156f851b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GAP.TechTest.Web.MVC.Models.InsurancePolicyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml"
   ViewData["Title"] = "Edit Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml"
 using (Html.BeginForm("EditSave", "Home", FormMethod.Post))
{    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal-body"">
        <ul class=""nav nav-tabs"" role=""tablist"">
            <li class=""nav-item"">
                <a class=""nav-link active"" data-toggle=""tab"" role=""tab"" href=""#edit-user-details"">Poliza</a>
            </li>
        </ul>
        <div class=""tab-content mt-4"">
            ");
#nullable restore
#line 14 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml"
       Write(await Html.PartialAsync("_InsurancePolicy", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"row margin-bottom-thick\">\n                <div class=\"col-sm-1 col-sm-pull-1 textAlignLeftCenter\">\n                    ");
#nullable restore
#line 17 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml"
               Write(Html.ActionLink("Back", "Index", "Home", new { @class = "btn btn-primary-action" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <div class=""col-sm-1 col-sm-offset-2 col-sm-push-2 textAlignRightCenter"">
                    <input type=""submit"" id=""command"" name=""command"" class=""btn btn-primary"" value=""Guardar"" />
                </div>

            </div>
        </div>
    </div> 
");
#nullable restore
#line 27 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GAP.TechTest.Web.MVC.Models.InsurancePolicyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591