# API Sản phẩm với Attribute Routing

## Mô tả
Dự án thực hành Attribute Routing và Route Constraints trong ASP.NET Core Web API.

## Yêu cầu
- .NET 9.0
- MySQL 
- Entity Framework Core

## Cài đặt
1. Restore packages: `dotnet restore`
2. Chạy ứng dụng: `dotnet run`
3. Truy cập Swagger: http://localhost:5001/swagger

## API Routes
- GET /api/items - Lấy tất cả sản phẩm
- GET /api/items/{id:int} - Lấy sản phẩm theo ID
- GET /api/items/code/{code:alpha:length(3)} - Lấy sản phẩm theo mã

## Route Constraints
- `:int` - Yêu cầu ID phải là số nguyên
- `:alpha:length(3)` - Yêu cầu code phải là 3 ký tự chữ cái

