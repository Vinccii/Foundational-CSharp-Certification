# Battle Simulation Challenge

Die Aufgabe: Einen kleinen rundenbasierten Kampf zwischen einem Helden und einem Monster simulieren - beide starten mit 10 Lebenspunkten. Jede Runde greift der Held zuerst an, dann das Monster (sofern es noch lebt). Der Kampf endet, sobald einer besiegt ist.

## Regeln

- Beide starten mit **10 Health Points**
- **Held greift zuerst** an, mit einem Angriff zwischen 1–10 Schaden
- **Monster greift zurück**, wenn es noch lebt, mit ebenfalls 1–10 Schaden
- Nach jedem Angriff wird der verbleibende Lebenspunktestand ausgegeben
- Der Kampf endet, wenn einer auf **0 oder weniger HP** fällt
- Danach wird der Gewinner ausgegeben

## Genutzte Konzepte

- `do-while`-Schleife → garantiert mindestens eine Kampfrunde
- `Random`-Klasse → um Schaden zufällig zu generieren
- `if`-Anweisung → um zu prüfen, ob das Monster noch zurückschlagen darf
- `-=` → um Schaden direkt von den Lebenspunkten abzuziehen
- String-Interpolation (`$"..."`) → für dynamische Konsolenausgabe

## Alternative Konzepte aus der Musterlösung

- `continue` → um bei Monster-Tod direkt zum nächsten Schleifendurchlauf zu springen
- Ternärer Operator `? :` → um den Sieger eleganter auszugeben
