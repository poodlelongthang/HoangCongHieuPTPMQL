# NetCoreAPI
* BUỔI HỌC SỐ 3
1.CẤU TRÚC THƯ MỤC .NET MVC
    Gồm:
        + Tên project VD: MVCMOVIE
        + Controllers: Thư mục chứa các controller(code để xử lý yêu câu từ View gửi về)
        + Models: Chứa các đại diện cho CSDL của ứng dụng
        + Views: Thư mục chứa các thành phần hiển thị giao diện người dùng
        + wwwroot: Thư mục chứa các file của dự án(HTML, CSS, JS)
        + appsettings.json và Program.cs: File chứa code cấu hình dự án

2.ĐỊNH TUYẾN ROUTE TRONG .NET MVC
    -MVC sẽ gọi bộ điều khiển (Controller) và các hành động bên trong (Action) thông qua URL
    -Logic định tuyến MVC sử dụng dạng: /[Controller]/[Action]/[Parameters]
    -Định tuyến được cấu hình trong file Program.cs:
                        app.MapControllerRoute(
                            name: "default",
                            pattern: "{controller=Home}/{action=Index}/{id?}");
    
3.TÌM HIỂU VỀ NAMESPACE TRONG C#
    -Là một cơ chế dùng để tổ chức và phân nhóm các lớp (class), interface, struct, enum...
    -Mục đích chính:
        + Tránh trùng tên giữa các class
        + Giúp code dễ quản lý, dễ đọc, dễ bảo trì
        + Phân chai rõ ràng các module trong project lớn

4.TÌM HIỂU VỀ CONTROLLER, VIEW TRONG .NET MVC
    *Controller:
        - Tên của Controller bắt buộc phải có phần hậu tố Controller: Ví dụ    StudentController, PersonController
        - Nằm trong thư mục Controllers
        - Nhiệm vụ của Controller:
            + Xử lý các yêu cầu của người dùng gửi tới từ View.
            + Truy xuất dữ liệu trong cơ sở dữ liệu.
            + Gọi các mẫu View và trả về dữ liệu
        - Mặc định khi tạo project sẽ có HomeController
        -Trong controller sẽ chứa các action, mỗi action sẽ thực thi một nhiệm vụ cụ thể 
    *View:
        - Có phần mở rộng là “.cshtml”
        - Nằm trong thư mục Views/Controler_Name (tương ứng với  - -    HelloWorldController sẽ có thư mục HelloWorld trong thư mục Views)
        - Nhiệm vụ của View: Cung cấp giao diện người dùng (HTML) bằng C#
* BUỔI HỌC SỐ 4
    1. VIEWBAG TRONG MVC:
    - Viewbag sử dụng để truyền tiêu đề, thông báo, dữ liệu đơn giản
    2. VD sử dụng Viewbag để gửi dữ liệu từ Controller về View
    Controller
        public IActionResult Index()
        { ViewBag.Title = "Trang chủ";
          ViewBag.UserName = "Hoàng Hiếu";
          ViewBag.Age = 20;
          return View();
        }
    View
        <h2>@ViewBag.Title</h2>
        <p>Tên người dùng: @ViewBag.UserName</p>
        <p>Tuổi: @ViewBag.Age</p>

    3. Gửi nhận dữ liệu giữa View và Controller thông qua Submit form
    4. VD
    

