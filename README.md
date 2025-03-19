# 🏡 FamilyTree - .NET 9 & Next.js Implementation

## 📖 About the Project
This project is a **full-stack application** that includes a **Next.js** frontend and an **ASP.NET Core Web API** backend, both containerized with **Docker Compose**. The application is designed to manage **family trees** and provide a **Dropdown Select component** for selecting families and inspect it members.

Key features include:
- **.NET 9 API** with **Clean Architecture** principles
- **Next.js frontend** with a custom **Dropdown Select component**
- **CQRS with MediatR** for structured request handling
- **EF Core** for database access with **PostgreSQL**
- **Containerized using Docker Compose**

---

## 🎯 Objectives
The application provides an API that returns individuals from a family tree and a frontend component that allows users to select a person from the list. The component supports:
- **Dropdown selection**
- **Searchable options**
- **Dynamic API integration**

---

## 📂 Project Structure

The project follows **Clean Architecture**, ensuring separation of concerns and maintainability.

```
FamilyTree.sln
│
├── 📂 src
│   ├── 📂 api                             # 🌍 ASP.NET Core Web API (Backend)
│   │   ├── FamilyTree.App                 # 🚀 API startup and configuration
│   │   ├── FamilyTree.Application         # 🧠 Business logic (CQRS, MediatR, Services)
│   │   ├── FamilyTree.Data                # 💾 EF Core database setup
│   │   ├── FamilyTree.Web                 # 🎨 API controllers
│   │   ├── FamilyTree.IntegrationTests    # 🔬 Integration tests (TestContainers)
│   │   ├── FamilyTree.ArchitectureTests   # 🔍 Architecture tests
│   │   └── Dockerfile                     # 🐳 Docker setup
│   │
│   ├── 📂 webapp                         # 🌐 Next.js frontend (React-based UI)
│       ├── family-tree                    # 📌 Main frontend app
│       │   ├── components                 # 🏗️ Reusable UI components (Dropdown Select, etc.)
│       │   ├── app                        # 📄 Next.js Server Side components
│       │   ├── api-queries                # 🔗 API service layer
│       │   ├── assets                     # 🎨 Images and static files
│       │   ├── .env                       # ⚙️ Environment configurations
│       │   ├── Dockerfile                 # 🐳 Docker setup
│       │   ├── package.json               # 📦 Dependencies
│       │   └── next.config.js             # ⚙️ Next.js configuration
│
├── docker-compose.yml                    # 🏗️ Docker Compose setup
├── README.md                             # 📘 Project documentation
└── FamilyTree.postman_collection.json    # 📘 Postman collection with API endpoints
```

---

## 🔗 API Endpoints

### **1️⃣ Get Families**
Retrieves a list of all families.

**Request:**
```http
GET /api/v1/Families
Headers:
  x-client-id: client-id-7c3de2b9-1b8a-423d-b18c-1817441823b8
```

### **2️⃣ Get Family by ID**
Retrieves details of a specific family.

**Request:**
```http
GET /api/v1/Families/{Family_Id}
Headers:
  x-client-id: client-id-3ff5d097-dd85-463a-bb52-5b51fe97fb51
```

### **3️⃣ Get Family Member**
Retrieves details of a specific person in a family.

**Request:**
```http
GET /api/v1/Families/{Family_Id}/members/{Person_Id}
Headers:
  x-client-id: client-id-7c3de2b9-1b8a-423d-b18c-1817441823b8
```

📌 **Headers Validation:**
- **400 Bad Request:** If `x-client-id` header is missing
- **401 Unauthorized:** If `x-client-id` is invalid

📌 **Seeded Families for Testing:**
- `0a0a041f-dbf7-46bc-92e2-825d07d92d3c` - Smith Family Tree
- `a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64` - Baggins Family
- `a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1` - Brown Family
- `a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43` - Johnson Family
- `b1a8e62d-4499-4f34-8773-b9fa4e7d2c43` - Smith Family
- `b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6` - Potter Family
- `c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81` - Atreides Family
- `c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81` - Gonzalez Family
- `f2a19d5c-3b4e-4d92-8827-6f5b2e34c812` - Williams Family

---

## 🎮 Dropdown Select Component (Next.js)

### **Component Usage in the Application**
```tsx
interface DropdownOption {
  label: string;
  value: string;
}

interface FamilySelectorProps {
  options: DropdownOption[];
}

export default function FamilySelector({ options }: FamilySelectorProps) {
  const [selected, setSelected] = useState<DropdownOption | null>(null);

  const handleSelection = (option: DropdownOption | null) => {
      setSelected(option);
  };

  return (
    <DropdownSelect options={options} selectedOption={selected} onChange={handleSelection} />
  );
}
```

### **Features**
✅ Searchable dropdown
✅ Selection with callback
✅ Custom styling with CSS modules
✅ Navigation to selected family

---

## 🛠️ Running the Application

### **1️⃣ Clone the Repository**
```sh
git clone https://github.com/your-username/FamilyTree.git
cd FamilyTree
```

### **2️⃣ Build the Application**
```sh
docker-compose build
```

### **3️⃣ Apply Migrations** (Manually using EF CLI)
```sh
docker-compose run familytree.api dotnet ef database update --project src/api/FamilyTree.Data
```

### **4️⃣ Start the Application**
```sh
docker-compose up
```

### **5️⃣ Access the Application**
- **API:** [http://localhost:7006](http://localhost:7006)
- **Frontend:** [http://localhost:3010](http://localhost:3010)

---

## ✅ Running Tests
### **1️⃣ Integration Tests (API)**
```sh
dotnet test src/api/FamilyTree.IntegrationTests
```

📌 **Frontend tests are not included in this implementation.**

---

## 📜 License
This project is licensed under the **MIT License**. Contributions are welcome!

---

## 🚀 Contributing
If you have improvements or bug fixes, feel free to **open a PR** on GitHub.

---

## 🎯 Summary
✅ **Full-stack .NET 9 & Next.js Application**  
✅ **Dropdown Select with Search capabilities**  
✅ **PostgreSQL database with EF Core**  
✅ **Containerized with Docker Compose**  
✅ **Integration tests with TestContainers**  
✅ **Clear API with headers validation**  
✅ **Manual EF migrations using CLI**  
✅ **Navigation to selected family using router**  

We look forward to seeing your contributions! 🚀

