# Pampazon Web - Frontend

## Overview

Pampazon Web is the Blazor WebAssembly frontend for the Pampazon Warehouse Management System. It provides a user interface for managing warehouse operations, including tracking products, stock levels, client information, incoming goods (receipts), customer orders, and dispatches.

This frontend application communicates with a backend API to fetch and manipulate data.

## Technologies Used

*   **Frontend:**
    *   Blazor WebAssembly
    *   .NET 8 (or latest version used)
    *   C#
    *   HTML, CSS (Bootstrap for styling)
*   **Backend API:** (Assumed to be a .NET Web API, details based on interaction)
    *   ASP.NET Core Web API
    *   Entity Framework Core (commonly used with .NET APIs)

## Features Implemented

*   **Core Data Display:**
    *   View a list of Products.
    *   View current Stock Positions, including product details, client, quantity, and location.
    *   View a list of Clients.
    *   View a list of Receipts (incoming goods).
    *   View a list of Orders.
    *   View a list of Dispatches.
*   **Data Management:**
    *   Basic CRUD operations (Create, Read, Update, Delete) for Products via `ProductForm.razor`.
    *   Basic CRUD operations (Create, Read, Update, Delete) for Clients via `ClientForm.razor`.
    *   Create and Delete functionality for Stock Positions via `StockPositionForm.razor` integrated into `Stock.razor`.
*   **API Integration:**
    *   All data pages fetch information from the backend API.
    *   Standardized API endpoint usage (e.g., `api/Products`, `api/StockPositions`, `api/Clients`, `api/Receipts`, `api/Orders`, `api/Dispatches`).
*   **User Experience:**
    *   Navigation menu for easy access to different sections.
    *   Error handling: Displays specific error messages if API calls fail or exceptions occur.
    *   Empty state messages: Shows "No [items] found" if API returns no data.
    *   Responsive table layouts for displaying data.

## Project Structure (Client - Pampazon.Web.Client)

*   **`Models/`**: Contains the C# classes representing the data structures used in the frontend (e.g., `Product.cs`, `StockPosition.cs`, `Client.cs`, `Order.cs`, `Receipt.cs`, `Dispatch.cs`). These models are designed to align with the backend API's DTOs.
*   **`Pages/`**: Contains the Razor components that define the application's pages (e.g., `Products.razor`, `Stock.razor`, `Clients.razor`, `Orders.razor`, `Receipts.razor`, `Dispatches.razor`).
*   **`Components/`**: Contains reusable Razor components used across different pages (e.g., `ProductForm.razor`, `ClientForm.razor`, `StockPositionForm.razor`).
*   **`Shared/`**: Contains shared layout components like `MainLayout.razor` and `NavMenu.razor`.
*   **`wwwroot/`**: Contains static assets like CSS and JavaScript files.
*   **`Program.cs`**: The entry point for the Blazor WASM application, where services are configured, including the `HttpClient` for API communication.

## Setup and Running the Application

1.  **Backend API:** Ensure the Pampazon backend API is running and accessible. The default configured URL for the API is `https://localhost:7001`.
2.  **Navigate to Project Directory:** Open a terminal or command prompt and navigate to the root directory of the `Pampazon.Web` solution.
3.  **Run the Client Project:**
    *   Navigate to the `Pampazon.Web/Client` directory if you want to run the client project directly or `Pampazon.Web/Server` if running the hosted version.
    *   Execute the command: `dotnet run`
4.  **Access the Application:** Open a web browser and go to the hosting URL provided by the `dotnet run` command (usually `https://localhost:XXXX` or `http://localhost:XXXX`).

## API Configuration

*   The base address for the backend API is configured in `Pampazon.Web/Client/Program.cs`.
*   The current `HttpClient.BaseAddress` is set to `https://localhost:7001/`. If your backend API is running on a different address or port, you will need to update this configuration.

## Current Status and Next Steps

The application has established basic functionality for viewing and managing core warehouse entities. Frontend models have been significantly realigned to match backend API documentation. Error handling and user feedback for loading states are in place.

**Key areas for future development include:**

*   **Full CRUD for All Entities:** Implement complete Create, Read, Update, and Delete operations for Receipts, Orders, and Dispatches. This involves creating and integrating respective form components.
*   **Enum Synchronization:** Verify and ensure all enum values (`OrderStatus`, `ReceiptStatus`, `DispatchStatus`) in the frontend models exactly match the values expected and returned by the backend API.
*   **Advanced Form Features:**
    *   Implement edit functionality in `StockPositionForm.razor`.
    *   Add dropdowns for selecting related entities (e.g., Products when creating OrderItems, Clients when creating Orders).
    *   Implement client-side and server-side validation enhancements.
*   **Detailed Views:** Create pages or modals for viewing the full details of an individual Order, Receipt, or Dispatch, including their line items.
*   **Workflow Implementation:** Develop UI elements and logic to support warehouse workflows (e.g., processing new receipts, picking and packing orders, finalizing dispatches).
*   **Authentication and Authorization:** Secure the application by implementing user login and role-based access control.
*   **Testing:** Write unit and integration tests.
*   **UI/UX Enhancements:** Further refine the user interface and experience, potentially adding features like sorting, filtering, and pagination for tables.
*   **Deployment:** Configure the application for deployment to a hosting environment. 