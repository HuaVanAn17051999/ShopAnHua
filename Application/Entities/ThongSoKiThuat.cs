using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    public class ThongSoKiThuat
    {
        public int Id { get; set; }
        public string ManHinh { get; set; }
        public string HeDieuHanh { get; set; }
        public string CameraTruoc { get; set; }
        public string CameraSau { get; set; }
        public string CPU { get; set; }
        public string Ram { get; set; }
        public string BoNhoTrong { get; set; }
        public string TheNho { get; set; }
        public string TheSim { get; set; }
        public string DungLuongPin { get; set; }
        public string OCung { get; set; }
        public string CardManHinh { get; set; }
        public string KichThuoc { get; set; }
        public string ThietKe { get; set; }
        public string CongKetNoi { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
