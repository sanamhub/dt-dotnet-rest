# Getting started with REST API

This is a practical phase, refer to project [ResetApiCourse](RestApiCourse.sln) for more details.

**Topics covered:**

- The system we will build an API for
- Creating the projects
- Defining the movie API contracts
- Creating a temporary database
- Creating the movies controller
- Implementing movie creation
- Introducing mapping
- Keeping track of the endpoints
- Implementing movie retrieval
- Perfecting the movie creation endpoint
- Implementing movie update
- Implementing movie deletion
- Why partial updates are not used

Patch (partial updates) has really fallen out of favor in the API world. The reason is that it is hard to implement correctly and consistently. It is much easier to implement a PUT endpoint that takes the full object and updates it. This is why we are not implementing a PATCH endpoint.
Patch request looks something like this:

![patch](contents/image1.png)

> [!NOTE]
> Project i.e. ./ResetApiCourse.sln is in final state

> Recap: First we created project, and we structure and architecture of our codebase to have the API, application and contracts projects separated from each other for better separation of concerns. Then we defined our API contracts and made a temporary in-memory database so we can implement our endpoints. Then we created all crud aspects of the API so create, read, update, and delete and we perfected all of them and then we introduced mapping and a dedicated space to store all the API endpoints.
