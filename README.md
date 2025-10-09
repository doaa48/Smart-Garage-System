# Smart-Garage-System 
Smart Garage System Desktop application with .NET framework and C#  delivers a seamless solution for controlling and monitoring a parking garage. Users can book slots, check availability, review history, export reports, and handle slot/trouble management using a modern Windows Forms UI.It is ideal for operators, attendants, and users seeking organized, automated parking management.
# Features
- Login and Signup: Secure authentication and user registration.
- Slot Map: Visual representation of available, reserved, permanent, and maintenance slots.
- Reservations: Book by hour/month, choose vehicle type, auto‑assign slots, handle payments, and view status.
- Statistics: Track available/reserved slots and trouble cases in real-time charts.
- Ticketing: Configurable pricing (fixed, tiered, daily overnight), ticket generation, and management.
- History: Search/filter reservation records, export to PDF for reporting.
- Trouble Logging: Classify and record issues/taxes, assign to vehicle/slot history.
-Slot Dealing: Add/update slot info, address/collector, and enforce update rules for hardware mapping.
-User Feedback: Inline prompts, error dialogs, validations.

# Screenshots
Login and Sign-Up
<img width="624" height="351" alt="Picture1" src="https://github.com/user-attachments/assets/8e51456d-8621-4947-bc3d-0fafa75c7320" />
<img width="624" height="348" alt="Picture2" src="https://github.com/user-attachments/assets/3664dac4-ccf1-4756-9adb-ed32ad8293d8" />

Home Dashboard
<img width="598" height="364" alt="Picture10" src="https://github.com/user-attachments/assets/fc3d002c-91a6-4b60-85f7-2c2532222c3c" />

Reservation Screen
<img width="624" height="351" alt="Picture16" src="https://github.com/user-attachments/assets/94f76d39-79f9-490d-a9df-ff5c85c0860d" />

Slot Map Visualization
<img width="624" height="351" alt="Picture11" src="https://github.com/user-attachments/assets/7c560a98-8663-4d7c-8447-e764f1d5e57e" />

Statistics Charts
<img width="576" height="324" alt="Picture17" src="https://github.com/user-attachments/assets/9e0a99e7-6535-4dec-897e-a0e849fa2d36" />

History Export
<img width="624" height="351" alt="Picture18" src="https://github.com/user-attachments/assets/3b4d1bf5-a928-4171-8db5-d52b0b1bad06" />

Book Ticket and Pricing
<img width="624" height="351" alt="Picture21" src="https://github.com/user-attachments/assets/e4a8bc05-bcdf-417e-aa8f-2d59c257cedf" />

Trouble Reporting
<img width="624" height="351" alt="Picture22" src="https://github.com/user-attachments/assets/6110b3a3-4895-4915-a0a6-8f12d5a67662" />

Slot Operations
<img width="563" height="317" alt="Picture12" src="https://github.com/user-attachments/assets/b55021d0-3998-425c-bf86-81d20f732450" />

# Tech Stack
Language: C#
Framework: .NET Framework ( 4.7 ,4.8+)
UI: Windows Forms
Data Storage: Microsoft SQL Server (local or remote)
IDE: Visual Studio (Community)

# System Requirements
Windows 10/11
.NET Framework (target version 4.7)
Visual Studio 2019+ with .NET desktop development workload
SQL Server Express/Developer, or LocalDB

# Getting Started
Clone the repository

text (((git clone https://github.com/doaa48/Smart-Garage-System.git
cd Smart-Garage-System)))
-Open the solution in Visual Studio
-Let NuGet restore dependencies and build all projects.
-Setup the Database (Run SQL scripts found in /database to create tables for users, slots, reservations, and trouble logs.)
-Update the app.config or settings to match SQL Server connection.
-Build and Run (Press F5 to launch.)

# Configuration
Connection Strings:
Set in app.config under <connectionStrings>.

App Settings:
Configure optional feature flags, logging levels.

Database Location:
Local/remote configurable for flexibility.
