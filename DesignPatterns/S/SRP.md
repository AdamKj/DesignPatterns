# Single Responsibility Principle

### *En klass ska ha en, och bara en, anledning till förändring.*

Varje klass ansvarar för enbart en sak. Det menas också att den bara har en anledning att förändras.
Ändrar du något i den klassen, kommer det bara påverka ett specifikt beteende i applikationen.
Det gör koden mer robust och kommer leda till mindre problematik.

Om en klass hade två ansvarsområden och man ändrade något i den klassen, skulle risken för logiska problem i antingen det ena eller andra beteendet vara väldigt hög.

#### Exempel
En PoängRäknar klass ansvarar bara för att räkna poängen i ett spel, enligt spelets regler.
Klassen ska då bara ändras om spelreglerna för hur poängen räknas, ändras.