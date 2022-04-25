# Interface Segregation Principle

### *Skapa snygga nitiska interfaces som är specifika*

Skapa små och specifika interfaces så klassen som implementerar den inte behöver onödiga metoder som ej behövs.  
Istället för att göra en klass som hanterar tre saker, gör tre klasser som hanterar varsin sak.

#### Exempel
Säg att du har en Spel applikation, där spelaren kan vara tre olika spelklasser. Där du använder dig av ett **Karaktär** interface med attackerna *slå*, *skjuta* eller *läka*.  
  
Istället för att ha en stor klass som hanterar de olika spelklasserna och deras attacker.  
Så har du tre olika klasser som ärver av **Karaktär** interfacet där de alla gör sina egna specifika attacker.