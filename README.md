# Projekt-Dokumentation

Gruppe Bilig | Meister

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.22       | 0.0.1   | Hauptprogramm geschrieben |
|30.08.22       | 0.1.0    |          Fehlererkennung programmiert                                                    |

## 1 Informieren

### 1.1 Ihr Projekt

Das Projekt heist Number Guesser. Es soll ein Spiel werden bei dem eine Nummer von 0 - 100 generiert wird und diese vom spieler erraten werden muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss     |  Funktionsal    | Ausgabe ob Zahl grösser oder kleiner ist |
| 2  |       Muss          |     Funktional |       Falls ungültige Zahl eingegeben erneut fragen                             |
            

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Projekt geöffnet und Zahl eingegeben            |   50      |     richtige Zahl, grösser oder kleiner              |
| 2.1  |      Projekt geöffnet und falsche Zahl eingegeben        |    0     |   Zahl zwischen 1 und 100 eingeben                |
| 2.2  |      Projekt geöffnet und falsche Zahl eingegeben        |    200     |   Zahl zwischen 1 und 100 eingeben                |

### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111336147/189826432-14c21ddc-b268-470e-a2e1-6802de5af86a.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 23.08      | Justus          |   Hauptprogramm    |  20min             |
| 2.A | 30.08      |    Justus       |  Fehlererkennung            |    10min           |

Total: 


## 3 Entscheiden

Da es ein kleines Projekt ist habe ich es nicht in mehrere Teile aufgeteilt. Es sollte eine schnelle Angelegenheit sein.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   23.08    |  Justus         |   20min            |    25min               |
| 2.A  |   30.08    |  Justus         |    10min           |       20min            |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 23.08      |   funktionstüchtig       | Justus       |
| 2.1  |  30.08     |   funktionstüchtig       |   Justus     |
| 2.2  | 30.08      |   funktionstüchtig       |   Justus     |


### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |  Programm geöffnet            |  richtige zahl       |   Sie haben gewonnen                |     Sie haben gewonnen                 |
| II   |       Programm gestartet  |    Zahl über 100 oder unter 1     |Zahl zwischen 1 und 100 eingeben   |   Zahl zwischen 1 und 100 eingeben     |
| III     |    Programm gestartet          | Buchstaben        |     Error              |      Error (Programm stürzt ab)                |



## 6 Auswerten

https://github.com/Jusmasterr/Lernbericht-Numberguesser
