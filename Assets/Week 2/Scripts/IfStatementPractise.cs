using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        Debug.Log("=====Bai 1=====");
        // Nhập một số từ bàn phím
        int n = Random.Range(-99, 99);
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if( n > 0) Debug.Log("So duong: " + n);
        else if( n < 0 ) Debug.Log("So am: " + n);
        else Debug.Log("Bang 0");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        Debug.Log("=====Bai 2=====");
        // Nhập một số từ bàn phím
        int n = Random.Range(-99, 99);
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if( n % 2 == 0 ) Debug.Log("So chan: " + n);
        else Debug.Log("So le: " + n);
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        Debug.Log("=====Bai 3=====");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float n = Random.Range(0, 10);
        Debug.Log("Diem trung binh: " + n);
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if( n >= 5) Debug.Log("Do");
        else Debug.Log("Truot");
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        Debug.Log("=====Bai 4=====");
        // Nhập hai số nguyên từ bàn phím
        int n = Random.Range(0, 99);
        Debug.Log("So thu 1: " + n);
        int m = Random.Range(0, 99);
        Debug.Log("So thu 2: " + m);
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if ( n > m) Debug.Log("So lon nhat: " + n);
        else Debug.Log("So lon nhat: " + m);
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        Debug.Log("=====Bai 5=====");
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        int n = Random.Range(0, 99);
        Debug.Log("Tien hien co: " + n);
        int m = Random.Range(0, 99);
        Debug.Log("Gia san pham: " + m);
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if ( n >= m) Debug.Log("Du dieu kien");
        else Debug.Log("Ko du dieu kien");
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        Debug.Log("=====Bai 6=====");
        // Nhập một năm từ bàn phím
        int n = Random.Range(1000, 2030);
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if (n % 4 == 0)
        {
            if (n % 100 == 0)
            {
                if (n % 400 == 0)
                    Debug.Log("Nam nhuan:" + n);
                else
                    Debug.Log("Nam khong nhuan:" + n);
            }
            else
                Debug.Log("Nam nhuan:" + n);
        }
        else
        {
            Debug.Log("Nam khong nhuan:" + n);
        }
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        Debug.Log("=====Bai 7=====");
        // Nhập tuổi của người mua vé từ bàn phím
        int n = Random.Range(1, 99);
        Debug.Log("Tuoi : " + n);
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        if (n < 18) Debug.Log("Gia ve 50,000");
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        else Debug.Log("Gia ve 100,000");
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        Debug.Log("=====Bai 8=====");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float n = Random.Range(0, 10);
        Debug.Log("Diem trung binh:" + n);
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if( n >= 9) Debug.Log("Hoc sinh xuat sac");
        else Debug.Log("Ko dat");
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        Debug.Log("=====Bai 9=====");
        // Nhập ba số nguyên từ bàn phím
        int n = Random.Range(0, 99);
        Debug.Log("So thu 1: " + n);
        int m = Random.Range(0, 99);
        Debug.Log("So thu 2: " + m);
        int x = Random.Range(0, 99);
        Debug.Log("So thu 3: " + x);
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        int max = n;
        if (m > max)
        {
            max = m;
        }
        if (x > max)
        {
            max = x; 
        }
        Debug.Log("So lon nhat: " + max);
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        Debug.Log("=====Bai 10=====");
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        int n = Random.Range(0, 99);
        Debug.Log("Gio lam viec: " + n);
        int Salary = 500000;
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        if (n > 40) Debug.Log("Luong tinh them gio");
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        else Debug.Log("Luong co dinh" + Salary);
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        Debug.Log("=====Bai 11=====");
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int n = Random.Range(0, 99);
        Debug.Log("Tuoi:" + n);
        bool isMember = Random.value > 0.5f;
        if (isMember == true) Debug.Log("Co the thanh vien");
        else Debug.Log("Ko co the thanh vien");
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if(n > 18 && isMember == true)
            Debug.Log("Duoc vao CLB");
        else
            Debug.Log("Khong duoc vao CLB");
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        Debug.Log("=====Bai 12=====");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float n = Random.Range(0, 10);
        Debug.Log("DTB: " + n);
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if (n >= 9) Debug.Log("Hoc sinh xuat sac");
        else if (n < 9 && n >= 8) Debug.Log("Hoc sinh gioi");
        else if (n < 8 && n >= 6) Debug.Log("Hoc sinh kha");
        else if (n < 6 && n >= 5) Debug.Log("Hoc sinh trung binh");
        else Debug.Log("Hoc sinh yeu");
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        Debug.Log("=====Bai 13=====");
        // Nhập số điện tiêu thụ từ bàn phím
        int price;
        int n = Random.Range(0, 999);
        Debug.Log("So dien tieu thu: " + n);
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        if( n <= 100 )
        {
            price = n * 1500;
            Debug.Log("Tien dien: " + price);
        }
        else
        {
            price = n * 2000;
            Debug.Log("Tien dien: " + price);
        }
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        Debug.Log("=====Bai 14=====");
        // Nhập số năm làm việc và đánh giá công việc
        int n = Random.Range(0, 50);
        Debug.Log("So nam lam viec:" + n);
        bool condition = Random.value > 0.5f;
        if (condition == true) Debug.Log("danh gia tot");
        else Debug.Log("Ko dc danh gia tot");
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if( n > 5 && condition == true) Debug.Log("Du dieu kien thang chuc");
        else Debug.Log("Ko du dieu kien thang chuc");
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        Debug.Log("=====Bai 15=====");
        // Nhập giá trị đơn hàng từ bàn phím
        int n = Random.Range(0, 1000000);
        Debug.Log("Gia tri don hang: " + n);
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (n > 500000) Debug.Log("Mien phi van chuyen");
        else Debug.Log("Ko mien phi van chuyen");
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        Debug.Log("=====Bai 16=====");
        // Nhập thu nhập từ bàn phím    
        decimal tongThuNhap = Random.Range(0, 1000000000);
        Debug.Log("Thu nhap ban than:" + tongThuNhap);
        decimal thue;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        // Khoản giảm trừ cho bản thân
        decimal giamTruBanThan = 11000000; // 11 triệu đồng/tháng

        // Thu nhập chịu thuế
        decimal thuNhapChiuThue = tongThuNhap - giamTruBanThan;

        // Nếu thu nhập chịu thuế <= 0, không phải đóng thuế
        if (thuNhapChiuThue <= 0)
        {
            thue = 0;
        }
        else 
        {
            // Biểu thuế lũy tiến từng phần
            if (thuNhapChiuThue <= 5000000)
            {
                thue = thuNhapChiuThue * 0.05m;
            }
            else if (thuNhapChiuThue <= 10000000)
            {
                thue = 5000000 * 0.05m + (thuNhapChiuThue - 5000000) * 0.10m;
            }
            else if (thuNhapChiuThue <= 18000000)
            {
                thue = 5000000 * 0.05m + 5000000 * 0.10m + (thuNhapChiuThue - 10000000) * 0.15m;
            }
            else if (thuNhapChiuThue <= 32000000)
            {
                thue = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + (thuNhapChiuThue - 18000000) * 0.20m;
            }
            else if (thuNhapChiuThue <= 52000000)
            {
                thue = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + 14000000 * 0.20m + (thuNhapChiuThue - 32000000) * 0.25m;
            }
            else if (thuNhapChiuThue <= 80000000)
            {
                thue = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + 14000000 * 0.20m + 20000000 * 0.25m + (thuNhapChiuThue - 52000000) * 0.30m;
            }
            else
            {
                thue = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + 14000000 * 0.20m + 20000000 * 0.25m + 28000000 * 0.30m + (thuNhapChiuThue - 80000000) * 0.35m;
            }
        }
        
        Debug.Log("Thue phai dong:" + thue);
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        Debug.Log("=====Bai 17=====");
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float diemToan = Random.Range(0, 10);
        Debug.Log("Diem Toan: " + diemToan);
        float diemVan = Random.Range(0, 10);
        Debug.Log("Diem Van: " + diemVan);
        float diemAnh = Random.Range(0, 10);
        Debug.Log("Diem Anh: " + diemAnh);
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float diemTrungBinh = (diemToan + diemVan + diemAnh) / 3;
        Debug.Log("Diem Trung Binh: " + diemTrungBinh);
        if(diemTrungBinh >= 5) Debug.Log("Dat");
        else Debug.Log("Ko dat");

    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        Debug.Log("=====Bai 18=====");
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        int soLuongHang = Random.Range(0, 500);
        Debug.Log("So luong hang: " + soLuongHang);
        bool conCho = Random.value > 0.5f;
        if (conCho == true) Debug.Log("Con cho");
        else Debug.Log("Ko con cho");
        if (soLuongHang < 100 && conCho == true) Debug.Log("Co the nhap them hang");
        else Debug.Log("Ko the nhap them hang");
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        Debug.Log("=====Bai 19=====");
        // Nhập một số từ bàn phím
        int n = Random.Range(0, 99);
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if( n > 10) Debug.Log(n + " lon hon 10");
        else if( n < 10 ) Debug.Log(n + " nho hon 10");
        else Debug.Log("Bang 10");
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        Debug.Log("=====Bai 20=====");
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        float n = Random.Range(0, 10);
        Debug.Log("Diem tong ket: " + n);
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if( n >= 9) Debug.Log("Du dieu kien dang ky");
        else Debug.Log("Ko du dieu kien dang ky");
    }
}
