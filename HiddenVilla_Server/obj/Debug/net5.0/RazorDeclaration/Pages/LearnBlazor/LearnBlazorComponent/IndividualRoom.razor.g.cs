// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
    public partial class IndividualRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\iorah\Desktop\Dotnet Mastery\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
       
    [Parameter]
    public BlazoRoom Room { get; set; }
    [Parameter]
    public EventCallback<bool> OnRoomCheckBoxSelection { get; set; }

    protected async Task RoomCheckSelectionChange(ChangeEventArgs e)
    {
        await OnRoomCheckBoxSelection.InvokeAsync((bool)e.Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
