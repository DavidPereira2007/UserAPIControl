# UserAPIControl

A simple study project built with ASP.NET Core and PostgreSQL to practice authentication, authorization, JWT, password hashing, and API development concepts.

This project was created for learning purposes only and is not intended for production use.

---

# About

The goal of this API is to simulate a basic authentication system with features such as:

- User registration
- User login
- JWT authentication
- Password hashing with BCrypt
- Protected routes
- User deletion
- User information retrieval

This project is also being used to practice English writing and backend development concepts.

---

# Features

## Register
Creates a new user if the username does not already exist.

Passwords are securely hashed using BCrypt before being stored in the database.

---

## Login
Authenticates the user and returns a JWT token if the credentials are valid.

---

## Protected Routes
Uses JWT Bearer Authentication to protect authenticated endpoints.

---

## Delete User
Allows authenticated users to delete their account.

---

# Technologies Used

- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- BCrypt.Net-Next
- Swagger / OpenAPI

---

# Security Concepts Practiced

- Password Hashing
- Authentication
- Authorization
- JWT Tokens
- Protected Endpoints
- Claims-Based Identity

---

# Important

This project was developed only for educational and practice purposes.

It is not production-ready and should not be used in real applications without additional security improvements and testing.