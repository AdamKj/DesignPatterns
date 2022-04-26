namespace SOLID.D.Good;

// controller depends on anyone that has the same functions as the interface. The 2 classes are now independent dependencies inversed
public class CourseController
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }
}

// course service depends on the interface
public class CourseService : ICourseService
{

}

public class FakeCourseServiceForTesting : ICourseService
{

}


public interface ICourseService
{

}
