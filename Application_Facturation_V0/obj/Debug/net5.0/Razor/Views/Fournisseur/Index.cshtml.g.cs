#pragma checksum "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74242936912a76237e75433ed1f4b6ab03a7dd1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fournisseur_Index), @"mvc.1.0.view", @"/Views/Fournisseur/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\_ViewImports.cshtml"
using Application_Facturation_V0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\_ViewImports.cshtml"
using Application_Facturation_V0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74242936912a76237e75433ed1f4b6ab03a7dd1b", @"/Views/Fournisseur/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588ec3e005e729e962d02c6bca23236db9d62846", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Fournisseur_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fournisseur>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/flaticon/close-0.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74242936912a76237e75433ed1f4b6ab03a7dd1b4338", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""../assets/img/apple-icon.png"">
    <link rel=""icon"" type=""image/png"" href=""../assets/img/favicon.png"">
    <title>
        Argon Dashboard 2 by Creative Tim
    </title>
    <!--     Fonts and icons     -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700"" rel=""stylesheet"" />
    <!-- Nucleo Icons -->
    <link href=""../assets/css/nucleo-icons.css"" rel=""stylesheet"" />
    <link href=""../assets/css/nucleo-svg.css"" rel=""stylesheet"" />
    <!-- Font Awesome Icons -->
    <script src=""https://kit.fontawesome.com/42d5adcbca.js"" crossorigin=""anonymous""></script>
    <link href=""../assets/css/nucleo-svg.css"" rel=""stylesheet"" />
    <!-- CSS Files -->
    <link id=""pagestyle"" href=""../assets/css/argon-dashboard.css?v=2.0.4"" rel=""stylesheet"" />
    <!-- SCRIPT -->
    <link src=""https://cdnjs.clo");
                WriteLiteral("udflare.com/ajax/libs/jquery/3.7.0/jquery.min.js\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74242936912a76237e75433ed1f4b6ab03a7dd1b6466", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card mb-4"">
                <div class=""card-header pb-0"">
                    <h6>Tableau des Fournisseurs</h6>
                    <!-- Button trigger modal -->
                    <button type=""button"" class=""btn bg-gradient-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                        Ajouter Fournisseur
                    </button>

                    <!-- Modal -->
                    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ajouter Fournisseur</h5>
                                    <button type=""button"" class=""btn-cl");
                WriteLiteral("ose\" data-bs-dismiss=\"modal\" aria-label=\"Close\" style=\"margin-right:10px;margin-bottom:10px\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "74242936912a76237e75433ed1f4b6ab03a7dd1b7967", async() => {
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
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"" id=""mod"">

                                    ");
#nullable restore
#line 53 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                               Write(Html.Partial("Create_PopUP",new Fournisseur()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                                
                            </div>
                        </div>
                    </div>

                </div>

                <div class=""card-body px-0 pt-0 pb-2"">
                    <div class=""table-responsive p-0"">
                        <table class=""table align-items-center mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Nom</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Address</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Telephone</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Code Postal</th>
        ");
                WriteLiteral(@"                            <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Ville</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Action</th>

                                    <th class=""text-secondary opacity-7""></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 78 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <tr>
                                            <td>
                                                <div class=""d-flex px-2 py-1"">
                                                    <div>
                                                    <img src=""../assets/flaticon/supplier_1.png"" style=""margin-right:20px;"" alt=""user1"">
                                                    </div>
                                                    <div class=""d-flex flex-column justify-content-center"">
                                                        <h6 class=""mb-0 text-sm"">");
#nullable restore
#line 87 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                            Write(item.nom);

#line default
#line hidden
#nullable disable
                WriteLiteral("  #");
#nullable restore
#line 87 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                        Write(item.identifiant_unique);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                                        <p class=\"text-xs text-secondary mb-0\">");
#nullable restore
#line 88 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                          Write(item.matricule_fiscale);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                                    </div>
                                                </div>
                                            </td>
                                        <td class=""align-middle text-center text-sm"">
                                                <p class=""text-xs font-weight-bold mb-0"">");
#nullable restore
#line 93 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                    Write(item.address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                                            </td>\r\n                                            <td class=\"align-middle text-center text-sm\">\r\n                                            <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 97 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                             Write(item.telephone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"align-middle text-center\">\r\n                                                <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 100 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                                 Write(item.code_postal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            </td>\r\n                                        <td class=\"align-middle text-center\">\r\n                                            <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 103 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                             Write(item.ville);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                        </td>
                                        <td class=""align-middle text-center text-sm"">
                                            
                                                <button type=""button"" class=""btn bg-gradient-primary"" data-bs-toggle=""modal"" data-bs-target=""");
#nullable restore
#line 107 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                                                                         Write("#editModal-"+item.fournisseur_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-url=\"");
#nullable restore
#line 107 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                                                                                                                        Write(Url.Action($"EditPartial/{item.fournisseur_id}"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                <i class=""fas fa-edit"">  </i>
                                                </button>

                                            <button type=""button"" class=""btn bg-gradient-danger"" data-bs-toggle=""modal"" data-bs-target=""");
#nullable restore
#line 111 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                                                                    Write("#deleteModal-"+item.fournisseur_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-url=\"");
#nullable restore
#line 111 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                                                                                                                                                                     Write(Url.Action($"DeletePartial/{item.fournisseur_id}"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                <i class=""fas fa-trash"">  </i>

                                            </button>
                                                <!--<form action=""Delete"" style=""display:inline;"">
                                                <button type=""submit"" class=""btn bg-gradient-danger"" asp-action=""Delete"" asp-route-id=""item.fournisseur_id"">
                                                     <i class=""fas fa-trash"">  </i>
                                            </button></form>-->
                                            ");
#nullable restore
#line 119 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                       Write(await Html.PartialAsync("DeletePartial",item));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 120 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                       Write(await Html.PartialAsync("_EditF",item));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            <!-- Edit Modal -->\r\n\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 125 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Fournisseur\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--   Core JS Files   -->
    <script src=""../assets/js/core/popper.min.js""></script>
    <script src=""../assets/js/core/bootstrap.min.js""></script>
    <script src=""../assets/js/plugins/perfect-scrollbar.min.js""></script>
    <script src=""../assets/js/plugins/smooth-scrollbar.min.js""></script>
    <script src=""../assets/js/plugins/chartjs.min.js""></script>

    <script>
        // JavaScript/jQuery code to handle ""Edit"" button click and populate the modal
        $(document).ready(function () {
            $('.edit-btn').click(function () {
                var clientId = $(this).data('client-id');
                var clientName = $(this).data('client-name');
                var clientEmail = $(this).data('client-email');

                // Populate the modal with the data
                $('#mod').load('/YourControl");
                WriteLiteral(@"ler/EditPartial?clientId=' + clientId + '&clientName=' + clientName + '&clientEmail=' + clientEmail);
            });
        });
    </script>
    <!-- Github buttons -->
    <script async defer src=""https://buttons.github.io/buttons.js""></script>
    <!-- Control Center for Soft Dashboard: parallax effects, scripts for the example pages etc -->
    <script src=""../assets/js/argon-dashboard.min.js?v=2.0.4""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fournisseur>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
