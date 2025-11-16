# DragonSoft.PageComponents

Eine moderne Sammlung wiederverwendbarer UI-Komponenten für Blazor und Razor mit .NET 10.0.

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
        <h3>Meine Karte</h3>
    </HeaderContent>
    <ChildContent>
        <p>Hier kommt dein Inhalt rein.</p>
    </ChildContent>
</BaseCard>
```

## 🎨 Komponenten

### BaseCard

Eine flexible, vielseitige Karten-Komponente mit mehreren Varianten und Layout-Optionen.

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

- **Default** - Standard-Kartenstil
- **Highlighted** - Karte mit farbiger Betonung links
- **Warning** - Warnung mit gelbem Akzent
- **Event** - Für Event-Anzeigen mit Hover-Effekt
- **News** - Für News-Artikel
- **Note** - Hervorgehobene Notiz mit Hintergrund
- **Detail** - Detailansicht mit Border
- **Consequences** - Für wichtige Konsequenzen
- **Hero** - Hero-Sektion mit Primary-Color
- **CTA** - Call-to-Action mit Gradient
- **Join** - Beitrittskarte mit Gradient
- **Contact** - Kontaktbereich
- **Legal** - Für rechtliche Inhalte
- **Rules** - Für Regelwerke
- **Info** - Info-Box zentriert

#### Header/Footer Layouts

- **Default** - Standard Block-Layout
- **SpaceBetween** - Flex mit space-between
- **SpaceAround** - Flex mit space-around
- **SpaceEvenly** - Flex mit space-evenly
- **Center** - Zentriert
- **Start** - Linksbündig
- **End** - Rechtsbündig

#### Beispiele

**Einfache Karte:**

```razor
<BaseCard>
    <p>Einfacher Inhalt</p>
</BaseCard>
```

**Karte mit Header und Footer:**

```razor
<BaseCard Variant="CardVariant.Highlighted"
          HeaderLayout="HeaderLayout.SpaceBetween"
          FooterLayout="FooterLayout.End">
    <HeaderContent>
        <h3>Titel</h3>
        <button>Action</button>
    </HeaderContent>
    <ChildContent>
        <p>Hauptinhalt der Karte.</p>
    </ChildContent>
    <FooterContent>
        <button>Speichern</button>
        <button>Abbrechen</button>
    </FooterContent>
</BaseCard>
```

**Call-to-Action Karte:**

```razor
<BaseCard Variant="CardVariant.Cta">
    <HeaderContent>
        <h2>Jetzt starten!</h2>
    </HeaderContent>
    <ChildContent>
        <p>Entdecke alle Funktionen unserer Plattform.</p>
    </ChildContent>
    <FooterContent>
        <button class="btn btn-primary">Mehr erfahren</button>
    </FooterContent>
</BaseCard>
```

## 🎨 Theming

Das Package unterstützt automatisches Light/Dark-Theme basierend auf den System-Präferenzen.

### CSS-Variablen

Die Komponenten nutzen CSS Custom Properties für einfache Anpassung:

```css
:root {
    --primary-color: hsl(199, 100%, 84%);
    --secondary-color: hsl(15, 69%, 53%);
    --tertiary-color: hsl(119, 54%, 65%);
    --bg-primary: hsl(0, 0%, 88%);
    --text-primary: hsl(0, 0%, 10%);
    /* ... weitere Variablen */
}
```

### Eigenes Theme

Überschreibe die CSS-Variablen in deinem eigenen Stylesheet:

```css
:root {
    --primary-color: #your-color;
    --secondary-color: #your-color;
}
```

## 📋 Voraussetzungen

- .NET 10.0 oder höher
- Blazor WebAssembly oder Blazor Server

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

Erstelle einen lokalen NuGet Feed oder nutze das Package direkt:

```bash
dotnet nuget add source /path/to/packages -n LocalFeed
dotnet pack -o /path/to/packages
```

## 🤝 Beitragen

Contributions sind willkommen! Bitte erstelle ein Issue oder Pull Request im GitHub Repository.

## 📄 Lizenz

Dieses Projekt ist unter der MIT-Lizenz lizenziert - siehe [LICENSE.txt](LICENSE.txt) für Details.

## 👤 Autor

**Kenthanar** - DragonSoft

## 📞 Support

Bei Fragen oder Problemen erstelle bitte ein Issue auf GitHub oder kontaktiere den Autor.

---

**Version:** 1.0.0  
**Target Framework:** .NET 10.0  
**Package ID:** DragonSoft.PageComponents