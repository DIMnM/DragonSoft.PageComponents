using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PageComponents.Components;

public partial class TextLink
{
    // Parameter für Styling und Funktionalität
    [Parameter] public string Href { get; set; } = "#"; // Ziel-URL
    [Parameter] public string Target { get; set; } = "_self"; // Ziel (z.B. _blank)
    [Parameter] public string Class { get; set; } = ""; // CSS-Klasse für benutzerdefinierte Stile
    [Parameter] public string Style { get; set; } = ""; // Inline-Stile
    [Parameter] public RenderFragment? ChildContent { get; set; } // Inhalt des Links
    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; } // Klick-Ereignis
}