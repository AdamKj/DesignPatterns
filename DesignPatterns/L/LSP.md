# Liskov Substitution Principle

### *Subklasser måste kunna vara utbytbara för deras basklass*

Om du har en klass **B** som ärver av klassen **A**, som har funktionen **a**.  
Du ska då kunna byta ut **a** funktionen med en **b** funktion utan att det påverkar eller crashar applikationen.

#### Exempel
Du har en **Audi** klass som ärver av klassen **Bil**, som har en *Start* funktion.  
Då ska du kunna skapa en funktion i **Audi** klassen utan att det påverkar eller förstör *Start* funktionen eller applikationen.