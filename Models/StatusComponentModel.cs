using BlazorApp.Enums;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Models;

public class StatusComponentModel : ComponentBase
{
    [Parameter]
    public Status Status { get; set; } = Status.Stop;

    public string CssStatus
    {
        get
        {
            return Status.ToString().ToLower();
        }
    }
}
