# Employee-Attendance-Manager-API

Employee Management System is a project developed in C# which aims to streamline employee attendance tracking and management. This system consists of both a backend, where the business logic is managed, and a frontend for the graphical interface.

Features
Employee Attendance Tracking: Employees can scan QR codes upon arrival and departure from work, allowing for efficient attendance management.
Admin Interface: Administrators can access an interface to manage all employee scans and perform administrative tasks.
MySQL Database: The system utilizes MySQL as the backend database for storing employee information and attendance records.
Authentication System: Firebase authentication is integrated to ensure secure access control for both employees and administrators.
Installation
Prerequisites
.NET Core SDK
MySQL Server
Firebase project for authentication
Setup
Clone the repository: git clone https://github.com/your-username/employee-management-system.git
Navigate to the backend directory: cd employee-management-system/backend
Restore dependencies: dotnet restore
Configure MySQL connection string in appsettings.json
Run the backend: dotnet run
Frontend Setup
Navigate to the frontend directory: cd employee-management-system/frontend
Install dependencies: npm install
Update Firebase configuration in src/firebase.js
Run the frontend: npm start
Usage
Access the frontend interface by navigating to http://localhost:3000 in your web browser.
Employees can scan QR codes upon arrival and departure to record their attendance.
Administrators can log in to the admin interface to manage employee scans and perform administrative tasks.
