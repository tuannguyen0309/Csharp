// namespace Tuan
// {
//     class Lop
//     {
//         protected float x;
//         protected string y;
//         public void Lop() { }
//         public void Lop(float a, string b)
//         {
//             x = a;
//             y = b;
//         }
//         public void Hienthi()
//         {
//             Console.Write("Thong Tin hien thi la:" + x + " " + y);
//         }
//     }
// }
// namespace Tuan
// {
//     class Lop1 : Lop
//     {
//         private int k = 0;

//         public void Nhapvao(int a)
//         {
//             k = a;
//         }
//         public NhanVien(float a, string b, int k)
//    : base(a, b)
//         {
//             this.k = k;
//         }
//         public void Hienthi()
//         {
//             Console.Write("Thong Tin hien thi La:" + a + " " + b + " " + k);
//         }
//     }
// }
// namespace Tuan
// {
//     class Lop2 : Lop
//     {
//         private string k;

//         public void Nhapvao(string a)
//         {
//             k = a;
//         }
//         public Sinhvien(float a, string b, string k)
//    : base(a, b)
//         {
//             this.k = k;
//         }
//         public void Hienthi()
//         {
//             Console.Write("Thong Tin Hien thi La:" + a + " " + b + " " + k);
//         }
//     }
// }