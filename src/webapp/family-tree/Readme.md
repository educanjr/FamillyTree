# 🌐 FamilyTree Frontend - Next.js Application

## 📖 About the Project

This is the **frontend application** for the **FamilyTree project**, built with **Next.js**. It provides an interactive UI for selecting and navigating between families using a **Dropdown Select component**.

Key features include:
- **Next.js 14 with TurboPack for optimized development**
- **Dropdown Select component with search functionality**
- **REST API integration with the FamilyTree backend**
- **Containerized using Docker**

---

## 📂 Project Structure

```
family-tree/
│
├── 📂 components             # 🏗️ Reusable UI components (Dropdown Select, etc.)
├── 📂 app                    # 📄 Next.js Server Side components
├── 📂 api-queries            # 🔗 API service layer
├── 📂 assets                 # 🎨 Images and static files
├── 📄 .env                   # 🛠️ Environment configurations
├── 📜 package.json           # 📦 Dependencies & scripts
├── 🐳 Dockerfile             # 🐳 Docker setup
├── ⚙️ next.config.js         # Next.js configuration
└── README.md                 # 📘 Project documentation
```

---

## 🛠️ Running the Application

### **1️⃣ Install Dependencies**

Run the following command to install the required dependencies:
```sh
npm install
```

### **2️⃣ Development Mode**

To start the application in development mode:
```sh
npm run dev
```
This runs the app in development mode with TurboPack for faster builds.

### **3️⃣ Build for Production**

To build the application for production:
```sh
npm run build
```
This compiles the Next.js app for optimal performance.

### **4️⃣ Start the Production Server**

To start the application in production mode:
```sh
npm run start
```

### **5️⃣ Run Linter**

To check for linting issues:
```sh
npm run lint
```

---

## 🚀 Running with Docker

### **1️⃣ Build the Docker Image**
```sh
docker build -t familytree-frontend .
```

### **2️⃣ Run the Container**
```sh
docker run -p 3010:3000 familytree-frontend
```

### **3️⃣ Access the Application**
- **Frontend:** [http://localhost:3010](http://localhost:3010)

---

## 🌍 Environment Variables

To configure the application, create a `.env` file in the root directory and specify the following variables:
```sh
NEXT_PUBLIC_API_BASE_URL=http://localhost:7006
NEXT_PUBLIC_X_CLIENT_ID=client-id-7c3de2b9-1b8a-423d-b18c-1817441823b8
```

---

## 📜 License
This project is licensed under the **MIT License**. Contributions are welcome!

---

## 🎯 Summary
✅ **Next.js frontend with TurboPack**  
✅ **Dropdown Select with Filter capabilities**  
✅ **REST API integration**  
✅ **Linting & best practices**  
✅ **Containerized with Docker**  

We look forward to seeing your contributions! 🚀

