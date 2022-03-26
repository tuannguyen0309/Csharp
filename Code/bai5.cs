// using System;
// namespace tuan2
// {
//     internal class NewBaseType
//     {
//         static void Main5(string[] argc)
//         {
//             int n, i, temp;
//             do
//             {
//                 Console.WriteLine("Nhap vao so phan tu cua mang: ");
//                 n = int.Parse(Console.ReadLine());
//             } while (n < 0);
//             // khởi tạo và cấp phát bộ nhớ cho mảng
//             int[] a = new int[n];

//             Console.WriteLine("Nhap cac phan tu vao mang: ");
//             for (i = 0; i < n; i++)
//             {
//                 Console.WriteLine("Nhap phan tu thu " + i + ": ");
//                 a[i] = int.Parse(Console.ReadLine());
//             }

//             //Tìm giá trị lớn nhất của trong mảng và in ra màn hình
//             int max = a[0];
//             for (i = 0; i < n - 1; i++)
//             {
//                 if (a[i] < a[i + 1])
//                 {
//                     max = a[i + 1];
//                 }
//             }
//             Console.WriteLine("\nGia tri lon nhat trong mang la: " + max);

//             //Tìm giá trị nhỏ nhất của trong mảng và in ra màn hình
//             int min = a[0];
//             for (i = 0; i < n - 1; i++)
//             {
//                 if (a[i] > a[i + 1])
//                 {
//                     min = a[i + 1];
//                 }
//             }
//             Console.WriteLine("Gia tri nho nhat trong mang la: " + min);

//             // sắp xếp theo thứ tự tăng dần
//             for (i = 0; i < n - 1; i++)
//             {
//                 for (int j = i + 1; j > i + 1; j++)
//                 {
//                     if (a[i] < a[j])
//                     {
//                         temp = a[j];
//                         a[j] = a[i];
//                         a[i] = temp;
//                     }
//                 }
//             }
//             Console.WriteLine("Mang sau khi duoc sap xep tang dan la: ");
//             for (i = 0; i < n; i++)
//             {
//                 Console.Write(a[i] + "\t");
//             }

//             // sắp xếp theo thứ tự giảm dần
//             for (i = 0; i < n - 1; i++)
//             {
//                 for (int j = i + 1; j <= n - 1; j++)
//                 {
//                     if (a[i] < a[j])
//                     {
//                         temp = a[i];
//                         a[i] = a[j];
//                         a[j] = temp;
//                     }
//                 }
//             }
//             Console.WriteLine("\nMang sau khi duoc sap xep giam dan la: ");
//             for (i = 0; i < n; i++)
//             {
//                 Console.Write(a[i] + "\t");
//             }
//             Console.ReadKey();
//         }
//     }

//     class bai5 : NewBaseType
//     {
//     }
// }