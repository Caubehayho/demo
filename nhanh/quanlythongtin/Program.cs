using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythongtin
{
    class SinhVien
    {

        private string maSinhVien;
        private string hoTen;
        private int ngaySinh;
        private int diemToan;
        private int diemAnh;
        private int diemVan;
        private String chuyenNghanh;
        private double diemTrungBinh;
        public SinhVien() { }
        public string layMaSV
        {
            get => maSinhVien;
            set => maSinhVien = value;
        }
        public String layHoTen
        {
            get => hoTen;
            set => hoTen = value;
        }
        public int layNgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }
        public int layDiemToan
        {
            get => diemToan;
            set => diemToan = value;
        }
        public int layDiemAnh
        {
            get => diemAnh;
            set => diemAnh = value;
        }
        public int layDiemVan
        {
            get => diemVan;
            set => diemVan = value;
        }
        public String layChuyenNghanh
        {
            get => chuyenNghanh;
            set => chuyenNghanh = value;
        }

        public void nhapThongTinsv()
        {
            Console.Write("nhap ma sinh vien: ");
            maSinhVien = Console.ReadLine();
            Console.Write("nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("nhap ngay sinh: ");
            ngaySinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap diem toan: ");
            diemToan = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap diem anh: ");
            diemAnh = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap diem van: ");
            diemVan = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap chuyen nghanh: ");
            chuyenNghanh = Console.ReadLine();
        }

        public void xuatThongTinsv()
        {
            Console.WriteLine("MaSV : {0}|| Ho Ten: {1}|| Nam sinh: {2}|| DiemToan: {3}|| DiemVan|| {4}|| DiemAnh {5}|| DiemTB {6} || Chuyen nganh : {7}", layMaSV, hoTen, layNgaySinh, layDiemToan, layDiemVan, layDiemAnh, DTB(layDiemToan, layDiemVan, layDiemAnh), chuyenNghanh);

        }
        //3diemcaonhat
       


        public double DTB(float layDiemtoan, float layDiemvan, float layDiemanh)
        {
            return (double)((layDiemtoan + layDiemvan + layDiemanh) / 3.0);

        }



        static void Main(string[] args)
        {




            int n;
            Console.Write("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());
            SinhVien[] DSSV = new SinhVien[n];
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("thong tin sinh vien thu" + (i + 1));
                Console.ReadKey();
                DSSV[i] = new SinhVien();
                DSSV[i].nhapThongTinsv();
            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("thong tin sinh vien thu:" + (i + 1));
                DSSV[i].xuatThongTinsv();
                Console.ReadKey();
            }


            Console.WriteLine("\n  SV co diem TB >=5 la :");
            for (int i = 0; i < n; i++)
            {
                if (DSSV[i].DTB(DSSV[i].layDiemToan, DSSV[i].layDiemVan, DSSV[i].layDiemAnh) >= 5)
                {
                    Console.WriteLine("\n MaSV: {0} | Ho Ten: {1}|Chuyen Nganh: {2}", DSSV[i].layMaSV, DSSV[i].layHoTen, DSSV[i].layChuyenNghanh);
                }
                Console.ReadKey();
            }


            for (int i = 0; i < n; i++)
            {
                int tam;
                for (int j = i + 1; j < n; j++)
                {
                    if (DSSV[i].diemTrungBinh < DSSV[j].diemTrungBinh)

                    {
                        tam = DSSV[i];
                        DSSV[i] = DSSV[j];
                        DSSV[j] = tam;
                    }
                }
            }

        }
    

    }
}





