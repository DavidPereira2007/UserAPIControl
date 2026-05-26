# UserAPIControl
API For Simulate register, login, logout, and get user info. This API is for testing purpose only, not for production use.

# API Functions
- Register: if user does not exist, create a new user with the provided username and password. using a jwt token to authenticate the user.
- Login: if user exists and password is correct, return a jwt token to authenticate the user.
- LoggedIn: if user is authenticated, return the user info.
- Logout: Exit the user session, invalidate the jwt token.
- deleteUser: if user is authenticated, delete the user from the database.