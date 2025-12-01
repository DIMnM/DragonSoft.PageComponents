# DragonSoft.PageComponents

Eine moderne Sammlung wiederverwendbarer UI-Komponenten für Blazor und Razor mit .NET 10.0. Die Bibliothek bietet eine umfassende Collection von Layout-, Text-, Button- und Spezialkomponenten mit automatischem Light/Dark-Theme-Support.

[![NuGet](https://img.shields.io/nuget/v/DragonSoft.PageComponents.svg)](https://www.nuget.org/packages/DragonSoft.PageComponents/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## 📦 Installation

Installiere das Package über NuGet:

```bash
dotnet add package DragonSoft.PageComponents
```

Oder über die Package Manager Console:

```powershell
Install-Package DragonSoft.PageComponents
```

## 🚀 Schnellstart

### 1. Package referenzieren

Füge die Namespace-Referenz in deine `_Imports.razor` ein:

```razor
@using PageComponents.Components
```

### 2. Statische Assets einbinden

Füge in deiner `App.razor` oder `index.html` / `_Host.cshtml` die CSS-Referenz hinzu:

```html
<link href="_content/PageComponents/css/style.css" rel="stylesheet" />
```

Für komponentenspezifische Styles:

```html
<link href="PageComponents.styles.css" rel="stylesheet" />
```

### 3. Komponenten verwenden

```razor
<BaseCard Variant="CardVariant.Highlighted">
    <HeaderContent>
        <Titel Level="3">Meine Karte</Titel>
    </HeaderContent>
    <ChildContent>
        <TextContent>Hier kommt dein Inhalt rein.</TextContent>
    </ChildContent>
</BaseCard>
```

## 🎨 Komponenten-Übersicht

### Layout-Komponenten

- **[BaseCard](#basecard)** - Flexible Karten-Komponente mit 15+ Varianten
- **[BaseGrid](#basegrid)** - Responsive Grid-Layout mit mehreren Presets
- **[BaseSection](#basesection)** - Section-Wrapper für strukturierte Layouts

### Text-Komponenten

- **[Titel](#titel)** - Überschriften (H1-H6) mit konsistentem Styling
- **[TextContent](#textcontent)** - Formatierter Text mit Varianten
- **[TextLink](#textlink)** - Gestylte Links mit Hover-Effekten

### Button-Komponenten

- **[Button](#button)** - Vielseitige Button-Komponente

### Spezial-Komponenten

- **[Emoji](#emoji)** - Emoji-Anzeige mit verschiedenen Größen
- **[EventDate](#eventdate)** - Formatierte Event-Datum-Anzeige
- **[CardNr](#cardnr)** - Nummerierte Karten-Badge
- **[TelegramLink](#telegramlink)** - Vorgefertigter Telegram-Link

---

## 📖 Komponenten-Dokumentation

### BaseCard

Eine flexible, vielseitige Karten-Komponente mit 15+ Varianten, optionalem Header/Footer und flexiblen Layout-Optionen.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Der Hauptinhalt der Karte |
| `HeaderContent` | RenderFragment? | null | Optionaler Header-Inhalt |
| `FooterContent` | RenderFragment? | null | Optionaler Footer-Inhalt |
| `ShowHeader` | bool | true | Header anzeigen |
| `ShowFooter` | bool | true | Footer anzeigen |
| `Variant` | CardVariant | Default | Vordefinierte Stilvariant |
| `CssClass` | string | "" | Zusätzliche CSS-Klassen |
| `HeaderLayout` | HeaderLayout | Default | Header-Layout-Modus |
| `FooterLayout` | FooterLayout | Default | Footer-Layout-Modus |

#### Varianten

| Variante | Beschreibung | Verwendung |
|----------|--------------|------------|
| `Default` | Standard-Kartenstil | Allgemeine Inhalte |
| `Highlighted` | Linker farbiger Akzent | Hervorgehobene Inhalte |
| `Warning` | Gelber Akzent | Warnungen |
| `WarningSub` | Gedämpfte Warnung | Untergeordnete Warnungen |
| `Event` | Border mit Hover | Event-Anzeigen |
| `News` | News-Stil | Nachrichtenartikel |
| `NewsSub` | Gedämpfter News-Stil | Untergeordnete News |
| `Note` | Farbiger Hintergrund | Wichtige Notizen |
| `Detail` | Border-Stil | Detailansichten |
| `Consequences` | Warning + Border | Wichtige Konsequenzen |
| `Sub` | Tertiärer Hintergrund | Untergeordnete Inhalte |
| `Hero` | Primary-Color Hintergrund | Hero-Sektionen |
| `Cta` | Gradient-Hintergrund | Call-to-Action |
| `Join` | Gradient-Stil | Beitritts-Bereiche |
| `Contact` | Kontakt-Stil | Kontaktinformationen |
| `Legal` | Rechtlicher Stil | Rechtliche Inhalte |
| `Rules` | Regelwerk-Stil | Regelungen |
| `RulesSub` | Gedämpfte Regeln | Unter-Regelungen |
| `Info` | Zentrierte Info-Box | Informationen |

#### Header/Footer Layouts

| Layout | Beschreibung |
|--------|--------------|
| `Default` | Standard Block-Layout |
| `SpaceBetween` | Flex mit space-between |
| `SpaceAround` | Flex mit space-around |
| `SpaceEvenly` | Flex mit space-evenly |
| `Center` | Zentriert |
| `Start` | Linksbündig |
| `End` | Rechtsbündig |

#### Beispiele

```razor
<!-- Einfache Karte -->
<BaseCard>
    <TextContent>Einfacher Inhalt</TextContent>
</BaseCard>

<!-- Karte mit allem -->
<BaseCard Variant="CardVariant.Highlighted"
          HeaderLayout="HeaderLayout.SpaceBetween"
          FooterLayout="FooterLayout.End">
    <HeaderContent>
        <Titel Level="3">Titel</Titel>
        <Button Variant="ButtonVariant.Secondary">Action</Button>
    </HeaderContent>
    <ChildContent>
        <TextContent>Hauptinhalt der Karte.</TextContent>
    </ChildContent>
    <FooterContent>
        <Button Variant="ButtonVariant.Success">Speichern</Button>
        <Button Variant="ButtonVariant.Danger">Abbrechen</Button>
    </FooterContent>
</BaseCard>

<!-- CTA-Karte -->
<BaseCard Variant="CardVariant.Cta">
    <HeaderContent>
        <Titel Level="2">Jetzt starten!</Titel>
    </HeaderContent>
    <ChildContent>
        <TextContent>Entdecke alle Funktionen.</TextContent>
    </ChildContent>
    <FooterContent>
        <Button Variant="ButtonVariant.Primary" Href="/start">Los geht's</Button>
    </FooterContent>
</BaseCard>
```

---

### BaseGrid

Responsive Grid-Layout-Komponente mit mehreren vordefinierten Presets für verschiedene Anwendungsfälle.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Grid-Elemente |
| `Preset` | GridPreset | Medium | Vordefiniertes Grid-Layout |
| `CssClass` | string | "" | Zusätzliche CSS-Klassen |
| `CustomStyle` | string | "" | Benutzerdefinierte Inline-Styles |

#### Grid-Presets

| Preset | Min-Breite | Verwendung |
|--------|------------|------------|
| `XLarge` | 450px | Overview-Bereiche |
| `Large` | 350px | Große Karten |
| `Medium` | 320px | News, QuickLinks, Activities |
| `Small` | 250px | Values, Principles, Team |
| `Compact` | 280px | FAQ, kompakte Listen |
| `Single` | 100% | Einzelspaltige Layouts |

#### Beispiel

```razor
<BaseGrid Preset="GridPreset.Medium">
    <BaseCard Variant="CardVariant.News">
        <TextContent>Artikel 1</TextContent>
    </BaseCard>
    <BaseCard Variant="CardVariant.News">
        <TextContent>Artikel 2</TextContent>
    </BaseCard>
    <BaseCard Variant="CardVariant.News">
        <TextContent>Artikel 3</TextContent>
    </BaseCard>
</BaseGrid>
```

---

### BaseSection

Einfacher Section-Wrapper mit konsistentem Margin für strukturierte Layouts.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Section-Inhalt |
| `CssClass` | string | "" | Zusätzliche CSS-Klassen |

#### Beispiel

```razor
<BaseSection>
    <Titel Level="2">Meine Sektion</Titel>
    <BaseGrid Preset="GridPreset.Medium">
        <!-- Grid-Inhalte -->
    </BaseGrid>
</BaseSection>
```

---

### Titel

Überschriften-Komponente (H1-H6) mit konsistentem Styling und Ausrichtungsoptionen.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Überschriften-Text |
| `Level` | int | 2 | Überschriften-Level (1-6) |
| `Alignment` | TextAlignment | Left | Textausrichtung |
| `CssClass` | string | "" | Zusätzliche CSS-Klassen |
| `Style` | string | "" | Inline-Styles |

#### TextAlignment-Optionen

- `Left` - Linksbündig
- `Center` - Zentriert
- `Right` - Rechtsbündig
- `Justify` - Blocksatz

#### Beispiel

```razor
<Titel Level="1" Alignment="TextAlignment.Center">
    Hauptüberschrift
</Titel>

<Titel Level="3">
    Unterüberschrift
</Titel>
```

---

### TextContent

Formatierte Text-Komponente mit verschiedenen Stil-Varianten, flexibler Ausrichtung und Spacing-Kontrolle.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Text-Inhalt |
| `Variant` | TextVariant | Default | Text-Stil |
| `Alignment` | TextAlignment | Left | Textausrichtung |
| `Display` | DisplayMode | Block | Display-Modus |
| `Padding` | SpacingSize | Default | Padding-Größe |
| `Margin` | SpacingSize | Default | Margin-Größe |
| `CssClass` | string | "" | Zusätzliche CSS-Klassen |
| `Style` | string | "" | Inline-Styles |

#### Varianten

| Variante | Beschreibung | HTML-Tag |
|----------|--------------|----------|
| `Default` | Standard-Text | `<p>` |
| `Bold` | Fett | `<strong>` |
| `Italic` | Kursiv | `<i>` |
| `Muted` | Gedämpfter Text | `<p>` |
| `Highlight` | Hervorgehoben | `<p>` |

#### TextAlignment-Optionen

- `Left` - Linksbündig
- `Center` - Zentriert
- `Right` - Rechtsbündig
- `Justify` - Blocksatz

#### DisplayMode-Optionen

| Mode | Beschreibung |
|------|--------------|
| `Block` | Block-Element (neue Zeile) |
| `Inline` | Inline-Element (im Textfluss) |
| `InlineBlock` | Inline-Block (kombiniert beide) |

#### SpacingSize-Optionen

| Größe | Padding | Margin |
|-------|---------|--------|
| `Default` | Standard | Standard (1rem) |
| `None` | 0 | 0 |
| `Small` | 0.5rem | 0.5rem |
| `Medium` | 1rem | 1rem |
| `Large` | 1.5rem | 2rem |

#### Beispiele

```razor
<!-- Normaler Text -->
<TextContent>Normaler Text</TextContent>

<!-- Fetter, zentrierter Text -->
<TextContent Variant="TextVariant.Bold" Alignment="TextAlignment.Center">
    Fetter, zentrierter Text
</TextContent>

<!-- Hervorgehobener Text mit großem Margin -->
<TextContent Variant="TextVariant.Highlight" Margin="SpacingSize.Large">
    Hervorgehobener Text
</TextContent>

<!-- Inline-Text mit kleinem Padding -->
<TextContent Display="DisplayMode.Inline" Padding="SpacingSize.Small">
    Inline-Text
</TextContent>

<!-- Gedämpfter Text rechtsbündig -->
<TextContent Variant="TextVariant.Muted" Alignment="TextAlignment.Right">
    Gedämpfter rechtsbündiger Text
</TextContent>
```

---

### TextLink

Gestylte Link-Komponente mit animierten Hover-Effekten.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Link-Text |
| `Href` | string | "#" | Ziel-URL |
| `Target` | string | "_self" | Link-Target |
| `Class` | string | "" | CSS-Klassen |
| `Style` | string | "" | Inline-Styles |
| `OnClick` | EventCallback | - | Click-Event |

#### Beispiel

```razor
<TextLink Href="https://example.com" Target="_blank">
    Externer Link
</TextLink>
```

---

### Button

Vielseitige Button-Komponente mit mehreren Varianten, optional als Link verwendbar.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Button-Text |
| `Variant` | ButtonVariant | Primary | Button-Stil |
| `Href` | string? | null | Optional: Als Link rendern |
| `Target` | string | "_self" | Link-Target |
| `Type` | string | "button" | Button-Type |
| `Icon` | string | "" | Icon-Klasse |
| `Disabled` | bool | false | Button deaktiviert |
| `CssClass` | string | "" | Zusätzliche CSS-Klassen |
| `OnClick` | EventCallback | - | Click-Event |

#### Varianten

| Variante | Verwendung |
|----------|------------|
| `Primary` | Hauptaktionen |
| `Secondary` | Sekundäre Aktionen |
| `Tertiary` | Tertiäre Aktionen |
| `Success` | Erfolgsaktionen |
| `Warning` | Warnungen |
| `Danger` | Gefährliche Aktionen |
| `Link` | Link-Stil |

#### Beispiel

```razor
<Button Variant="ButtonVariant.Primary" OnClick="HandleClick">
    Klick mich
</Button>

<Button Variant="ButtonVariant.Success" Href="/success" Icon="fa fa-check">
    Weiter
</Button>
```

---

### Emoji

Emoji-Anzeige-Komponente mit verschiedenen Größen-Levels, optionalem Schatten und Unterstützung für zusätzliche HTML-Attribute.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `EmojiChar` | string | "" | Emoji-Zeichen |
| `Level` | int | 0 | Größen-Level (0-6) |
| `Shadow` | bool | false | Text-Schatten aktivieren |
| `Class` | string | "" | CSS-Klassen |
| `Style` | string | "" | Inline-Styles |
| `AdditionalAttributes` | Dictionary<string, object>? | null | Zusätzliche HTML-Attribute |

#### Größen-Levels

| Level | Größe |
|-------|-------|
| 0 | Standard |
| 1 | 1rem |
| 2 | 2rem |
| 3 | 3rem |
| 4 | 4rem |
| 5 | 5rem |
| 6 | 6rem |

#### Emoji-Konstanten

Die Komponente bietet über 200 vordefinierte Emoji-Konstanten in der `Emojis`-Klasse:

```razor
<Emoji EmojiChar="@Emojis.Rocket" Level="3" />
<Emoji EmojiChar="@Emojis.Fire" Level="2" Shadow="true" />
<Emoji EmojiChar="🎉" Level="4" />
```

**Beliebte Emojis:**
- `Emojis.Rocket` 🚀 - Rakete
- `Emojis.Fire` 🔥 - Feuer
- `Emojis.Star` ⭐ - Stern
- `Emojis.RedHeart` ❤️ - Rotes Herz
- `Emojis.CircleWithCheck` ✅ - Häkchen
- `Emojis.Warning` ⚠️ - Warnung
- `Emojis.LightBulb` 💡 - Glühbirne
- `Emojis.Trophy` 🏆 - Trophäe
- `Emojis.Target` 🎯 - Zielscheibe
- `Emojis.Sparkles` ✨ - Funkeln

#### Kategorien

Die Emoji-Konstanten sind in verschiedene Kategorien unterteilt:

- **Transport:** Airplane, Car, Rocket, Ship, Train, Bicycle
- **Tiere:** Cat, Dog, Dragon, Butterfly, Bird, Bear
- **Essen:** Pizza, Burger, Coffee, IceCream, Sushi
- **Natur:** Sun, Moon, Star, Rainbow, Tree, Flower
- **Symbole:** Heart, CheckMark, Warning, Info, Fire
- **Aktivitäten:** Gaming, Music, Sports, Party
- **Objekte:** Book, Camera, Phone, Computer
- **Farben:** RedSquare, BlueSquare, GreenSquare (mit Heart-Varianten)

Für die vollständige Liste siehe [Emojis.cs](PageComponents/Components/Emojis.cs) - über 200 Emojis verfügbar!

#### Beispiele

```razor
<!-- Einfaches Emoji -->
<Emoji EmojiChar="@Emojis.Rocket" Level="2" />

<!-- Emoji mit Schatten -->
<Emoji EmojiChar="@Emojis.Star" Level="3" Shadow="true" />

<!-- Großes Emoji mit Custom-Klasse -->
<Emoji EmojiChar="@Emojis.Fire" Level="5" Class="my-custom-class" />

<!-- Emoji mit zusätzlichen Attributen -->
<Emoji EmojiChar="@Emojis.Heart" 
       Level="2" 
       Shadow="true"
       AdditionalAttributes="@(new Dictionary<string, object> { { "data-tooltip", "Gefällt mir" } })" />
```

---

### EventDate

Formatierte Event-Datum-Anzeige mit gestyltem Badge.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Datum-Text |

#### Beispiel

```razor
<EventDate>15. Dezember 2024</EventDate>
```

---

### CardNr

Nummerierte Badge-Komponente für Karten (positioniert oben links).

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | - | Nummer |

#### Beispiel

```razor
<BaseCard Variant="CardVariant.Legal">
    <CardNr>1</CardNr>
    <Titel Level="3">Erste Regel</Titel>
    <TextContent>Regeltext...</TextContent>
</BaseCard>
```

---

### TelegramLink

Vorgefertigter Link zu Telegram-Profilen mit flexiblen Anzeige-Optionen.

#### Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `Username` | string | "" | Telegram-Username |
| `DisplayName` | string | "" | Anzeigetext (optional) |
| `ChildContent` | RenderFragment? | null | Custom Content (optional) |

#### Beispiel

```razor
<!-- Einfacher Link mit Username -->
<TelegramLink Username="meinusername" />

<!-- Link mit Display-Name -->
<TelegramLink Username="meinusername" DisplayName="Mein Name" />

<!-- Link mit Custom Content -->
<TelegramLink Username="meinusername">
    <Emoji EmojiChar="@Emojis.Chat" Level="1" /> Kontaktiere mich
</TelegramLink>
```

---

## 🎨 Theming & Dark Mode

Das Package unterstützt **automatisches Light/Dark-Theme** basierend auf den System-Präferenzen (`prefers-color-scheme`).

### CSS-Variablen

Die Komponenten nutzen CSS Custom Properties für vollständige Anpassbarkeit:

#### Hauptfarben

```css
:root {
    /* Logo-basierte Farben */
    --primary-color: hsl(199, 100%, 84%);
    --secondary-color: hsl(15, 69%, 53%);
    --tertiary-color: hsl(119, 54%, 65%);
}
```

#### Hintergrundfarben

```css
:root {
    --bg-primary: hsl(0, 0%, 88%);      /* Haupthintergrund */
    --bg-secondary: hsl(0, 0%, 93%);    /* Cards, etc. */
    --bg-tertiary: hsl(0, 0%, 98%);     /* Sub-Elemente */
}
```

#### Textfarben

```css
:root {
    --text-primary: hsl(0, 0%, 10%);    /* Haupttext */
    --text-secondary: hsl(0, 0%, 25%);  /* Sekundärtext */
    --text-tertiary: hsl(0, 0%, 40%);   /* Tertiärtext */
}
```

#### Abgrenzungsfarben

```css
:root {
    --border-primary: hsl(0, 0%, 75%);
    --border-secondary: hsl(0, 0%, 50%);
    --border-tertiary: hsl(0, 0%, 25%);
}
```

#### Status-Farben

```css
:root {
    --success-color: hsl(134, 61%, 61%);
    --warning-color: hsl(54, 100%, 60%);
    --danger-color: hsl(354, 71%, 53%);
    --error-color: hsl(0, 100%, 60%);
    --info-color: hsl(207, 100%, 60%);
}
```

### Eigenes Theme

Überschreibe die Variablen in deinem eigenen Stylesheet:

```css
:root {
    --primary-color: #your-color;
    --secondary-color: #your-color;
    --bg-primary: #your-background;
}

/* Nur für Dark Mode überschreiben */
@media (prefers-color-scheme: dark) {
    :root {
        --primary-color: #your-dark-color;
    }
}
```

---

## 📋 Voraussetzungen

- **.NET 10.0** oder höher
- **Blazor WebAssembly** oder **Blazor Server**
- Modernes Browser mit CSS Custom Properties Support

---

## 🔧 Entwicklung

### Lokaler Build

```bash
dotnet build
```

### Package erstellen

```bash
dotnet pack --configuration Release
```

### Lokaler Test

Erstelle einen lokalen NuGet Feed:

```bash
dotnet nuget add source /path/to/packages -n LocalFeed
dotnet pack -o /path/to/packages
```

In einem Test-Projekt:

```bash
dotnet add package DragonSoft.PageComponents --source LocalFeed
```

---

## 📚 Vollständiges Beispiel

```razor
@page "/demo"
@using PageComponents.Components

<BaseSection>
    <Titel Level="1" Alignment="TextAlignment.Center">
        <Emoji EmojiChar="@Emojis.Rocket" Level="2" Shadow="true" />
        Willkommen
    </Titel>

    <BaseGrid Preset="GridPreset.Medium">
        <BaseCard Variant="CardVariant.Highlighted">
            <HeaderContent>
                <Titel Level="3">Feature 1</Titel>
                <EventDate>Neu!</EventDate>
            </HeaderContent>
            <ChildContent>
                <TextContent>Beschreibung des ersten Features.</TextContent>
                <TextContent Variant="TextVariant.Highlight" Margin="SpacingSize.Large">
                    Besonders wichtig!
                </TextContent>
            </ChildContent>
            <FooterContent>
                <Button Variant="ButtonVariant.Primary" Href="/feature1">
                    Mehr erfahren
                </Button>
            </FooterContent>
        </BaseCard>

        <BaseCard Variant="CardVariant.News">
            <HeaderContent>
                <Titel Level="3">
                    <Emoji EmojiChar="@Emojis.Announcement" Level="1" /> Neuigkeiten
                </Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent Variant="TextVariant.Bold" Alignment="TextAlignment.Center">
                    Aktuelle Updates
                </TextContent>
                <TextContent>
                    Entdecke die neuesten Features.
                </TextContent>
            </ChildContent>
        </BaseCard>

        <BaseCard Variant="CardVariant.Contact">
            <HeaderContent>
                <Titel Level="3">
                    <Emoji EmojiChar="@Emojis.Contact" Level="1" /> Kontakt
                </Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent Alignment="TextAlignment.Center">
                    Schreib uns auf 
                    <TelegramLink Username="support">
                        <Emoji EmojiChar="@Emojis.Chat" Level="1" /> Telegram
                    </TelegramLink>
                </TextContent>
            </ChildContent>
        </BaseCard>
    </BaseGrid>
</BaseSection>
```

---

## 🤝 Beitragen

Contributions sind willkommen! 

1. Fork das Repository
2. Erstelle einen Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit deine Änderungen (`git commit -m 'Add some AmazingFeature'`)
4. Push zum Branch (`git push origin feature/AmazingFeature`)
5. Öffne einen Pull Request

---

## 📄 Lizenz

Dieses Projekt ist unter der **MIT-Lizenz** lizenziert - siehe [LICENSE.txt](LICENSE.txt) für Details.

---

## 👤 Autor

**Kenthanar** - [DragonSoft](https://github.com/DIMnM)

---

## 📞 Support

- **Issues:** [GitHub Issues](https://github.com/DIMnM/DragonSoft.PageComponents/issues)
- **Discussions:** [GitHub Discussions](https://github.com/DIMnM/DragonSoft.PageComponents/discussions)
- **NuGet:** [DragonSoft.PageComponents](https://www.nuget.org/packages/DragonSoft.PageComponents/)

---

## 🗺️ Roadmap

- [ ] Weitere Button-Varianten
- [ ] Modal-/Dialog-Komponenten
- [ ] Tab-Komponenten
- [ ] Accordion-Komponenten
- [ ] Toast-Notifications
- [ ] Form-Komponenten
- [ ] Weitere Grid-Layout-Optionen
- [ ] Animation-Utilities
- [ ] Table-Komponenten
- [ ] Badge-Komponenten
- [ ] Progress-Bar-Komponenten

---

## 📝 Changelog

### Version 1.1.11
- Vollständige .NET 10.0 Unterstützung
- Über 200 vordefinierte Emoji-Konstanten
- Erweiterte TextContent-Komponente mit Spacing-Kontrolle
- Emoji-Komponente mit Shadow-Support
- Verbesserte Dokumentation

### Version 1.1.12.1
- Dynamische Anpassung für den BorderRadius der BaseCard-Komponente und des Buttons


---

**Version:** 1.2.0
**Target Framework:** .NET 10.0  
**Package ID:** DragonSoft.PageComponents  
**Repository:** [GitHub](https://github.com/DIMnM/DragonSoft.PageComponents)
