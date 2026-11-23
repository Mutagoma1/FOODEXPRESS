# FoodExpress: A Desktop Food Ordering and Delivery Management System

**Author:** Caleb Ndirima Mutagoma  
**Institution:** Adventist University of Central Africa (AUCA)  
**Course:** .NET Programming  
**Framework:** .NET 10 Windows Forms (WinForms)  
**Architecture:** Model-View-Controller (MVC)  
**Database:** Relational Database (SQLite via `Microsoft.Data.Sqlite`)  

---

## 📌 Project Overview
FoodExpress is a Windows desktop application that enables restaurants to take, manage, track, and report food orders. Built strictly according to the **FoodExpress Software Requirements Specification (SRS)**, it features complete graphical user interaction with a relational database, strict business rule enforcement, and a clean **MVC** separation of concerns.

---

## 🏗️ MVC Architecture

```
FoodExpress/
├── Models/                     # Data entities & database representation
│   ├── User.cs                 # User entity (Customer & Admin roles)
│   ├── Category.cs             # Food categories
│   ├── MenuItem.cs             # Menu items with price snapshot, availability, active flag
│   ├── Order.cs                # Order entity with status state machine
│   ├── OrderItem.cs            # Order line items with frozen snapshot pricing
│   ├── OrderStatusHistory.cs   # Audit trail of order status transitions (FR-7.7)
│   ├── CartItem.cs             # Active customer shopping cart items
│   └── DashboardMetrics.cs     # Real-time analytics, order status counts & best-sellers
│
├── Data/                       # Data access & database persistence
│   ├── DatabaseHelper.cs       # Connection manager, SQLite schema setup & auto-seeding
│   └── Repositories/
│       ├── UserRepository.cs       # User CRUD, authentication & profile updates
│       ├── CategoryRepository.cs   # Category management & validation
│       ├── MenuItemRepository.cs   # Menu catalog, search, filter & soft deletion (FR-6.5)
│       └── OrderRepository.cs      # Transactional order placement, status flow & metrics
│
├── Controllers/                # Business logic & view-model coordination
│   ├── AuthController.cs       # Login, registration, session state & profile editing
│   ├── MenuController.cs       # Category & menu item management, search & filters
│   ├── CartController.cs       # In-memory shopping cart (+/-, remove, totals calculation)
│   ├── OrderController.cs      # Transactional checkout, cancellation & status progression
│   └── ReportController.cs     # Dashboard analytics & CSV reporting export (FR-8.3)
│
├── Views/                      # Windows Forms GUI screens (Drag-and-Drop Designer compatible)
│   ├── LoginForm.cs (.Designer.cs)           # User login with role routing & quick-fill
│   ├── RegisterForm.cs (.Designer.cs)        # Customer registration with validation
│   ├── MainCustomerForm.cs (.Designer.cs)    # Customer portal (Menu, Cart, Orders, Profile)
│   ├── MainAdminForm.cs (.Designer.cs)       # Admin portal (Dashboard, Orders, Menu, Categories)
│   └── OrderDetailsDialog.cs (.Designer.cs)  # Modal dialog displaying line items & status log
│
└── Common/                     # Utility services
    ├── PasswordHelper.cs       # PBKDF2 cryptographic password hashing (SHA-256 + 16-byte salt)
    └── ImageHelper.cs          # Non-locking bitmap loading and placeholder generator
```

---

## 🔑 Pre-Seeded Default Accounts

The database is automatically created and seeded on the very first run (`foodexpress.db`):

| Role | Email | Password | Full Name |
| :--- | :--- | :--- | :--- |
| **Administrator** | `admin@foodexpress.com` | `Admin123!` | Administrator |
| **Customer** | `caleb@example.com` | `Password123!` | Caleb Ndirima Mutagoma |

> *Quick-Fill buttons are also provided directly on the Login screen for one-click testing.*

---

## 🚀 How to Open and Run in Visual Studio

1. Open **Visual Studio 2026** (or Visual Studio 2022).
2. Choose **"Open a project or solution"**.
3. Select **`FoodExpress.slnx`** or **`FoodExpress.sln`** located in:
   ```
   C:\Users\mutagoma\OneDrive\Desktop\FOODEXPRESS
   ```
4. Press **`F5`** or click **`Start Debugging`** / **`Start Without Debugging` (Ctrl+F5)**.

### 🎨 Visual Studio Drag-and-Drop Form Designer
Each form under `Views/` has standard `.cs` and `.Designer.cs` partial classes:
* Double-click any form (e.g. `MainCustomerForm.cs` or `MainAdminForm.cs`) or right-click and choose **"View Designer" (Shift+F7)**.
* You can drag and drop controls directly from the **Toolbox**, move them around, or customize their properties in the **Properties Window**.

---

## 📋 SRS Requirements Coverage (49/49)

### 1. User Registration and Authentication
- **FR-1.1**: Full name, email, phone number, password registration.
- **FR-1.2**: Validation for email uniqueness, email format regex, password minimum 6 characters.
- **FR-1.3**: Secure login with email and PBKDF2 hashed password verification.
- **FR-1.4**: Logout clears active user session.
- **FR-1.5**: New user registrations are automatically assigned role `Customer`.
- **FR-1.6**: Admin screens open strictly for users with the `Admin` role.
- **FR-1.7**: Profile view and edit (name, phone, default delivery address, password change).

### 2. Menu Browsing
- **FR-2.1**: Menu items categorized and filtered dynamically.
- **FR-2.2**: Visual display of name, description, price, food image/icon, and availability badge.
- **FR-2.3**: Category filter dropdown and reset options.
- **FR-2.4**: Real-time keyword search by food name or description.
- **FR-2.5**: Unavailable items clearly marked as "OUT OF STOCK" and prevented from being added to the cart.

### 3. Shopping Cart
- **FR-3.1**: Logged-in customer can add available menu items to the cart.
- **FR-3.2**: Quantity adjustment (+ / -) with automatic line total recalculation.
- **FR-3.3**: Remove individual item from cart.
- **FR-3.4**: Automatic total price calculation updated immediately on any change.
- **FR-3.5**: Clear whole cart button.

### 4. Checkout & Order Placement
- **FR-4.1**: Checkout prohibited if cart is empty.
- **FR-4.2**: Delivery address and contact phone pre-filled from customer profile.
- **FR-4.3**: Payment method selection (Cash on Delivery, Mobile Money, Card).
- **FR-4.4**: Live order summary breakdown before confirmation.
- **FR-4.5**: Status initialized to `Placed`; current item prices copied into order items so future menu price changes do not alter historic orders.
- **FR-4.6**: Cart cleared upon successful order placement.
- **FR-4.7**: Database transaction (`SqliteTransaction`) guarantees all-or-nothing atomicity.
- **FR-4.8**: Confirmation popup dialog displaying unique order number (e.g. `ORD-YYYYMMDD-XXXX`).

### 5. Order Tracking & History (Customer)
- **FR-5.1**: Current status badge for each customer order.
- **FR-5.2**: Automatic refresh timer (10s interval) + manual "Refresh" button for live updates without restarting.
- **FR-5.3**: Full past orders history list.
- **FR-5.4**: View full details dialog showing ordered items, unit prices, subtotal, and audit history.
- **FR-5.5 / BR-7**: Customer can cancel order **only** while its status is `Placed`.

### 6. Menu and Category Management (Admin)
- **FR-6.1**: Add, edit, and delete food categories with dependency check.
- **FR-6.2**: Add new menu items with image file selector from computer.
- **FR-6.3**: Edit item details (name, description, price, category, image).
- **FR-6.4**: Toggle item availability directly without deleting.
- **FR-6.5**: Safe deletion: if an item appears in historical orders, it is automatically deactivated (soft deleted) rather than erased to protect order integrity.
- **FR-6.6**: Validation for price > 0 and mandatory fields.

### 7. Order Management (Admin)
- **FR-7.1**: Orders list ordered newest first.
- **FR-7.2**: Full customer contact, delivery address, and items display.
- **FR-7.3 & FR-7.4 / BR-6**: Strict status state machine progression:
  $$\text{Placed} \longrightarrow \text{Preparing} \longrightarrow \text{Out for Delivery} \longrightarrow \text{Delivered}$$
  Orders cannot skip steps or move backwards.
- **FR-7.5**: Admin can cancel orders that have not yet reached `Delivered`.
- **FR-7.6**: Filter orders by status and date.
- **FR-7.7**: Timestamp audit log records every status transition and who updated it.

### 8. Dashboard & Reports (Admin)
- **FR-8.1**: Dashboard cards showing today's sales, today's order count, and counts for each status.
- **FR-8.2**: Top best-selling menu items ranked by quantity sold and revenue.
- **FR-8.3**: One-click export of order records to standard CSV file format.

---

## 🔒 Security & Reliability
- **Password Hashing**: PBKDF2 with SHA-256 and unique 16-byte cryptographic salts.
- **SQL Injection Prevention**: 100% parameterized SQLite commands.
- **ACID Transactions**: Order placement executes inside atomic transactions.
- **Memory Safety**: Non-locking image streams to prevent Windows Forms file locks.
