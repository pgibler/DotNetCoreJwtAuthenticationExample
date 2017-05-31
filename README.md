# DotNetCore JWT Authentication Example Project

----
## What's in this project

A simple .NET Web API project that implements server side JWT token creation and validation.

----
## Requirements

.NET Core 1.1 - [download](https://www.microsoft.com/net/download/core)

----
## Setup

1. Clone the repository
2. Start `cmd.exe`.
3. Run the following commands in it.

```
cd <cloned_repo_path>
cd DotNetCoreJwtAuthenticationExample
dotnet build
dotnet run
```

4. Utilizing an HTTP request tool such as [Postman](https://www.getpostman.com/), create a request with the following parameters and execute it.

    ![POST request example](/Media/post_request.png?raw=true "An example POST request to generate a bearer token.")

5. Copy the value from the `access_token` parameter.
6. Utilizing an HTTP request tool, create a request with the following parameters and execute it.
    * Set the `Authorization` header equal to `Bearer <access_token>`.

    ![Authenticated GET request example](/Media/authenticated_request.png?raw=true "An example authenticated GET request using the bearer token to authenticate the request server side.")

7. Request authenticated!

If the request *fails* to authenticate properly, you will receive the following result:

![Unauthenticated GET request example](/Media/unauthenticated_request.png?raw=true "An example unauthenticated GET request that did not correctly authenticate.")

----
## Can I use code from this project

Yes it's MIT licensed, have at it!

----
## Special thanks

Nate Barbettini (@nbarbettini) for making the most straightforward and comprehensible guide on implementing JWT token creation and validation. Much of the code in this project is directly based on his implementation with some differences I felt made it easier to comprehend.

Read his tutorial [here](https://stormpath.com/blog/token-authentication-asp-net-core) for very useful insights and how to build a project like this one from scratch.
