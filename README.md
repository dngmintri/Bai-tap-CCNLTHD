## 4. Bài tập cho Chương 7: Định tuyến (Routing) nâng cao

**Tên đồ án nhỏ: API Sản phẩm với Attribute Routing**

* **Mục tiêu:** Thực hành **Attribute Routing** và **Route Constraints**.
* **Mô tả:**
    1.  [cite_start]Tạo **API Controller** `ProductsApiController` kế thừa từ `ControllerBase` và đánh dấu `[ApiController]`, `[Route("api/items")]`[cite: 5658].
    2.  [cite_start]Tạo Action `GetAll()` đánh dấu `[HttpGet]` trả về danh sách sản phẩm mẫu[cite: 5874].
    3.  Tạo Action `GetById(int id)` đánh dấu `[HttpGet("{id:int}")]` trả về sản phẩm theo `id`. [cite_start]Constraint `:int` đảm bảo `id` phải là số nguyên[cite: 5673].
    4.  Tạo Action `GetByCode(string code)` đánh dấu `[HttpGet("code/{code:alpha:length(3)}")]` trả về sản phẩm theo mã (`code`). [cite_start]Constraint `:alpha:length(3)` yêu cầu `code` phải là 3 ký tự chữ cái[cite: 5677].
    5.  Test các route bằng Postman hoặc trình duyệt: `/api/items`, `/api/items/123`, `/api/items/code/XYZ`.

---

## 5. Bài tập cho Chương 8: Làm việc với Cơ sở dữ liệu

**Tên đồ án nhỏ: CRUD Ghi chú với EF Core In-Memory**

* **Mục tiêu:** Thực hành **EF Core** (DbContext, DbSet, Migrations - dù In-Memory không cần), **CRUD**, và **Repository Pattern**.
* **Mô tả:**
    1.  Tạo **Model** `Note.cs` (`Id`, `Title`, `Content`).
    2.  [cite_start]Tạo `AppDbContext` kế thừa `DbContext`, khai báo `DbSet<Note> Notes` [cite: 5742-5745].
    3.  Trong `Program.cs`, đăng ký DbContext sử dụng **In-Memory Database**: `builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("NotesDB"));` (Cần cài package `Microsoft.EntityFrameworkCore.InMemory`).
    4.  [cite_start]Tạo **interface** `INoteRepository` với các method CRUD (GetAll, GetById, Add, Update, Delete) [cite: 5756-5763].
    5.  [cite_start]Tạo **class** `NoteRepository` implement `INoteRepository`, inject `AppDbContext` và thực hiện các thao tác CRUD dùng LINQ và EF Core [cite: 5765-5775].
    6.  Đăng ký `INoteRepository`/`NoteRepository` vào DI.
    7.  Tạo `NotesController` (API hoặc MVC), inject `INoteRepository` và gọi các method của repository để xử lý request.

---
