#pragma checksum "E:\ARŞİV\PROJELERİM\ASP.NET MVC CORE BLOG PROJESİ\CoreBlogProjesi\CoreBlogProjesi\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2281fc48a4eb72ac6dbcb057196daa7dac9dd50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "E:\ARŞİV\PROJELERİM\ASP.NET MVC CORE BLOG PROJESİ\CoreBlogProjesi\CoreBlogProjesi\Views\_ViewImports.cshtml"
using CoreBlogProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ARŞİV\PROJELERİM\ASP.NET MVC CORE BLOG PROJESİ\CoreBlogProjesi\CoreBlogProjesi\Views\_ViewImports.cshtml"
using CoreBlogProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2281fc48a4eb72ac6dbcb057196daa7dac9dd50", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0524a1972fb2152627f20207d6dcd651ef7c311b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n\t<h4>Kategoriler</h4>\r\n\t<ul class=\"list-group single\">\r\n");
#nullable restore
#line 7 "E:\ARŞİV\PROJELERİM\ASP.NET MVC CORE BLOG PROJESİ\CoreBlogProjesi\CoreBlogProjesi\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach(var item in Model)
		{	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\t\t\t");
#nullable restore
#line 10 "E:\ARŞİV\PROJELERİM\ASP.NET MVC CORE BLOG PROJESİ\CoreBlogProjesi\CoreBlogProjesi\Views\Shared\Components\CategoryList\Default.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<span class=\"badge badge-primary badge-pill\">0</span>\r\n\t\t</li>\r\n");
#nullable restore
#line 13 "E:\ARŞİV\PROJELERİM\ASP.NET MVC CORE BLOG PROJESİ\CoreBlogProjesi\CoreBlogProjesi\Views\Shared\Components\CategoryList\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
