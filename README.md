
# Dokumentation
Tuan Binh Tran, 27.11.2018

# Inhaltsverzeichnis
* [Einleitung](#einleitung)
* [Zweck des Dokuments](#zweck-des-dokuments)
* [Installationsanleitung](https://github.com/tuanbinhtran/modul-318-student/blob/master/docs/Installationsanleitung.md)
* [Funktionen & Bugs](#funktionen--bugs)
  - [Zusätzliche Funktionen](#zusätzliche-funktionen)
  - [Nicht implementierte Funktionen](#nicht-implementierte-funktionen)
  - [Bekannte Bugs](#bekannte-bugs)
* [Use Cases](#use-cases)
* [Aktivitätsdiagram](#aktivitätsdiagram)
* [Testfälle](#testfälle)
* [GUI Mockups](#gui-mockups)
* [Code Guidelines](#code-guidelines)


# Einleitung
Diese ÖV-Applikation wurde als Projekt für das ÜK 318 *"Analysieren und objektbasiert programmieren mit Komponenten"* entwickelt.
Diese Dokumentation dient als Übersicht der Applikationen und beinhaltet auch gerlerntes und angewendetes Wissen.

Die Daten werden von http://transport.opendata.ch abgerufen und benutzt eine bereits vorhandene APi-Schnittstelle.

Dieses Projekt ist public und kann von jedem geforkt werden.


# Zweck des Dokuments
Dieses Dokument dient für die Projektarbeit des ÜK 318 *"Analysieren und objektbasiert programmieren mit Komponenten"*.
Im diesem Dokument wurde der Prozess dokumentiert.

# Funktionen & Bugs
Folgende Funktionen sind umgesetzt:
 - Auto-Complete bzw. Vorschlag für die eingegebenen Stationen während der Eingabe. (Wenn nach ca. 1 Sek. nicht mehr eingegeben wird) (Anforderung 1 & 4)
 - Verbindungen zwischen zwei gültigen Stationen werden angezeigt. (Anforderung 2)
 - Eine Abfahrtstafel einer bestimmten Station kann angezeigt werden. (Anforderung 3)
 - Für die Verbindungen kann ein beliebiger Zeitpunkt gesetzt werden. (Anforderung 5)
 - Der Standort der gültigen Station kann abgerufen werden. (Anforderung 6)

## Zusätzliche Funktionen
Diese zusätzliche Funktionen sind nicht in den vorgegebenen Anforderungen zu finden.

Folgende zusätzliche Funktionen sind umgesetzt:
 - Beide Stationen können getauscht werden. 
 - Der Zeitpunkt kann als Abfahrtszeit sowie auch Ankunftszeit angegeben werden. 
 - Dark Mode.
 
## Nicht implementierte Funktionen
Folgende Funktionen sind **nicht** umgesetzt:
 - Es können alle Stationen in der Nähe der aktuellen Station angezeigt werden.
 - Gefundene Resultate können via Mail weitergeleitet werden.

## Bekannte Bugs
Folgende Bugs sind bekannt:
 - Beim Auto-Complete kann es sein, dass das Programm freezed. 


# Use Cases
![use cases](https://github.com/tuanbinhtran/modul-318-student/blob/master/use_case.png "use cases")

# Aktivitätsdiagram
![Aktivitätsdiagram](https://github.com/tuanbinhtran/modul-318-student/blob/master/Aktivitätsdiagram.png "Aktivitätsdiagram")

# Testfälle
Nr.  | Ausführung | Erwartetes Ergebnis
---- | ---------- | -------------------
1.| In der Von-Station `Hochdorf` eingeben und in der Nach-Station `Luzern` eingeben. Danach den Button `Verbindungen suchen` tätigen. | Es sollten nun 4 Verbindungen angezeigt werden.
2.| Ausführung gemäss 1. Testfall und danach die ENTER-Taste oder den Button `Verbindungen suchen` tätigen. | Es sollten nun 4 Verbindungen angezeigt werden.

# GUI Mockups
Diese GUI Mockups zeigen, wie die Vorstellung der Applikation vor Beginn der Arbeit geplant war. 

Nur einiges wurde umgesetzt, da während der Entwicklung bessere/andere Ideen und Vorstellungen entstanden sind.

Start

![Start page](https://github.com/tuanbinhtran/modul-318-student/blob/master/GUI_Mockups/Start.png "Start")

Suggestions

![Suggestions](https://github.com/tuanbinhtran/modul-318-student/blob/master/GUI_Mockups/Suggestions.png "Suggestions")

Connections

![Connections](https://github.com/tuanbinhtran/modul-318-student/blob/master/GUI_Mockups/Connections.png "Connections")



# Code Guidelines
Die Code Guidelines sind [HIER](https://github.com/tuanbinhtran/modul-318-student/blob/master/Code%20Guidelines.md) zu finden.

