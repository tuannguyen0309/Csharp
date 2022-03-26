// using System;
// namespace tuan2
// {
//     internal class NewBaseType
//     {
//         static void Main4(string[] argc)
//         {
//             int n, i, k;
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

//             // Hiển thị mảng vừa nhập
//             Console.WriteLine("\nMang da nhap la: ");
//             for (i = 0; i < n; i++)
//             {
//                 Console.Write(a[i] + "\t");
//             }

//             Console.WriteLine("\n");
//             //Nhập vào số k
//             Console.Write("Nhap vao so k: ");
//             k = int.Parse(Console.ReadLine());
//             int count = 0;
//             for (i = 0; i < n; i++)
//             {
//                 if (k == a[i])
//                 {
//                     count++;
//                 }
//             }
//             //Hiển thị số lần k xuất hiện trong mảng
//             Console.WriteLine("So lan xuat hien cua k: " + count);

//             Console.ReadKey();
//         }
//     }

//     class bai4 : NewBaseType
//     {
//     }
// }