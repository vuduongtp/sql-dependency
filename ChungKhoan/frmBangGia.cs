using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungKhoan
{
    public partial class frmBangGia : Form
    {
        public string m_connect = "Data Source=VUDUONG;Initial Catalog =CHUNGKHOAN; User ID =sa; Password=123456";
        public string m_query = "SELECT MACP, GIAMUA2, KLMUA2, GIAMUA1, KLMUA1, GIAKHOP, KLKHOP, GIABAN1, KLBAN1, GIABAN2, KLBAN2 FROM dbo.GIATRUCTUYEN";
        SqlConnection con = null;
        //delegate dùng để định nghĩa ra một thực thể đại diện cho các hàm(phương thức, hoặc constructor) có cùng một kiểu hàm vd (int, int) -> (int).
        public delegate void NewHome();//giống như con trỏ hàm, ở đây không khai báo parameter thì có thể truyền vào đây hàm void
        public event NewHome OnNewHome;//su kien thuc hien OnNewHome, chứa các phương thức, các phương thức này sẽ được thực thi đồng loạt khi sự kiện xẩy ra

        public frmBangGia()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();//cấp quyen sql client
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnNewHome += new NewHome(frmBangGia_OnNewHome);//Khởi tạo hàm.., đăng ký sự kiện
            LoadData();

        }

        //1. Khởi tạo kết nối
        //2. Khởi tạo SQLDependency
        //3. Tạo sự kiện lắng nghe sự thay đỏi từ sqlserver
        //4. Tạo sự kiện cập nhật thay đỏi len UI

        private void LoadData()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(m_query, con);
            cmd.Notification = null;

            SqlDependency dependency = new SqlDependency(cmd);
            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);//nhận su kiện thay đổi từ sqlserver. Subscribe đến sự kiện SqlDependency.

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            gvBangGia.DataSource = dt;
        }

        public void frmBangGia_OnNewHome()
        {
            //Xảy ra khi 1 sự kiện gọi đên nó
            //Không cho phép cập nhật giao diện từ luông khác
            //Đoạn mã sau kiểm tra xem nó có an toàn không khi cập nhật UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//trả về true thì phải gọi lại Invoke(Delegate, Object[]), false thì ko cần
            {
                //Tạo một delegate để thực hiện chuyển đổi luồng
                NewHome dd = new NewHome(frmBangGia_OnNewHome);
                //Sắp xếp dữ liệu từ luồng dang chạy sang luồng UI.
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();

        }

        public void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency dependency = sender as SqlDependency;//lấy đêpncy vừa gửi sự kiện
            dependency.OnChange -= dependency_OnChange;//bỏ sự kiện vua lay de không bị chồng nhau
            if (OnNewHome != null)
            {
                OnNewHome();//truyền sự kiện qua bên khởi tạo
            }

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            SqlDependency.Stop(m_connect);
            this.Close();
        }

        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            Form1 vt = new Form1();
            vt.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime =  DateTime.Now; //thời gian hiện tại
            txtTime.Text =  String.Format("{0:dd/MM/yyyy  HH:mm:ss}", dateTime);  
        }

        private void btnResetPhienGD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("EXEC SP_ResetPhienGD", con);
            int n = (int)command.ExecuteNonQuery();
            MessageBox.Show("Đã làm mới phiên giao dịch.", "Làm mới thành công", MessageBoxButtons.OK);
            con.Close();
        }
    }
}
