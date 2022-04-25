# Single Responsibility Principle

### *En klass ska ha en, och bara en, anledning till förändring.*

Varje klass eller metod ansvarar för enbart en sak och ingenting annat.<br/>
Ändrar man något i klassen eller metoden, kommer det bara påverka ett specifikt beteende i applikationen.

#### Exempel
En PoängRäknar klass ansvarar bara för att räkna poängen i ett spel, enligt spelets regler.
Klassen ska bara ändras om spelreglerna för hur poängen räknas, ändras.