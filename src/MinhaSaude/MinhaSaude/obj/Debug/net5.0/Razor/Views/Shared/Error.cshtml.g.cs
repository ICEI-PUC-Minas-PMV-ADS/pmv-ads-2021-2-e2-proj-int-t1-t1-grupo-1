#pragma checksum "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b676226fe5c64a47b45554b80a0ebb360c31c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\_ViewImports.cshtml"
using MinhaSaude;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\_ViewImports.cshtml"
using MinhaSaude.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\Shared\Error.cshtml"
using MInhaSaude.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b676226fe5c64a47b45554b80a0ebb360c31c1", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b28e4a7e59fc6392331e13e00f4fe091e0763b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 10 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 13 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 15 "E:\OneDrive - sga.pucminas.br\GitHub\pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-1\src\MinhaSaude\MinhaSaude\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
