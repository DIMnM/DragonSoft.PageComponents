using Microsoft.AspNetCore.Components;

namespace PageComponents.Components;

public partial class CardNr
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
}