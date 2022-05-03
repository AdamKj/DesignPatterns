# Dependency Injection

### Hur fungerar Dependency Injection?
En ``Dependency`` är ett beroende av någonting. Alltså är ``Dependency`` ett objekt som ett annat objekt beror av.  
  
Te x. 
```cs
public interface IMyDependency
{
    void WriteMessage(string message);
}

public class MyDependency : IMyDependency
{
    public void WriteMessage(string message)
    {
        Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
    }
}
```  
Där våran klass ``MyDependency`` beror av ``IMyDependency`` interfacet och all dess innehåll.