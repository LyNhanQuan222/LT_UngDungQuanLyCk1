using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ltudql1.Model;
namespace ltudql1
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
            //var db = new QuanLyTracNghiemDataContext();
            //var users = db.NguoiDungs;
            //dataGridViewNguoiDung.DataSource = users;
            var frmHocSinh = new FrmHocSinh();
            frmHocSinh.ShowDialog();
        }
    }
}
