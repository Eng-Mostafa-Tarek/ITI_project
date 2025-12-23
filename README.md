## Library Management System (WinForms)
A desktop-based Library Management System built using C# WinForms and SQL Server. The application allows librarians to manage books, categories, members, and track book loan transactions efficiently.

# Features
Book Management: Add, update, delete, and list books with details like Title, Author, and Price.

Category Management: Organize books into different categories (e.g., Science, History, Fiction).

Member Management: Register and manage library members' contact information.

Loan Tracking: Record book borrowing transactions, track loan dates, and return status.

Relational Database: Uses SQL Server with foreign key constraints to ensure data integrity.

# 🛠️ Tech Stack
Frontend: C# WinForms (.NET Framework / .NET Core)

Backend: SQL Server

Database Access: ADO.NET (Microsoft.Data.SqlClient)

# 📂 Database Schema
The project consists of the following main tables:

BOOK: Stores book details and links to categories.

CATEGORY: Stores different book genres/types.

MEMBER: Stores library users' data.

LOAN: Manages the borrowing process between members and books.
