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

<h3>Was macht LINQ besonders?</h3>
Mit LINQ kannst du Daten <strong>filtern, gruppieren </strong> und <strong>transformieren</strong>, egal ob es sich um Listen, XML, Datenbanken oder andere Datenquellen handelt.









