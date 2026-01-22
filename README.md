# GameStore API

A .NET Minimal API for managing a video game inventory system. Supports full CRUD operations using Entity Framework Core and SQL Server.

## Technologies
* **.NET 8.0** (Minimal API)
* **Entity Framework Core** (ORM)
* **SQL Server** (Database)

## Prerequisites
* .NET 8.0 SDK
* SQL Server (LocalDB)

## Setup & Installation

**1. Clone the repository**
```bash
git clone git@github.com:karma01/GameStoreAPI.git
cd GameStore
Create Game (POST)

JSON

{
  "name": "Shadow Fight",
  "genreId": 2,
  "price": 59.99,
  "releaseDate": "2024-10-12"
}
Update Game (PUT)

JSON

{
  "name": "Shadow Fight Remastered",
  "genreId": 2,
  "price": 69.99,
  "releaseDate": "2024-12-01"
}
