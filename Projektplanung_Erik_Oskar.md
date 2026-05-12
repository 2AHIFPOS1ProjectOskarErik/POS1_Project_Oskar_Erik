# POS1 Project 2025/26 Oskar und Erik

## Grundidee
*	2D Platformer auf Unity erstellen
*	Simplistischer Combatsystem (Ähnlich wie Hollow Knight)
*	Story: Du wirst vom König geschickt und musst dich in ein Unterirdisches Höhlensystem bzw. Dungeon begeben und 1 Bösen Magier töten um ihn zu stoppen Magische Kristalle für böse Zwecke zu verwenden
*	Man startet in einem Camp auf einer Ebene vor dem Schloss, was den ersten Checkpoint mit einem Tutorial darstellt. Wenn du sofort zum Schloss gehst wirst du abgewiesen da du einen Brief benötigst welchen du im Tutorial am Rande des Waldes findest. Im Tutorial erklärt ein NPC dir wie du dich bewegen kannst und anschließend musst du ein Banditenlager unterwerfen. Danach begibst du dich zum Schloss wo der König dir deine Hauptquest gibt: Ein böser Magier hat die Kontrolle über den Dungeon unter der Burg übernommen und du musst ihn stoppen. 
*	Du begibst dich in den Dungeon und triffst auf viele Gegner und triffst auf den Magier doch der flüchtet in die Höhle unter dem Dungeon und lässt dich gegen einen Mini-Boss kämpfen. Anschließend folgst du dem Magier in die Höhle und musst dich dort durchkämpfen bis du anschließend ein letztes Mal gegen ihn kämpfst. Nach dem du ihn besiegt hast wirst du als Held gefeiert und das Spiel endet.
*	Grafik soll eher pixelig sein

## Mindestanforderungen

*	Klassen werden verwendet, um in Unity Dinge wie Movement, Enemys (Wahrscheinlich in mehrere Klassen aufgeteilt), Objekte mit bestimmten Eigenschaften (z.B. Spikes und Fallen) umzusetzen
*	Listen werden für Inventar, Leben und Münzen verwendet 
*	Usercontroll gibt es in Unity so nicht (So ChatGPT)
*	Objekte werden grafisch dargestellt
*	Herzen und Geld werden prozedural im Code generiert
*	Position auf der Karte (lezter Checkpoint), Geld, Herzen, Inventar, Progress (Boss tot?) werden alle gespeichert
*	Keine Ahnung wie man Unterfenster bzw. Seiten in Unity funktioniert oder ob es überhaupt geht aber wenn dann wird das Inventar und das Main Menu und Settingsmenü als Unterseiten gemacht
*	Gelogged werden Inputs des Spielers, Interaktionen mit NPCs, Gegnern, Objecten, Etc.
*	Animiert werden Spieler (Bewegen, Angreifen, …), Gegner, NPCs (Idle Animationen, …), Environment (Background, …)
Must-haves:
*	Spieler:
    *	Movement:
        *	Springen mit Space
        *	Walljump (Nach kurzem Zeitdelay rutscht man ab)
        *	Mit A-Key nach links bewegen
        * Mit D-Key nach rechts bewegen
        *	Mit S-Key crouchen
    *	 Combatsystem
        *	 Schlag nach links mit Mouseclick und D
        *	Schlag nach rechts mit Mouseclick und A
        *	Schlag nach oben mit Mouseclick und W
        *	Mit R heilen
    *	Interagieren mit NPCs und Gegnern
        *	Mit E mit den NPCs reden wird Dialog angezeigt
        *	Wenn Gegner berührt wird, wird Schaden genommen
    *	 Inventar in dem die Items angezeigt werden
    *	 Lebensanzeige
        *	Mit Herzen wird angezeigt wie viel leben der Spieler noch hat

    *	Gegner: 
        *	Simple Gegner (Bewegen sich von Rechts nach links, wenn sie den Spieler berühren machen sie Schaden)
        *	Gegner welche den Spieler verfolgen sobald er in ihre Sight-Hitbox tritt bis der Spieler wieder aus dieser Hitbox heraustritt
    *	Fallen und Environmental Hazards 
        *	Spikes
        *	Pfeilfalle
        *	Bärenfalle
    *	Bosse
        *	Ein Boss mit relativ simplen Moves 
            *	Schlag der eine Schockwave spawned
            *	Nahkampfangriff nach Rechts bzw. Links
            *	Fernkampfangriff (Projektil wird in Richtung Spieler abgefeuert)
            *	Nahkampfangriff der in die Richtung des Angriffes Spikes aus dem Boden erscheinen lässt und diese dann wieder verschwinden 
        *	Ein Mini-Boss
            *	Läuft nur von rechst nach links und springt manchmal
            *	Eigentlich ein normaler Gegner aber mit einer HP-Leiste und mehr HP
    *	Assets
        *	Online gratis Assets vom Unity Store verwenden
        *	simple die wir nicht finden werden selber gemacht
        *	komplexe vielleicht mit KI
        *	Animations
            *	Spieler
                *	Bewegen und Springen
                *	Angriff
                *	Schaden bekommen
                *	Death
            *	Gegner
                *	Bewegen
                *	Schaden bekommen
                *	Death
            *	Boss
                *	Bewegen
                *	Angriff
                *	Schaden
                *	Death
        *	NPCs
            *	Idle Animation 
    * Map
        *	4 Areas
            *	2 Hauptareas (Dungeon, Höhle)
            *	Dungeon: Erste Area
            *	Höhle: 2. Area
            *	2 Nebenareas (klein aber wichtig für die Story, Schloss, Wald)
                *	Schloss: Quests werden vergeben, Handeln, … (Hubarea)
                *	Shop
                    *	3 Items 
                *	Wald: Tutorial Area, wichtig für Sidequest
        *	Wenn M gedrückt wird, wird eine Weltkarte angezeigt mit wichtigen Orten sodass man sich orientieren kann
        *	Checkpoints
            *	Mit vielen Hunden und Katzen
    *	Items
        *	1 Schwert
        *	Consumables
            *	Healthpotion
            *	Damage-Up Potion
            *	Geld (Schmekles)
        *	Permament Health-Up 
    *	Ending
        *	Endet nachdem man den Boss getötet hat
        *	Man wird als Held gefeiert

    *	Startscreen
        *	Menu
        *	New Game
            *	Erstellt einen neuen, leeren Spielstand und löscht den alten
        *	Load Game
            *	Falls ein alter Spielstand existiert, lädt diesen
        *	Exitbutton


Nice-To-Haves
*	1 Extra Waffe
*	Komplexeres Combatsystem
*	Komplexere Gegner mit richtigen Angriffen
*	Mehr Consumables (Damage-Up, …)
*	Story weiter ausbauen
    *	2-3 Weitere Bosse
    *	2 weiter Areas
      * Void/Limbo
      * Vulkan
    * Mehrere Enden
      * König besiegen?
    * Subareas
* Sounddesign 
* Hintergrundmusic
    * Online Gratis herunterladen
    *	Soundeffekts
        * Online Gratis herunterladen+
        * Selber machen wenn simpel 
* 	Settingsmenu
    *	Lautstärke anpassen
*	Assets selbst überarbeiten bzw. erstellen
*	Mehrere Spielstände
*	Mehr Auswahl im Shop
*	Position wird auf der Map angezeigt

 
















Projektplanung
Klassen
*	GameManager
*	PlayerController
*	Inventory
*	Item
*	Consumables
*	Premanent Item
*	EnemyBase
*	SimpleEnemy
*	EnemyBase
*	Boss
*	Trap Base
*	SaveData
*	UIManager

