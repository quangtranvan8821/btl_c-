using System;

namespace BTL_HuongSuKien.DTO
{
    internal class NhanVien
    {
        private int id_nhan_vien;
        private string ten_phong_ban;
        private string ten_chuc_vu;
        private string ten_nhan_vien;
        private DateTime ngay_sinh;
        private string dia_chi;
        private string sdt;
        private string gioi_tinh;
        private int id_hop_dong;
        private int id_luong;

        public NhanVien(int id_nhan_vien, string ten_phong_ban, string ten_chuc_vu, string ten_nhan_vien, DateTime ngay_sinh, string dia_chi, string sdt, string gioi_tinh, int id_hop_dong, int id_luong)
        {
            this.id_nhan_vien = id_nhan_vien;
            this.ten_phong_ban = ten_phong_ban;
            this.ten_chuc_vu = ten_chuc_vu;
            this.ten_nhan_vien = ten_nhan_vien;
            this.ngay_sinh = ngay_sinh;
            this.dia_chi = dia_chi;
            this.sdt = sdt;
            this.gioi_tinh = gioi_tinh;
            this.id_hop_dong = id_hop_dong;
            this.id_luong = id_luong;
        }

        public int Id_nhan_vien { get => id_nhan_vien; set => id_nhan_vien = value; }
        public string Ten_phong_ban { get => ten_phong_ban; set => ten_phong_ban = value; }
        public string Ten_chuc_vu { get => ten_chuc_vu; set => ten_chuc_vu = value; }
        public string Ten_nhan_vien { get => ten_nhan_vien; set => ten_nhan_vien = value; }
        public DateTime Ngay_sinh { get => ngay_sinh; set => ngay_sinh = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
        public int Id_hop_dong { get => id_hop_dong; set => id_hop_dong = value; }
        public int Id_luong { get => id_luong; set => id_luong = value; }
    }
}
