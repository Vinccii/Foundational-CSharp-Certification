# Role Input Validation Challenge

Die Aufgabe: Den Benutzer so lange nach einer Rolle fragen, bis eine **gültige Rolle** eingegeben wurde:  
`Administrator`, `Manager` oder `User`.

Die Eingabe kann dabei auch Großbuchstaben und Leerzeichen enthalten (z. B. `"  ADMIN  "`), soll aber trotzdem akzeptiert werden.  
Ziel ist es, die Eingabe zu **bereinigen und zu vergleichen**, bis eine gültige Rolle erkannt wird.

---

## Regeln

- Benutze eine **`do-while`-Schleife**, damit die Eingabe mindestens einmal abgefragt wird.
- Verwende `Console.ReadLine()` zur Eingabe.
- Bereinige die Eingabe mit:
  - `.Trim()` → entfernt Leerzeichen am Anfang und Ende
  - `.ToLower()` → macht alles klein (case-insensitive Vergleich)
- Akzeptierte Eingaben: `administrator`, `manager`, `user`
- Bei ungültiger Eingabe → Fehlermeldung + erneute Eingabe
- Bei gültiger Eingabe → Ausgabe mit Bestätigung und Schleifenende

---

## Genutzte Konzepte

- `do-while`-Schleife → für mindestens eine Eingabeaufforderung
- `string?` → Eingabevariable kann `null` sein (z. B. bei `Console.ReadLine()`)
- `Trim()` → entfernt unnötige Leerzeichen
- `ToLower()` → erleichtert den Vergleich, unabhängig von Groß-/Kleinschreibung
- Logik-Verknüpfung mit `||` → `if (role == "administrator" || role == "manager" || role == "user")`
- Bool-Variable zur Schleifensteuerung (`validRole`)

---

## Stolperfallen / Besonderheiten

- Wichtig: Die Schleifenbedingung muss **`while (!validRole)`** heißen  
  → Sonst würde die Schleife **weiterlaufen, wenn die Eingabe korrekt ist**
- `readResult != null` ist nötig, da `Console.ReadLine()` theoretisch `null` zurückgeben kann
- Im Vergleich zur Musterlösung habe ich `Trim()` und `ToLower()` **in einer Zeile verkettet**, was den Code etwas kompakter macht

---

## Unterschied zur Musterlösung

- Die Musterlösung speichert `readResult.Trim()` zuerst in `roleName` und ruft `ToLower()` später auf → ich habe direkt `Trim().ToLower()` gemacht
- Beide Lösungen sind **funktional gleichwertig**

---
