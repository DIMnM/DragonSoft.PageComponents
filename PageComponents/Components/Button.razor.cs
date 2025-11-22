namespace PageComponents.Components;

using Microsoft.AspNetCore.Components;

public partial class Button
{
    /// <summary>
    /// Inhalt des Buttons
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Link-URL (wenn als Link verwendet)
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// Button-Variante
    /// </summary>
    [Parameter]
    public ButtonVariant Variant { get; set; } = ButtonVariant.Primary;

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string? CssClass { get; set; }

    /// <summary>
    /// Link-Target (z.B. "_blank")
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// Icon-Klasse (z.B. "fas fa-home")
    /// </summary>
    [Parameter]
    public string? Icon { get; set; }

    /// <summary>
    /// Button-Type (button, submit, reset)
    /// </summary>
    [Parameter]
    public string Type { get; set; } = "button";

    /// <summary>
    /// Button deaktiviert
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public int BorderRadius { get; set; } = 8;

    /// <summary>
    /// Click-Event
    /// </summary>
    [Parameter]
    public EventCallback OnClick { get; set; }

    private string BorderRadiusStyle => $"border-radius: {BorderRadius}px;";
}

public enum ButtonVariant
{
    Primary,
    Secondary,
    Tertiary,
    Success,
    Warning,
    Danger,
    Link
}