```markdown
# 🐾 Pampals - A Cute ASP.NET Core MVC Backend Project

Welcome to **Pampals**, a super simple and cute ASP.NET Core Web API project that helps you play with virtual pets! 🐶🐱🐰  
In this project, we’re not using a database — we’re just storing the pets in memory, like a toy box that gets empty every time you restart the game.

---

## ✨ What is Pampals?

Pampals is a small backend project that follows the **MVC (Model-View-Controller)** design pattern.  
Imagine you have a magical animal shelter that keeps a list of pets you tell it about. You can:

- 🐾 Add a pet (like a Cat named Fluffy)
- 🐾 See all the pets you’ve added
- 🐾 Find one specific pet by its ID
- 🐾 Delete a pet

Each pet has a **name**, a **type** (like Dog, Cat, Rabbit), and a secret **ID**.

---

## 📁 Project Structure

Here's how the project is organized:

```
```
Pampals/
├── Controllers/
│   └── PetController.cs      --> Handles requests (like a receptionist 🧑‍💼)
├── Models/
│   └── Pet.cs                --> Defines what a Pet is (like a birth certificate 🐶)
├── Program.cs                --> Starts the app and sets up routes (like a conductor 🚂)
├── Properties/
│   └── launchSettings.json   --> Settings for running the app locally
└── README.md                 --> You’re reading it! 📖
```
![pampals](https://github.com/user-attachments/assets/c9cfdf6c-94d3-47f4-aa4a-f35753e96f77)

````

---

## 💡 MVC Explained with Pampals

### 1. **Model** - `Pet.cs`
This is the 🧱 blueprint for a pet. It tells the app:  
"Every pet must have an `Id`, a `Name`, and a `Type`."

```csharp
public class Pet {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
}
````

---

### 2. **Controller** - `PetController.cs`

This is the 🧠 brain that handles all the logic. When you send a request (like “add a pet”), it:

* 📨 Receives your request
* 📦 Creates or finds pets
* 📤 Sends the response back

Endpoints:

* `GET /api/pet` → See all pets
* `GET /api/pet/{id}` → See one pet
* `POST /api/pet` → Add a new pet
* `DELETE /api/pet/{id}` → Remove a pet

---

### 3. **Program.cs**

This is the engine that turns everything on. It sets up:

* Routing
* Middleware
* Controllers

---

## 🚀 How to Run Pampals

### ✅ Requirements:

* [.NET SDK 7.0+](https://dotnet.microsoft.com/download)

### 📦 Steps:

1. Clone this repo:

   ```bash
   git clone https://github.com/Rohit-554/pampals.git
   cd pampals
   ```

2. Run the project:

   ```bash
   dotnet run
   ```

3. Open your browser or Postman and visit:

   ```
   http://localhost:5076/api/pet
   ```

---

## 🎮 Example Requests

### ➕ Add a Pet (POST)

```bash
curl http://localhost:5076/api/pet \
  -H "Content-Type: application/json" \
  -d '{"name": "Fluffy", "type": "Cat"}'
```
<br>
open postman -> file -> imports -> paste curl

### 📋 Get All Pets (GET)

```bash
curl http://localhost:5076/api/pet
```

### 🔍 Get a Pet by ID (GET)

```bash
curl http://localhost:5076/api/pet/1
```

### ❌ Delete a Pet (DELETE)

```bash
curl -X DELETE http://localhost:5076/api/pet/1
```

---

## 📌 Notes

* 🧠 The pet list is **in memory only** — once you stop the app, the pets disappear.
* 🎨 There is **no frontend**, just APIs.
* 🧒 Even a kid could play with this API using Postman or a browser!

---

## 🐣 Want to Make It Even Cuter?

* Add emojis to pet types 🐶🐱🐰
* Create random pet names
* Add timestamps or pet birthdays 🎂

---

## ❤️ Made with Care

This project was made for fun and learning.
If you enjoyed it, give the repo a ⭐ and go pet a real dog or cat nearby! 🐕

---

```

Would you like me to generate a matching GitHub repo structure or `.gitignore` for this project too?
```
