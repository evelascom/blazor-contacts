// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ContactList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\Blazor-Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactList.razor"
       
    IEnumerable<Contact> contacts;
    public string Message { get; set; }

    protected async override Task OnInitializedAsync()
    {
        try
        {
            contacts = await ContactService.GetAll();
        }
        catch (Exception e)
        {
            
            Message = "Error..." + e.InnerException.StackTrace;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
