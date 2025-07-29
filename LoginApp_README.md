# VB.NET Windows Forms Login Application

This is a simple login form created using VB.NET Windows Forms. The application demonstrates basic user authentication with a clean, modern interface.

## Features

- **Username and Password Input**: Text fields for user credentials
- **Input Validation**: Checks for empty fields and displays appropriate error messages
- **Demo Credentials**: Pre-configured test accounts for demonstration
- **Modern UI**: Clean design with Segoe UI font and modern color scheme
- **Keyboard Navigation**: Support for Enter key navigation and login
- **Clear/Reset Function**: Button to clear input fields
- **Exit Function**: Clean application termination

## Demo Credentials

The application comes with two pre-configured demo accounts:

1. **Admin Account**
   - Username: `admin`
   - Password: `password123`

2. **User Account**
   - Username: `user`
   - Password: `user123`

## How to Use

1. **Launch the Application**: Run the compiled executable or open in Visual Studio
2. **Enter Credentials**: Type a username and password in the respective fields
3. **Login**: Click the "Login" button or press Enter in the password field
4. **Demo Credentials**: Click "Show Demo Credentials" to see available test accounts
5. **Clear Fields**: Use the "Clear" button to reset both input fields
6. **Exit**: Click "Exit" to close the application

## Keyboard Shortcuts

- **Tab**: Navigate between fields
- **Enter** (in username field): Move to password field
- **Enter** (in password field): Attempt login
- **Alt + L**: Click Login button
- **Alt + C**: Click Clear button
- **Alt + E**: Click Exit button

## File Structure

```
LoginApp/
├── LoginApp.vbproj          # Project file
├── LoginForm.vb             # Main form code-behind
├── LoginForm.Designer.vb    # Form designer (UI layout)
├── LoginForm.resx          # Form resources
└── My Project/             # VB.NET project files
    ├── Application.myapp
    ├── Application.Designer.vb
    ├── Resources.resx
    ├── Resources.Designer.vb
    ├── Settings.settings
    └── Settings.Designer.vb
```

## Building the Project

### Prerequisites
- .NET Framework 4.7.2 or later
- Visual Studio 2017 or later (or MSBuild tools)

### Build Instructions
1. Open the project in Visual Studio
2. Build the solution (Build → Build Solution)
3. The executable will be created in `bin/Debug/` or `bin/Release/`

### Command Line Build
```bash
msbuild LoginApp.vbproj /p:Configuration=Release
```

## Security Note

⚠️ **Important**: This is a demonstration application with hardcoded credentials. In a production environment, you should:

- Use secure password storage (hashed passwords)
- Implement proper user authentication (database, Active Directory, etc.)
- Add proper input sanitization
- Implement account lockout policies
- Use HTTPS for network communications
- Add logging and audit trails

## Customization

You can easily customize this application by:

1. **Changing UI Colors**: Modify the color values in `LoginForm.Designer.vb`
2. **Adding More Users**: Update the validation logic in `btnLogin_Click`
3. **Database Integration**: Replace hardcoded credentials with database queries
4. **Additional Validation**: Add password complexity requirements
5. **Branding**: Add your company logo and styling

## License

This is a demo application provided for educational purposes. Feel free to modify and use as needed.