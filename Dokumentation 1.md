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
  - [2. Lastenheft (Projektplanung)](#2-lastenheft-projektplanung)
  - [3. Softwarevoraussetzungen](#3-softwarevoraussetzungen)
  - [4. Roadmap-Übersicht](#4-roadmap-übersicht)
  - [5. Projekttagebuch](#5-projekttagebuch)
  - [6. Architektur / Funktionsblöcke](#6-architektur--funktionsblöcke)
    - [6.1 Player System](#61-player-system)
    - [6.2 Enemy System](#62-enemy-system)
    - [6.3 Inventory System](#63-inventory-system)
    - [6.4 Shop System](#64-shop-system)
    - [6.5 Dialogue System](#65-dialogue-system)
    - [6.6 Save / Load System](#66-save--load-system)
    - [6.7 UI System](#67-ui-system)
    - [6.8 Systemzusammenhang](#68-systemzusammenhang)
  - [7. Stolpersteine \& Lösungen](#7-stolpersteine--lösungen)
    - [7.1 Animationen](#71-animationen)
    - [7.2 NPC dialog](#72-npc-dialog)
    - [7.3 Erik wir bei Contributors nicht angezeigt](#73-erik-wir-bei-contributors-nicht-angezeigt)
    - [7.4 Gameengine war ungewohnt](#74-gameengine-war-ungewohnt)
    - [7.5 Koruptet File](#75-koruptet-file)
  - [8 Bedienungsanleitung](#8-bedienungsanleitung)
    - [8.1 Spielstart](#81-spielstart)
    - [8.2 Steuerung](#82-steuerung)
      - [8.2.1 Bewegung](#821-bewegung)
      - [8.2.2 Kampf](#822-kampf)
      - [8.2.3 Interaktion](#823-interaktion)
      - [8.2.4 Menüs / UI](#824-menüs--ui)
    - [8.3 Spielziel](#83-spielziel)
    - [8.4 Gegner](#84-gegner)
    - [8.5 Fallen](#85-fallen)
    - [8.6 Bosse](#86-bosse)
      - [8.6.1 Mini-Boss](#861-mini-boss)
      - [8.6.2 Hauptboss (Magier)](#862-hauptboss-magier)
    - [8.7 Items \& Wirtschaft](#87-items--wirtschaft)
    - [8.8 Spielwelt](#88-spielwelt)
    - [8.9 Speichern \& Laden](#89-speichern--laden)
    - [8.10 Spielende](#810-spielende)
  - [9 Detaillierte Beschreibung der Umsetzung](#9-detaillierte-beschreibung-der-umsetzung)
  - [10 Quellen der Assets](#10-quellen-der-assets)
    - [10.1 Unity Store https://assetstore.unity.com/publishers/40094](#101-unity-store-httpsassetstoreunitycompublishers40094)
    - [10.2 AI](#102-ai)
  - [11 Testbeschreibung](#11-testbeschreibung)
  - [12 Architektur und Funktionsblöcke](#12-architektur-und-funktionsblöcke)
  - [13 Detaillierte Umsetzungsbeschreibung](#13-detaillierte-umsetzungsbeschreibung)

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


## 2. Lastenheft (Projektplanung)

**Was soll entstehen?**
- 2D Platformer Spiel
- spielbarer Charakter
- Gegner & Boss-System
- Inventar + Items
- Shop-System
- Levelstruktur mit mehreren Areas
- Save/Load System
  
## 3. Softwarevoraussetzungen

- Unity Version 6000.2.5f1
- Visual Studio 2022 
- Git / GitHub Desktop   


## 4. Roadmap-Übersicht

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
| 12 | Boss | #12 | Anfang Juni | ✅ Abgeschlossen |
| 13 | Assets | #10 | Mai – Anfang Juni | ✅ Abgeschlossen  |
| 14 | Ending | #18 | Anfang Juni | ✅ Abgeschlossen |
| 15 | Speichern | #51 | – | ✅ Abgeschlossen  |
| 16 | Loggen | #53 | – | ✅ Abgeschlossen |

---



## 5. Projekttagebuch 

| Tag | Monat | Oskar | Erik
|---|---|---|---|
| 6 | Mai | G^ithub erstellt |  Assets gezeichnet| 
| 7 | Mai | Planungsphase |Planungsphase
| 8 | Mai | NPC dialog  | Assets gezeichnet/Gesucht|
| 9 | Mai | Planungsphase |Planungsphase 
| 10 | Mai | Player erstellt mit Basic Movement |  Planungsphase|
| 11 | Mai | Planungsphase fertiggestelltsodas wir sie morgen abgeben konnten |Planungsphase fertiggestelltsodas wir sie morgen abgeben konnten
| 12 | Mai | der NPC dialog wurde gefixt |  Planungsphase wurde der letzte feinschlif verpasst |
| 13 | Mai | NPC dialog wieder gefixt weil es wieder nicht ging | Planungsphase
| 14 | Mai | crouchen angefangen |  Skitzze und Aufbau des Programms für Planungsphase2
| 15 | Mai | crouchen fertiggestellt und die klassendiagramme erstellt |  Skitzze und Aufbau des Programms für Planungsphase2
| 16 | Mai | den enemy angefangen und bewegen lassen | Walking und idle animation für player
| 17 | Mai | player nimmt schaden am gegner und kann sterben |NPC idle animation gemacht und player animation hitbox gefixed
| 18 | Mai | player kann angreifen |Start und deathscreen gezeichnet
| 19 | Mai | angefangen das der Gegner schaden nimmt | Start und deathscreen gezeichnet und eingefügt
| 20 | Mai | Gegner nimmt schaden fertiggestellt, Schlossarea hinzugefügt | Start und deathscreen funktionierten
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
| 13 | Juni | Upslash und König dialog angefangen |Tutorial Gegener aniemiert
| 14 | Juni |  Upslash und König dialog weitergemacht | logger angefangen
| 15 | Juni |  Upslash und König dialog weitergemacht | Bugfixing/Verschönern
| 16 | Juni | Upslash und König dialog fertig|Bugfixing/Verschönern
| 17 | Juni | Mergeconflict gelösed |Bugfixing/Verschönern
| 18 | Juni | Mergeconflict gelösed| logger erstellt 
| 19 | Juni | Mergeconflict fertig gelösed|dugeon angefangen verschönern
| 20 | Juni | Speichern laden angefangen |dugeon zu ende verschönern
| 21 | Juni |Speichern laden fertig | schloss fertig gestellt
| 22 | Juni | loggen und buggfixen |endscreen und options angefangen und alles nochmal verschönert wegen korupter File
| 23 | Juni | Präsi, Buggs gefixed und Klassendiagramme |endscreen, Dokumentation und options fertig

## 6. Architektur / Funktionsblöcke

Das Spiel ist in mehrere unabhängige Systeme (Funktionsblöcke) unterteilt, die jeweils eigene Aufgaben übernehmen und miteinander interagieren.

---

### 6.1 Player System
- Steuerung des Spielers (Bewegung, Springen, Ducken)
- Kampfsystem (Angriffe in verschiedene Richtungen)
- Health-System (Schaden, Tod, Respawn)
- Animationen über Animator Controller

---

### 6.2 Enemy System
- **Basic Enemy**
  - Patrouilliert zwischen festen Punkten
  - Dreht bei Kollision um

- **Follow Enemy**
  - Erkennt den Spieler in einem bestimmten Radius
  - Verfolgt den Spieler aktiv

- **Boss / Miniboss**
  - Mehrere Angriffsmuster
  - Höhere Lebenspunkte
  - Eigene AI-Logik

---

### 6.3 Inventory System
- Speicherung von Items in einer Liste
- Nutzung von Consumables (z. B. Heiltränke)
- Dynamische Anzeige im UI

---

### 6.4 Shop System
- Kaufen und Verkaufen von Items
- Nutzung einer Ingame-Währung („Schmekles“)
- UI-basierte Interaktion über Buttons

---

### 6.5 Dialogue System
- Aktivierung über Trigger im Spiel
- Schrittweise Anzeige von Texten
- Steuerung über Interaktionsbutton (E)

---

### 6.6 Save / Load System
- Speicherung des Spielstands
- Gespeichert werden:
  - Spielerposition
  - Inventar
  - Health
  - Fortschritt im Spiel

---

### 6.7 UI System
- Hauptmenü (Start / Load / Exit)
- Pause Menü
- HUD (Health, Coins, Items)
- Endscreen

---

### 6.8 Systemzusammenhang
Die einzelnen Systeme arbeiten miteinander:
- Player interagiert mit Enemy System (Schaden)
- Inventory beeinflusst Kampf und Heilung
- Save System speichert alle wichtigen Systeme
- UI zeigt alle Systeme dem Spieler an
  
## 7. Stolpersteine & Lösungen



### 7.1 Animationen

| | |
|---|---|
| **Problem** | Animationen von Spieler und NPC wurden konstant verbunden.
| **Ursache** | Sie haten den gleichen Animator in Unity |
| **Lösung** | Einen Seperaten Animator für beide zu erstellen |


---

### 7.2 NPC dialog

| | |
|---|---|
| **Problem** | Sobald man eine neue scene loaded stopte das spiel. |
| **Ursache** | Der NPC dialog wurde gesucht und nicht gefunden was zu einen error kam. |
| **Lösung** | den Dialog Script bei den Szenen zu entfernen |


### 7.3 Erik wir bei Contributors nicht angezeigt

| | |
|---|---|
| **Problem** | Erik wir bei Contributors nicht angezeigt
obwohl er auch admin ist . |
| **Ursache** | wurde nie gefunden |
| **Lösung** | hat das programmieren und pushen nicht gestört also maben wir es einfach so gellasen|

### 7.4 Gameengine war ungewohnt
| | |
|---|---|
| **Problem** | Wir beide haben zum ersten Mal mit Unity gearbeitet |
| **Lösung** | Tutorials anschauen und uns Befehle von KI erklären lassen |

### 7.5 Korrupte File
| | |
|---|---|
| **Problem** | Korrupte File im Schloss augetreten welches es komplett gelöscht und das Spiel nicht starten lassen |
| **Lösung** | Letzter funktionierender Commit benutzt welcher dazu führte das 2 Tage an Arbeit verloren gingen |



## 8 Bedienungsanleitung

### 8.1 Spielstart
Beim Start des Spiels gelangst du in das Hauptmenü.

Dort kannst du auswählen:
- **New Game** → Startet ein neues Spiel (alter Speicher wird gelöscht)
- **Load Game** → Lädt einen vorhandenen Spielstand
- **Exit** → Beendet das Spiel

Das Spiel beginnt im Tutorial-Camp vor dem Schloss.

---

### 8.2 Steuerung

#### 8.2.1 Bewegung
- **A** → Nach links bewegen  
- **D** → Nach rechts bewegen  
- **Space** → Springen  
- **S** → Ducken (Crouch)  
- **Walljump** → An Wänden springen (mit kurzem Delay und Abrutschen nach kurzer Zeit)

#### 8.2.2 Kampf
- **Linke Maustaste + A** → Schlag nach links  
- **Linke Maustaste + D** → Schlag nach rechts  
- **Linke Maustaste + W** → Schlag nach oben  
- **R** → Heilung (wenn Item vorhanden)
- **T** → Schadens Trank. 2x damage (wenn Item vorhanden)

#### 8.2.3 Interaktion
- **E** → Mit NPCs sprechen, Dialoge weiterklicken, Interaktionen starten

#### 8.2.4 Menüs / UI
- **M** → Weltkarte öffnen  
- **ESC** → Pause-Menü (je nach Implementierung)
- **Tab** → Inventar öffnen
---

### 8.3 Spielziel
Du wurdest vom König beauftragt, einen bösen Magier zu stoppen, der im Dungeon unter der Burg die Kontrolle übernommen hat.

Der Ablauf des Spiels:
- Tutorial absolvieren  
- Zum Schloss gehen  
- Hauptquest vom König annehmen  
- Dungeon betreten und Gegner bekämpfen  
- Mini-Boss besiegen  
- In die Höhle folgen  
- Finalen Boss (Magier) besiegen  
- Spiel abschließen und als Held gefeiert werden  

---

### 8.4 Gegner
- Einfache Gegner bewegen sich von links nach rechts und verursachen Schaden bei Kontakt  
- Fortgeschrittene Gegner verfolgen den Spieler im Sichtbereich  
- Beim Kontakt mit Gegnern nimmt der Spieler Schaden  

---

### 8.5 Fallen
- **Spikes** → verursachen Schaden bei Berührung  
- **Pfeilfallen** → schießen Projektile auf den Spieler  
- **Bärenfallen** → verlangsamen oder schädigen den Spieler  

---

### 8.6 Bosse

#### 8.6.1 Mini-Boss
- Mehr Lebenspunkte als normale Gegner  
- Bewegt sich von links nach rechts  
- Springt gelegentlich  
- Einfaches Angriffsmuster  

#### 8.6.2 Hauptboss (Magier)
- Mehrere Angriffstypen:
  - Nahkampfangriff
  - Projektilangriff
  - Schockwave-Attacke
  - Boden-Spikes
- Flieht einmal während des Kampfes in die Höhle  
- Finaler Bosskampf am Ende des Spiels  

---

### 8.7 Items & Wirtschaft
- **Münzen (Schmekles)** als Währung  
- **Schwert** als Standardwaffe  
- **Heiltränke** zur Regeneration  
- **Damage-Up Tränke** zur Verstärkung  
- Permanente Health-Upgrades möglich  
- Shop im Schloss zum Kaufen und Verkaufen von Items  

---

### 8.8 Spielwelt
Das Spiel besteht aus 4 Hauptbereichen:

- **Tutorial** → Tutorial, Einführung & NPCs
- **Schloss** →  NPC, Shop  
- **Dungeon** → Hauptspielbereich mit Gegnern & Mini-Boss  
- **Höhle** → Finaler Bossbereich  

---

### 8.9 Speichern & Laden
Gespeichert werden:
- Spielerposition  
- Hp  
- Max Hp
- Geld  
- Checkpoint
- Story-Fortschritt (z. B. Boss besiegt oder nicht)  

---

### 8.10 Spielende
Das Spiel endet nach dem Sieg über den Magier.

Danach:
- Endscreen wird angezeigt  
- Der Spieler wird als Held gefeiert  
- Rückkehr ins Hauptmenü


## 9 Detaillierte Beschreibung der Umsetzung



## 10 Quellen der Assets

### 10.1 Unity Store https://assetstore.unity.com/publishers/40094
1. Luiz Melow. https://assetstore.unity.com/publishers/34852
2. SZADI ART. https://assetstore.unity.com/publishers/40094
3. BIGMANJD. https://assetstore.unity.com/publishers/40094
4. Sven Thole. https://assetstore.unity.com/publishers/31468

### 10.2 AI
1. ChatGPT und Cloude haben ein paar kleine Assets im Ordener "Random Assets" gemacht

## 11 Testbeschreibung
1. **Manuelle Tests im Unity Editor:**
Funktionen wurden direkt im Spiel regelmäßig ausprobiert, um sicherzustellen, dass Gameplay, Steuerung und UI korrekt funktionieren.

2. **Playtests:**
Das Spiel wurde in der Play-Mode-Ansicht getestet, um Fehler in der Logik, Kollisionen und Animationen zu überprüfen.

3. **Debugging mit Unity Console:**
Fehlermeldungen und Warnungen wurden in der Konsole überprüft und behoben.

## 12 Architektur und Funktionsblöcke
Architektur und Funktionsblöcke

Das Projekt ist ein 2D-Platformer, entwickelt in Unity. Beim
Start wird vom Main-Window auf eine Menu-Page weitergeleitet,
welche das Hauptmenü abbildet. Von dort aus kann ein neuer
Spielstand gestartet oder ein bestehender Spielstand geladen
werden. Wird versucht, einen Spielstand zu laden, obwohl keiner
existiert, wird dies durch eine Exception abgefangen.
Anschließend kann der Spieler entweder direkt in die Game-Page
gelangen oder zuvor eine Difficulty auswählen, welche auf einer
separaten Page erfolgt. Danach befindet sich der Spieler in der
Game-Page, in der alle wichtigen Klassen im Game-Loop
zusammengeführt und verarbeitet werden.

Das Spiel folgt einer klaren Szenenstruktur. Der Spieler startet
in einer Tutorial-Area, welche als Einstieg und Einführung
in die Steuerung dient. Danach folgt der Übergang in ein Hub
(Schloss), in dem die Hauptquest vom König vergeben wird. Von
dort aus gelangt der Spieler in den Dungeon, wo verschiedene
Gegner, Fallen und ein Mini-Boss warten. Anschließend folgt eine
zweite Dungeon-Ebene (Höhle), in der der finale Kampf gegen den
Magier stattfindet. Nach dem Sieg endet das Spiel mit einer
Abschlusssequenz.

Im Projekt werden mehrere Systeme parallel verwendet. Das
Player-System beinhaltet Movement, Jumping, Walljump, Crouching
sowie ein Combat-System mit richtungsabhängigen Angriffen.
Zusätzlich gibt es ein Inventar-System, ein Lebenssystem
basierend auf Herzen sowie Interaktionsmöglichkeiten mit NPCs
über eine Interaktionstaste.

Das Gegner-System besteht aus einfachen Patrouillen-Gegnern, die
sich horizontal bewegen und bei Kontakt Schaden verursachen, 
sowie aus Verfolger-Gegnern, die den Spieler innerhalb einer
Sight-Hitbox verfolgen. Zusätzlich gibt es Bosse und Mini-Bosse
mit erweiterten Lebenspunkten und eigenen Angriffsmustern.

Das Environment-System enthält verschiedene Fallen wie Spikes,
Pfeilfallen und Bärenfallen, welche dem Spieler Schaden zufügen
können. Diese sind in die Level integriert und werden teilweise
prozedural bzw. aus vorgegebenen Raumstrukturen generiert.

Das Item-System umfasst Waffen, Consumables wie Heiltränke und
Damage-Up-Potions, Geld als In-Game-Währung sowie permanente
Upgrades. Diese werden teilweise zufällig im Level generiert oder
über Gegner-Drops erhalten.

Das UI- und Menü-System besteht aus einem Startmenü mit New Game,
Load Game und Exit, einem Pause-Menü sowie einem Inventar- und
Shop-System. Zusätzlich kann über eine Map-Anzeige (Taste M) die
Weltübersicht geöffnet werden, um die Orientierung im Spiel zu
verbessern.

Das Save-/Load-System speichert alle relevanten
Spielinformationen im JSON-Format. Dazu gehören die
Spielerposition (Checkpoint), Inventar, Geld, Leben sowie der
Fortschritt im Spiel, wie besiegte Bosse oder freigeschaltete
Bereiche.


## 13 Detaillierte Umsetzungsbeschreibung

Zu Beginn des Projekts stand eine Planungsphase, in der die Grundidee des Spiels festgelegt wurde. Es handelt sich um einen 2D-Platformer in Unity mit einem simplistischen Kampfsystem, welches sich an Spielen wie Hollow Knight orientiert.

Die Story wurde ebenfalls in dieser Phase definiert. Der Spieler wird vom König beauftragt, ein unterirdisches Dungeon-System zu betreten und einen bösen Magier zu besiegen, der magische Kristalle für dunkle Zwecke verwendet. Das Spiel beginnt in einem Camp vor dem Schloss, welches als Tutorial- und Checkpoint-Bereich dient. Der Spieler wird zunächst daran gehindert, das Schloss zu betreten, da er einen Brief benötigt, der im Tutorial am Rande des Waldes gefunden wird. Dort lernt der Spieler grundlegende Steuerung und kämpft gegen ein Banditenlager. Danach wird er zum Schloss geschickt, wo er die Hauptquest vom König erhält.

Im weiteren Verlauf der Story betritt der Spieler den Dungeon, kämpft sich durch verschiedene Gegner und trifft auf den Magier, welcher jedoch in eine tiefere Höhle flieht. Dort folgt ein Kampf gegen einen Mini-Boss, bevor der Spieler den Magier in der finalen Höhle erneut stellt. Nach dessen Besiegung endet das Spiel mit einer Heldensequenz.

Auch die technischen Mindestanforderungen wurden in der Planungsphase definiert. Dazu gehört die Verwendung von Klassen für Movement, Gegner und Objekte mit speziellen Eigenschaften wie Fallen. Listen werden für Inventar, Leben und Geld verwendet. Außerdem sollen alle wichtigen Daten wie Position (letzter Checkpoint), Geld, Herzen, Inventar und Progress gespeichert werden. Zusätzlich werden Eingaben, NPC-Interaktionen und Gegneraktionen geloggt. Animationen sollen für Spieler, Gegner, NPCs und die Umgebung umgesetzt werden. Die Grafik soll dabei bewusst pixelartig gehalten werden.

Die Must-Have-Systeme wurden ebenfalls festgelegt. Der Spieler soll Movement mit Springen, Walljump, Laufen und Crouching besitzen sowie ein Kampfsystem mit richtungsabhängigen Angriffen und Heilung. Außerdem soll er mit NPCs interagieren können und ein Inventar sowie ein Herz-basiertes Lebenssystem besitzen.

Die Gegner bestehen aus einfachen Patrouillen-Gegnern sowie Verfolger-Gegnern mit Sichtbereich. Zusätzlich gibt es Umweltfallen wie Spikes, Pfeilfallen und Bärenfallen. Bosse besitzen einfache Angriffsmuster wie Nahkampf, Fernkampf, Schockwellen und Bodenangriffe mit Spikes. Zusätzlich gibt es einen Mini-Boss mit erhöhter Lebensanzahl.

Die Spielwelt ist in vier Areas unterteilt: Dungeon und Höhle als Hauptgebiete sowie Schloss und Wald als Nebenbereiche. Das Schloss dient als Hub für Quests und Shops, während der Wald als Tutorial-Area dient. Checkpoints sind über die Welt verteilt und enthalten humorvolle Elemente wie Hunde und Katzen.

Das Item-System umfasst ein Schwert, Heiltränke, Damage-Up-Potions, Geld („Schmekles“) sowie permanente Gesundheits-Upgrades. Das Spiel endet nach dem finalen Bosskampf, wobei der Spieler als Held gefeiert wird.

Das Startmenü besteht aus New Game, Load Game und Exit. Ein New Game erstellt einen neuen Spielstand und löscht den alten, während Load Game einen bestehenden Spielstand lädt.

Als Nice-To-Haves wurden zusätzliche Inhalte wie weitere Waffen, komplexere Gegner, mehr Consumables, zusätzliche Bosse und Areas (z. B. Void/Limbo und Vulkan), mehrere Enden, Sounddesign, ein Settings-Menü, mehr Spielstände sowie eine bessere Map-Übersicht definiert.

