# Building an SDK for our API

This is a practical phase, refer to project [ResetApiCourse](RestApiCourse.sln) for more details.

**Topics covered:**

- Why create an SDK?
- Creating the SDK project and the client example
- Introducing Refit
- Retrieving movies
- Using the HttpClientFactory
- Adding authentication
- Handling token generation and refreshing
- Adding the remaining requests

> Recap: We explained what SDK is and why you may need it for your REST API but we had a look at an amazing library called Refit, which really makes making SDKs for our codebase extremely easy. We are able to reuse all of our contracts to built that SDK and we saw how we can use a token and authentication and also provide authentication on demand with a generated token every time. And then we implemented the full version of the SDK with all the endpoints so we can have a complete experience for the developers consuming our API.
