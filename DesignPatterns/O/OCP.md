# Open-Closed Principle

### *Du ska kunna utöka en klass, utan att behöva ändra i den.*

Du ska inte behöva ändra någonting i din klass, men du ska kunna utöka den, te x. i form av subklasser.  
Där kan du lägga till annan kod du behöver för att få ut önskat beteende.

#### Exempel
Har du en **Bil** klass som använder en **Broms** metod där metodens enda syfte är att sakna ner bilen.  
Skulle du vilja sätta igång bromsljus när bilen bromsar? Då kan du skapa en subklass som överskrider **Broms** metoden i **Bil** klassen.  
Om du nu anropar din metod för bromsljusen efter du anropat **Broms** metoden, så har du utökat beteendet i **Bil** klassen utan att ändra i den.