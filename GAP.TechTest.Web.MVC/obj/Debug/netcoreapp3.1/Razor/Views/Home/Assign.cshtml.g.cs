#pragma checksum "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8d1337e446ad9ede9a7ce69fe8189a091d69dab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Assign), @"mvc.1.0.view", @"/Views/Home/Assign.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d1337e446ad9ede9a7ce69fe8189a091d69dab", @"/Views/Home/Assign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5285d942ae68650ec02d37af295a5af156f851b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Assign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GAP.TechTest.Web.MVC.Models.AssignModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
   ViewData["Title"] = "Edit Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
 using (Html.BeginForm("AssignSave", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
Write(Html.HiddenFor(model => model.InsurancePolicyId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""modal-body"">
                    <ul class=""nav nav-tabs"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""tab"" role=""tab"" href=""#edit-user-details"">Poliza</a>
                        </li>
                    </ul>
                    <div class=""tab-content mt-4"">                       
                        <div role=""tabpanel"" class=""tab-pane container active"" id=""edit-user-details"">
                            <div class=""form-group row required"">
                                <label class=""col-md-3 col-form-label"" for=""name"">Nombre Poliza</label>
                                <div class=""col-md-9"">
                                    ");
#nullable restore
#line 18 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
                               Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row required"">
                                <label class=""col-md-3 col-form-label"" for=""description"">Descripcion</label>
                                <div class=""col-md-9"">
                                    ");
#nullable restore
#line 24 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
                               Write(Html.DropDownListFor(model => model.Name, new SelectList(ViewBag.Users, "Value", "Text")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            
                        </div>



                        <div class=""row margin-bottom-thick"">
                            <div class=""col-sm-1 col-sm-pull-1 textAlignLeftCenter"">
                                ");
#nullable restore
#line 34 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
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
                </div>");
#nullable restore
#line 43 "C:\code\GAP - OZ\GAP.TechTest.Web.MVC\Views\Home\Assign.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GAP.TechTest.Web.MVC.Models.AssignModel> Html { get; private set; }
    }
}
#pragma warning restore 1591