```mermaid
flowchart TD
    A[CourseController] --> B[CourseService]
```

```mermaid
flowchart TD
    A[CourseController] --> B[ICourseService]
    C[CourseServiceImplementation] --> B
```