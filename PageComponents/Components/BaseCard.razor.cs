using Microsoft.AspNetCore.Components;

namespace PageComponents.Components;

public partial class BaseCard
{
    /// <summary>
    /// Hauptinhalt der Karte
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Header-Inhalt (optional)
    /// </summary>
    [Parameter]
    public RenderFragment? HeaderContent { get; set; }

    /// <summary>
    /// Footer-Inhalt (optional)
    /// </summary>
    [Parameter]
    public RenderFragment? FooterContent { get; set; }

    /// <summary>
    /// Header anzeigen
    /// </summary>
    [Parameter]
    public bool ShowHeader { get; set; } = true;

    /// <summary>
    /// Footer anzeigen
    /// </summary>
    [Parameter]
    public bool ShowFooter { get; set; } = true;

    /// <summary>
    /// Karten-Variante
    /// </summary>
    [Parameter]
    public CardVariant Variant { get; set; } = CardVariant.Default;

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string CssClass { get; set; } = "";

    /// <summary>
    /// Header-Layout
    /// </summary>
    [Parameter]
    public HeaderLayout HeaderLayout { get; set; } = HeaderLayout.Default;

    /// <summary>
    /// Vertikale Ausrichtung der Header-Elemente
    /// </summary>
    [Parameter]
    public VerticalAlign HeaderAlign { get; set; } = VerticalAlign.Center;

    /// <summary>
    /// Footer-Layout
    /// </summary>
    [Parameter]
    public FooterLayout FooterLayout { get; set; } = FooterLayout.Default;

    /// <summary>
    /// Vertikale Ausrichtung der Footer-Elemente
    /// </summary>
    [Parameter]
    public VerticalAlign FooterAlign { get; set; } = VerticalAlign.Center;

    /// <summary>
    /// Border-Radius in Pixeln (Standard: 10)
    /// </summary>
    [Parameter]
    public int BorderRadius { get; set; } = 10;

    /// <summary>
    /// Gibt die CSS-Klasse für die Karten-Variante zurück
    /// </summary>
    private string VariantClass => Variant switch
    {
        CardVariant.Highlighted => "card-highlighted",
        CardVariant.Warning => "card-warning",
        CardVariant.WarningSub => "card-warning-sub",
        CardVariant.Event => "card-event",
        CardVariant.News => "card-news",
        CardVariant.NewsSub => "card-news-sub",
        CardVariant.Note => "card-note",
        CardVariant.Detail => "card-detail",
        CardVariant.Consequences => "card-consequences",
        CardVariant.Sub => "card-sub",
        CardVariant.Hero => "card-hero",
        CardVariant.Cta => "card-cta",
        CardVariant.Join => "card-join",
        CardVariant.Contact => "card-contact",
        CardVariant.Legal => "card-legal",
        CardVariant.Rules => "card-rules",
        CardVariant.RulesSub => "card-rules-sub",
        CardVariant.Info => "card-info",
        _ => ""
    };

    /// <summary>
    /// Gibt die CSS-Klasse für das Header-Layout zurück
    /// </summary>
    private string HeaderLayoutClass => HeaderLayout switch
    {
        HeaderLayout.SpaceBetween => "header-space-between",
        HeaderLayout.SpaceAround => "header-space-around",
        HeaderLayout.SpaceEvenly => "header-space-evenly",
        HeaderLayout.Center => "header-center",
        HeaderLayout.Start => "header-start",
        HeaderLayout.End => "header-end",
        _ => ""
    };

    /// <summary>
    /// Gibt die CSS-Klasse für das Footer-Layout zurück
    /// </summary>
    private string FooterLayoutClass => FooterLayout switch
    {
        FooterLayout.SpaceBetween => "footer-space-between",
        FooterLayout.SpaceAround => "footer-space-around",
        FooterLayout.SpaceEvenly => "footer-space-evenly",
        FooterLayout.Center => "footer-center",
        FooterLayout.Start => "footer-start",
        FooterLayout.End => "footer-end",
        _ => ""
    };

    /// <summary>
    /// Gibt die CSS-Klasse für die Header-Ausrichtung zurück
    /// </summary>
    private string HeaderAlignClass => HeaderAlign switch
    {
        VerticalAlign.Start => "align-start",
        VerticalAlign.Center => "align-center",
        VerticalAlign.End => "align-end",
        VerticalAlign.Stretch => "align-stretch",
        _ => "align-center"
    };

    /// <summary>
    /// Gibt die CSS-Klasse für die Footer-Ausrichtung zurück
    /// </summary>
    private string FooterAlignClass => FooterAlign switch
    {
        VerticalAlign.Start => "align-start",
        VerticalAlign.Center => "align-center",
        VerticalAlign.End => "align-end",
        VerticalAlign.Stretch => "align-stretch",
        _ => "align-center"
    };

    /// <summary>
    /// Gibt den inline-style für den border-radius zurück
    /// </summary>
    private string BorderRadiusStyle => $"border-radius: {BorderRadius}px;";
}

/// <summary>
/// Verfügbare Karten-Varianten
/// </summary>
public enum CardVariant
{
    Default,
    Highlighted,
    Warning,
    WarningSub,
    Event,
    News,
    NewsSub,
    Note,
    Detail,
    Consequences,
    Sub,
    Hero,
    Cta,
    Join,
    Contact,
    Legal,
    Rules,
    RulesSub,
    Info
}

/// <summary>
/// Header-Layout-Optionen
/// </summary>
public enum HeaderLayout
{
    Default,
    SpaceBetween,
    SpaceAround,
    SpaceEvenly,
    Center,
    Start,
    End
}

/// <summary>
/// Footer-Layout-Optionen
/// </summary>
public enum FooterLayout
{
    Default,
    SpaceBetween,
    SpaceAround,
    SpaceEvenly,
    Center,
    Start,
    End
}

public enum VerticalAlign
{
    Start,      // Oben ausrichten
    Center,     // Mittig ausrichten (Standard)
    End,        // Unten ausrichten
    Stretch     // Über gesamte Höhe strecken
}