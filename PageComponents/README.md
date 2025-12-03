# DragonSoft.PageComponents

Eine moderne, umfassende Sammlung wiederverwendbarer UI-Komponenten für Blazor und Razor. Die Bibliothek unterstützt .NET 8.0, 9.0 und 10.0 und bietet eine vollständige Collection von Layout-, Text-, Button- und Spezialkomponenten mit automatischem Light/Dark-Theme-Support.

[![NuGet](https://img.shields.io/nuget/v/DragonSoft.PageComponents.svg)](https://www.nuget.org/packages/DragonSoft.PageComponents/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%209.0%20%7C%2010.0-512BD4)](https://dotnet.microsoft.com/)

## 🌟 Features

- ✅ **Multi-Framework-Support:** .NET 8.0, 9.0 und 10.0 in einem Package
- 🎨 **Automatisches Light/Dark-Theme:** Basierend auf System-Präferenzen
- 📱 **Fully Responsive:** Mobile-first Design
- 🎯 **11 Komponenten:** Von Layout bis Spezial-Features
- 🚀 **Production-Ready:** Getestet und optimiert
- 📦 **Easy Integration:** Einfache Installation via NuGet
- 🎭 **19+ Card-Varianten:** Für jeden Anwendungsfall
- 😀 **200+ Emoji-Konstanten:** Vordefiniert und typsicher
- 🔧 **Vollständig anpassbar:** CSS Custom Properties
- 📝 **Umfassend dokumentiert:** Mit Beispielen

---

## 📦 Installation

### Via .NET CLI

```bash
dotnet add package DragonSoft.PageComponents
```

### Via Package Manager Console

```powershell
Install-Package DragonSoft.PageComponents
```

### Via PackageReference

```xml
<PackageReference Include="DragonSoft.PageComponents" Version="1.2.2" />
```

---

## 🚀 Schnellstart

### 1. Namespace importieren

Füge in `_Imports.razor` hinzu:

```razor
@using PageComponents.Components
```

### 2. CSS-Dateien einbinden

In `App.razor`, `index.html` oder `_Host.cshtml`:

```html
<!-- Haupt-Stylesheet -->
<link href="_content/PageComponents/app.css" rel="stylesheet" />

<!-- Komponenten-Scoped Styles -->
<link href="PageComponents.styles.css" rel="stylesheet" />
```

### 3. Erste Komponente verwenden

```razor
@page "/"

<BaseSection>
    <Titel Level="1" Alignment="TextAlignment.Center">
        <Emoji EmojiChar="@Emojis.Rocket" Level="2" Shadow="true" />
        Willkommen!
    </Titel>
    
    <BaseCard Variant="CardVariant.Highlighted">
        <HeaderContent>
            <Titel Level="3">Meine erste Karte</Titel>
        </HeaderContent>
        <ChildContent>
            <TextContent>Hier kommt dein Inhalt rein.</TextContent>
        </ChildContent>
        <FooterContent>
            <Button Variant="ButtonVariant.Primary">Klick mich!</Button>
        </FooterContent>
    </BaseCard>
</BaseSection>
```

---

## 🎨 Komponenten-Übersicht

### 📐 Layout-Komponenten

| Komponente | Beschreibung | Varianten |
|------------|--------------|-----------|
| **[BaseCard](#basecard)** | Flexible Karten-Komponente mit Header/Footer | 19+ Varianten |
| **[BaseGrid](#basegrid)** | Responsive Grid-System | 6 Presets |
| **[BaseSection](#basesection)** | Section-Wrapper für Struktur | - |

### 📝 Text-Komponenten

| Komponente | Beschreibung | Features |
|------------|--------------|----------|
| **[Titel](#titel)** | Überschriften H1-H6 | Alignment, Custom Styles |
| **[TextContent](#textcontent)** | Formatierter Text | 5 Varianten, Spacing |
| **[TextLink](#textlink)** | Gestylte Links | Hover-Effekte, Events |

### 🔘 Button-Komponenten

| Komponente | Beschreibung | Varianten |
|------------|--------------|-----------|
| **[Button](#button)** | Vielseitige Buttons | 7 Varianten, Icons |

### ✨ Spezial-Komponenten

| Komponente | Beschreibung | Features |
|------------|--------------|----------|
| **[Emoji](#emoji)** | Emoji-Anzeige | 7 Größen, Shadow, 200+ Konstanten |
| **[EventDate](#eventdate)** | Event-Datum Badge | Styled Badge |
| **[CardNr](#cardnr)** | Nummerierte Badge | Position oben-links |
| **[TelegramLink](#telegramlink)** | Telegram-Link | Custom Content |

---

## 📖 Detaillierte Komponenten-Dokumentation

### BaseCard

Eine hochflexible Karten-Komponente mit 19+ Varianten, optionalem Header/Footer, flexiblen Layout-Optionen und dynamisch anpassbarem BorderRadius.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Hauptinhalt der Karte |
| `HeaderContent` | RenderFragment? | `null` | Optionaler Header-Inhalt |
| `FooterContent` | RenderFragment? | `null` | Optionaler Footer-Inhalt |
| `ShowHeader` | bool | `true` | Header anzeigen |
| `ShowFooter` | bool | `true` | Footer anzeigen |
| `Variant` | CardVariant | `Default` | Vordefinierte Stilvariant |
| `CssClass` | string | `""` | Zusätzliche CSS-Klassen |
| `HeaderLayout` | HeaderLayout | `Default` | Header-Layout-Modus |
| `FooterLayout` | FooterLayout | `Default` | Footer-Layout-Modus |
| `HeaderAlign` | VerticalAlignment | `Stretch` | Vertikale Ausrichtung im Header |
| `FooterAlign` | VerticalAlignment | `Stretch` | Vertikale Ausrichtung im Footer |
| `BorderRadius` | string | `"8px"` | Border-Radius der Karte |

#### 🎨 Varianten

<table>
<tr><th>Variante</th><th>Beschreibung</th><th>Verwendung</th></tr>
<tr><td><code>Default</code></td><td>Standard-Kartenstil</td><td>Allgemeine Inhalte</td></tr>
<tr><td><code>Highlighted</code></td><td>Linker farbiger Akzent</td><td>Hervorgehobene Inhalte</td></tr>
<tr><td><code>Warning</code></td><td>Gelber Akzent</td><td>Warnungen</td></tr>
<tr><td><code>WarningSub</code></td><td>Gedämpfte Warnung</td><td>Untergeordnete Warnungen</td></tr>
<tr><td><code>Event</code></td><td>Border mit Hover</td><td>Event-Anzeigen</td></tr>
<tr><td><code>News</code></td><td>News-Stil</td><td>Nachrichtenartikel</td></tr>
<tr><td><code>NewsSub</code></td><td>Gedämpfter News-Stil</td><td>Untergeordnete News</td></tr>
<tr><td><code>Note</code></td><td>Farbiger Hintergrund</td><td>Wichtige Notizen</td></tr>
<tr><td><code>Detail</code></td><td>Border-Stil</td><td>Detailansichten</td></tr>
<tr><td><code>Consequences</code></td><td>Warning + Border</td><td>Wichtige Konsequenzen</td></tr>
<tr><td><code>Sub</code></td><td>Tertiärer Hintergrund</td><td>Untergeordnete Inhalte</td></tr>
<tr><td><code>Hero</code></td><td>Primary-Color Hintergrund</td><td>Hero-Sektionen</td></tr>
<tr><td><code>Cta</code></td><td>Gradient-Hintergrund</td><td>Call-to-Action</td></tr>
<tr><td><code>Join</code></td><td>Gradient-Stil</td><td>Beitritts-Bereiche</td></tr>
<tr><td><code>Contact</code></td><td>Kontakt-Stil</td><td>Kontaktinformationen</td></tr>
<tr><td><code>Legal</code></td><td>Rechtlicher Stil</td><td>Rechtliche Inhalte</td></tr>
<tr><td><code>Rules</code></td><td>Regelwerk-Stil</td><td>Regelungen</td></tr>
<tr><td><code>RulesSub</code></td><td>Gedämpfte Regeln</td><td>Unter-Regelungen</td></tr>
<tr><td><code>Info</code></td><td>Zentrierte Info-Box</td><td>Informationen</td></tr>
</table>

#### 📐 Layout-Optionen

**Header/Footer Layout:**
- `Default` - Block-Layout
- `SpaceBetween` - Flex mit space-between
- `SpaceAround` - Flex mit space-around
- `SpaceEvenly` - Flex mit space-evenly
- `Center` - Zentriert
- `Start` - Linksbündig
- `End` - Rechtsbündig

**Vertikale Ausrichtung:**
- `Start` - Oben
- `Center` - Mittig
- `End` - Unten
- `Stretch` - Gestreckt (Standard)

#### 💡 Beispiele

```razor
<!-- Einfache Karte -->
<BaseCard>
    <TextContent>Einfacher Inhalt</TextContent>
</BaseCard>

<!-- Karte mit Header und Footer -->
<BaseCard Variant="CardVariant.Highlighted" BorderRadius="16px">
    <HeaderContent>
        <Titel Level="3">Überschrift</Titel>
        <EventDate>Neu!</EventDate>
    </HeaderContent>
    <ChildContent>
        <TextContent>Karteninhalt mit größerem BorderRadius.</TextContent>
    </ChildContent>
    <FooterContent>
        <Button Variant="ButtonVariant.Primary">Mehr erfahren</Button>
    </FooterContent>
</BaseCard>

<!-- Event-Karte mit zentrierter Ausrichtung -->
<BaseCard Variant="CardVariant.Event"
          HeaderLayout="HeaderLayout.SpaceBetween"
          HeaderAlign="VerticalAlignment.Center">
    <HeaderContent>
        <Titel Level="3">Live-Konzert</Titel>
        <EventDate>15. Dez</EventDate>
    </HeaderContent>
    <ChildContent>
        <TextContent>Rock am Ring 2024</TextContent>
    </ChildContent>
</BaseCard>

<!-- CTA-Karte -->
<BaseCard Variant="CardVariant.Cta" BorderRadius="20px">
    <HeaderContent>
        <Titel Level="2" Alignment="TextAlignment.Center">Jetzt starten!</Titel>
    </HeaderContent>
    <ChildContent>
        <TextContent Alignment="TextAlignment.Center">
            Entdecke alle Features noch heute.
        </TextContent>
    </ChildContent>
    <FooterContent>
        <Button Variant="ButtonVariant.Primary" 
                Href="/start"
                BorderRadius="25px">
            Los geht's
        </Button>
    </FooterContent>
</BaseCard>

<!-- Regel-Karte mit Nummer -->
<BaseCard Variant="CardVariant.Legal">
    <CardNr>1</CardNr>
    <Titel Level="4">Erste Regel</Titel>
    <TextContent>Beschreibung der Regel...</TextContent>
</BaseCard>
```

---

### BaseGrid

Ein responsives Grid-Layout-System mit vordefinierten Presets für verschiedene Anwendungsfälle. Wechselt automatisch auf eine Spalte bei mobilen Geräten.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Grid-Elemente |
| `Preset` | GridPreset | `Medium` | Vordefiniertes Grid-Layout |
| `CssClass` | string | `""` | Zusätzliche CSS-Klassen |
| `CustomStyle` | string | `""` | Benutzerdefinierte Inline-Styles |

#### 📏 Grid-Presets

| Preset | Min-Breite | Verwendung |
|--------|------------|------------|
| `XLarge` | 450px | Overview-Bereiche, große Dashboards |
| `Large` | 350px | Große Karten, Feature-Übersichten |
| `Medium` | 320px | News, QuickLinks, Activities (Standard) |
| `Small` | 250px | Values, Principles, Team-Member |
| `Compact` | 280px | FAQ, kompakte Listen |
| `Single` | 100% | Einzelspaltige Layouts |

#### 💡 Beispiele

```razor
<!-- Standard Grid (Medium) -->
<BaseGrid>
    <BaseCard>Karte 1</BaseCard>
    <BaseCard>Karte 2</BaseCard>
    <BaseCard>Karte 3</BaseCard>
</BaseGrid>

<!-- Large Grid für Features -->
<BaseGrid Preset="GridPreset.Large">
    @foreach (var feature in features)
    {
        <BaseCard Variant="CardVariant.Highlighted">
            <TextContent>@feature.Description</TextContent>
        </BaseCard>
    }
</BaseGrid>

<!-- Compact Grid für FAQ -->
<BaseGrid Preset="GridPreset.Compact">
    <BaseCard Variant="CardVariant.Detail">
        <Titel Level="4">Frage 1?</Titel>
        <TextContent>Antwort...</TextContent>
    </BaseCard>
    <BaseCard Variant="CardVariant.Detail">
        <Titel Level="4">Frage 2?</Titel>
        <TextContent>Antwort...</TextContent>
    </BaseCard>
</BaseGrid>

<!-- Custom Gap -->
<BaseGrid Preset="GridPreset.Medium" CustomStyle="gap: 3rem;">
    <BaseCard>Größerer Abstand</BaseCard>
    <BaseCard>Zwischen den Karten</BaseCard>
</BaseGrid>
```

---

### BaseSection

Ein einfacher Section-Wrapper mit konsistentem Margin für strukturierte Seitenlayouts.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Section-Inhalt |
| `CssClass` | string | `""` | Zusätzliche CSS-Klassen |

#### 💡 Beispiele

```razor
<!-- Einfache Section -->
<BaseSection>
    <Titel Level="2">Meine Sektion</Titel>
    <TextContent>Section-Inhalt...</TextContent>
</BaseSection>

<!-- Section mit Grid -->
<BaseSection>
    <Titel Level="2" Alignment="TextAlignment.Center">Unsere Services</Titel>
    <BaseGrid Preset="GridPreset.Large">
        <BaseCard>Service 1</BaseCard>
        <BaseCard>Service 2</BaseCard>
        <BaseCard>Service 3</BaseCard>
    </BaseGrid>
</BaseSection>

<!-- Mit Custom CSS-Klasse -->
<BaseSection CssClass="hero-section">
    <BaseCard Variant="CardVariant.Hero">
        <Titel Level="1">Willkommen</Titel>
    </BaseCard>
</BaseSection>
```

---

### Titel

Eine Überschriften-Komponente (H1-H6) mit konsistentem Styling, Ausrichtungsoptionen und responsive Größenanpassung.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Überschriften-Text |
| `Level` | int | `2` | Überschriften-Level (1-6) |
| `Alignment` | TextAlignment | `Left` | Textausrichtung |
| `CssClass` | string | `""` | Zusätzliche CSS-Klassen |
| `Style` | string | `""` | Inline-Styles |

#### 🎯 Alignment-Optionen

- `Left` - Linksbündig (Standard)
- `Center` - Zentriert
- `Right` - Rechtsbündig
- `Justify` - Blocksatz

#### 💡 Beispiele

```razor
<!-- H1 zentriert -->
<Titel Level="1" Alignment="TextAlignment.Center">
    Hauptüberschrift
</Titel>

<!-- Standard H2 -->
<Titel>Standardüberschrift</Titel>

<!-- H3 mit Emoji -->
<Titel Level="3">
    <Emoji EmojiChar="@Emojis.Star" Level="1" /> Features
</Titel>

<!-- H4 rechtsbündig -->
<Titel Level="4" Alignment="TextAlignment.Right">
    Rechtsbündige Überschrift
</Titel>

<!-- Mit Custom Style -->
<Titel Level="2" 
       CssClass="custom-title" 
       Style="text-transform: uppercase;">
    Custom Styling
</Titel>
```

---

### TextContent

Eine formatierte Text-Komponente mit verschiedenen Stil-Varianten, flexibler Ausrichtung und vollständiger Spacing-Kontrolle.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Text-Inhalt |
| `Variant` | TextVariant | `Default` | Text-Stil |
| `Alignment` | TextAlignment | `Left` | Textausrichtung |
| `Display` | DisplayMode | `Block` | Display-Modus |
| `Padding` | SpacingSize | `Default` | Padding-Größe |
| `Margin` | SpacingSize | `Default` | Margin-Größe |
| `CssClass` | string | `""` | Zusätzliche CSS-Klassen |
| `Style` | string | `""` | Inline-Styles |

#### 🎨 Varianten

| Variante | Beschreibung | HTML-Tag | CSS-Klasse |
|----------|--------------|----------|------------|
| `Default` | Standard-Text | `<p>` | `.text-content` |
| `Bold` | Fett | `<strong>` | `.text-bold` |
| `Italic` | Kursiv | `<i>` | `.text-italic` |
| `Muted` | Gedämpft | `<p>` | `.text-muted` |
| `Highlight` | Hervorgehoben | `<p>` | `.text-highlight` |

#### 📐 Layout-Optionen

**TextAlignment:**
- `Left` - Linksbündig
- `Center` - Zentriert
- `Right` - Rechtsbündig
- `Justify` - Blocksatz

**DisplayMode:**
- `Block` - Block-Element (neue Zeile)
- `Inline` - Inline-Element (im Textfluss)
- `InlineBlock` - Kombiniert beide

**SpacingSize:**

| Größe | Padding | Margin |
|-------|---------|--------|
| `Default` | Standard | 1rem |
| `None` | 0 | 0 |
| `Small` | 0.5rem | 0.5rem |
| `Medium` | 1rem | 1rem |
| `Large` | 1.5rem | 2rem |

#### 💡 Beispiele

```razor
<!-- Normaler Text -->
<TextContent>Dies ist ein normaler Text.</TextContent>

<!-- Fetter, zentrierter Text -->
<TextContent Variant="TextVariant.Bold" 
             Alignment="TextAlignment.Center">
    Wichtige zentrale Nachricht
</TextContent>

<!-- Hervorgehobener Text mit großem Margin -->
<TextContent Variant="TextVariant.Highlight" 
             Margin="SpacingSize.Large">
    Besonders wichtiger Hinweis
</TextContent>

<!-- Inline-Text -->
<TextContent Display="DisplayMode.Inline">
    Dieser Text ist im Textfluss
</TextContent>
<TextContent Display="DisplayMode.Inline" Variant="TextVariant.Bold">
    und dieser ist fett
</TextContent>

<!-- Gedämpfter Text ohne Margin -->
<TextContent Variant="TextVariant.Muted" 
             Margin="SpacingSize.None">
    Zusatzinformation
</TextContent>

<!-- Kursiv mit Padding -->
<TextContent Variant="TextVariant.Italic" 
             Padding="SpacingSize.Medium">
    Zitat oder Anmerkung
</TextContent>

<!-- Rechtsbündig -->
<TextContent Alignment="TextAlignment.Right">
    Rechts ausgerichtet
</TextContent>
```

---

### TextLink

Eine gestylte Link-Komponente mit animierten Hover-Effekten und Event-Handling.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Link-Text |
| `Href` | string | `"#"` | Ziel-URL |
| `Target` | string | `"_self"` | Link-Target |
| `Class` | string | `""` | CSS-Klassen |
| `Style` | string | `""` | Inline-Styles |
| `OnClick` | EventCallback | - | Click-Event |

#### 💡 Beispiele

```razor
<!-- Einfacher Link -->
<TextLink Href="/about">Über uns</TextLink>

<!-- Externer Link -->
<TextLink Href="https://example.com" Target="_blank">
    Externe Website
</TextLink>

<!-- Mit Click-Event -->
<TextLink Href="#" OnClick="HandleClick">
    Klickbarer Link
</TextLink>

<!-- Im Text eingebettet -->
<TextContent>
    Besuche unsere <TextLink Href="/services">Services-Seite</TextLink> 
    für mehr Informationen.
</TextContent>

<!-- Mit Custom CSS -->
<TextLink Href="/contact" Class="special-link">
    Kontaktiere uns
</TextLink>
```

---

### Button

Eine vielseitige Button-Komponente mit 7 Varianten, Icon-Support, optional als Link verwendbar und dynamisch anpassbarem BorderRadius.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Button-Text |
| `Variant` | ButtonVariant | `Primary` | Button-Stil |
| `Href` | string? | `null` | Optional: Als Link rendern |
| `Target` | string | `"_self"` | Link-Target (mit Href) |
| `Type` | string | `"button"` | Button-Type (button/submit/reset) |
| `Icon` | string | `""` | Icon-Klasse (z.B. Font Awesome) |
| `Disabled` | bool | `false` | Button deaktiviert |
| `CssClass` | string | `""` | Zusätzliche CSS-Klassen |
| `BorderRadius` | string | `"8px"` | Border-Radius |
| `OnClick` | EventCallback | - | Click-Event |

#### 🎨 Varianten

| Variante | Farbe | Verwendung |
|----------|-------|------------|
| `Primary` | Primary Color | Hauptaktionen, CTA |
| `Secondary` | Secondary Color | Sekundäre Aktionen |
| `Tertiary` | Tertiary Color | Tertiäre Aktionen |
| `Success` | Grün | Bestätigungen, Speichern |
| `Warning` | Gelb | Warnungen |
| `Danger` | Rot | Löschen, gefährliche Aktionen |
| `Link` | Transparent | Link-ähnliche Buttons |

#### 💡 Beispiele

```razor
<!-- Standard Primary Button -->
<Button OnClick="HandleClick">Klick mich</Button>

<!-- Success Button mit Icon -->
<Button Variant="ButtonVariant.Success" 
        Icon="fa fa-check"
        OnClick="Save">
    Speichern
</Button>

<!-- Button als Link -->
<Button Variant="ButtonVariant.Primary" 
        Href="/start">
    Jetzt starten
</Button>

<!-- Danger Button deaktiviert -->
<Button Variant="ButtonVariant.Danger" 
        Disabled="true"
        Icon="fa fa-trash">
    Löschen
</Button>

<!-- Button mit externem Link -->
<Button Variant="ButtonVariant.Secondary"
        Href="https://docs.example.com"
        Target="_blank"
        Icon="fa fa-external-link">
    Dokumentation
</Button>

<!-- Submit Button in Form -->
<Button Type="submit" 
        Variant="ButtonVariant.Success">
    Formular absenden
</Button>

<!-- Link-Style Button -->
<Button Variant="ButtonVariant.Link" 
        OnClick="ShowMore">
    Mehr anzeigen
</Button>

<!-- Button mit Custom BorderRadius -->
<Button Variant="ButtonVariant.Primary" 
        BorderRadius="25px"
        Icon="fa fa-rocket">
    Vollständig rund
</Button>

<!-- Button-Gruppe -->
<div style="display: flex; gap: 1rem;">
    <Button Variant="ButtonVariant.Success">Ja</Button>
    <Button Variant="ButtonVariant.Danger">Nein</Button>
    <Button Variant="ButtonVariant.Secondary">Abbrechen</Button>
</div>
```

---

### Emoji

Eine Emoji-Anzeige-Komponente mit 7 Größen-Levels, optionalem Schatten und Unterstützung für zusätzliche HTML-Attribute.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `EmojiChar` | string | `""` | Emoji-Zeichen |
| `Level` | int | `0` | Größen-Level (0-6) |
| `Shadow` | bool | `false` | Text-Schatten aktivieren |
| `Class` | string | `""` | CSS-Klassen |
| `Style` | string | `""` | Inline-Styles |
| `AdditionalAttributes` | Dictionary<string, object>? | `null` | Zusätzliche HTML-Attribute |

#### 📏 Größen-Levels

| Level | Größe | Verwendung |
|-------|-------|------------|
| `0` | inherit | Standard (übernimmt Textgröße) |
| `1` | 1rem (16px) | Klein, inline im Text |
| `2` | 2rem (32px) | Mittel, in Überschriften |
| `3` | 3rem (48px) | Groß, als Icon |
| `4` | 4rem (64px) | Sehr groß, Hero-Bereiche |
| `5` | 5rem (80px) | Extra groß, Highlights |
| `6` | 6rem (96px) | Maximum, Eye-Catcher |

#### 😀 Emoji-Konstanten (200+)

**Beliebte Emojis:**

```csharp
// Transport
Emojis.Rocket       // 🚀
Emojis.Airplane     // ✈️
Emojis.Car          // 🚗

// Symbole
Emojis.Fire         // 🔥
Emojis.Star         // ⭐
Emojis.RedHeart     // ❤️
Emojis.CircleWithCheck // ✅
Emojis.Warning      // ⚠️
Emojis.LightBulb    // 💡
Emojis.Trophy       // 🏆

// Essen
Emojis.Pizza        // 🍕
Emojis.Coffee       // ☕
Emojis.Hamburger    // 🍔
Emojis.IceCream     // 🍨

// Natur
Emojis.Sun          // ☀️
Emojis.Moon         // 🌙
Emojis.Rainbow      // 🌈
Emojis.Tree         // 🌳

// Aktivitäten
Emojis.Music        // 🎶
Emojis.Party        // 🥳
Emojis.Gaming       // 🎮

// Objekte
Emojis.Book         // 📖
Emojis.Computer     // 🖥️
Emojis.Camera       // 📷
```

**Kategorien:**
- 🚗 **Transport:** Airplane, Car, Rocket, Ship, Train, Bicycle, Motorcycle
- 🐱 **Tiere:** Cat, Dog, Dragon, Butterfly, Bird, Bear, Fox, Lion, Panda
- 🍕 **Essen:** Pizza, Hamburger, Coffee, Sushi, Taco, IceCream, Donut
- 🌳 **Natur:** Sun, Moon, Star, Rainbow, Tree, Flower, Leaves, Cloud
- ❤️ **Herzen:** RedHeart, BlueHeart, GreenHeart, YellowHeart, PurpleHeart
- ✨ **Symbole:** CheckMark, Warning, Info, Fire, Sparkles
- 🎮 **Aktivitäten:** Gaming, Music, Sports, Party, Dance, Cinema
- 📱 **Objekte:** Book, Camera, Phone, Computer, Laptop
- 🎄 **Events:** ChristmasTree, Halloween, Fireworks, Party

> **Tipp:** Für die vollständige Liste siehe `Emojis.cs` - über 200 Konstanten verfügbar!

#### 💡 Beispiele

```razor
<!-- Einfaches Emoji -->
<Emoji EmojiChar="@Emojis.Rocket" Level="2" />

<!-- Emoji mit Schatten -->
<Emoji EmojiChar="@Emojis.Star" Level="3" Shadow="true" />

<!-- Großes Emoji -->
<Emoji EmojiChar="@Emojis.Fire" Level="5" />

<!-- Inline im Text -->
<TextContent>
    Willkommen <Emoji EmojiChar="@Emojis.RedHeart" /> auf unserer Seite
</TextContent>

<!-- In Überschrift -->
<Titel Level="2">
    <Emoji EmojiChar="@Emojis.Trophy" Level="2" Shadow="true" /> 
    Unsere Erfolge
</Titel>

<!-- Mit Tooltip -->
<Emoji EmojiChar="@Emojis.LightBulb" 
       Level="3"
       Shadow="true"
       AdditionalAttributes="@(new Dictionary<string, object> {
           { "title", "Tipp" },
           { "data-tooltip", "Wichtiger Hinweis" }
       })" />

<!-- Emoji-Reihe -->
<div style="display: flex; gap: 1rem;">
    <Emoji EmojiChar="@Emojis.Sun" Level="2" Shadow="true" />
    <Emoji EmojiChar="@Emojis.Moon" Level="2" Shadow="true" />
    <Emoji EmojiChar="@Emojis.Star" Level="2" Shadow="true" />
</div>

<!-- Hero-Bereich -->
<BaseCard Variant="CardVariant.Hero">
    <Emoji EmojiChar="@Emojis.Rocket" Level="6" Shadow="true" />
    <Titel Level="1">Bereit zum Start?</Titel>
</BaseCard>
```

---

### EventDate

Eine formatierte Event-Datum-Anzeige als gestyltes Badge.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Datum-Text |

#### 💡 Beispiele

```razor
<!-- Einfaches Datum -->
<EventDate>15. Dezember 2024</EventDate>

<!-- Mit Uhrzeit -->
<EventDate>20:00 Uhr</EventDate>

<!-- Nur Tag -->
<EventDate>Heute</EventDate>

<!-- In Card Header -->
<BaseCard Variant="CardVariant.Event">
    <HeaderContent>
        <Titel Level="3">Konzert</Titel>
        <EventDate>15. Dez 2024</EventDate>
    </HeaderContent>
    <ChildContent>
        <TextContent>Live-Musik am Marktplatz</TextContent>
    </ChildContent>
</BaseCard>

<!-- Mit Emoji -->
<BaseCard Variant="CardVariant.Event">
    <HeaderContent>
        <div style="display: flex; align-items: center; gap: 1rem;">
            <Emoji EmojiChar="@Emojis.Calendar" Level="2" />
            <Titel Level="3">Workshop</Titel>
        </div>
        <EventDate>20. Jan 2025</EventDate>
    </HeaderContent>
</BaseCard>
```

---

### CardNr

Eine nummerierte Badge-Komponente für Karten, positioniert oben links.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `ChildContent` | RenderFragment | **erforderlich** | Nummer oder Text |

#### 💡 Beispiele

```razor
<!-- Einfache Nummerierung -->
<BaseCard Variant="CardVariant.Legal">
    <CardNr>1</CardNr>
    <Titel Level="3">Erste Regel</Titel>
    <TextContent>Regeltext...</TextContent>
</BaseCard>

<!-- Mit Buchstaben -->
<BaseCard Variant="CardVariant.Rules">
    <CardNr>A</CardNr>
    <Titel Level="3">Abschnitt A</Titel>
    <TextContent>Abschnittstext...</TextContent>
</BaseCard>

<!-- Mehrere Karten -->
<BaseGrid Preset="GridPreset.Medium">
    @for (int i = 1; i <= 5; i++)
    {
        <BaseCard Variant="CardVariant.Legal">
            <CardNr>@i</CardNr>
            <Titel Level="4">Regel @i</Titel>
            <TextContent>Beschreibung der Regel @i</TextContent>
        </BaseCard>
    }
</BaseGrid>

<!-- In Compact Grid -->
<BaseGrid Preset="GridPreset.Compact">
    <BaseCard Variant="CardVariant.Rules">
        <CardNr>1</CardNr>
        <TextContent>Erste Anweisung</TextContent>
    </BaseCard>
    <BaseCard Variant="CardVariant.Rules">
        <CardNr>2</CardNr>
        <TextContent>Zweite Anweisung</TextContent>
    </BaseCard>
</BaseGrid>
```

---

### TelegramLink

Ein vorgefertigter Link zu Telegram-Profilen mit flexiblen Anzeige-Optionen.

#### 🔧 Parameter

| Parameter | Typ | Standard | Beschreibung |
|-----------|-----|----------|--------------|
| `Username` | string | `""` | Telegram-Username (ohne @) |
| `DisplayName` | string | `""` | Anzeigetext (optional) |
| `ChildContent` | RenderFragment? | `null` | Custom Content (optional) |

#### 💡 Beispiele

```razor
<!-- Einfacher Link mit Username -->
<TelegramLink Username="meinusername" />

<!-- Mit Display-Name -->
<TelegramLink Username="meinusername" DisplayName="Mein Name" />

<!-- Mit Custom Content und Emoji -->
<TelegramLink Username="support">
    <Emoji EmojiChar="@Emojis.Chat" Level="1" /> Support kontaktieren
</TelegramLink>

<!-- In Text eingebettet -->
<TextContent>
    Schreib uns auf 
    <TelegramLink Username="support">
        <Emoji EmojiChar="@Emojis.Chat" /> Telegram
    </TelegramLink>
</TextContent>

<!-- In Card -->
<BaseCard Variant="CardVariant.Contact">
    <HeaderContent>
        <Titel Level="3">
            <Emoji EmojiChar="@Emojis.Contact" Level="1" /> Kontakt
        </Titel>
    </HeaderContent>
    <ChildContent>
        <TextContent Alignment="TextAlignment.Center">
            <TelegramLink Username="support" DisplayName="Support-Team" />
        </TextContent>
    </ChildContent>
</BaseCard>

<!-- Mehrere Kontakte -->
<BaseGrid Preset="GridPreset.Small">
    <BaseCard Variant="CardVariant.Contact">
        <Emoji EmojiChar="@Emojis.Contact" Level="3" />
        <Titel Level="4">Sales</Titel>
        <TelegramLink Username="sales">Kontaktiere Sales</TelegramLink>
    </BaseCard>
    <BaseCard Variant="CardVariant.Contact">
        <Emoji EmojiChar="@Emojis.Contact" Level="3" />
        <Titel Level="4">Support</Titel>
        <TelegramLink Username="support">Kontaktiere Support</TelegramLink>
    </BaseCard>
</BaseGrid>
```

---

## 🎨 Theming & Styling

### Automatisches Light/Dark-Theme

Das Package bietet vollautomatisches Theme-Switching basierend auf `prefers-color-scheme`:

```css
/* Automatisch aktiviert bei System Dark Mode */
@media (prefers-color-scheme: dark) {
    /* Dark Theme Variablen */
}
```

### CSS Custom Properties

Alle Komponenten nutzen CSS Custom Properties für maximale Anpassbarkeit:

#### 🎨 Hauptfarben

```css
:root {
    /* Logo-basierte Primärfarben */
    --primary-color: hsl(199, 100%, 84%);
    --secondary-color: hsl(15, 69%, 53%);
    --tertiary-color: hsl(119, 54%, 65%);
    
    /* Transparente Varianten */
    --primary-transparent: hsla(199, 100%, 84%, 0.75);
    --primary-transparent-low: hsla(199, 100%, 84%, 0.2);
    --secondary-transparent: hsla(15, 87%, 53%, 0.75);
    --tertiary-transparent: hsla(119, 54%, 65%, 0.4);
}
```

#### 🎭 Hintergrund & Text

```css
:root {
    /* Hintergrundfarben - Light */
    --bg-primary: hsl(0, 0%, 88%);
    --bg-secondary: hsl(0, 0%, 93%);
    --bg-tertiary: hsl(0, 0%, 98%);
    
    /* Textfarben - Light */
    --text-primary: hsl(0, 0%, 10%);
    --text-secondary: hsl(0, 0%, 25%);
    --text-tertiary: hsl(0, 0%, 40%);
}

@media (prefers-color-scheme: dark) {
    :root {
        /* Hintergrundfarben - Dark */
        --bg-primary: hsl(0, 0%, 2%);
        --bg-secondary: hsl(0, 0%, 7%);
        --bg-tertiary: hsl(0, 0%, 12%);
        
        /* Textfarben - Dark */
        --text-primary: hsl(0, 0%, 90%);
        --text-secondary: hsl(0, 0%, 75%);
        --text-tertiary: hsl(0, 0%, 60%);
    }
}
```

#### 📐 Borders & Schatten

```css
:root {
    /* Abgrenzungsfarben */
    --border-primary: hsl(0, 0%, 75%);
    --border-secondary: hsl(0, 0%, 50%);
    --border-tertiary: hsl(0, 0%, 25%);
    
    /* Schatten */
    --shadow-primary: hsla(0, 0%, 0%, 0.8);
    --shadow-secondary: hsla(0, 0%, 0%, 0.5);
    --shadow-tertiary: hsla(0, 0%, 0%, 0.2);
}
```

#### ✅ Status-Farben

```css
:root {
    /* Status-Farben mit Hover-States */
    --success-color: hsl(134, 61%, 61%);
    --success-color-hover: hsl(133, 61%, 66%);
    
    --warning-color: hsl(54, 100%, 60%);
    --warning-color-hover: hsl(45, 100%, 66%);
    
    --danger-color: hsl(354, 71%, 53%);
    --danger-color-hover: hsl(354, 68%, 57%);
    
    --error-color: hsl(0, 100%, 60%);
    --info-color: hsl(207, 100%, 60%);
}
```

### 🎨 Eigenes Theme erstellen

Überschreibe die Variablen in deinem Stylesheet:

```css
/* custom-theme.css */
:root {
    /* Primärfarben anpassen */
    --primary-color: #3498db;
    --secondary-color: #e74c3c;
    
    /* Hintergrund anpassen */
    --bg-primary: #ffffff;
    --bg-secondary: #f8f9fa;
    
    /* Text anpassen */
    --text-primary: #212529;
}

/* Dark Mode anpassen */
@media (prefers-color-scheme: dark) {
    :root {
        --primary-color: #2980b9;
        --bg-primary: #1a1a1a;
        --text-primary: #f8f9fa;
    }
}
```

---

## 📋 Systemanforderungen

### Framework-Versionen

- ✅ **.NET 8.0** (LTS)
- ✅ **.NET 9.0** (Standard)
- ✅ **.NET 10.0** (Latest)

### Blazor-Support

- ✅ **Blazor WebAssembly**
- ✅ **Blazor Server**
- ✅ **Blazor Hybrid**

### Browser-Support

- ✅ Chrome/Edge 90+
- ✅ Firefox 88+
- ✅ Safari 14+
- ✅ Mobile Browser (iOS, Android)

### Optionale Dependencies

- Font Awesome (für Button-Icons)
- Custom Icon-Bibliotheken

---

## 🚀 Entwicklung & Build

### Lokaler Build

```bash
# Projekt klonen
git clone https://github.com/DIMnM/DragonSoft.PageComponents.git
cd DragonSoft.PageComponents

# Build
dotnet build

# Für spezifisches Framework
dotnet build -f net10.0
```

### NuGet Package erstellen

```bash
# Release Build
dotnet pack --configuration Release

# Output-Verzeichnis festlegen
dotnet pack -o ./nupkg --configuration Release
```

### Multi-Targeting Build

Das Package wird automatisch für alle drei Frameworks gebaut:

```bash
dotnet build
# Erstellt Builds für:
# - net8.0
# - net9.0
# - net10.0
```

### Lokaler Test

```bash
# Lokalen NuGet Feed erstellen
dotnet nuget add source ./nupkg -n LocalFeed

# Package erstellen
dotnet pack -o ./nupkg

# In Test-Projekt verwenden
cd ../TestProject
dotnet add package DragonSoft.PageComponents --source LocalFeed
```

---

## 📚 Vollständiges Beispiel-Projekt

### Komplette Demo-Seite

```razor
@page "/"
@using PageComponents.Components

<BaseSection>
    <!-- Hero Section -->
    <BaseCard Variant="CardVariant.Hero" BorderRadius="16px">
        <ChildContent>
            <Titel Level="1" Alignment="TextAlignment.Center">
                <Emoji EmojiChar="@Emojis.Rocket" Level="3" Shadow="true" />
                DragonSoft.PageComponents
            </Titel>
            <TextContent Alignment="TextAlignment.Center" 
                        Variant="TextVariant.Bold"
                        Margin="SpacingSize.Large">
                Moderne UI-Komponenten für Blazor
            </TextContent>
            <div style="display: flex; justify-content: center; gap: 1rem;">
                <Button Variant="ButtonVariant.Primary" 
                        Href="/docs"
                        Icon="fa fa-book"
                        BorderRadius="25px">
                    Dokumentation
                </Button>
                <Button Variant="ButtonVariant.Secondary" 
                        Href="https://github.com/DIMnM/DragonSoft.PageComponents"
                        Target="_blank"
                        Icon="fa fa-github"
                        BorderRadius="25px">
                    GitHub
                </Button>
            </div>
        </ChildContent>
    </BaseCard>
</BaseSection>

<BaseSection>
    <!-- Features Section -->
    <Titel Level="2" Alignment="TextAlignment.Center">
        <Emoji EmojiChar="@Emojis.Star" Level="2" Shadow="true" />
        Features
    </Titel>
    
    <BaseGrid Preset="GridPreset.Large">
        <BaseCard Variant="CardVariant.Highlighted" BorderRadius="12px">
            <HeaderContent>
                <Emoji EmojiChar="@Emojis.LightBulb" Level="3" />
                <Titel Level="3">Einfach zu verwenden</Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent>
                    Intuitive API und umfassende Dokumentation machen 
                    den Einstieg kinderleicht.
                </TextContent>
            </ChildContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Highlighted" BorderRadius="12px">
            <HeaderContent>
                <Emoji EmojiChar="@Emojis.Sparkles" Level="3" />
                <Titel Level="3">Vollständig anpassbar</Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent>
                    CSS Custom Properties ermöglichen vollständige 
                    Theme-Anpassung.
                </TextContent>
            </ChildContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Highlighted" BorderRadius="12px">
            <HeaderContent>
                <Emoji EmojiChar="@Emojis.Trophy" Level="3" />
                <Titel Level="3">Production-Ready</Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent>
                    Getestet, optimiert und bereit für den 
                    produktiven Einsatz.
                </TextContent>
            </ChildContent>
        </BaseCard>
    </BaseGrid>
</BaseSection>

<BaseSection>
    <!-- Events Section -->
    <Titel Level="2" Alignment="TextAlignment.Center">
        <Emoji EmojiChar="@Emojis.Calendar" Level="2" Shadow="true" />
        Kommende Events
    </Titel>
    
    <BaseGrid Preset="GridPreset.Medium">
        <BaseCard Variant="CardVariant.Event">
            <HeaderContent>
                <Titel Level="3">Workshop: Blazor Basics</Titel>
                <EventDate>20. Jan 2025</EventDate>
            </HeaderContent>
            <ChildContent>
                <TextContent>
                    Einführung in Blazor-Entwicklung mit praktischen Beispielen.
                </TextContent>
            </ChildContent>
            <FooterContent>
                <Button Variant="ButtonVariant.Primary" 
                        Href="/events/blazor-basics">
                    Mehr Info
                </Button>
            </FooterContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Event">
            <HeaderContent>
                <Titel Level="3">Webinar: UI-Design</Titel>
                <EventDate>25. Jan 2025</EventDate>
            </HeaderContent>
            <ChildContent>
                <TextContent>
                    Best Practices für moderne Web-UI-Gestaltung.
                </TextContent>
            </ChildContent>
            <FooterContent>
                <Button Variant="ButtonVariant.Primary" 
                        Href="/events/ui-design">
                    Mehr Info
                </Button>
            </FooterContent>
        </BaseCard>
    </BaseGrid>
</BaseSection>

<BaseSection>
    <!-- Rules Section -->
    <Titel Level="2" Alignment="TextAlignment.Center">
        Wichtige Regeln
    </Titel>
    
    <BaseGrid Preset="GridPreset.Compact">
        <BaseCard Variant="CardVariant.Rules">
            <CardNr>1</CardNr>
            <Titel Level="4">Code-Qualität</Titel>
            <TextContent>
                Schreibe sauberen, wartbaren Code.
            </TextContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Rules">
            <CardNr>2</CardNr>
            <Titel Level="4">Dokumentation</Titel>
            <TextContent>
                Dokumentiere deine Komponenten ausführlich.
            </TextContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Rules">
            <CardNr>3</CardNr>
            <Titel Level="4">Testing</Titel>
            <TextContent>
                Teste alle Features gründlich.
            </TextContent>
        </BaseCard>
    </BaseGrid>
</BaseSection>

<BaseSection>
    <!-- Contact Section -->
    <Titel Level="2" Alignment="TextAlignment.Center">
        <Emoji EmojiChar="@Emojis.Contact" Level="2" Shadow="true" />
        Kontakt
    </Titel>
    
    <BaseGrid Preset="GridPreset.Small">
        <BaseCard Variant="CardVariant.Contact">
            <HeaderContent>
                <Emoji EmojiChar="@Emojis.Chat" Level="3" />
                <Titel Level="4">Support</Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent Alignment="TextAlignment.Center">
                    <TelegramLink Username="support">
                        Kontaktiere Support
                    </TelegramLink>
                </TextContent>
            </ChildContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Contact">
            <HeaderContent>
                <Emoji EmojiChar="@Emojis.Email" Level="3" />
                <Titel Level="4">Email</Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent Alignment="TextAlignment.Center">
                    <TextLink Href="mailto:info@dragonsoft.dev">
                        info@dragonsoft.dev
                    </TextLink>
                </TextContent>
            </ChildContent>
        </BaseCard>
        
        <BaseCard Variant="CardVariant.Contact">
            <HeaderContent>
                <Emoji EmojiChar="@Emojis.Computer" Level="3" />
                <Titel Level="4">GitHub</Titel>
            </HeaderContent>
            <ChildContent>
                <TextContent Alignment="TextAlignment.Center">
                    <TextLink Href="https://github.com/DIMnM" Target="_blank">
                        GitHub Profile
                    </TextLink>
                </TextContent>
            </ChildContent>
        </BaseCard>
    </BaseGrid>
</BaseSection>

<BaseSection>
    <!-- CTA Section -->
    <BaseCard Variant="CardVariant.Cta" BorderRadius="20px">
        <HeaderContent>
            <Titel Level="2" Alignment="TextAlignment.Center">
                Bereit loszulegen?
            </Titel>
        </HeaderContent>
        <ChildContent>
            <TextContent Alignment="TextAlignment.Center" 
                        Variant="TextVariant.Bold">
                Installiere DragonSoft.PageComponents noch heute!
            </TextContent>
        </ChildContent>
        <FooterContent>
            <Button Variant="ButtonVariant.Primary" 
                    Href="/docs/installation"
                    Icon="fa fa-download"
                    BorderRadius="30px">
                Jetzt installieren
            </Button>
        </FooterContent>
    </BaseCard>
</BaseSection>

@code {
    // Event-Handler Beispiele
    private void HandleClick()
    {
        Console.WriteLine("Button clicked!");
    }
    
    private void ShowMore()
    {
        // Navigation oder State-Update
    }
    
    private async Task Save()
    {
        // Speicher-Logik
        await Task.Delay(100);
    }
}
```

---

## 🎯 Best Practices

### ✅ Empfohlene Patterns

```razor
<!-- ✅ GOOD: Strukturierte Sections -->
<BaseSection>
    <Titel Level="2">Section-Titel</Titel>
    <BaseGrid Preset="GridPreset.Medium">
        <BaseCard>Inhalt</BaseCard>
    </BaseGrid>
</BaseSection>

<!-- ✅ GOOD: Konsistente BorderRadius -->
<BaseCard BorderRadius="12px">
    <Button BorderRadius="12px">Passender Button</Button>
</BaseCard>

<!-- ✅ GOOD: Spacing mit Enum -->
<TextContent Margin="SpacingSize.Large">
    Konsistentes Spacing
</TextContent>
```

### ❌ Zu vermeiden

```razor
<!-- ❌ BAD: Inkonsistente Größen -->
<BaseCard BorderRadius="12px">
    <Button BorderRadius="8px">Nicht passend</Button>
</BaseCard>

<!-- ❌ BAD: Custom Styles statt Presets -->
<BaseGrid CustomStyle="grid-template-columns: repeat(3, 1fr);">
    <!-- Verwende stattdessen GridPreset -->
</BaseGrid>
```

### 📱 Responsive Design

- Alle Grids wechseln automatisch auf eine Spalte bei mobilen Geräten
- Emoji-Größen werden auf Level 4+ reduziert
- Padding und Margins werden automatisch angepasst
- BorderRadius bleibt konsistent

### ⚡ Performance-Tipps

1. **Verwende Presets:** GridPreset ist optimierter als CustomStyle
2. **Nutze Varianten:** CardVariant statt Custom CSS
3. **Emoji-Konstanten:** Typsicher und performanter
4. **BorderRadius sparsam:** Nur wenn vom Standard abweichend

---

## 🤝 Contributing

Wir freuen uns über Contributions! 

### Workflow

1. **Fork** das Repository
2. **Branch** erstellen (`git checkout -b feature/AmazingFeature`)
3. **Commit** Änderungen (`git commit -m 'Add AmazingFeature'`)
4. **Push** zum Branch (`git push origin feature/AmazingFeature`)
5. **Pull Request** öffnen

### Guidelines

- Befolge den bestehenden Code-Stil
- Füge Tests hinzu
- Aktualisiere die Dokumentation
- Beschreibe Änderungen im PR

---

## 📄 Lizenz

Dieses Projekt ist unter der **MIT-Lizenz** lizenziert.

```
MIT License

Copyright (c) 2025 Denis Ilday Mediendienstleistungen und Mehr

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
```

Siehe [LICENSE.txt](LICENSE.txt) für den vollständigen Text.

---

## 👤 Autor

**Kenthanar**  
DragonSoft - Professional Web Solutions

- 🌐 Website: [DragonSoft](https://github.com/DIMnM)
- 💻 GitHub: [@DIMnM](https://github.com/DIMnM)
- 📦 NuGet: [DragonSoft.PageComponents](https://www.nuget.org/packages/DragonSoft.PageComponents/)

---

## 📞 Support & Community

### 🆘 Hilfe erhalten

- 📚 **Dokumentation:** Diese README
- 🐛 **Bugs:** [GitHub Issues](https://github.com/DIMnM/DragonSoft.PageComponents/issues)
- 💬 **Diskussionen:** [GitHub Discussions](https://github.com/DIMnM/DragonSoft.PageComponents/discussions)
- 📦 **NuGet:** [Package-Seite](https://www.nuget.org/packages/DragonSoft.PageComponents/)

### 📢 Updates

- ⭐ **Star** das Repository für Updates
- 👁️ **Watch** für neue Releases
- 🔔 **Subscribe** zu Discussions

---

## 🗺️ Roadmap

### ✅ Version 1.2.2 (Aktuell)

- Multi-Targeting (.NET 8.0, 9.0, 10.0)
- BorderRadius-Parameter
- Vertikale Ausrichtung in Cards
- 200+ Emoji-Konstanten
- Vollständige Dokumentation

### 🔮 Geplante Features

#### Version 1.3.0
- [ ] Modal-/Dialog-Komponenten
- [ ] Toast-Notifications
- [ ] Loading-Spinner
- [ ] Skeleton-Screens

#### Version 1.4.0
- [ ] Tab-Komponenten
- [ ] Accordion-Komponenten
- [ ] Dropdown-Menüs
- [ ] Breadcrumb-Navigation

#### Version 1.5.0
- [ ] Form-Komponenten (Input, Select, Checkbox, Radio)
- [ ] Validation-Support
- [ ] Form-Layout-Helpers

#### Version 2.0.0
- [ ] Table-Komponenten mit Sorting/Filtering
- [ ] Pagination-Komponente
- [ ] Progress-Bar-Komponenten
- [ ] Badge-Komponenten
- [ ] Animation-Utilities
- [ ] Advanced Grid-Features
- [ ] Carousel-Komponente
- [ ] Image-Gallery
- [ ] Video-Player-Wrapper

---

## 📝 Changelog

### Version 1.2.2 (2025-01-03)

#### 🎉 Features
- **Multi-Targeting Support:** Vollständige Unterstützung für .NET 8.0, 9.0 und 10.0 in einem NuGet-Package
- **BorderRadius-Parameter:** Dynamisch anpassbarer BorderRadius für BaseCard und Button
- **Vertikale Ausrichtung:** HeaderAlign und FooterAlign Parameter für BaseCard
- **Package-Struktur:** Optimierte Package-Metadaten und README-Integration

#### 🐛 Bugfixes
- Verbesserte CSS-Spezifität für Header/Footer-Layouts
- Korrektur der BorderRadius-Anwendung bei verschiedenen Card-Varianten

#### 📚 Dokumentation
- Vollständig überarbeitete README mit allen Parametern
- Über 50 praktische Code-Beispiele
- Detaillierte API-Dokumentation für alle Komponenten

### Version 1.1.12.1 (2024-12-20)

#### 🎉 Features
- Dynamische BorderRadius-Anpassung für BaseCard
- Dynamische BorderRadius-Anpassung für Button
- Erste Multi-Framework-Unterstützung

### Version 1.1.11 (2024-12-15)

#### 🎉 Features
- Vollständige .NET 10.0 Unterstützung
- Über 200 vordefinierte Emoji-Konstanten in Emojis.cs
- Erweiterte TextContent-Komponente mit Spacing-Kontrolle (Padding/Margin)
- Emoji-Komponente mit Shadow-Support
- Emoji-Komponente mit AdditionalAttributes-Support

#### 📚 Dokumentation
- Erweiterte Beispiele für alle Komponenten
- Kategorisierte Emoji-Listen

### Version 1.1.10 (2024-12-01)

#### 🎉 Initiale Veröffentlichung
- **BaseCard:** Karten-Komponente mit 19+ Varianten
- **BaseGrid:** Grid-System mit 6 Presets
- **BaseSection:** Section-Wrapper
- **Titel:** Überschriften-Komponente (H1-H6)
- **TextContent:** Text-Komponente mit 5 Varianten
- **TextLink:** Link-Komponente
- **Button:** Button-Komponente mit 7 Varianten
- **Emoji:** Emoji-Komponente mit 7 Größen
- **EventDate:** Event-Badge
- **CardNr:** Nummerierte Badge
- **TelegramLink:** Telegram-Link-Komponente
- **Theme-System:** Automatisches Light/Dark-Mode
- **CSS-Variablen:** Vollständig anpassbar

---

## 🙏 Danksagungen

Danke an:
- Die Blazor-Community für Feedback und Inspiration
- Alle Contributors und Early Adopters
- Microsoft für das großartige Blazor-Framework

---

## 📊 Projekt-Statistiken

- **11 Komponenten** production-ready
- **19+ Card-Varianten** für jeden Anwendungsfall
- **200+ Emoji-Konstanten** vordefiniert
- **7 Button-Varianten** vollständig gestyled
- **6 Grid-Presets** für responsive Layouts
- **3 .NET-Versionen** in einem Package
- **100% responsive** mobile-first Design
- **MIT-Lizenz** völlig frei nutzbar

---

**Version:** 1.2.2  
**Target Frameworks:** .NET 8.0, 9.0, 10.0  
**Package ID:** DragonSoft.PageComponents  
**Repository:** [GitHub](https://github.com/DIMnM/DragonSoft.PageComponents)  
**License:** MIT

---

Made with ❤️ by [DragonSoft](https://github.com/DIMnM)

⭐ **Star** das Projekt auf GitHub!
