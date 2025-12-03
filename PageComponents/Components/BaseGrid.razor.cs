using Microsoft.AspNetCore.Components;

namespace PageComponents.Components;

public partial class BaseGrid
{
    /// <summary>
    /// Inhalt des Grids
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Vordefinierte Grid-Layouts
    /// </summary>
    [Parameter]
    public GridPreset Preset { get; set; } = GridPreset.Medium;

    /// <summary>
    /// Minimale Spaltenbreite (überschreibt Preset)
    /// </summary>
    [Parameter]
    public string? MinWidth { get; set; }

    /// <summary>
    /// Gap zwischen Grid-Items
    /// </summary>
    [Parameter]
    public string? Gap { get; set; }

    /// <summary>
    /// Maximale Breite des Grids
    /// </summary>
    [Parameter]
    public string? MaxWidth { get; set; }

    /// <summary>
    /// Grid zentrieren
    /// </summary>
    [Parameter]
    public bool Centered { get; set; }

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string? CssClass { get; set; }

    /// <summary>
    /// Anzahl der Spalten (überschreibt Preset und MinWidth)
    /// </summary>
    [Parameter]
    public int? Columns { get; set; }

    private string PresetClass => Preset switch
    {
        GridPreset.XLarge => "grid-x-large",
        GridPreset.Large => "grid-large",
        GridPreset.Medium => "grid-medium",
        GridPreset.Small => "grid-small",
        GridPreset.Compact => "grid-compact",
        GridPreset.Single => "grid-single",
        _ => "grid-medium"
    };

    private string CustomStyle
    {
        get
        {
            var styles = new List<string>();

            // Nur Custom Styles hinzufügen, wenn sie auch wirklich custom sind

            // Custom Columns überschreibt alles
            if (Columns.HasValue)
            {
                styles.Add($"grid-template-columns: repeat({Columns.Value}, 1fr)");
            }
            // Custom MinWidth überschreibt Preset
            else if (!string.IsNullOrEmpty(MinWidth))
            {
                styles.Add($"grid-template-columns: repeat(auto-fit, minmax({MinWidth}, 1fr))");
            }

            // Custom Gap
            if (!string.IsNullOrEmpty(Gap))
            {
                styles.Add($"gap: {Gap}");
            }

            // MaxWidth
            if (!string.IsNullOrEmpty(MaxWidth))
            {
                styles.Add($"max-width: {MaxWidth}");
            }

            // Centered
            if (Centered)
            {
                styles.Add("margin-left: auto");
                styles.Add("margin-right: auto");
            }

            return string.Join("; ", styles);
        }
    }

    protected override void OnParametersSet()
    {
        if (Columns <= 0)
            throw new ArgumentOutOfRangeException(nameof(Columns),
                "BorderRadius must be >= 0");

        base.OnParametersSet();
    }

}

public enum GridPreset
{
    Default,   // 300px (häufigster Wert)
    Large,     // 350px (OverviewGrid)
    XLarge,    // 450px (OversizeGrid)
    Medium,    // 300px (News, QuickLink, Activity, Contact)
    Small,     // 250px (Value, Principles, Team)
    Compact,   // 280px (FAQ)
    Single,    // 1fr (Legal - single column)
}