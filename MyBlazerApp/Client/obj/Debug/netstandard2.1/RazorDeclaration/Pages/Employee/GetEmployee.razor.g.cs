#pragma checksum "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\Pages\Employee\GetEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4c9b875f826ec3496b3b6251577407263829e5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyBlazerApp.Client.Pages.Employee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using MyBlazerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\_Imports.razor"
using MyBlazerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\Pages\Employee\GetEmployee.razor"
using MyBlazerApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class GetEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "E:\Company_Task\MyBlazerApp\MyBlazerApp\Client\Pages\Employee\GetEmployee.razor"
       
    EmployeeDto[] empList;

    protected override async Task OnInitializedAsync()
    {
        empList = await Http.GetFromJsonAsync<EmployeeDto[]>("/api/Employee/Index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591