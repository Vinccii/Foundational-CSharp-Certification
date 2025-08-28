# Challenge Project – Contoso Pets (Branching & Looping)

Dieses **Challenge-Projekt** aus dem Microsoft C# Zertifikatskurs behandelt die Entwicklung von Features im **Contoso Pets**-Anwendungsbeispiel.  
Ziel war es, mithilfe von **Iteration**- und **Selection**-Statements eine einfache Benutzeroberfläche in der Konsole zu bauen, die Eingaben validiert und unvollständige Tierdaten vervollständigt.  

---

## 📚 Inhalte des Projekts
- Arbeiten mit **mehrdimensionalen Arrays** (`string[,] ourAnimals`)  
- Menüführung mit **switch/case**  
- **For-Schleifen** zum Durchlaufen aller Datensätze  
- **While-Schleifen** für Eingabevalidierung  
- Bedingte Verzweigungen mit `if` / `continue`  
- Benutzer-Eingaben über `Console.ReadLine()` verarbeiten  
- Parsing & Validierung von Daten (`int.TryParse`, `string.IsNullOrEmpty`)  
- Zwischenspeichern & Zurückschreiben von Array-Werten  

---

## 🏹 Exercises

### 🎯 Exercise 1 – Ensure animal ages and physical descriptions are complete (100 XP)
- Ziel: Sicherstellen, dass jedes Tier eine **gültige Altersangabe** und eine **physische Beschreibung** hat.  
- Schritte:
  - Leere Slots überspringen (`if (ourAnimals[i,0] == "ID #: ") continue;`)  
  - Alter: Nur Zahlen erlaubt, Eingabe wiederholen bis gültig (`int.TryParse`).  
  - Physische Beschreibung: darf nicht null oder leer sein, Eingabe wiederholen bis gültig.  
- Abschluss: Konsolenausgabe: "Age and physical description fields are complete for all of our friends.
Press the Enter key to continue"

---

### 🎯 Exercise 2 – Ensure pet nicknames and personality descriptions are complete (100 XP)
- Ziel: Sicherstellen, dass jedes Tier einen **Nickname** und eine **Persönlichkeitsbeschreibung** hat.  
- Schritte:
- Nickname (Index 3) aus Array lesen, Label `"Nickname:"` entfernen, prüfen ob leer.  
- Solange leer → wiederholt Prompt: `Enter a nickname for ID #: {id}`  
- Personality (Index 5) analog prüfen, Prompt:  
  `Enter a personality description for ID #: {id} (likes or dislikes, tricks, energy level)`  
- Ergebnisse korrekt mit Label zurückschreiben (`"Nickname: " + value`, `"Personality: " + value`).  
- Abschluss: Konsolenausgabe: "Nickname and personality description fields are complete for all of our friends.
Press the Enter key to continue"

---

## ✅ Gelerntes
- Mit **Iteration** (for/while) lassen sich Arrays elegant prüfen und ergänzen.  
- **Input-Validierung** ist entscheidend, um fehlerhafte oder unvollständige Eingaben zu vermeiden.  
- **Null-Coalescing-Operator (`??`)** schützt vor null-Werten in Benutzereingaben.  
- Durch `.Replace("Label:", "")` können Label-Anteile entfernt werden, um nur den Rohwert zu prüfen.  
- **Commit-Schritte**: kleine, saubere Commits (erst Nickname, dann Personality, dann Abschlussmeldung).  
- Arbeiten nach einer **Design Specification** ist ein wichtiger Bestandteil echter Softwareentwicklung.  

---

## 🖥 Beispiel: Option 4 (Nickname & Personality)
```csharp
// Auszug: Option 4 – Nickname & Personality validieren
string nicknameRaw = ourAnimals[i, 3].Replace("Nickname:", "").Trim();
while (string.IsNullOrEmpty(nicknameRaw))
{
  Console.WriteLine($"Enter a nickname for ID #: {id}");
  string? input = Console.ReadLine();
  nicknameRaw = (input ?? "").Trim();
}
ourAnimals[i, 3] = "Nickname: " + nicknameRaw;

string personalityRaw = ourAnimals[i, 5].Replace("Personality:", "").Trim();
while (string.IsNullOrEmpty(personalityRaw))
{
  Console.WriteLine($"Enter a personality description for ID #: {id} (likes or dislikes, tricks, energy level)");
  string? input = Console.ReadLine();
  personalityRaw = (input ?? "").Trim();
}
ourAnimals[i, 5] = "Personality: " + personalityRaw;


