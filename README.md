# Postgresql API

這個專案是一個基於 ASP.NET Core 和 PostgreSQL 的 API，旨在演示如何在 ASP.NET Core 中使用 Entity Framework Core 和 PostgreSQL 進行資料操作。專案包括了基本的 CRUD 操作和對 PostgreSQL 資料庫的連接。

## 專案結構

- `Program.cs`: 應用程式的入口點，配置服務和中介軟體。
- `Models/PreOrder.cs`: 定義了 `PreOrder` 實體模型。
- `Controllers/PreOrderController.cs`: 提供了處理 `PreOrder` 資料的 API 接口。
- `appsettings.json`: 配置檔案，包含資料庫連接字串和其他設置。
- `sql_struct.sql`: SQL 結構檔案，用於創建資料庫表。

## 安裝與配置

### 先決條件

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Visual Studio Code](https://code.visualstudio.com/) 或 [Visual Studio](https://visualstudio.microsoft.com/)

### 啟動

~~~

dotnet build
dotnet run

~~~


### 測試 API
API 運行後，可以使用以下範例來測試 POST 請求：

範例 POST 請求

~~~

--http://localhost:5178/api/preorder

{
  "email": "test@example.com",
  "name": "John Doe",
  "phone": "123-456-7890",
  "contact": "Jane Doe",
  "product": "Sample Product",
  "count": 5,
  "remark": "This is a test remark",
  "ischeck": true
}

~~~

- 預期回應
  
~~~

"Pre-order created successfully."

~~~