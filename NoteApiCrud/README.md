# CRUD Ghi chú với EF Core In-Memory

## Mô tả
Dự án thực hành EF Core với In-Memory Database và Repository Pattern.

## Yêu cầu
- .NET 9.0
- Entity Framework Core In-Memory

## Cài đặt
1. Restore packages: `dotnet restore`
2. Chạy ứng dụng: `dotnet run`
3. Truy cập Swagger: http://localhost:5236/swagger

## API Endpoints
- GET /api/notes - Lấy tất cả ghi chú
- GET /api/notes/{id} - Lấy ghi chú theo ID
- POST /api/notes - Tạo ghi chú mới
- PUT /api/notes/{id} - Cập nhật ghi chú
- DELETE /api/notes/{id} - Xóa ghi chú

## Kiến trúc
- Model: Note.cs (Id, Title, Content)
- Data: AppDbContext với DbSet<Note>
- Repository Pattern: INoteRepository và NoteRepository
- In-Memory Database: Dữ liệu lưu trong bộ nhớ

