# Beyond Basic CRUD

This is a practical phase, refer to project [ResetApiCourse](RestApiCourse.sln) for more details.

**Topics covered:**

- Implementing slug-based retrieval
- Moving to a real database
- Adding the database infrastructure code
- Removing the old in-memory database
- Adding a business logic layer
- Implementing validation
- Cancellation token passing

> Recap: Implemented slug based retrieval to allow flexibility when we're point reading a piece of data, we moved to a real database using Docker to run it. We added some really nice infrastructure code to allow for some table creations on startup. Then we removed the old fake in-memory database and replaced it real queries that call to the database which is running through Docker, we implemented a business layer to start adding some things like the validation. And we started passing out cancellation tokens to allow for some more graceful shutdowns.
