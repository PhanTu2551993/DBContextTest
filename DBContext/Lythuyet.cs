namespace DBContextTest
{
    public class Lythuyet

    {
        /*
         Migrations là một tính năng của Entity Framework Core giúp bạn quản lý và áp dụng các thay đổi đối với cấu trúc cơ sở dữ liệu (schema) của bạn theo cách có thể dễ dàng theo dõi và kiểm soát. Khi bạn thay đổi mô hình dữ liệu trong code (chẳng hạn như thêm một bảng mới hoặc thay đổi một thuộc tính), bạn có thể sử dụng migrations để đồng bộ hóa những thay đổi đó với cơ sở dữ liệu mà không phải tạo lại toàn bộ cơ sở dữ liệu từ đầu.

            Cách Migrations Hoạt Động
            Tạo Migrations:

                Khi bạn thực hiện thay đổi trong các lớp mô hình (Model classes), bạn có thể tạo một migration mới để phản ánh những thay đổi đó trong cơ sở dữ liệu.
                Khi bạn chạy lệnh dotnet ef migrations add <MigrationName>, Entity Framework Core sẽ tạo ra một tập hợp các tệp mã C# đại diện cho các thay đổi cần thiết để cập nhật cơ sở dữ liệu của bạn từ trạng thái hiện tại lên trạng thái mới.
            Áp Dụng Migrations:

                Sau khi đã tạo migration, bạn có thể áp dụng nó lên cơ sở dữ liệu bằng lệnh dotnet ef database update.
                Lệnh này sẽ thực thi các lệnh SQL tương ứng với những thay đổi được định nghĩa trong migration, cập nhật cơ sở dữ liệu của bạn để đồng bộ với mô hình trong code.
            Quản lý Migrations:

                Mỗi migration được tạo ra đều có một dấu thời gian và tên, giúp bạn theo dõi thứ tự và nội dung của các thay đổi.
                Bạn có thể di chuyển cơ sở dữ liệu đến bất kỳ migration nào đã tồn tại, hoặc hoàn tác những thay đổi (rollback) nếu cần.
         */

        /*
         1. Khái niệm Partial View
            Partial View là một tập hợp con của View, chứa một phần của giao diện người dùng và được nhúng vào View chính.
            Partial View thường được sử dụng để hiển thị các phần giao diện được lặp đi lặp lại trên nhiều trang, như header, footer, sidebar, hoặc các danh sách con.
            Không giống như View chính, Partial View không có Layout riêng mà chỉ là một đoạn HTML độc lập.
        2. Ưu điểm của Partial View
            Tái sử dụng: Partial View giúp tránh lặp lại mã, tiết kiệm thời gian và giảm thiểu lỗi khi cần thay đổi.
            Dễ bảo trì: Bằng cách tách các phần giao diện người dùng thành các Partial View, bạn có thể dễ dàng cập nhật hoặc chỉnh sửa một phần của giao diện mà không ảnh hưởng đến các phần khác.
            Tối ưu hóa: Partial View giúp chia nhỏ giao diện, làm cho việc tải trang nhanh hơn và cải thiện trải nghiệm người dùng.
         */

        //Tìm hiểu view component
        /*
         View Component trong ASP.NET Core là một thành phần cho phép bạn xây dựng các phần nhỏ của giao diện người dùng một cách tái sử dụng và độc lập, tương tự như Partial View, nhưng với nhiều tính năng mạnh mẽ hơn. Dưới đây là chi tiết về View Component:

        1. Khái niệm View Component
            View Component là một phần của giao diện người dùng có thể được nhúng vào một View hoặc Layout, nhưng không phụ thuộc vào Controller.
            View Component tương tự như một Partial View nhưng có thể chứa logic xử lý riêng, do đó cho phép bạn tách biệt rõ ràng giữa giao diện và logic kinh doanh.
            View Component có thể được so sánh với các "widgets" hoặc "components" trong các framework khác, nơi chúng được sử dụng để hiển thị các thành phần giao diện có thể tái sử dụng.
        2. Cách hoạt động của View Component
            View Component bao gồm ba phần chính:
            Lớp View Component: Chứa logic để chuẩn bị dữ liệu cho phần giao diện.
            Phương thức Invoke hoặc InvokeAsync: Được gọi khi View Component được yêu cầu, có thể đồng bộ hoặc bất đồng bộ.
            View tương ứng: Tương tự như Partial View, đây là nơi chứa mã HTML/Razor để hiển thị dữ liệu.
         */

        //Tìm hiểu và tạo taghelper

        /*
         Tag Helper là một tính năng mạnh mẽ trong ASP.NET Core, giúp tạo ra mã HTML động trong các Razor View bằng cách sử dụng cú pháp HTML trực quan hơn. Tag Helper được thiết kế để cải thiện trải nghiệm phát triển bằng cách cho phép bạn sử dụng các thẻ HTML cùng với các thuộc tính để thực hiện các tác vụ phức tạp, thay vì phải dựa vào các phương thức hoặc cú pháp Razor truyền thống.

        1. Khái niệm về Tag Helper
            Tag Helper là các lớp C# được liên kết với các phần tử HTML cụ thể, giúp thực hiện các chức năng nhất định như hiển thị dữ liệu, tạo liên kết, xử lý biểu mẫu, v.v.
            Chúng mang lại trải nghiệm phát triển tương tự như các thuộc tính tùy chỉnh trong HTML và có thể được sử dụng để cải thiện tính rõ ràng và tính gọn gàng của mã HTML trong Razor View.
        2. Cách hoạt động của Tag Helper
            Tag Helper sử dụng cú pháp HTML, nhưng phía sau nó lại là logic C# được thực thi trên máy chủ.
            Khi Razor View được biên dịch, ASP.NET Core sẽ tìm và thực thi logic của Tag Helper trước khi trả lại mã HTML cuối cùng cho người dùng.
        3. Ưu điểm của Tag Helper
            Tính rõ ràng và dễ sử dụng: Tag Helper cho phép bạn viết mã HTML trong Razor View một cách trực quan hơn, giảm thiểu sự lộn xộn của các cú pháp Razor phức tạp.
            Tái sử dụng và tùy chỉnh: Bạn có thể tạo các Tag Helper tùy chỉnh để tái sử dụng mã, giúp mã nguồn của bạn dễ bảo trì và mở rộng.
            Hỗ trợ IntelliSense: Khi sử dụng Tag Helper, Visual Studio cung cấp tính năng IntelliSense, giúp bạn dễ dàng viết và kiểm tra mã.
         */
    }
}
