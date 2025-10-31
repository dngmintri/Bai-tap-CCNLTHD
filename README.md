## 1. Bài tập cho Chương 4: Các khái niệm cơ bản

### **1.1. MVC Pattern: Trang "Thông tin Sinh viên"**

* **Mục tiêu:** Hiểu rõ luồng **Model-View-Controller** cơ bản.
* **Mô tả:**
    1.  Tạo **Model** `Student.cs` với các thuộc tính `Id`, `Name`, `Major`.
    2.  Tạo **Controller** `StudentController` với Action `Index()`.
    3.  [cite_start]Trong `Index()`, tạo một danh sách các `Student` mẫu[cite: 4431].
    4.  [cite_start]Truyền danh sách này vào **View** (`Index.cshtml`)[cite: 4442].
    5.  [cite_start]Trong `Index.cshtml`, sử dụng **Razor** (`@model`, `@foreach`) để hiển thị danh sách sinh viên trong một bảng HTML [cite: 4449-4467].
    6.  Cấu hình **Conventional Routing** mặc định để truy cập `/Student` hoặc `/Student/Index`.

---
## 2. Bài tập cho Chương 5: Xử lý dữ liệu và Form

**Tên đồ án nhỏ: Form Đăng ký Sự kiện**

* **Mục tiêu:** Luyện tập **Tag Helpers**, **Model Binding**, và **Validation** (Server + Client).
* **Mô tả:**
    1.  Tạo **Model** `EventRegistration.cs` với các thuộc tính như `Name` (`[Required]`, `[StringLength(50)]`), `Email` (`[Required]`, `[EmailAddress]`), `NumberOfAttendees` (`[Range(1, 10)]`).
    2.  Tạo **Controller** `EventController` với hai Action `Register()`: một cho `[HttpGet]` (hiển thị form) và một cho `[HttpPost]` (xử lý form).
    3.  Trong View `Register.cshtml`:
        * [cite_start]Sử dụng **Tag Helpers** (`<form asp-action...>`, `<label asp-for...>`, `<input asp-for...>`, `<span asp-validation-for...>`, `<div asp-validation-summary...>` ) để tạo form [cite: 5051-5056, 5191, 5382].
        * Nhớ thêm các script cho client-side validation (thường có sẵn trong template).
    4.  Trong Action `[HttpPost] Register(EventRegistration model)`:
        * [cite_start]Kiểm tra `ModelState.IsValid`[cite: 5026].
        * Nếu hợp lệ, xử lý dữ liệu (ví dụ: lưu vào đâu đó hoặc chỉ hiển thị thông báo thành công qua `TempData`) và `RedirectToAction`.
        * [cite_start]Nếu không hợp lệ, `return View(model)` để hiển thị lại form với lỗi[cite: 5028].

---
## 3. Bài tập cho Chương 6: Vòng đời, Middleware và State Management

### **3.1. Middleware: Ghi Log Thời gian Request**

* **Mục tiêu:** Hiểu cách tạo và đăng ký một **custom Middleware**.
* **Mô tả:**
    1.  [cite_start]Tạo class `RequestTimingMiddleware`[cite: 5524].
    2.  Trong `InvokeAsync(HttpContext context)`, ghi lại thời gian bắt đầu (`Stopwatch`).
    3.  [cite_start]Gọi `await _next(context);` để chuyển sang middleware tiếp theo[cite: 5535].
    4.  Sau khi `_next` hoàn thành, dừng `Stopwatch` và ghi log (dùng `ILogger`) thời gian xử lý request cho URL hiện tại.
    5.  [cite_start]Trong `Program.cs`, đăng ký middleware bằng `app.UseMiddleware<RequestTimingMiddleware>();` [cite: 5505] (đặt ở đầu pipeline để đo toàn bộ thời gian).

### **3.2. State Management: Truyền Thông báo qua TempData**

* **Mục tiêu:** Sử dụng **TempData** để hiển thị thông báo sau khi redirect.
* **Mô tả:**
    1.  [cite_start]Trong Action `[HttpPost] Create` (ví dụ từ bài tập Form), sau khi lưu thành công, thêm dòng: `TempData["SuccessMessage"] = "Sản phẩm đã được tạo thành công!";`[cite: 5616].
    2.  Sau đó `return RedirectToAction("Index");`.
    3.  [cite_start]Trong View `Index.cshtml`, thêm đoạn code để kiểm tra và hiển thị `TempData["SuccessMessage"]` (nếu có)[cite: 5621]. TempData sẽ tự động bị xóa sau khi đọc.

---

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


## 6. Bài tập cho Chương 9: Tương tác với API

**Tên đồ án nhỏ: Client Gọi API Thời tiết**

* **Mục tiêu:** Sử dụng **HttpClientFactory** và **HttpClient** để gọi một API bên ngoài.
* **Mô tả:**
    1.  Chọn một API thời tiết công khai miễn phí (ví dụ: OpenWeatherMap - cần đăng ký API key).
    2.  [cite_start]Trong `Program.cs`, đăng ký **named HttpClient** (`builder.Services.AddHttpClient("WeatherApi", ...)`), cấu hình `BaseAddress` và có thể thêm header API key mặc định [cite: 5952-5960].
    3.  [cite_start]Tạo một `WeatherService` class, inject `IHttpClientFactory` vào constructor [cite: 5971-5974].
    4.  Trong `WeatherService`, viết method `GetCurrentWeatherAsync(string city)`:
        * [cite_start]Lấy HttpClient bằng `_factory.CreateClient("WeatherApi")`[cite: 5977].
        * [cite_start]Gửi request GET (dùng `GetAsync` hoặc `GetFromJsonAsync`) đến endpoint của API thời tiết, truyền tên thành phố và API key[cite: 5978].
        * [cite_start]Xử lý **HttpResponseMessage**, kiểm tra `IsSuccessStatusCode`, đọc và **deserialize** JSON response thành một DTO/Model `WeatherData` [cite: 5979-5981].
    5.  Tạo Controller/Page để gọi `WeatherService` và hiển thị kết quả.

