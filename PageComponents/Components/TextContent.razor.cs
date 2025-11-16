using Microsoft.AspNetCore.Components;

namespace PageComponents.Components;

public partial class TextContent
{
    /// <summary>
    /// Textinhalt
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Text-Variante
    /// </summary>
    [Parameter]
    public TextVariant Variant { get; set; } = TextVariant.Default;

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string? CssClass { get; set; }

    private string VariantClass => Variant switch
    {
        TextVariant.Bold => "text-bold",
        TextVariant.Muted => "text-muted",
        TextVariant.Highlight => "text-highlight",
        TextVariant.Italic => "text-italic",
        _ => ""
    };
}

public enum TextVariant
{
    Default,
    Bold,
    Muted,
    Highlight,
    Italic
}