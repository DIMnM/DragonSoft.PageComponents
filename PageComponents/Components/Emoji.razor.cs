namespace PageComponents.Components;

using Microsoft.AspNetCore.Components;

public partial class Emoji
{
    /// <summary>
    /// Das anzuzeigende Emoji-Zeichen
    /// </summary>
    [Parameter]
    public string EmojiChar { get; set; } = "";

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string Class { get; set; } = "";

    /// <summary>
    /// Zusätzliche Inline-Styles
    /// </summary>
    [Parameter]
    public string Style { get; set; } = "";

    /// <summary>
    /// Text-Shadow aktivieren
    /// </summary>
    [Parameter]
    public bool Shadow { get; set; } = false;

    /// <summary>
    /// Größen-Level (0 = Standard, 1-6 = 1rem bis 6rem)
    /// </summary>
    [Parameter]
    public int Level { get; set; } = 0;

    /// <summary>
    /// Zusätzliche HTML-Attribute
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    /// <summary>
    /// Berechnet den kombinierten Inline-Style
    /// </summary>
    private string ComputedStyle
    {
        get
        {
            var fontSize = Level > 0 ? $"font-size: {Level}rem;" : "";
            var customStyle = !string.IsNullOrWhiteSpace(Style) ? Style : "";

            return $"{fontSize} {customStyle}".Trim();
        }
    }
}
