# IDisposable Interface

### Hur man implementerar det?
Du implementerar IDisposable Interfacet genom att ärva Interfacet i din klass.  
Te x. ``public class MyClass : IDisposable {}`` och sedan implementerar ``Dispose()`` metoden.  
  
### När ska man använda det själv?
Ska du läsa in en textfil eller öppna en databas connection, så behöver du sedan manuellt stänga den öppningen.  
Eftersom Garbage Collector ej vet när den ska släppa minnesallokeringen för öppningen av textfilen eller databas connectionen,
så behöver vi göra det, för att förhindra memory leaks.  
Det är då vi anropar ``Dispose()`` metoden, för att tala om för Garbage Collector att släppa den minnesallokeringen när vi inte längre behöver den.  
Använder vi oss av en ``using() {}`` behöver vi ej disposea då objektet automatiskt gör det efter scopet.  
Använder vi oss inte utav det få vi diposea manuellt.
  
### Hur disposar man säkert?
För att försäkra oss att vi disposar våran filöppning och minskar risken för memory leaks, 
kan vi antingen använda oss av ``try/finally`` eller använda oss av ett ``using`` scope.  

#### *try/finally*

public void MyMethod()  
{  
    var db = new AppDbContext();  
    try // wrappar vår kod som kan orsaka errors  
    {  
        throw new Exception();  
    }  
    finally // kommer alltid utföras oavsett vad som sker i try blocket  
    {  
        db.Dispose();  
        System.Console.WriteLine("db always disposed");  
    }  
 }  
    
    
#### *using*

public void MyMethod()   
{  
    using(var db = new AppDbContext())  
    {  
        throw new Exception();  
    } // här kommer vi disposea våran öppning då scopet avslutas  
}
