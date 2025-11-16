namespace PageComponents.Components;

using Microsoft.AspNetCore.Components;

public partial class BaseCard
{
    /// <summary>
    /// Hauptinhalt der Card
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Header-Inhalt der Card
    /// </summary>
    [Parameter]
    public RenderFragment? HeaderContent { get; set; }

    /// <summary>
    /// Footer-Inhalt der Card
    /// </summary>
    [Parameter]
    public RenderFragment? FooterContent { get; set; }

    /// <summary>
    /// Variante der Card (Standard, Hervorgehoben, Warnung)
    /// </summary>
    [Parameter]
    public CardVariant Variant { get; set; } = CardVariant.Default;

    /// <summary>
    /// Zusätzliche CSS-Klassen
    /// </summary>
    [Parameter]
    public string? CssClass { get; set; }

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
    /// Layout des Headers (wie Elemente verteilt werden)
    /// </summary>
    [Parameter]
    public CardHeaderLayout HeaderLayout { get; set; } = CardHeaderLayout.Default;

    /// <summary>
    /// Layout des Footers (wie Elemente verteilt werden)
    /// </summary>
    [Parameter]
    public CardFooterLayout FooterLayout { get; set; } = CardFooterLayout.Default;

    /// <summary>
    /// Vertikale Ausrichtung der Header-Elemente
    /// </summary>
    [Parameter]
    public VerticalAlign HeaderAlign { get; set; } = VerticalAlign.Center;

    /// <summary>
    /// Vertikale Ausrichtung der Footer-Elemente
    /// </summary>
    [Parameter]
    public VerticalAlign FooterAlign { get; set; } = VerticalAlign.Center;

    private string HeaderLayoutClass
    {
        get
        {
            var classes = new List<string>();

            // Layout-Klasse
            classes.Add(HeaderLayout switch
            {
                CardHeaderLayout.SpaceBetween => "header-space-between",
                CardHeaderLayout.SpaceAround => "header-space-around",
                CardHeaderLayout.SpaceEvenly => "header-space-evenly",
                CardHeaderLayout.Center => "header-center",
                CardHeaderLayout.End => "header-end",
                CardHeaderLayout.Start => "header-start",
                _ => ""
            });

            // Vertikale Ausrichtung
            classes.Add(HeaderAlign switch
            {
                VerticalAlign.Start => "align-start",
                VerticalAlign.Center => "align-center",
                VerticalAlign.End => "align-end",
                VerticalAlign.Stretch => "align-stretch",
                _ => "align-center"
            });

            return string.Join(" ", classes.Where(c => !string.IsNullOrEmpty(c)));
        }
    }

    private string FooterLayoutClass
    {
        get
        {
            var classes = new List<string>();

            // Layout-Klasse
            classes.Add(FooterLayout switch
            {
                CardFooterLayout.SpaceBetween => "footer-space-between",
                CardFooterLayout.SpaceAround => "footer-space-around",
                CardFooterLayout.SpaceEvenly => "footer-space-evenly",
                CardFooterLayout.Center => "footer-center",
                CardFooterLayout.End => "footer-end",
                CardFooterLayout.Start => "footer-start",
                _ => ""
            });

            // Vertikale Ausrichtung
            classes.Add(FooterAlign switch
            {
                VerticalAlign.Start => "align-start",
                VerticalAlign.Center => "align-center",
                VerticalAlign.End => "align-end",
                VerticalAlign.Stretch => "align-stretch",
                _ => "align-center"
            });

            return string.Join(" ", classes.Where(c => !string.IsNullOrEmpty(c)));
        }
    }
    private string VariantClass => Variant switch
    {
        CardVariant.Consequences => "card-consequences",
        CardVariant.Contact => "card-contact",
        CardVariant.CTA => "card-cta",
        CardVariant.Detail => "card-detail",
        CardVariant.Event => "card-event",
        CardVariant.Highlighted => "card-highlighted",
        CardVariant.Hero => "card-hero",
        CardVariant.Info => "card-info",
        CardVariant.Join => "card-join",
        CardVariant.Legal => "card-legal",
        CardVariant.News => "card-news",
        CardVariant.NewsSubCard => "card-news-sub",
        CardVariant.Note => "card-note",
        CardVariant.Rules => "card-rules",
        CardVariant.RulesSubCard => "card-rules-sub",
        CardVariant.SubCard => "card-sub",
        CardVariant.Warning => "card-warning",
        CardVariant.WarningSubCard => "card-warning-sub",
        _ => "card-default"
    };
}

public enum CardVariant
{
    Consequences,
    Contact,
    CTA,
    Default,
    Detail,
    Event,
    Highlighted,
    Hero,
    Info,
    Join,
    Legal,
    NewsSubCard,
    News,
    Note,
    Rules,
    RulesSubCard,
    SubCard,
    Warning,
    WarningSubCard
}

public enum CardHeaderLayout
{
    Default,        // Normaler Block-Flow
    SpaceBetween,   // Elemente an den Rändern, Platz dazwischen
    SpaceAround,    // Gleicher Abstand um jedes Element
    SpaceEvenly,    // Perfekt gleichmäßig verteilt
    Center,         // Alle Elemente zentriert
    Start,          // Alle Elemente links
    End             // Alle Elemente rechts
}

public enum CardFooterLayout
{
    Default,        // Normaler Block-Flow
    SpaceBetween,   // Elemente an den Rändern, Platz dazwischen
    SpaceAround,    // Gleicher Abstand um jedes Element
    SpaceEvenly,    // Perfekt gleichmäßig verteilt
    Center,         // Alle Elemente zentriert
    Start,          // Alle Elemente links
    End             // Alle Elemente rechts
}

public enum VerticalAlign
{
    Start,      // Oben ausrichten
    Center,     // Mittig ausrichten (Standard)
    End,        // Unten ausrichten
    Stretch     // Über gesamte Höhe strecken
}