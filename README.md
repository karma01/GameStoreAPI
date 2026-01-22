# 🎮 GameStore API

A **.NET 8 Minimal API** for managing a video game inventory system. This project demonstrates clean RESTful CRUD operations using **Entity Framework Core** with **SQL Server (LocalDB)**.

Perfect for learning:

* Minimal APIs in .NET 8
* EF Core with SQL Server
* Clean CRUD-based backend design

---

## 🚀 Features

* Full **CRUD** operations for games
* Uses **Entity Framework Core** for data access
* SQL Server (LocalDB) support
* Lightweight **Minimal API** architecture
* Clean and beginner-friendly project structure

---

## 🛠 Technologies Used

* **.NET 8.0** – Minimal API
* **Entity Framework Core** – ORM
* **SQL Server (LocalDB)** – Database

---

## 📦 Prerequisites

Make sure you have the following installed:

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
* SQL Server **LocalDB** or SQL Server Express
* Git

---

## ⚙️ Setup & Installation

### 1️⃣ Clone the Repository

```bash
git clone git@github.com:karma01/GameStoreAPI.git
cd GameStoreAPI
```

---

### 2️⃣ Database Configuration

Update the connection string in **`appsettings.json`**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GameStoreDb;Trusted_Connection=True;"
}
```

Apply migrations and create the database:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 3️⃣ Run the Application

```bash
dotnet run
```

The API will start running at:

```
https://localhost:5001
```

(or the port shown in your console)

---

## 📡 API Endpoints

| Method | Endpoint      | Description              |
| ------ | ------------- | ------------------------ |
| GET    | `/games`      | Retrieve all games       |
| GET    | `/games/{id}` | Retrieve a specific game |
| POST   | `/games`      | Create a new game        |
| PUT    | `/games/{id}` | Update an existing game  |
| DELETE | `/games/{id}` | Delete a game            |

---

## 📥 Request Payloads

### ➕ Create Game (POST)

```json
{
  "name": "Shadow Fight",
  "genreId": 2,
  "price": 59.99,
  "releaseDate": "2024-10-12"
}
```

---

### ✏️ Update Game (PUT)

```json
{
  "name": "Shadow Fight Remastered",
  "genreId": 2,
  "price": 69.99,
  "releaseDate": "2024-12-01"
}
```

---

## 🧪 Testing the API

You can test the endpoints using:

* **Postman**
* **Swagger UI** (if enabled)
* **curl**

Example:

```bash
curl https://localhost:5001/games
```

---

## 📌 Project Structure (Overview)

```
GameStoreAPI
│── Data/
│   └── GameStoreContext.cs
│── Models/
│   └── Game.cs
│── Program.cs
│── appsettings.json
```





