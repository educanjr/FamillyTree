# 🏡 FamilyTree Backend - .NET 9 API

## 📖 About the Project

This is the **backend API** for the **FamilyTree project**, built with **ASP.NET Core (.NET 9)**. It provides endpoints to manage families and their members, with data stored in **PostgreSQL**. The API follows **Clean Architecture** principles and supports **CQRS with MediatR**.

Key features include:
- **.NET 9 API with Clean Architecture**
- **CQRS pattern using MediatR**
- **Entity Framework Core with PostgreSQL**
- **Dockerized environment**
- **Integration tests using TestContainers**
- **Seeded database for testing**

---

## 📂 Project Structure

```
FamilyTree.sln
│
├── 📂 FamilyTree.App           # 🚀 API Startup & Configuration
├── 📂 FamilyTree.Application   # 🧠 Business logic (CQRS, MediatR, Services)
├── 📂 FamilyTree.Data          # 💾 EF Core database setup with migrations & seeding
├── 📂 FamilyTree.Web           # 🎨 API Controllers
├── 📂 FamilyTree.IntegrationTests  # 🔬 Integration tests (TestContainers)
├── 📂 FamilyTree.ArchitectureTests # 🔍 Architecture tests
├── 🐳 Dockerfile               # 🐳 Docker setup
├── 📝 appsettings.json         # ⚙️ Configuration file
└── 📜 README.md                # 📘 Project documentation
```

---

## 🔗 API Endpoints

### **1️⃣ Get Families**
Retrieves a list of all families.
```http
GET /api/v1/Families
Headers:
  x-client-id: client-id-7c3de2b9-1b8a-423d-b18c-1817441823b8
```

### **2️⃣ Get Family by ID**
Retrieves details of a specific family.
```http
GET /api/v1/Families/{Family_Id}
Headers:
  x-client-id: client-id-3ff5d097-dd85-463a-bb52-5b51fe97fb51
```

### **3️⃣ Get Family Member**
Retrieves details of a specific person in a family.
```http
GET /api/v1/Families/{Family_Id}/members/{Person_Id}
Headers:
  x-client-id: client-id-7c3de2b9-1b8a-423d-b18c-1817441823b8
```

📌 **Headers Validation:**
- **400 Bad Request:** If `x-client-id` header is missing
- **401 Unauthorized:** If `x-client-id` is invalid

---

## 🛠️ Running the Application

### **1️⃣ Clone the Repository**
```sh
git clone https://github.com/your-username/FamilyTree.git
cd FamilyTree/src/api
```

### **2️⃣ Build the Application**
```sh
dotnet build
```

### **3️⃣ Apply Migrations (Manually using EF CLI)**
```sh
dotnet ef database update --project FamilyTree.Data
```

### **4️⃣ Run the API Locally**
```sh
dotnet run --project FamilyTree.App
```

### **5️⃣ Access the API**
- **Swagger UI:** [https://localhost:7122/swagger](https://localhost:7122/swagger/index.html)
- **Base API URL:** `https://localhost:7122/api`

---

## 🚀 Running with Docker

### **1️⃣ Build the Docker Image**
```sh
docker build -t familytree-api .
```

### **2️⃣ Run the Container**
```sh
docker run -p 7006:80 familytree-api
```

### **3️⃣ Run with Docker Compose**
```sh
docker-compose up --build
```

---

## ✅ Running Tests

### **1️⃣ Integration Tests**
```sh
dotnet test FamilyTree.IntegrationTests
```

### **2️⃣ Architecture Tests**
```sh
dotnet test FamilyTree.ArchitectureTests
```

---

## 📜 License
This project is licensed under the **MIT License**. Contributions are welcome!

---

## 🎯 Summary
✅ **.NET 9 API with Clean Architecture**  
✅ **CQRS pattern using MediatR**  
✅ **Entity Framework Core with PostgreSQL**  
✅ **Seeded database for testing**  
✅ **Integration tests with TestContainers**  
✅ **Containerized with Docker**  

We look forward to seeing your contributions! 🚀

