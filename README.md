# 📚 Library Management System – Project Plan

This project aims to develop a **Library Management System** divided into two main independent parts, allowing each of the two team members to work efficiently with minimal dependencies.

---

## 🧩 Project Structure Overview

The system is divided into two core parts:

* **Part 1:** Core Catalog and User Management *(Assigned to Member 1)*
* **Part 2:** Circulation and Financials *(Assigned to Member 2)*

Both parts will be developed in parallel and integrated after completion.

---

## 🧠 Part 1: Core Catalog and User Management

**Assigned to:** *Member 1*

This part focuses on the foundational data of the library — the books, members, and staff.

### 📗 Modules to Develop

#### 1. **Book Catalog / Master Data Management**

**Database Schema:**

* `Books` table with fields like `BookId`, `Title`, `Author`, `Category`, `ISBN`, `Status`, etc.

**UI/UX:**

* Form to add new books
* Form to edit existing book details
* View to list all books with **search** and **filter** (by category, author, availability)

**Backend/Logic:**

* Add, update, and delete book records
* Search and filter functionality
* Manage book status: *Available, Issued, Damaged/Lost*

---

#### 2. **Member / Student Management**

**Database Schema:**

* `Members` table with fields such as `MemberId`, `MemberName`, `MemberType`, `Contact`, `ExpiryDate`, etc.

**UI/UX:**

* New member registration form
* Edit member information form
* List view with **search** and **filter** options

**Backend/Logic:**

* Register and update member details
* Manage membership status (*Active/Inactive*) and expiry tracking

---

#### 3. **Staff / Librarian Management**

**Database Schema:**

* `Staff` table with fields like `StaffId`, `FullName`, `Role`, `Username`, `Password`, etc.

**UI/UX:**

* Form to add and manage staff
* Login interface

**Backend/Logic:**

* User authentication and **role-based access control** (Admin, Librarian)
* Secure password handling (**hashing**)

---

## 💼 Part 2: Circulation and Financials

**Assigned to:** *Member 2*

This section handles the operational workflow — issuing, returning books, and managing fines.

### 📚 Modules to Develop

#### 1. **Book Issue Management**

**Database Schema:**

* `BookIssue` table with fields like `IssueId`, `MemberId`, `BookId`, `IssueDate`, `DueDate`, etc.

**UI/UX:**

* Interface to issue books to members (with book and member search)

**Backend/Logic:**

* Record book issue transactions
* Automatically update book status to *Issued*
* Calculate due dates automatically
* Enforce borrowing limits per member

---

#### 2. **Book Return Management**

**Database Schema:**

* Use `BookReturn` table **or** update `BookIssue` upon return

**UI/UX:**

* Interface to process book returns

**Backend/Logic:**

* Record book returns
* Update book status back to *Available*
* Calculate and display overdue fines

---

#### 3. **Fine & Payment Management**

**Database Schema:**

* `Fines` table with fields such as `FineId`, `MemberId`, `IssueId`, `FineAmount`, `PaymentStatus`, etc.

**UI/UX:**

* View for librarians to check outstanding fines
* Payment recording interface

**Backend/Logic:**

* Automatically create fine records for overdue books
* Update fine payment status upon settlement

---

## 🤝 Shared Responsibilities

| Task                       | Description                                                                                                 |
| -------------------------- | ----------------------------------------------------------------------------------------------------------- |
| **Database Design**        | Both members collaborate to finalize the database schema and relationships before development begins.       |
| **Reporting & Analytics**  | Split based on modules: Member 1 handles books/members reports, Member 2 handles circulation/fines reports. |
| **Notifications & Alerts** | Shared feature — can be divided by module context.                                                          |
| **Testing & Deployment**   | Each member tests their modules independently before final integration testing.                             |

---

## 🏁 Development Flow

1. **Phase 1:** Database design & schema alignment
2. **Phase 2:** Independent module development
3. **Phase 3:** Integration & testing
4. **Phase 4:** UI/UX refinement & final deployment

---

## ⚙️ Technologies (Suggested)

* **Frontend:** HTML, CSS, JavaScript, Bootstrap
* **Backend:** PHP / ASP.NET / Node.js (based on project setup)
* **Database:** MySQL / SQL Server
* **Version Control:** Git & GitHub

---

## 👥 Team Collaboration Notes

* Keep commits frequent and descriptive.
* Use feature branches for each module.
* Perform code reviews before merging to `main`.
* Maintain shared documentation for database and API structure.

---
