

# BÁO CÁO NGHIÊN CỨU VÀ PHÁT TRIỂN HỆ THỐNG GIAO DIỆN NGƯỜI - MÁY (HCI) TRÊN NỀN TẢNG WINDOWS FORMS

## 📝 PROGRAMMING INTERFACE

## 📝 TÓM TẮT DỰ ÁN (ABSTRACT)
Dự án này tập trung nghiên cứu, thiết kế và thực nghiệm các giải pháp kiến trúc giao diện người-máy (Human-Computer Interaction - HCI) 
ứng dụng nền tảng đồ họa Windows Forms trên hệ sinh thái .NET. 
Nghiên cứu trải dài qua 06 phân hệ cốt lõi nền tảng (tương ứng từ Chương 2 đến Chương 7) và 01 phân hệ thực nghiệm chuyên sâu (Bài tập Nâng cao). 
Nội dung nghiên cứu đi từ các thành phần điều khiển cơ bản, lập trình hướng đối tượng ứng dụng GUI, kỹ thuật hoạt họa xử lý biến cố thời gian, 
kiểm soát sự kiện tương tác ngoại vi (chuột/bàn phím), quản lý cấu trúc dữ liệu phân cấp phức tạp, cho đến kỹ thuật tính toán đồ họa vector 2D (GDI+ Rendering).
Các module được tối ưu hóa nhằm đánh giá hiệu năng xử lý bất đồng bộ, xử lý sự kiện động tại thời điểm thực thi (Runtime) và nâng cao trải nghiệm tương tác
người dùng (UX).

---

## 🏛️ PHẦN I: CÁC PHÂN HỆ NỀN TẢNG (CHƯƠNG 2 - CHƯƠNG 7)

### 📁 PHÂN HỆ CHƯƠNG 02: Cơ Sở Điều Khiển Biến Cố & Xử Lý Ngoại Lệ (Chương 2)
* **Mục tiêu nghiên cứu:** Xác lập cơ chế phân tách và kiểm soát dòng dữ liệu nhập liệu, triển khai hệ thống lọc và xử lý các điều kiện biên và ngoại lệ
(Exception Handling) trong môi trường GUI cơ bản.

* **Các module thực nghiệm:**
    * *Cacpheptinh (Phép toán cơ bản):* Hệ thống tính toán số học cơ bản, cô lập lỗi chia cho 0 (`DivideByZeroException`) và chuẩn hóa đầu vào phi số.
    * *Giải phương trình bậc 2:* Hiện thực hóa giải thuật toán học cấu trúc trên môi trường trực quan, tự động validate dữ liệu đầu vào.
    * *Hệ thống mô phỏng quay số (Lucky Mini-Game):* Cơ chế sinh số giả ngẫu nhiên (`Random Class`) kết hợp ràng buộc điều kiện tích lũy điểm tuyến tính.
    * *SimpleCalculator & Mảng Thống kê:* Bộ máy phân tích cú pháp biểu thức toán học dạng chuỗi đơn giản và tối ưu hóa vòng lặp xử lý mảng phần tử số nguyên
ngẫu nhiên.

* **Code trong BaiTapTuLam_CacChuong/Chuong2**
    * *BaiTapTuLam_CacChuong/Chuong2/Bai1_TuLam_C2*
    * *BaiTapTuLam_CacChuong/Chuong2/Bai2_TuLam_C2*
    * *BaiTapTuLam_CacChuong/Chuong2/Bai3_TuLam_C2*
    * *BaiTapTuLam_CacChuong/Chuong2/Bai5_TuLam_C2*
    * *BaiTapTuLam_CacChuong/Chuong2/Bai6_TuLam_C2*

### 📁 PHÂN HỆ CHƯƠNG 03: Mô Hình Hóa Đối Tượng Trực Quan - OOP GUI (Chương 3)
* **Mục tiêu nghiên cứu:** Thực nghiệm giải pháp đóng gói (`Encapsulation`) dữ liệu thuộc tính thông qua các `Properties`, cấu trúc hóa các thực thể
toán học và không gian hình học phẳng trực quan hóa lên GUI.

* **Các module thực nghiệm:**
    * *PhepToanPhanSo:* Lớp thực thể Phân số tích hợp thuật toán tìm Ước số chung lớn nhất (USCLN) tự động tối giản cấu trúc trước khi kết xuất đồ họa.
    * *Lớp Tamgiac & Hinhtron:* Mô hình hóa toán học không gian 2D, tự động tính toán thuộc tính diện tích, chu vi, biên hình học và kiểm tra tọa độ
điểm động (`Point Inside Circle`).

* **Code trong BaiTapTuLam_CacChuong/Chuong3**
    * *BaiTapTuLam_CacChuong/Chuong3/Bai1_TuLam_C3*
    * *BaiTapTuLam_CacChuong/Chuong3/Bai2_TuLam_C3*
    * *BaiTapTuLam_CacChuong/Chuong3/Bai3_TuLam_C3*
  

### 📁 PHÂN HỆ CHƯƠNG 04: Hoạt Họa Đồ Họa & Kiến Trúc Đa Giao Diện MDI (Chương 4)
* **Mục tiêu nghiên cứu:** Nghiên cứu cơ chế dựng hình lặp theo chu kỳ thời gian (`Timer Tick Animation`) và quản lý không gian làm việc đa tài
liệu (Multiple Document Interface - MDI) kết hợp hệ thống Dialog tương tác sâu với hệ điều hành.

* **Các module thực nghiệm:**
    * *Hệ thống Tâng bóng tự động (Ball Animation):* Ứng dụng Vector vận tốc $(dx, dy)$ tương tác đảo chiều biên hình học với không gian giới
hạn `ClientRectangle` của Form.
    * *Hệ thống tích hợp Windows Dialogs:* Triển khai các thành phần `OpenFileDialog`, `FolderBrowserDialog`, `ColorDialog`, `FontDialog` nhằm tối
ưu tương tác tệp tin và tùy biến giao diện hệ thống.
    * *MyPhoto MDI Application:* Kiến trúc quản lý cây tiến trình Form con chứa tài nguyên ảnh tĩnh.
 
* **Code trong BaiTapTuLam_CacChuong/Chuong3**
    * *BaiTapTuLam_CacChuong/Chuong4/Bai1_TuLam_C4*
    * *BaiTapTuLam_CacChuong/Chuong4/Bai2_TuLam_C4*
    * *BaiTapTuLam_CacChuong/Chuong4/Bai4_TuLam_C4*

### 📁 PHÂN HỆ CHƯƠNG 05: Mô Phỏng Tương Tác Thiết Bị Ngoại Vi Động (Chương 5)
* **Mục tiêu nghiên cứu:** Nghiên cứu các sự kiện tương tác thời gian thực từ thiết bị ngoại vi gồm Chuột (`MouseDown`, `MouseMove`, `MouseUp`) và Bàn
phím (`KeyDown`) tác động lên các đối tượng giao diện được khởi tạo động vào bộ nhớ tại thời điểm thực thi (Runtime UI Generation).

* **Các module thực nghiệm:**
    * *MoveObject Engine:* Cơ chế kéo thả (`Drag and Drop`) đối tượng đồ họa trực quan vào vùng chứa giới hạn (`Panel Boundary Detection`).
    * *Phát triển Game Tâng bóng (Paddle Ball Game):* Tích hợp thanh chắn điều khiển bằng Keyboard/Mouse, tính toán xử lý va chạm cơ học động giữa vật thể
bóng và thanh chắn.

* **Code trong BaiTapTuLam_CacChuong/Chuong3**
    * *BaiTapTuLam_CacChuong/Chuong5/Bai1_TuLam_C5*    

### 📁 PHÂN HỆ CHƯƠNG 06: Cấu Trúc Dữ Liệu Phân Cấp & Quản Lý Hệ Thống Tệp Tin (Chương 6)
* **Mục tiêu nghiên cứu:** Áp dụng mô hình cấu trúc cây phân cấp (`TreeView`) và hiển thị luồng dữ liệu tối ưu (`ListView`, `FlowLayoutPanel`) phục vụ phân tích
cấu trúc tệp tin logic của hệ điều hành Windows.
* **Các module thực nghiệm:**
    * *PhotoAlbum Explorer:* Hệ thống ánh xạ danh mục ổ đĩa, tự động duyệt thư mục bất đồng bộ để tải tài nguyên đa phương tiện hiển thị dạng lưới lưới
(`FlowLayout Dynamic Rendering`).
    * *ListViewDemo:* Tái hiện cấu trúc hiển thị thông tin metadata của tệp tin (File Name, Size, Last Accessed) tương thích các chế độ View khác nhau
(`LargeIcon`, `SmallIcon`, `Details`).

* **Code trong BaiTapTuLam_CacChuong/Chuong3**
    * *BaiTapTuLam_CacChuong/Chuong6/Bai1_TuLam_C6*
    

### 📁 PHÂN HỆ CHƯƠNG 07: Vẽ Kỹ Thuật Đồ Họa Vector GDI+ Rendering (Chương 7)
* **Mục tiêu nghiên cứu:** Nghiên cứu sâu về không gian tên `System.Drawing`, cơ chế dựng hình thông qua biến cố `Paint` của Form, thao tác trực tiếp với các
thực thể vector đồ họa (`Graphics`, `Pen`, `Brush`, `Rectangle`, `Polygon`).

* **Các module thực nghiệm:**
    * *SimplePaint System:* Công cụ vẽ tự do điều khiển bằng Mouse, xử lý chuyển đổi bảng màu RGB động bằng phím tắt và tăng/giảm độ dày nét vẽ thời gian thực.
    * *Company Weekly Sales Chart:* Hệ thống tự động thu thập thông tin định lượng toán học từ trường dữ liệu đầu vào để tính toán tỷ lệ, dựng biểu đồ cột tương
ứng với các giá trị thống kê tuần.
    * *DrawShapes Controller:* Ứng dụng vẽ hình học tùy biến hỗ trợ xóa bộ nhớ đệm (`Clear All`) và tùy chọn hộp thoại (`Option Dialog`) điều khiển cấu trúc
hình học.

* **Code trong BaiTapTuLam_CacChuong/Chuong3**
    * *BaiTapTuLam_CacChuong/Chuong7/Bai1_TuLam_C7*
    * *BaiTapTuLam_CacChuong/Chuong7/Bai2_TuLam_C7*

---

## 🚀 PHẦN II: PHÂN HỆ THỰC NGHIỆM CHUYÊN SÂU (ADVANCED PROJECTS REPORT)

Phân hệ này trình bày chi tiết kết quả nghiên cứu, mô hình hóa giải thuật và thực nghiệm ứng dụng đối với 08 hệ thống phần mềm nâng cao, áp dụng các kỹ thuật 
kiến trúc HCI chuyên sâu trên nền tảng .NET Windows Forms.

### 🕹️ BÀI TOÁN THỰC NGHIỆM 01: CÔNG NGHỆ GAME ENGINE - TRÚC XANH
* **Tên bài toán:** Hệ thống Trò chơi Khớp dịch ma trận bộ nhớ đồ họa – Game Trúc Xanh (Flip Card Game Memory Match).
* **Chức năng hệ thống:** Khởi tạo ma trận lưới các thẻ ô rỗng che giấu tài nguyên hình ảnh phía sau. Cho phép lật mở tương tác liên tiếp hai thẻ ô để tìm kiếm
sự trùng khớp. Nếu trùng khớp, cặp thẻ được thiết lập mở vĩnh viễn; nếu không, hệ thống tự động úp thẻ lại và kết thúc khi giải phóng toàn bộ ma trận.
* **Cách giải quyết & Thuật toán:** Sử dụng cấu trúc mảng hai chiều động (`2D Array`) ánh xạ chỉ mục (ID) hình ảnh ngẫu nhiên lên lưới điều khiển `PictureBox`. Áp
dụng giải thuật trộn bài (Shuffle Algorithm) dựa trên hàm `Random` để đảo vị trí các phần tử dữ liệu khi khởi tạo. Sử dụng cơ chế ủy quyền biến cố tập trung
(Centralized Event Handling) để so sánh thuộc tính ảnh của thẻ thứ nhất và thẻ thứ hai được kích hoạt `Click`.
* **Tác dụng củng cố tri thức:** Rèn luyện tư duy quản lý trạng thái đối tượng (State Management), kỹ thuật ánh xạ tài nguyên đa phương tiện tĩnh vào bộ nhớ
Runtime và kỹ năng kiểm soát luồng điều kiện tuần tự phức tạp.
* **Tính năng tối ưu hóa:** Tích hợp bộ định thời trễ bất đồng bộ (`System.Windows.Forms.Timer`). Khi phát hiện hai ô lệch đồ họa, hệ thống tạm thời khóa quyền
tương tác click của người dùng (`Enabled = false` cho lưới thẻ) trong 1 giây để họ kịp ghi nhớ, sau đó tự động lật úp (`Auto-flip close`) và giải phóng luồng bấm mà không gây treo hay đóng băng giao diện chính (Main UI Thread).
* **Vai trò với người dùng:** Cung cấp ứng dụng giải trí kích thích tư duy, rèn luyện khả năng ghi nhớ ngắn hạn (Short-term memory) và sự tập trung trực quan
thông qua cơ chế phản hồi thị giác tức thì (Visual Feedback).

#### Anh
> [<img <img width="356" height="380" alt="Screenshot 2026-05-30 215846" src="https://github.com/user-attachments/assets/64bae0f8-faa0-4394-b54f-7db00f15beb5" />]


### 🎥 BÀI TOÁN THỰC NGHIỆM 02: TRÌNH PHÁT ĐA PHƯƠNG TIỆN LUỒNG TỰ ĐỘNG
* **Tên bài toán:** Hệ thống quản lý và trình phát đa phương tiện động tích hợp I/O – Image Player Professional.
* **Chức năng hệ thống:** Tự động quét và tải danh sách tệp ảnh từ thư mục hệ thống lên `ListBox`. Cho phép người dùng chọn ảnh thủ công để hiển thị lên
`PictureBox`, kích hoạt chế độ phát tự động (Slideshow), thêm (Add) tệp ảnh mới và xóa (Remove) ảnh khỏi hệ thống.
* **Cách giải quyết & Thuật toán:** Sử dụng không gian tên `System.IO` (`File`, `Directory`) để thao tác trực tiếp với ổ cứng máy tính. Ràng buộc dữ liệu
(Data Binding) giữa danh mục tên tệp của `ListBox` với luồng nạp ảnh của `PictureBox`. Sử dụng `Timer` để tự động tăng chỉ mục `SelectedIndex` của `ListBox` tuần
tự nhằm tạo hiệu ứng Slideshow.
* **Tác dụng củng cố tri thức:** Hoàn thiện kỹ năng xử lý hệ thống tệp tin vật lý (File System Manipulation), cơ chế quản lý bộ nhớ đệm hình ảnh và kỹ thuật xử
đồng bộ trạng thái giữa các thành phần điều khiển (Control State Synchronization).
* **Tính năng tối ưu hóa:** Khi thực hiện tính năng **Add**, phần mềm đọc luồng byte dữ liệu ảnh và sao chép bất đồng bộ tệp từ máy tính cục bộ vào thư mục
gốc `Images` của dự án. Tiến trình này tự động làm mới (Refresh) danh sách hiển thị mà không làm nghẽn luồng I/O của ứng dụng.
* **Vai trò với người dùng:** Giúp người dùng quản lý bộ sưu tập ảnh cá nhân một cách ngăn nắp, đơn giản hóa các thao tác phức tạp với ổ cứng thông qua giao diện
đồ họa trực quan và thân thiện.

### 🕒 BÀI TOÁN THỰC NGHIỆM 03: HỆ THỐNG ĐỒNG HỒ PHỨC HỢP ĐA QUỐC GIA
* **Tên bài toán:** Hệ thống giám sát thời gian thực đa múi giờ tích hợp hoạt họa – World Clock Studio.
* **Chức năng hệ thống:** Hiển thị đồng hồ số (Digital Clock) cập nhật liên tục từng giây theo thời gian hệ thống. Tích hợp hệ thống nút chuyển đổi linh hoạt
giữa các múi giờ quốc tế lớn (Hà Nội, London, New York, Tokyo...) và cho phép tùy biến định dạng hiển thị.
* **Cách giải quyết & Thuật toán:** Sử dụng lớp `DateTime.Now` kết hợp với phương thức toán học `.AddHours()` dựa trên độ lệch múi giờ (Timezone Offset) của từng
quốc gia. Định dạng chuỗi xuất dữ liệu (String Formatting) dạng `"hh:mm:ss tt"` để xuất ra các thành phần `Label`. Khởi chạy sự kiện `Tick` của bộ định thời với
tần suất chu kỳ ngắn ($Interval = 1000ms$) để ép giao diện vẽ lại thời gian thực.
* **Tác dụng củng cố tri thức:** Làm chủ kỹ thuật xử lý kiểu dữ liệu ngày tháng thời gian (`DateTime Structure`), kỹ nghệ định dạng chuỗi nâng cao và phương pháp
đồng bộ hóa biến cố chu kỳ.
* **Tính năng tối ưu hóa:** Tối ưu hóa bộ nhớ bằng cách sử dụng một `Timer` duy nhất làm luồng đếm nhịp chính cho toàn bộ các múi giờ thay vì tạo nhiều bộ định
thời chạy song song, giúp giảm thiểu tối đa hao phí tài nguyên CPU và xung đột tiểu trình.
* **Vai trò với người dùng:** Hỗ trợ người dùng (đặc biệt là những người làm việc trong môi trường toàn cầu) theo dõi thời gian quốc tế một cách chính xác, trực
quan, tránh nhầm lẫn giờ giấc khi tương tác xuyên quốc gia.

### 🧮 BÀI TOÁN THỰC NGHIỆM 04: CÔNG CỤ TÍNH TOÁN ĐA NĂNG & THỐNG KÊ LỊCH SỬ
* **Tên bài toán:** Công cụ xử lý biểu thức đại số tích hợp lưu trữ mảng dữ liệu – Advanced Smart Calculator.
* **Chức năng hệ thống:** Thực hiện các phép toán số học từ cơ bản đến phức tạp (lũy thừa, phần trăm, căn bậc hai) thông qua hệ thống phím số trực quan. Tích hợp
bộ nhớ lưu trữ lịch sử các lần tính toán gần nhất vào một vùng hiển thị danh sách phụ.
* **Cách giải quyết & Thuật toán:** Áp dụng mô hình kiến trúc ngăn xếp (Stack) hoặc bộ phân tích cú pháp chuỗi toán học (Expression Parser) để xử lý các toán hạng
và toán tử theo đúng thứ tự ưu tiên toán học. Sử dụng các cấu trúc mảng động (`List<string>`) để tích lũy dữ liệu lịch sử tính toán và đẩy vào thành phần hiển thị
 `ListBox` hoặc `RichTextBox`.
* **Tác dụng củng cố tri thức:** Sâu sắc hóa tư duy giải thuật xử lý chuỗi ký tự, kỹ thuật phân tích cú pháp (Parsing), kiểm soát lỗi toán học biên (như chia cho 0,
 tràn số) và cơ chế lưu trữ dữ liệu tạm thời.
* **Tính năng tối ưu hóa:** Triển khai giải pháp bẫy lỗi toàn diện (`Try-Catch Blocks`) tại tầng xử lý logic. Khi người dùng nhập biểu thức sai cú pháp, ứng dụng
không bị sập (Crash) mà tự động phát ra cảnh báo định dạng thân thiện và đưa con trỏ về trạng thái xóa sạch dữ liệu lỗi (`Reset`).
* **Vai trò với người dùng:** Cung cấp một công cụ tính toán nhanh chóng, chính xác tuyệt đối, hỗ trợ xem lại lịch sử các bước tính trước đó để đối chiếu số liệu
mà không cần phải thực hiện lại từ đầu.

### 🗒️ BÀI TOÁN THỰC NGHIỆM 05: TRÌNH SOẠN THẢO VĂN BẢN ĐA TÍNH NĂNG (MINI-WORD)
* **Tên bài toán:** Hệ thống xử lý văn bản định dạng phong phú tích hợp tương tác tệp – Rich Text Editor.
* **Chức năng hệ thống:** Cho phép người dùng nhập liệu, chỉnh sửa văn bản, thay đổi định dạng ký tự (In đậm, In nghiêng, Gạch chân, Màu sắc, Font chữ). Hỗ trợ
các chức năng quản lý tệp tiêu chuẩn: Tạo mới (New), Mở tệp văn bản có sẵn (Open), Lưu trữ (Save) và Tìm kiếm/Thay thế từ khóa trong văn bản.
* **Cách giải quyết & Thuật toán:** Sử dụng thành phần điều khiển `RichTextBox` làm hạt nhân xử lý. Tương tác sâu với các thành phần Dialog hệ thống của Windows
bao gồm `FontDialog`, `ColorDialog`, `OpenFileDialog`, và `SaveFileDialog`. Sử dụng các phương thức xử lý chuỗi chuyên sâu như `.SelectionFont`, `.SelectionColor`,
và thuật toán tìm kiếm vị trí chuỗi `.Find()` để đánh dấu (Highlight) từ khóa.
* **Tác dụng củng cố tri thức:** Nâng cao kỹ năng tùy biến thuộc tính đồ họa của ký tự, làm chủ cơ chế tương tác với các hộp thoại hệ điều hành bản quyền và giải
thuật tìm kiếm văn bản.
* **Tính năng tối ưu hóa:** Tích hợp bộ lọc định dạng đuôi tệp (`Filter Property`) và cơ chế kiểm tra trạng thái thay đổi dữ liệu (`IsModified`). Nếu người dùng
nhấn thoát khi văn bản chưa được lưu, hệ thống tự động tính toán và đưa ra hộp thoại nhắc nhở thông minh nhằm bảo vệ an toàn dữ liệu.
* **Vai trò với người dùng:** Cung cấp một trình soạn thảo thu nhỏ tiện lợi, đáp ứng đầy đủ nhu cầu ghi chép nhanh và định dạng tài liệu văn bản chuyên nghiệp mà
không cần cài đặt các bộ phần mềm nặng nề.

### 📂 BÀI TOÁN THỰC NGHIỆM 06: QUẢN LÝ THÔNG TIN PHÂN CẤP TÍCH HỢP CƠ SỞ DỮ LIỆU
* **Tên bài toán:** Hệ thống quản lý danh mục thực thể theo mô hình phân cấp cây dữ liệu – Hierarchical Data Explorer.
* **Chức năng hệ thống:** Biểu diễn danh sách thông tin (ví dụ: Danh sách nhân viên theo phòng ban, danh mục sản phẩm theo kho hàng) dưới dạng sơ đồ cây phân cấp.
Cho phép người dùng thêm nút mới, sửa tên nút, xóa nút trực tiếp trên giao diện và hiển thị thông tin chi tiết của phần tử được chọn sang bảng dữ liệu bên cạnh.
* **Cách giải quyết & Thuật toán:** Phối hợp đồng bộ hai điều khiển cao cấp là `TreeView` (để biểu diễn cấu trúc cây phân cấp) và `ListView` hoặc `DataGridView`
(để hiển thị chi tiết dữ liệu). Ứng dụng thuật toán duyệt cây đồ thị (Tree Traversal) thông qua các thuộc tính `.Nodes`, `.SelectedNode` để định vị chính xác vị
trí của phần tử trong cấu trúc dữ liệu phân tầng.
* **Tác dụng củng cố tri thức:** Làm chủ cấu trúc dữ liệu dạng cây (Tree Data Structure) trong môi trường trực quan, kỹ thuật xử lý nút động (Dynamic Node
Manipulation) và tư duy tổ chức dữ liệu khoa học.
* **Tính năng tối ưu hóa:** Áp dụng kỹ thuật tải dữ liệu lười (`Lazy Loading`). Hệ thống chỉ thực hiện nạp dữ liệu chi tiết của nút con khi người dùng nhấn mở
rộng (`BeforeExpandEvent`), giúp tiết kiệm tài nguyên bộ nhớ đệm và tăng tốc độ khởi chạy ứng dụng ban đầu lên gấp nhiều lần khi đối mặt với dữ liệu lớn.
* **Vai trò với người dùng:** Giúp các nhà quản trị hoặc người dùng phổ thông dễ dàng bao quát toàn bộ mô hình tổ chức phức tạp của doanh nghiệp hoặc hệ thống kho
 bãi, đơn giản hóa việc tìm kiếm và phân loại thông tin.

### 🏁 BÀI TOÁN THỰC NGHIỆM 07: MÔ PHỎNG ĐA LUỒNG BẤT ĐỒNG BỘ - CUỘC ĐUA KỲ THÚ
* **Tên bài toán:** Hệ thống mô phỏng đồ họa chuyển động đa luồng bất đồng bộ – Cuộc Đua Kỳ Thú (Asynchronous Animal Racing Game).
* **Chức năng hệ thống:** Khởi tạo trạng thái đưa các đối tượng nhân vật đồ họa về vạch xuất phát tuyến tính lề trái. Kích hoạt tiến trình di chuyển song song của
các đối tượng về phía biên phải với vận tốc hoàn toàn độc lập và ngẫu nhiên. Tự động nhận diện thực thể chạm đích đầu tiên, ghi nhận thời gian thực thi chính xác
(đến mili-giây) và hiển thị kết quả trực quan.
* **Cách giải quyết & Thuật toán:** Sử dụng giải thuật đa luồng thời gian song song dựa trên thành phần kiểm soát chu kỳ chuyển động (`Timer`) hoặc đa luồng bất
đồng bộ (`Task/Thread`). Sử dụng hàm sinh số ngẫu nhiên (`Random.Next`) liên tục để bổ biến giá trị đại số ngẫu nhiên vào tọa độ trục $X$ (thuộc tính `.Left`) của
 từng đối tượng đồ họa riêng biệt theo từng đơn vị thời gian.
* **Tác dụng củng cố tri thức:** Củng cố sâu sắc kiến thức về lập trình đa luồng (Multi-threading) hoặc quản lý tiến trình song song đồng thời (Concurrency).
Nâng cao kỹ năng toán học lập trình trong việc tính toán vận tốc, gia tốc hình học và xử lý dịch chuyển tịnh tiến vật thể đồ họa trong không gian 2D.
* **Tính năng tối ưu hóa:** Hệ thống thiết lập cơ chế giám sát biên động thời gian thực (`Real-time Collision Boundary Check`) lồng bên trong vòng lặp hoạt họa.
 Ngay khi phát hiện tọa độ `Right` của thực thể đầu tiên vượt qua giá trị biên phải của vùng chứa (`ClientRectangle.Width`), hệ thống tự động phát biến cố ngắt
khẩn cấp toàn bộ các luồng chạy còn lại để giải phóng CPU, đồng thời đảo ngược trạng thái khóa của các nút điều khiển (`Lock/Unlock Control Buttons State`) để
ngăn chặn việc người dùng bấm kích hoạt trùng lặp làm lỗi luồng bộ nhớ.
* **Vai trò với người dùng:** Mang lại trải nghiệm mô phỏng chuyển động cơ học khách quan, trực quan hóa các tiến trình xử lý ẩn của máy tính thành các chuyển
động đồ họa dễ hiểu, sinh động đối với người sử dụng.

### 📊 BÀI TOÁN THỰC NGHIỆM 08: MODULE ĐỒ HỌA PHỨC HỢP ĐỊNH LƯỢNG - STOCK CHART
* **Tên bài toán:** Thành phần điều khiển tùy biến vẽ biểu đồ cấu trúc tài chính tài sản định lượng – Stock Chart UserControl.
* **Chức năng hệ thống:** Cung cấp giao diện cho phép thu thập động dữ liệu định lượng (Mã cổ phiếu, Giá trị thị trường) và thuộc tính hiển thị (Màu sắc chỉ định).
Tự động tính toán tỷ lệ phần trăm toán học và dựng hình vẽ biểu đồ hình tròn (Pie Chart) phân tách cung, đồng thời tự động kết xuất bảng chú giải dữ liệu biên
(Legend Table) tương ứng.
* **Cách giải quyết & Thuật toán:** Đóng gói toàn bộ logic xử lý và dựng hình vào một thành phần điều khiển độc lập tự thiết kế (`UserControl`) để tăng khả năng
tái sử dụng cấu trúc ở nhiều Form khác nhau. Khai thác biến cố vẽ kỹ thuật `Paint` và đối tượng đồ họa `Graphics` của nền tảng GDI+. Sử dụng thuật toán lượng giác
để quy đổi giá trị phần trăm của từng phần tử sang hệ số góc Sweep Angle đồ họa theo độ ($360^\circ$) để truyền vào phương thức `DrawPie`/`FillPie`.
* **Tác dụng củng cố tri thức:** Làm chủ kỹ thuật phát triển thành phần giao diện tùy biến nâng cao (Custom UserControl Component Development). Thấu hiểu sâu sắc
cơ chế dựng hình đồ họa vector (Vector Graphics Rendering), hệ tọa độ màn hình và kỹ năng áp dụng thuật toán hình học toán học vào không gian hiển thị GDI+.
* **Tính năng tối ưu hóa:** Triển khai cơ chế vẽ lặp tối ưu: Mỗi khi người dùng nhấn nút **Add Stock**, hệ thống không thực hiện hủy và tạo mới lại thành phần đồ
họa (gây hiện tượng nhấp nháy màn hình - Screen Flickering), mà chỉ thực hiện cập nhật lại mảng danh sách dữ liệu trong bộ nhớ trong và gọi phương thức làm mới bề
mặt hình học `Invalidate()`. Điều này ép buộc hệ thống chỉ vẽ lại vùng không gian có sự thay đổi, giúp tiết kiệm tối đa tài nguyên card đồ họa và bộ nhớ RAM.
* **Vai trò với người dùng:** Cung cấp cho các nhà phân tích dữ liệu hoặc người dùng thông thường một công cụ báo cáo trực quan hóa số liệu (Data Visualization)
 cực kỳ chuyên nghiệp, biến các hàng số liệu thô khan thành biểu đồ màu sắc trực quan, chính xác và dễ dàng phân tích tỷ trọng tài sản.

---

## Tác Giả

* Người thực hiện: Lê Thanh Danh
* Ngày Thực hiện: 01/05/2026
* Ngày hoàn thành: 30/05/2026
