// namespace Hanh_27
// {
//     class LopCoSo
//     {
//         protected float x;
//         protected string y;
//         public void LopCoSo() { }
//         public void LopCoSo(float a, string b)
//         {
//             x = a;
//             y = b;
//         }
//         public void InThongTin()
//         {
//             Console.Write("Thong Tin La:" + x + " " + y);
//         }
//     }
// }
// namespace Hanh_27
// {
//     class Lop1 : LopCoSo
//     {
//         private int k = 0;

//         public void NhapSo(int a)
//         {
//             k = a;
//         }
//         public NhanVien(float a, string b, int k)
//    : base(a, b)
//         {
//             this.k = k;
//         }
//         public void InThongTin()
//         {
//             Console.Write("Thong Tin La:" + a + " " + b + " " + k);
//         }
//     }
// }
// namespace Hanh_27
// {
//     class Lop2 : LopCoSo
//     {
//         private string k;

//         public void NhapSo(string a)
//         {
//             k = a;
//         }
//         public NhanVien(float a, string b, string k)
//    : base(a, b)
//         {
//             this.k = k;
//         }
//         public void InThongTin()
//         {
//             Console.Write("Thong Tin La:" + a + " " + b + " " + k);
//         }
//     }
// }
// namespace Hanh_27
// {
//     class Main
//     {
//         LopCoSo c = new LopCoSo(2, "XIn Chao");
//         c.InThongTin();
// 		Lop1 a = new Lop1(2.2, "XIn Chao", 5);
//         a.InThongTin();
// 		Lop2 b = new Lop2(2.2, "XIn Chao", "Tam Biet");
//         b.InThongTin();
//     }
// }
