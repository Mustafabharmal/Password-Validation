# Password-Validation 🔐

This project demonstrates a user management system that allows users to configure password policies and validate user passwords against those policies. The system is built using ASP.NET MVC with Razor views.

## Features ✨

- **Password Policy Configuration**: Allows administrators to set requirements for password length, lowercase letters, uppercase letters, numeric characters, and special characters.
- **User Password Validation**: Validates user passwords against the configured password policy.

## Pages 📄

1. **Password Policy Configuration Page**: Set up the password policy with specific requirements.
2. **User Registration Page**: Validate user passwords based on the configured policy.

## Installation and Setup 🚀

### Prerequisites 📋

- .NET Core SDK
- Visual Studio or any C# compatible IDE

### Steps 🛠️

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/Mustafabharmal/Password-Validation.git
    cd Password-Validation
    ```

2. **Open the Project**:
    Open the project in Visual Studio or your preferred C# IDE.

3. **Build the Project**:
    Build the project to restore dependencies.

## Project Structure 📁

### Client-Side (Views) 🌐

- **Views/Home/Index.cshtml**: Page for configuring password policy.
- **Views/Home/Password.cshtml**: Page for validating user passwords.

### Server-Side (Controllers and Models) 💻

- **Controllers/HomeController.cs**: Handles HTTP requests and business logic for password policy and validation.
- **Models/PasswordPolicy.cs**: Represents the password policy configuration.

## Usage Instructions 📝

### Configuring Password Policy ⚙️

1. Navigate to the password policy configuration page (`/Home/Index`).
2. Fill in the form with the desired password requirements.
    - Minimum Length
    - Lowercase Letters
    - Uppercase Letters
    - Numeric Characters
    - Special Characters
3. Click "Save" to save the policy.

### Validating User Passwords 🔍

1. Navigate to the password validation page (`/Home/Password`).
2. Enter a password in the input field.
3. Click "Send" to validate the password against the configured policy.
4. The result will be displayed below the input field indicating whether the password matches the policy.

## Conclusion 🎉

This project provides a comprehensive example of implementing a user management system with customizable password policies. It demonstrates the use of ASP.NET MVC for creating dynamic web applications with robust form handling and validation.

**Happy Coding!** 💻🚀
