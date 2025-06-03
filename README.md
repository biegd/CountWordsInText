<h1>Count words in text</h1>
<h2>Aufgabenstellung</h2>
Schreiben Sie eine Methode in C#, die in einem gegebenen Text zählt, wie oft jedes Wort vorkommt. Die Ausgabe soll eine alphabetisch sortierte Liste aller Wörter mit ihrer jeweiligen Häufigkeit sein.

<h2>Anforderungen</h2>
- Die Groß-/Kleinschreibung soll ignoriert werden
- Satzzeichen sollen entfernt werden
- Die Ausgabe soll alphabetisch nach Wörtern sortiert sein

```csharp
string input = "Hallo Welt! Hallo, C# Welt. Welt sagt Hallo.";
```

<h3>Beispiel-Ausgabe</h3>

```csharp
C#: 1
hallo: 3
sagt: 1
welt: 3
```

<h2>Regex</h2>
Regex steht für <strong>"Regular Expression</strong>, auf Deutsch: <strong>Regulärer Ausdruck</strong>
Es handelt sich um eine <strong>Mustersprache</strong>, mit der man in Texten nach bestimmten Zeichenfolgen
suchen, diese prüfen oder ersetzen kann.
<h3>Was kann man mit Regex machen?</h3>

| <strong>Aufgabe</strong>                    | <strong>Regex-Ausdruck</strong> | <strong>Bedeutung</strong>                       |
|:--------------------------------------------|:--------------------------------|:------------------------------------------------:|
|Prüfen, ob ein String nur aus Ziffern besteht|`^\d+$`                          |Anfang bis Ende nur Ziffer (`d` steht für Ziffer) |
|Alle Satzzeichen entfernen                   |`[^\wäöüß]+`                     |Alle Zeichen entfernen, die nicht Buchstaben/ <br>Zahlen sind|
|E-mail-Adressen finden                       |`b[w.-]+@[\w.-]+\.\w(2,4)\b      |Grobes Muster für eine Email-Adresse              |

<h3>Beispiel aus der vorherigen Aufgabe</h3>

```csharp
string cleaned = Regex.Replace(text.ToLower(), @"[^\wäöüß]+", " ");
```

<strong>Bedeutung</strong>
- `Regex.Replace(...)` ersetzt Teile eines Strings
- Der Ausdruck '"[^\wäöüß]+"' bedeutet:
  - `\w` steht für "word character" (also Buchstaben und Ziffern).
  - `äöüß`wurden manuell ergänzt, damit auch deutsche Umlaute erlaubt sind.
  - `[^...]`bedeutet: <strong>Nicht diese Zeichen.</strong>
  - `+`heißt: Eins oder mehr davon.
  - Ergebnis: <strong>Alle Zeichen, die keine Buchstaben oder Ziffern sind, werden durch Leerzeichen ersetzt</strong>.
 
<h3>Wofür wird Regex typischerweise verwendet?</h3>
- Eingaben validieren (z.B. Email, Postleitzahl, Telefonnummer)
- Text durchsuchen (z.B. finde alle Zahlen im Text)
- Inhalte ersetzen (z.B. alle "," durch ";" in einer CSV-Datei).


<h2>LINQ</h2>
<strong>LINQ</strong> steht für <strong>Language Integrated Query</strong> und ist eine Leistungsstarke Funktion in C#, mit der du <strong>Abfragen
auf Datenquellen direkt in der Programmiersprache</strong> formulieren kannst - ähnlich wie bei SQL, aber typsicher und in C#-Syntax integriert.

<strong>Was macht LINQ besonders?</strong>
Mit LINQ kannst du Daten <strong>filtern, gruppieren </strong> und <strong>transformieren</strong>, egal ob es sich um Listen, XML, Datenbanken oder andere Datenquellen handelt.

<h3>Beispiel: LINQ auf einer Liste</h3>

```csharp
var namen = new List<string> { "Anna", "Ben", "Clara", "Anna", "David" };

// Nur eindeutige Namen, alphabetisch sortiert:
var eindeutigeNamen = namen
    .Distinct()
    .OrderBy(n => n);

foreach (var name in eindeutigeNamen)
{
    Console.WriteLine(name);
}
```

Ausgabe

```csharp
Anna
Ben
Clara
David
```

<strong>Häufig genutzte LINQ-Methoden</strong>
| <strong>Methode</strong>                    | <strong>Bedeutung</strong>                       |
|:--------------------------------------------|:------------------------------------------------:|
| `Where(...)`                                | Filtert nach einer Bedingung                     |
| `Select(...)`                               | Wandelt Elemente um (wie `map`in anderen Sprachen|
| `OrderBy(...)`/`ThenBy(...)`                | Sortieren                                        |
| `GroupBy(...)`                              | Gruppiert nach einem Schlüssel                   |
| `Distinct(...)`                             | Entfernt Duplikate                               |
| `First()`, `FirstOrDefault()`               | Gibt erstes Element (oder `null`) zurück          |
| `Any()`                                     | Gibt `true`zurück, wenn mindestens ein Element <br> vorhanden ist|
| `Count()`                                   | Gibt die Anzahl zurück                           |



<strong> Beispiel mit Zahlen</strong>
```csharp
int[] zahlen = { 1, 2, 3, 4, 5, 6 };

// Alle geraden Zahlen verdoppeln und sortieren
var ergebnis = zahlen
    .Where(z => z % 2 == 0)
    .Select(z => z * 2)
    .OrderBy(z => z);

foreach (var z in ergebnis)
{
    Console.WriteLine(z);
}
```

Ausgabe:

```cscharp
4
8
12
```

<h3>LINQ Query-Syntax vs. Methodensyntax</h3>

C# bietet zwei Stile - beide tun dasselbe

<strong>Query-Syntax (SQL-ähnlich):
```csharp
var result = from z in zahlen
             where z % 2 == 0
             select z * 2;
```

<strong>Methodensyntax</strong>
```csharp
var result = zahlen.Where(z => z % 2 == 0).Select(z => z * 2);
```

<h3>Anwendungsfälle im Alltag:</h3>

- Daten aus einer <strong>SQL-Datenbank</strong> (z.B. mit Entity Framework)
- <strong> CSV-Dateien oder XML-Dateien</strong> auslesen und verarbeiten
- <strong>Listen filtern und sortieren</strong> in WPF, ASP.NET, Konsolenprogrammen, usw.
- Daten aggregieren (z.B. GroupBy, Sum, Average)













