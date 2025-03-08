# User specific actions

This is a practical phase, refer to project [ResetApiCourse](RestApiCourse.sln) for more details.

**Topics covered:**

- The concept of movie ratings
- Where should ratings live?
- Preparing the database
- Using the user id
- Updating the existing functionality to support ratings
- Rating a movie
- Deleting a rating
- Retrieving user ratings

> Recap: We introduced the concept of movie ratings and understood where they should live both in our controllers and our endpoints based on the relations they have between the resources. We updated the database to facilitate it and then also we baked in the user id logic that we can get from jwt token being passed down on every request. We added functionality to rate a movie and update the rating of a movie and also functionality to delete the rating of a movie, on the top of that logged in user can now actually list all the ratings as well.
