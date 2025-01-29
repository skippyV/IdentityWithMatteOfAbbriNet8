This project was my attempt to use the package https://github.com/matteofabbri/AspNetCore.Identity.Mongo with Blazor server web app.
The first goal was to have an EditForm (CreateUserForm.razor) in Blazor for adding a user to the Identity Mongodb.

However, the error "No converter registered for type" happens when using a user model bound to the form.

I don't know if this is a Blazor issue - meaning it can't be done with Net8.0 - or if I'm just clueless.
Maybe a little of both.
