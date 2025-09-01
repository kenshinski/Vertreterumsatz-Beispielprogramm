# Vertreterumsatz Beispielprogramm

Dieses Beispielprogramm sammelt und berechnet die Umsätze von bis zu fünf Vertretern. Es handelt sich um eine Konsolenanwendung in C#, die den Benutzer wiederholt nach Vertreternummern und deren jeweiligen Umsätzen fragt. Die Umsatzeingabe wird pro Vertreter solange fortgesetzt, bis ein Umsatz von `0` eingegeben wird. Die Eingabe von Vertreternummer `0` beendet das gesamte Programm und zeigt die Gesamtumsatzsumme aller eingegebenen Vertreter an.

## Funktionsweise

1. **Vertreternummer eingeben:**  
   Das Programm fordert den Benutzer auf, eine Vertreternummer einzugeben. Die Eingabe von `0` beendet die Eingabe und zeigt das Gesamtergebnis an.

2. **Umsätze erfassen:**  
   Für jeden Vertreter können beliebig viele Umsätze eingegeben werden. Die Eingabe von Umsatz `0` beendet die Eingabe für den aktuellen Vertreter.

3. **Summenberechnung:**  
   Nach Abschluss der Umsatzeingabe für einen Vertreter wird die Summe der Umsätze für diesen Vertreter angezeigt.

4. **Gesamtsumme:**  
   Nach Abschluss aller Eingaben wird die Gesamtumsatzsumme aller Vertreter angezeigt.

## Beispielablauf

```
Bitte Vertreter-Nr. eingeben (Ende = 0): 
1
Bitte Umsatz für Vertreter 1 eingeben (Ende = 0): 
150
Bitte Umsatz für Vertreter 1 eingeben (Ende = 0): 
200
Bitte Umsatz für Vertreter 1 eingeben (Ende = 0): 
0

Summe für Vertreter 1: 350 Euro

Bitte Vertreter-Nr. eingeben (Ende = 0): 
2
Bitte Umsatz für Vertreter 2 eingeben (Ende = 0): 
500
Bitte Umsatz für Vertreter 2 eingeben (Ende = 0): 
0

Summe für Vertreter 2: 500 Euro

Bitte Vertreter-Nr. eingeben (Ende = 0): 
0

Gesamtumsatzsumme: 850
```

## Voraussetzungen

- [.NET SDK](https://dotnet.microsoft.com/download) (z.B. .NET 6 oder höher)
- C# Kenntnisse (Grundlagen)

## Ausführen

Kompiliere und starte das Programm über die Konsole:

```bash
dotnet run
```

## Hinweise

- Ungültige Eingaben (z.B. Buchstaben statt Zahlen) führen zu einer Fehlermeldung.
- Das Programm ist für eine einfache Demonstration gedacht und kann bei Bedarf erweitert werden.

## Lizenz

Dieses Beispiel steht unter der MIT-Lizenz.
