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
        public delegate void NewHome();//giống như con trỏ hàm, ở đây không khai báo parameter thì có thể truyền vào đây hàm void
        public event NewHome OnNewHome;//su kien thuc hien OnNewHome

        public frmBangGia()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
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
            OnNewHome += new NewHome(frmBangGia_OnNewHome);//thực hiện hàm..
            LoadData();

        }

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
            dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            gvBangGia.DataSource = dt;
        }

        public void frmBangGia_OnNewHome()
        {
            //This event will occur on a thread pool thread.
            //It is illegal to update the UI from a worker thread
            //The following code checks to see if it is safe update the UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//trả về true thì phải gọi lại Invoke(Delegate, Object[]), false thì ko cần
            {
                //Create a delegate to perform the thread switch
                NewHome dd = new NewHome(frmBangGia_OnNewHome);
                //Marshal the data from the worker thread to the UI thread.
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();

        }

        public void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency dependency = sender as SqlDependency;
            dependency.OnChange -= dependency_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
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
            txtTime.Text =  String.Format("{0:dd/MM/yyyy  HH:mm:ss}", dateTime);  // "Sunday, March 9, 2008"
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
