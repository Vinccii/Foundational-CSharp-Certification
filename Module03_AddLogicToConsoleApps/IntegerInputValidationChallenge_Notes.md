# Integer Input Validation Challenge

Die Aufgabe: Den Benutzer so lange nach einer Zahl zwischen **5 und 10** fragen, bis er eine **gültige Ganzzahl** in diesem Bereich eingibt.  
Das Programm erkennt sowohl **nicht-numerische Eingaben** (z. B. `"abc"`), als auch **Zahlen außerhalb des gültigen Bereichs** (z. B. `3` oder `11`) und gibt entsprechende Fehlermeldungen aus.

## Regeln

- Nutze eine **`do-while`-Schleife**, damit der Benutzer mindestens einmal zur Eingabe aufgefordert wird.
- Verwende `Console.ReadLine()` für den Input.
- Verwandle den Textinput mit **`int.TryParse()`** in eine Zahl.
- Wenn der Input **keine Zahl** ist, soll eine Fehlermeldung kommen.
- Wenn der Input eine Zahl ist, aber **nicht zwischen 5 und 10**, soll eine andere Fehlermeldung kommen.
- Erst wenn eine gültige Zahl zwischen 5 und 10 eingegeben wurde, endet die Schleife.

## Genutzte Konzepte

- `do-while`-Schleife → garantiert mindestens einen Schleifendurchlauf
- `Console.ReadLine()` → um User-Eingabe als `string?` einzulesen
- `int.TryParse(string, out int)` → um Eingabe sicher in Zahl zu konvertieren
- `if`-Logik mit Bereichsprüfung → `(value < 5 || value > 10)`
- `bool`-Variable (`validNumber`) → steuert die Schleife

## Besonderheiten / Stolperfallen

- `TryParse` gibt bei ungültigem Input automatisch `false` zurück → kein Crash
- Bereichsprüfung **erst nach erfolgreichem Parse!**
- Es ist sinnvoll, `!isNumber` und `(value < 5 || value > 10)` **getrennt zu behandeln**, um saubere Fehlermeldungen zu geben.

## Unterschied zur Musterlösung

- Die Musterlösung verwendet eine zusätzliche Variable `valueEntered`, um `readResult` weiterzureichen.  
→ In dieser Lösung unnötig, da `TryParse` direkt mit `readResult` arbeiten kann – **effizienter und lesbarer**.

- Bereichsprüfung dort mit `<=` und `>=`  
→ In dieser Lösung präziser mit `<` und `>` (reiner Bereichsexklusivtest)
