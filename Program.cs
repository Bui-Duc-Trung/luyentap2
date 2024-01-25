using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            ArrayList TimDienThoai = new ArrayList();
            int luachon = 0;
            do
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Quan Ly Cua Hang Dien Thoai");
                Console.WriteLine(" 1. Them dien thoai");
                Console.WriteLine(" 2. Them dien thoai chi tiet");
                Console.WriteLine(" 3. Tim dien thoai");
                Console.WriteLine(" 4. Dang/Ngung kinh doanh");
                Console.WriteLine(" 5. Thoat");
                Console.WriteLine("--------------------");
                Console.Write("Moi ban chon chuc nang: ");
                luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        {
                            ChucNang1(TimDienThoai);
                            break;
                        }
                    case 2:
                        {
                            ChucNang2(TimDienThoai);
                            break;
                        }
                    case 3:
                        {
                            ChucNang3(TimDienThoai);
                            break;
                        }
                    case 4:
                        {
                            // ChucNang4();
                            break;
                        }
                }
            } while (luachon != 5);
        }

        static void ChucNang1(ArrayList arr)
        {
            DienThoai DienThoaii = new DienThoai();
            Console.Write("Nhap Ma DT: ");
            DienThoaii.MaDT = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten DT: ");
            DienThoaii.TenDT = Console.ReadLine();
            Console.Write("Nhap Thuong hieu: ");
            DienThoaii.ThuongHieu = Console.ReadLine();
            arr.Add(DienThoaii);
        }

        static void ChucNang2(ArrayList dtct)
        {
            DienThoaiChiTiet dienThoaiChiTiett = new DienThoaiChiTiet();
            Console.Write("Nhap ma DT: ");
            dienThoaiChiTiett.MaDT = int.Parse(Console.ReadLine());
            Console.Write("Nhap dung luong: ");
            dienThoaiChiTiett.DungLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau sac: ");
            dienThoaiChiTiett.MauSac = Console.ReadLine();
            Console.Write("Nhap so luong");
            dienThoaiChiTiett.SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tien: ");
            dienThoaiChiTiett.GiaTien = int.Parse(Console.ReadLine());
            Console.Write("Nhap trang thai: ");
            dienThoaiChiTiett.TrangThai = bool.Parse(Console.ReadLine());
            dtct.Add(dienThoaiChiTiett);

        }

        static void ChucNang3(ArrayList dtct)
        {
            foreach (DienThoaiChiTiet dienThoaiChiTiett in dtct)
            {
                Console.WriteLine($"{dienThoaiChiTiett.MaDT}\t{dienThoaiChiTiett.TenDT}\t" +
                    $"{dienThoaiChiTiett.ThuongHieu}\t{dienThoaiChiTiett.DungLuong}\t{dienThoaiChiTiett.MauSac}\t" +
                    $"{dienThoaiChiTiett.SoLuong}\t{dienThoaiChiTiett.GiaTien}\t{dienThoaiChiTiett.TrangThai}");
            }
        }
    }
}
