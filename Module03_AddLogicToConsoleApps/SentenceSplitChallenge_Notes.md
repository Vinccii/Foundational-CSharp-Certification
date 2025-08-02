# Sentence Split Challenge

Die Aufgabe: Zerlege mehrere Strings mit mehreren Sätzen (durch Punkte getrennt) in einzelne Sätze und gib sie zeilenweise aus – ohne Punkt am Ende.

## Vorgabe

string[] myStrings = new string[2] {
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};

___

## Ziel

- Jeder Satz aus jedem String soll einzeln ausgegeben werden.
- Der Punkt am Ende soll nicht mitausgegeben werden.
- Es dürfen keine leeren Zeilen entstehen.

## Genutzte Konzelte

- `for`-Schleife → Zugriff auf jedes Element des Arrays mit Index
- `IndexOf(".")` → Position des ersten Punktes im aktuellen String
- `Remove(int index)` → schneidet alles nach der Punktposition weg → ergibt den Satz
- `Substring(int startIndex)` → übernimmt den Reststring nach dem Punkt
- `TrimStart()` → entfernt Leerzeichen am Anfang
- `while-Schleife` → extrahiert iterativ alle Sätze, bis kein Punkt mehr gefunden wird

## Warum for statt foreach?

- Ein foreach erlaubt es nicht, die Variable myString zu verändern (sie ist read-only).
  Da wir aber den String in der Schleife mit Substring() und TrimStart() bearbeiten wollen, wurde for gewählt 
  – für direkte Kontrolle über den Index und Mutationen am String.

## Beispielausgab

I like pizza
I like roast chicken
I like salad
I like all three of the menu choices

## Was ich gelertn habe

- IndexOf() liefert -1, wenn kein Zeichen gefunden wurde → wichtig für Schleifenende
- Strings kann man mit Methoden wie Remove und Substring dynamisch verarbeiten
- TrimStart() hilft, saubere Ausgaben ohne unnötige Leerzeichen zu erzeugen
- Punktzeichen nicht mit ausgeben: Remove() schneidet genau bis zum Punkt