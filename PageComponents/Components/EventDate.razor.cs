using Microsoft.AspNetCore.Components;

namespace PageComponents.Components;

public partial class EventDate
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
}