using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        Debug.Log("=====Bai 1=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, 89, 222, 44 };
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach(int i in a)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        Debug.Log("=====Bai 2=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, 89, 222, 44 };
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        foreach(int i in a)
        {
            sum += i;
        }
        Debug.Log("Tong: " + sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        Debug.Log("=====Bai 3=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, 89, 222, 44 };
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int max = a[0];
        foreach(int i in a)
        {
            if(i > max)
                max = i;  
        }
        Debug.Log("Phan tu lon nhat: " + max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        Debug.Log("=====Bai 4=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, 89, 222, 44 };
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int count = 0;
        foreach(int i in a)
        {
            if(i % 2 == 0)
            {
                count++;
                Debug.Log(i);
            } 
        }
        Debug.Log("So luong phan tu chan: " + count);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        Debug.Log("=====Bai 5=====");
        // Tạo một danh sách các chuỗi
         List<string> a = new List<string> { "One", "Two", "Three", "Four", "Eight" };
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach(string i in a)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        Debug.Log("=====Bai 6=====");
        // Tạo một danh sách các chuỗi
         List<string> a = new List<string> { "One", "Two", "Three", "Four", "Eleven"};
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string longestString = string.Empty;

        // Sử dụng vòng lặp foreach để tìm chuỗi dài nhất
        foreach (string i in a)
        {
            if (i.Length > longestString.Length)
            {
                longestString = i;
            }
        }
        Debug.Log("Chuoi dai nhat: " + longestString);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        Debug.Log("=====Bai 7=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, 89, 222, 44 };
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int sum = 0;
        foreach(int i in a)
        {
            if(i % 2 != 0)
            {
                sum += i;
            } 
        }
        Debug.Log("Tong le: " + sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        Debug.Log("=====Bai 8=====");
        Debug.Log("So chan trong mang");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, 89, 222, 44 };
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach(int i in a)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            } 
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        Debug.Log("=====Bai 9=====");
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] a = { 11, 24, 89, 222, 44 };
        int n = 24;
        bool flag = false;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach(int i in a)
        {
            if(i == n)
            {
                flag = true;
                break;
            } 
        }
        if(flag == true) Debug.Log(n + " ton tai trong mang");
        else Debug.Log(n + " ko ton tai trong mang");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        Debug.Log("=====Bai 10=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, -89, 222, -44 };
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        int count = 0;
        foreach(int i in a)
        {
            if(i < 0)
            {
                count++;
                Debug.Log(i);
            } 
        }
        Debug.Log("So luong phan tu am: " + count);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        Debug.Log("=====Bai 11=====");
        Debug.Log("So lon hon 10:");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, -89, 222, -44 };
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach(int i in a)
        {
            if(i > 0)
            {
                Debug.Log(i);
            } 
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        Debug.Log("=====Bai 12=====");
        // Tạo một danh sách các chuỗi
         List<string> a = new List<string> { "One", "Two", "Aa", "Four", "Eleven"};
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        string shortestString = a[0];
        foreach (string i in a)
        {
            if (i.Length < shortestString.Length)
            {
                shortestString = i;
            }
        }
        Debug.Log("Chuoi ngan nhat: " + shortestString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        Debug.Log("=====Bai 13=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, -89, 222, -44 };
        int[] a2 = new int[a.Length];
        int index = 0;
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        foreach(int i in a)
        {
            a2[index] = i * 2;
            index++;
        }
        Debug.Log("Mang nhan doi");
        foreach (int i in a2)
        {
            Debug.Log(i);
        }

    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        Debug.Log("=====Bai 14=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, -89, 222, -44 };
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        int max = int.MinValue;
        foreach (int i in a)
        {
            if (i > max)
            {
                max = i;
            }
        }
        int secondMax = int.MinValue;
        foreach (int i in a)
        {
            if (i > secondMax && i < max)
            {
                secondMax = i;
            }
        }
        Debug.Log("Phan tu lon thu 2: " + secondMax);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        Debug.Log("=====Bai 15=====");
        // Tạo một danh sách các chuỗi
         List<string> a = new List<string> { "One", "Two", "Aa", "Four", "Eleven"};
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach (string i in a)
        {
            if (i.StartsWith("A"))
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        Debug.Log("=====Bai 16=====");
        // Tạo một danh sách các chuỗi
        List<string> a = new List<string> { "One", "Two", "Aa", "Four", "Hello", "Eleven"};
        bool flag = false;
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string i in a)
        {
            if (i == "Hello")
            {
                flag = true;
                break; 
            }
        }
        if (flag == true)
            Debug.Log("Co chuoi 'Hello'.");
        else
            Debug.Log("Ko co chuoi 'Hello'.");
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        Debug.Log("=====Bai 17=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, -89, 222, -44 };
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach(int i in a)
        {
            if(i < 0)
            {
                Debug.Log(i);
            } 
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        Debug.Log("=====Bai 18=====");
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] a = { 11, 24, -89, 222, 24, -44 };
        int n = 24;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int count = 0;
        foreach(int i in a)
        {
            if(i == n)
            {
                count++;
            } 
        }
        Debug.Log("So lan xuat hien cua " + n + ": " + count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        Debug.Log("=====Bai 19=====");
        // Tạo một mảng số nguyên
        int[] a = { 11, 24, -89, 222, 24, -44 };
        List<int> a2 = new List<int>();
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        foreach (int i in a)
        {
            if (i > 10)
            {
                a2.Add(i);
            }
        }
        Debug.Log("danh sach lon hon 10: ");
        foreach (int i in a2)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        Debug.Log("=====Bai 20=====");
        // Tạo một danh sách các chuỗi
        List<string> a = new List<string> { "Oneeee", "Two", "Aa", "Four", "Hello", "Eleven"};
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string i in a)
        {
            if (i.Length > 5)
            {
                Debug.Log(i);
            }
        }
    }

}
