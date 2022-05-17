# Dependency Injection

## Hur fungerar Dependency Injection?
En ``Dependency`` är ett beroende av någonting. Alltså är ``Dependency Injection`` i princip att förse alla de objekt som ett annat objekt behöver, dess beroenden.  
  
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
Där våran klass ``MyDependency`` beror av ``IMyDependency`` interfacet och implementerar all dess innehåll.  
  
Ett annat exempel kan vara  
```cs
public interface Waiter 
{
    string OrderFood(string food);
}

public class Customer 
{
    public string GetFood(Waiter waiter) 
    {
        return waiter.OrderFood("hamburger");
    }
}
```
  
## Skillnad på Scoped, Transient och Singleton?
``Scoped`` skapar en ny instans för varje HTTP request, men behåller den instansen för varje ny likadan request.  
  
``Transient`` skapar en ny instans för varje HTTP request oavsett om den är en likadan request, eller helt ny.  
  
``Singleton`` skapar enbart en instans och bibehåller den instansen genom hela applikationen.

## Vad är Service Provider?
``IServiceProvider`` är ett interface som hämtar/hanterar ett service objekt från en ``ServiceCollection``, som innehåller våra services.  

**Kod exempel**  
```cs
using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
```
  
**Bild förklaring**  
*Dependency Resolver = Service Provider*  
*Blå container = ServiceCollection av våra services*  
![Dependency-Injection-ASP NET-Core](https://user-images.githubusercontent.com/76393729/167145712-50cf8ba3-2c3f-426f-b061-c709f3cb75d5.png)


## Varför används ett Scoped Service?
Det används för att kunna hämta ut Services ur Service Containern  
så de sedan kan Disposas automatiskt, för att förhindra memory leaks.
