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
    /// Textausrichtung
    /// </summary>
    [Parameter]
    public TextAlignment Alignment { get; set; } = TextAlignment.Left;

    /// <summary>
    /// Display-Modus
    /// </summary>
    [Parameter]
    public DisplayMode Display { get; set; } = DisplayMode.Block;

    /// <summary>
    /// Padding-Größe
    /// </summary>
    [Parameter]
    public SpacingSize Padding { get; set; } = SpacingSize.Default;

    /// <summary>
    /// Margin-Größe
    /// </summary>
    [Parameter]
    public SpacingSize Margin { get; set; } = SpacingSize.Default;

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string? CssClass { get; set; }

    [Parameter]
    public string? Style { get; set; }

    private string VariantClass => Variant switch
    {
        TextVariant.Bold => "text-bold",
        TextVariant.Muted => "text-muted",
        TextVariant.Highlight => "text-highlight",
        TextVariant.Italic => "text-italic",
        _ => ""
    };

    private string AlignmentClass => Alignment switch
    {
        TextAlignment.Left => "text-left",
        TextAlignment.Center => "text-center",
        TextAlignment.Right => "text-right",
        TextAlignment.Justify => "text-justify",
        _ => ""
    };

    private string DisplayClass => Display switch
    {
        DisplayMode.Inline => "text-inline",
        DisplayMode.InlineBlock => "text-inline-block",
        DisplayMode.Block => "text-block",
        _ => ""
    };

    private string PaddingClass => Padding switch
    {
        SpacingSize.None => "text-padding-none",
        SpacingSize.Small => "text-padding-small",
        SpacingSize.Medium => "text-padding-medium",
        SpacingSize.Large => "text-padding-large",
        _ => ""
    };

    private string MarginClass => Margin switch
    {
        SpacingSize.None => "text-margin-none",
        SpacingSize.Small => "text-margin-small",
        SpacingSize.Medium => "text-margin-medium",
        SpacingSize.Large => "text-margin-large",
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

public enum TextAlignment
{
    Left,
    Center,
    Right,
    Justify
}

public enum DisplayMode
{
    Block,
    Inline,
    InlineBlock
}

public enum SpacingSize
{
    Default,
    None,
    Small,
    Medium,
    Large
}