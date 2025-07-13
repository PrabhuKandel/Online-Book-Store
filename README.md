# 📚 Online-Book Store.NET

A web-based Bookstore application (Book e-commerce) built using ASP.NET Core and Entity Framework Core.  
This project supports Stripe for payment integration and includes role-based authorization.

---

## 📦 Features

- 🛠 **Admin Role**
  - Upload and manage books with detailed descriptions.
  - Perform CRUD operations on books and categories.
  - Create user accounts and manage orders.
  - Lock and unlock users
  - Pay for company user 

- 👤 **Employee Role**
  - can view order details of all type of users.

- 🏢 **Company Role**
  - Can place orders with and pay later.
  - Managed separately from individual customers.

- 🛒 **Customer Role**
  - Standard users who can browse books and place orders with upfront payment.

- 💳 **Stripe Integration**
  - Secure online payment gateway integration (test mode).

- 📝 **Rich Text Editor**
  - Integrated TinyMCE for enhanced book description formatting.

- 🧱 **Modular & Scalable Architecture**
  - Built using ASP.NET Core MVC and Entity Framework Core.

- 🛍 **Shopping Cart with Session Management**
  - Add, update, and remove books from cart with session-based state persistence.

---


## 🚀 Getting Started

### 1. Prerequisites

- SQL Server or LocalDB  
- A Stripe account (for payment integration)

---

## 2.  Configuration

### appsettings.json

Update the `appsettings.json` file with your own configuration:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=BookStore;Trusted_Connection=True;MultipleActiveResultSets=true"
},
"Stripe": {
  "SecretKey": "YOUR_STRIPE_SECRET_KEY",
  "PublishableKey": "YOUR_STRIPE_PUBLISHABLE_KEY"
}
```

Replace:
- `YOUR_SERVER_NAME` with your SQL Server instance name  
- `YOUR_STRIPE_SECRET_KEY` and `YOUR_STRIPE_PUBLISHABLE_KEY` with your credentials from [Stripe Dashboard](https://dashboard.stripe.com/)

---

### 3.  Admin Role and User Setup

Go to:

```
BookStore.DataAccess/DbInitializer/DbInitializer.cs
```

This file handles seeding:
- Default roles (e.g., Admin, User)
- A default admin user

You can customize:
- Admin email and password  
- Role names and seed data  

> ⚠️ Make changes **before running database migrations**, so they're applied properly.

---

### 4.  TinyMCE Editor (Rich Text Editor)

TinyMCE has been used for rich text editing, but its CDN script has been removed.

To re-enable it:

1. Open `Views/Shared/_Layout.cshtml`  
2. add:

```html
<script src="https://cdn.tiny.cloud/1/no-api-key/tinymce/6/tinymce.min.js" referrerpolicy="origin"></script>
```

3. Replace `no-api-key` with your own from [TinyMCE Cloud](https://www.tiny.cloud/)

---

## 5.  Database Setup

After completing configuration:

Open the **Package Manager Console** and run:

```powershell
Add-Migration InitialCreate
Update-Database
```

This will generate and apply the database schema using Entity Framework Core.


## 6.  Security Reminder

Do **not** commit secrets like:

- Stripe keys  
- Connection strings  



---

## 🙌 Contributing

Pull requests and issues are welcome!  
Feel free to fork and extend the project.

---


