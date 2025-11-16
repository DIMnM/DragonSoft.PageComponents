namespace PageComponents.Components;

using Microsoft.AspNetCore.Components;

public partial class Titel
{
    /// <summary>
    /// Inhalt des Titels
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Heading-Level (1-6)
    /// </summary>
    [Parameter]
    public int Level { get; set; } = 2;

    /// <summary>
    /// Textausrichtung
    /// </summary>
    [Parameter]
    public TextAlign Align { get; set; } = TextAlign.Center;

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string? CssClass { get; set; }

    /// <summary>
    /// Gets or sets the CSS styles to apply to the rendered element.
    /// </summary>
    /// <remarks>This property allows you to specify inline CSS styles as a string. If set, the styles are
    /// applied directly to the element's 'style' attribute. This can be used to override or supplement styles defined
    /// by classes or external stylesheets.</remarks>
    [Parameter]
    public string? Style { get; set; }

    private string GetAlignmentClass() => Align switch
    {
        TextAlign.Left => "text-left",
        TextAlign.Center => "text-center",
        TextAlign.Right => "text-right",
        TextAlign.Justify => "text-justify",
        _ => "text-center"
    };
}

public enum TextAlign
{
    Left,
    Center,
    Right,
    Justify
}