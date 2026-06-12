# Projektdokumentation – 2D C# Platformer
**Projekt:** POS1_Project_Oskar_Erik  
**Repository:** [github.com/2AHIFPOS1ProjectOskarErik/POS1_Project_Oskar_Erik](https://github.com/2AHIFPOS1ProjectOskarErik/POS1_Project_Oskar_Erik)  
**Zeitraum:** Mai 2026 – Juni 2026  
**Autoren:** Oskar, Erik  

---

## Inhaltsverzeichnis
- [Projektdokumentation – 2D C# Platformer](#projektdokumentation--2d-c-platformer)
  - [Inhaltsverzeichnis](#inhaltsverzeichnis)
  - [1. Projektübersicht](#1-projektübersicht)
    - [Ziel des Projekts](#ziel-des-projekts)
  - [2. Roadmap-Übersicht](#2-roadmap-übersicht)
  - [3. Projekttagebuch](#3-projekttagebuch)
  - [4. Stolpersteine \& Lösungen](#4-stolpersteine--lösungen)
    - [4.1 Animationen](#41-animationen)
    - [4.2 NPC dialog](#42-npc-dialog)
    - [4.3 Erik wir bei Contributors nicht angezeigt](#43-erik-wir-bei-contributors-nicht-angezeigt)

---

## 1. Projektübersicht

| Merkmal | Details |
|---|---|
| Projekttyp | 2D-Platformer |
| Sprache | C# |
| Versionskontrolle | Git / GitHub |
| Zeitraum | Mai – Juni 2026 |
| Team | 2 Personen (Oskar, Erik) |

### Ziel des Projekts
Entwicklung eines 2D-Platformer-Spiels in C# mit folgenden Kernfeatures: spielbarer Charakter, Gegner (Basic & Follow), Miniboss, Boss, Inventarsystem, Shop, Healthsystem, Checkpoint-System, Karte, Hintergrundmusik, Startmenü, Pausemenü sowie ein Ending.

---

## 2. Roadmap-Übersicht

Die folgende Tabelle zeigt alle geplanten Features, deren Issue-Nummern und den ungefähren Umsetzungszeitraum laut GitHub-Roadmap.

| # | Feature | Issue | Zeitraum (ca.) | Status |
|---|---|---|---|---|
| 1 | Items | #17 | Mai – Juni | ✅ Abgeschlossen |
| 2 | Player | #11 | Mitte Mai | ✅ Abgeschlossen |
| 3 | Enemy Basic | #14 | Mitte Mai | ✅ Abgeschlossen |
| 4 | Startmenu | #19 | Mitte Mai | ✅ Abgeschlossen |
| 5 | Health | #27 | Mitte Mai | ✅ Abgeschlossen |
| 6 | Inventory | #26 | Mitte–Ende Mai | ✅ Abgeschlossen |
| 7 | Enemy Follow | #15 | Mitte–Ende Mai | ✅ Abgeschlossen |
| 8 | Shop | #25 | Ende Mai | ✅ Abgeschlossen |
| 9 | Miniboss | #13 | Ende Mai | ✅ Abgeschlossen |
| 10 | Map | #16 | Ende Mai – Anfang Juni | ✅ Abgeschlossen |
| 11 | Checkpoint | #28 | Anfang Juni | ✅ Abgeschlossen |
| 12 | Boss | #12 | Anfang Juni | 🔄 In Arbeit |
| 13 | Assets | #10 | Mai – Anfang Juni | 🔄 In Arbeit  |
| 14 | Ending | #18 | Anfang Juni | 🔄 In Arbeit |
| 15 | Spei... | #51 | – | 🔄 In Arbeit  |
| 16 | Logg... | #53 | – | 🔄 In Arbeit |

---



## 3. Projekttagebuch 

| Tag | Monat | Oskar | Erik
|---|---|---|---|
| 6 | Mai | github erstellt |  Assets gezeichnet| 
| 7 | Mai | Planungsphase |Planungsphase
| 8 | Mai | NPC dialog  | Assets gezeichnet/Gesucht|
| 9 | Mai | Planungsphase |Planungsphase 
| 10 | Mai | Player ersetelt mit basic movement |  Planungsphase|
| 11 | Mai | Planungsphase fertiggestelltsodas wir sie morgen abgeben konnten |Planungsphase fertiggestelltsodas wir sie morgen abgeben konnten
| 12 | Mai | der NPC dialog wurde gefixt |  Planungsphase wurde der letzte feinschlif verpasst |
| 13 | Mai | NPC dialog wieder gefixt weil es wieder nicht ging | Planungsphase
| 14 | Mai | crouchen angefangen |  Skitzze und Aufbau des Programms für Planungsphase2
| 15 | Mai | crouchen fertiggestellt und die klassendiagramme erstellt |  Skitzze und Aufbau des Programms für Planungsphase2
| 16 | Mai | den enemy angefangen und bewegen lassen | Walking und idle animation für player
| 17 | Mai | player nimmt schaden am gegner und kann sterben |NPC idle animation gemacht und player animation hitbox gefixed
| 18 | Mai | player kann angreifen |Start und deathscreen gezeichnet
| 19 | Mai | angefangen das der gegner schaden nimmt | Start und deathscreen gezeichnet und eingefügt
| 20 | Mai | gegner nimmt schaden fertiggestellt, Schlossarea hinzugefügt | Start und deathscreen funktionierten
| 21 | Mai | HP Bar angefengen | Buttons am startmenu gefixed,made an jump animation 
| 22 | Mai | HP Bar weitergemacht| Assets gedownloaded
|23 | Mai | HP Bar weitergemacht| spawn ein bissien verschönert
|24 | Mai | HP Bar funktioniert jetzt  | macht das man das inventar öffnen kann
| 25 | Mai | Burg Layout fürs erste fertig|shop angefangen 
| 26 | Mai | Dungeon layout fertig gestellt, Healthbug wurde gefixt | fixte das inventory, machte das man ind en schop raus und rein gehen kann und ein moneysystem
| 27 | Mai | Enemy folgt angefangen |enemy lässt münzen fallen
| 28 | Mai | Enemy folgt weitergemacht|münzen im schop verbrauchbar gemacht 
| 29 | Mai | Enemy folgt weitergemacht| jump hitbox gefixed
| 30 | Mai | Enemy folgt fertig |potions angefangen
| 31 | Mai | Minibossraum angefangen |potions weitergemacht
| 1 | Juni | Minibossraum hinzugefügt |potions fertig
| 2 | Juni | Miniboss hinzugefügt welcher läuft und spring, MiniBoss HP werden correkt angezeigt|potions im inventar angezeigt
| 3 | Juni | Boss angefangen| map erstellt 
| 4 | Juni |  Checkpointsystem eingeführt|3 Fallen gamcht
| 5 | Juni | Boss weitergemacht | iventory und potions funktional gamacht  
| 6 | Juni | Boss mit 3 von 4 attacken aber ohne Healthbar hinzugefügt | pausemenu und background musik erstellt
| 7 | Juni | bug gefixed  |HealthUp angefangen 
| 9 | Juni |  Minibossbugfix anfang|HealthUp fertiggestellt 
| 11 | Juni | Miniboss funktioniert jetzt auch wenn man im Tutorial spawnt | Spawn weiter verschönert und  
| 12 | Juni | game ausfürbar mit .exe gemacht | Projektdokumentation

## 4. Stolpersteine & Lösungen



### 4.1 Animationen

| | |
|---|---|
| **Problem** | Animationen von Spieler und NPC wurden konstant verbunden.
| **Ursache** | Sie haten den gleichen Animator in Unity |
| **Lösung** | Einen Seperaten Animator für beide zu erstellen |


---

### 4.2 NPC dialog

| | |
|---|---|
| **Problem** | Sobald man eine neue scene loaded stopte das spiel. |
| **Ursache** | Der NPC dialog wurde gesucht und nicht gefunden was zu einen error kam. |
| **Lösung** | den dialog scriot bei den scenen zu entfernen |


### 4.3 Erik wir bei Contributors nicht angezeigt

| | |
|---|---|
| **Problem** | Erik wir bei Contributors nicht angezeigt
obwohl er auch admin ist . |
| **Ursache** | wurde nie gefunden |
| **Lösung** | hat das programmieren und pushen nicht gestört also maben wir es einfach so gellasen|

### 4.4 Gameengine war ungewohnt
| | |
|---|---|
| **Problem** | Wir beide haben zum ersten Mal mit Unity gearbeitet |
| **Lösung** | Tutorials anschauen und uns Befehle von KI erklären lassen |