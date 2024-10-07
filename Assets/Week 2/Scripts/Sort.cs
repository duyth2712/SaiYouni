using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1
    public void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    // Sort Algorithm 2
    public void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j; 
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    // Sort Algorithm 3
    public void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i]; 
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
    // Sort Algorithm 4
    void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Tìm chỉ số ở giữa mảng
            int mid = left + (right - left) / 2;

            // Gọi đệ quy để chia mảng làm hai nửa
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            // Trộn hai nửa đã được sắp xếp
            Merge(arr, left, mid, right);
        }
    }
    void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1; // Kích thước của mảng con trái
        int n2 = right - mid;    // Kích thước của mảng con phải

        // Tạo mảng tạm thời
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Sao chép dữ liệu vào mảng tạm thời
        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = arr[mid + 1 + j];

        // Trộn các mảng con
        int k = left;
        int iIndex = 0, jIndex = 0;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                arr[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            arr[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            arr[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
    // Sort Algorithm 5
    void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Tìm chỉ số của phần tử chia mảng làm hai
            int pi = Partition(arr, low, high);

            // Gọi đệ quy QuickSort cho mảng bên trái và bên phải
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    // Hàm để chia mảng và đặt phần tử "pivot" vào đúng vị trí
    int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Chọn phần tử cuối cùng làm pivot
        int i = (low - 1); // Chỉ số của phần tử nhỏ hơn

        for (int j = low; j <= high - 1; j++)
        {
            // Nếu phần tử hiện tại nhỏ hơn pivot
            if (arr[j] < pivot)
            {
                i++; // Tăng chỉ số của phần tử nhỏ hơn
                Swap(arr, i, j);
            }
        }

        // Đặt pivot vào đúng vị trí
        Swap(arr, i + 1, high);
        return i + 1;
    }

    // Hàm hoán đổi hai phần tử trong mảng
    void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        //Insert Algorithm here
        //this.BubbleSort(randomNumbers);
        //this.SelectionSort(randomNumbers);
        //this.InsertionSort(randomNumbers);
        //this.MergeSort(randomNumbers, 0, randomNumbers.Length - 1);
        this.QuickSort(randomNumbers, 0, randomNumbers.Length - 1);
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
