#pragma checksum "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfd97ed000b43112f4e360622030b302455c6f7"
// <auto-generated/>
#pragma warning disable 1591
namespace Facebook_Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Facebook_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manuel Rodas\source\repos\blazor-Facebook-Web\Facebook Web\Facebook Web\_Imports.razor"
using Facebook_Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-9");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-flex justify-content-center");
            __builder.OpenComponent<Facebook_Web.Shared.StoriesComponent>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "d-flex justify-content-center");
            __builder.OpenComponent<Facebook_Web.Shared.NewPostComponent>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<Facebook_Web.Shared.PostListComponent>(12);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<div class=\"col-3\"><div id=\"publicityandchatscontainer\"><div class=\"row\"><div class=\"col publicitycontainer\"><a class=\"publicitytitle\">Publicidad</a></div></div>\r\n            <div class=\"row\"><div class=\"col-12 publicitycontaineritem\"><div class=\"publicityimage\"></div>\r\n                    <div class=\"publicityitemtext\">Unete a nuestra nueva red de internet y telefonia</div></div></div>\r\n            <div class=\"row\"><div class=\"col-12 publicitycontaineritem\"><div class=\"publicityimage\"></div>\r\n                    <div class=\"publicityitemtext\">Tu tambien puedes optar por estos beneficios!</div></div></div>\r\n\r\n            <hr>\r\n            <div class=\"row\"><div class=\"col\" style=\"margin-bottom:15px\"><a class=\"chattitle\">Contactos</a>\r\n                    <div class=\"iconschats\"><img src=\"/img/icons/addvideocall.ico\">\r\n                        <img src=\"/img/icons/search.ico\">\r\n                        <img src=\"/img/icons/3dots.ico\"></div></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/1.jpg\"><a>Miguel Franco</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/2.jpg\"><a>Alejandro Estevez</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/3.jpg\"><a>Estefany Paname??o</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/4.jpg\"><a>Carol Gabriela Gutierrez</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/5.jpg\"><a>Rafael Nu??ez</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/3.jpg\"><a>Daniela Sofia Calderon</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/1.jpg\"><a>Fernando Perez</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/4.jpg\"><a>Andrea Villeda</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/2.jpg\"><a>Fernando Perez</a></div></div>\r\n            <div class=\"row\"><div class=\"col contactitemcontainer\"><img src=\"/img/pictures/5.jpg\"><a>Miguel Franco</a></div></div></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
