namespace SOLID.D;
public class Example
{
    public void Bad()
    {
        var service = new Bad.CourseService();
        var controller = new Bad.CourseController(service);
    }

    public void Good()
    {
        var service1 = new Good.CourseService();
        var controller1 = new Good.CourseController(service1);

        // we can send in anyone that implements the interface which lets us:
        // create focused unit tests 
        // decouple the controller from service
        // swap out the implementation of the service without having to refactor any controller code
        var service2 = new Good.FakeCourseServiceForTesting();
        var controller2 = new Good.CourseController(service2);
    }
}
