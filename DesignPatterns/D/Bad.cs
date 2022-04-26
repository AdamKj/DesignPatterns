namespace SOLID.D.Bad;

// higher level module
// course controller depends on the specific implementation from courseservice
public class CourseController
{
    private readonly CourseService _courseService;

    public CourseController(CourseService courseService)
    {
        _courseService = courseService;
    }
}


// lower level module
public class CourseService
{

}
