#pragma checksum "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\Pages\VideoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ba99afca2c643b6cf35dae73432e61e9d8fef2f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDapperCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using BlazorDapperCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\_Imports.razor"
using BlazorDapperCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\Pages\VideoList.razor"
using BlazorDapperCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videolist")]
    public partial class VideoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Source\BlazorDapper\Blazor---Dapper-CRUD---.NET-Core-3.1\BlazorDapperCrud\BlazorDapperCrud\Pages\VideoList.razor"
       
    IEnumerable<Video> videos;
    protected override async Task OnInitializedAsync()
    {
        videos = await VideoService.VideoList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVideoService VideoService { get; set; }
    }
}
#pragma warning restore 1591
