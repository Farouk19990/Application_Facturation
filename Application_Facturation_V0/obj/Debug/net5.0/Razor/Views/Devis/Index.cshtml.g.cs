#pragma checksum "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee4187ad6723b7be0d57b4584c1a25f954d38c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devis_Index), @"mvc.1.0.view", @"/Views/Devis/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee4187ad6723b7be0d57b4584c1a25f954d38c3", @"/Views/Devis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588ec3e005e729e962d02c6bca23236db9d62846", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Devis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Devis>>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee4187ad6723b7be0d57b4584c1a25f954d38c33425", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee4187ad6723b7be0d57b4584c1a25f954d38c35553", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card mb-4"">
                <div class=""card-header pb-0"">
                    <h6>Authors table</h6>
                    <!-- Button trigger modal -->
                    <button type=""button"" class=""btn bg-gradient-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
                        Launch demo modal
                    </button>

                    <!-- Modal -->
                    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                            <div class=""modal-content"" style=""width:900px"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                                    <button type=""button"" class=""btn-clo");
                WriteLiteral(@"se"" data-bs-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"" id=""mod"">

                                    ");
#nullable restore
#line 50 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                               Write(Html.Partial("_Create",new Devis()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn bg-gradient-secondary"" data-bs-dismiss=""modal"">Close</button>
                                    <button type=""button"" class=""btn bg-gradient-primary"">Save changes</button>
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
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Devis</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Total ");
                WriteLiteral(@"HT</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Total HT avant Remise</th>
                                    <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Total Remise</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Total TVA</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Total TTC</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Produit</th>
                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Client</th>




                                    <th class=""text-secondary opacity-7""></th>
                                </tr>
                            </thead>
    ");
                WriteLiteral("                        <tbody>\r\n");
#nullable restore
#line 83 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <tr>
                                        <td>
                                            <div class=""d-flex px-2 py-1"">
                                                <div>
                                                    <img src=""../assets/img/team-2.jpg"" class=""avatar avatar-sm me-3"" alt=""user1"">
                                                </div>
                                                <div class=""d-flex flex-column justify-content-center"">
                                                    <h6 class=""mb-0 text-sm"">");
#nullable restore
#line 92 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                        Write(item.devis_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                                    <p class=\"text-xs text-secondary mb-0\">");
#nullable restore
#line 93 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                      Write(item.date_devis);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""text-xs font-weight-bold mb-0"">");
#nullable restore
#line 98 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                Write(item.total_ht);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                        </td>
                                        <td class=""align-middle text-center text-sm"">
                                            <span class=""badge badge-sm bg-gradient-success"">Online</span>
                                        </td>
                                        <td class=""align-middle text-center"">
                                            <span class=""text-secondary text-xs font-weight-bold"">");
#nullable restore
#line 105 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                             Write(item.total_ht_avant_remis);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </td>\r\n                                        <td class=\"align-middle text-center\">\r\n                                            <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 108 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                             Write(item.total_remise);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </td>\r\n                                        <td class=\"align-middle text-center\">\r\n                                            <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 111 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                             Write(item.total_tva);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </td>\r\n                                        <td class=\"align-middle text-center\">\r\n                                            <span class=\"text-secondary text-xs font-weight-bold\">");
#nullable restore
#line 114 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                             Write(item.total_ttc);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                        </td>
                                         <td class=""align-middle text-center"">
                                            <!--<span class=""text-secondary text-xs font-weight-bold"">item.Devis_produit.designation</span>-->
                                        </td>
                                        <td class=""align-middle text-center"">
                                            <span class=""text-secondary text-xs font-weight-bold"">");
#nullable restore
#line 120 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                             Write(item.Devis_client.nom_client);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                        </td>
                                       <td class=""align-middle"">
                                            <!--
                                                                                        <button type=""button"" class=""btn bg-gradient-primary"" data-bs-toggle=""modal"" data-bs-target=""");
#nullable restore
#line 124 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                                                                                                                 Write("#editModal-"+item.id_client);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-url=\"");
#nullable restore
#line 124 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                                                                                                                                                           Write(Url.Action($"EditPartial/{item.id_client}"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                               Edit
                                            </button>
                                            <form action=""Delete"" style=""display:inline;"">
                                            <button type=""submit"" class=""btn bg-gradient-danger"" asp-action=""Delete"" asp-route-id=""");
#nullable restore
#line 128 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
                                                                                                                              Write(item.id_client);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                Delete
                                            </button></form>
                                           
                                            await Html.PartialAsync(""EditPartial"",item) -->
                                            <!-- Edit Modal -->
                                        </td>
                                   
                                    </tr>
");
#nullable restore
#line 137 "C:\Users\DELL\source\repos\Application_Facturation_V0\Application_Facturation_V0\Views\Devis\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Devis>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
