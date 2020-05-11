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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conns = "Data Source=VUDUONG;Initial Catalog =CHUNGKHOAN; User ID =sa; Password=123456";

        private void Button1_Click(object sender, EventArgs e)
        {
            //macp , ngay,loaigd,soluong,giadat
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmacp1.Items.Add("ACB");
            txtmacp1.Items.Add("VCB");
            txtmacp1.Items.Add("HONDA");
            txtmacp1.Items.Add("MAZDA");
            txtmacp1.Items.Add("DUONG");
            txtmacp1.Items.Add("HAU");

            txtmacp1.SelectedIndex = 0;
            txtloadlenh.Items.Add("LỆNH GIOI HAN (LO)");
            txtloadlenh.SelectedIndex = 0;
            txtloadlenh.Enabled = false;

            DateTime aDate = DateTime.Now;
            label2.Text= "Đặt lệnh mua cho ngày : "+ aDate.ToString("dd/MM/yyyy");
            label8.Text = "Đặt lệnh bán cho ngày : " + aDate.ToString("dd/MM/yyyy");
            label15.Text = "LỆNH ĐẶT NGÀY : " + aDate.ToString("dd / MM / yyyy");

            comboBox4.Items.Add("ACB");
            comboBox4.Items.Add("VCB");
            comboBox4.Items.Add("HONDA");
            comboBox4.Items.Add("MAZDA");
            comboBox4.Items.Add("DUONG");
            comboBox4.Items.Add("HAU");
            comboBox4.SelectedIndex = 0;
            comboBox3.Items.Add("LỆNH GIOI HAN (LO)");
            comboBox3.SelectedIndex = 0;
            comboBox3.Enabled = false;

            Loadlenhdat();

        }

       public void Exchange(string macp,string ngay,string loai,int soluong, double gia)
        {

            // string chuoi = macp + "|" + ngay + "|" + loai + "|" + soluong + "|" + gia;
            //   MessageBox.Show(chuoi);
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();
                string sql = "EXEC SP_KHOPLENH_LO '" + macp + "','" + loai + "'," + soluong + "," + gia + "";
                //  MessageBox.Show(sql);
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //   cmd.Parameters.Add("@param1", SqlDbType.NVarChar, 10).Value = ma;
                    //  cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 100).Value = fol;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Thành Công !", "Thông Báo", MessageBoxButtons.OK);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

         

                /*
                using (var conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=CHUNGKHOAN;Integrated Security=True"))
                using (var command = new SqlCommand("SP_KHOPLENH_LO", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    conn.Open();
                    command.Parameters.Add(new SqlParameter("@macp", macp));
                    command.Parameters.Add(new SqlParameter("@Ngay", ngay));
                    command.Parameters.Add(new SqlParameter("@LoaiGD", loai));
                    command.Parameters.Add(new SqlParameter("@soluongMB", soluong));
                    command.Parameters.Add(new SqlParameter("@giadatMB",float.Parse(gia.ToString())));
                    command.ExecuteNonQuery();
                }
                */
                /*

                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=CHUNGKHOAN;Integrated Security=True"))
                {



                    conn.Open();

                    // 1.  create a command object identifying the stored procedure
                    SqlCommand cmd = new SqlCommand("SP_KHOPLENH_LO", conn);

                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3. add parameter to command, which will be passed to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@macp", macp));
                    cmd.Parameters.Add(new SqlParameter("@Ngay", ngay));
                    cmd.Parameters.Add(new SqlParameter("@LoaiGD", loai));
                    cmd.Parameters.Add(new SqlParameter("@soluongMB", soluong));
                    cmd.Parameters.Add(new SqlParameter("@giadatMB", gia));
                    SqlDataReader rdr = cmd.ExecuteReader();
                    MessageBox.Show("dung");
                    // execute the command


                }

        */


            }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           
            
            DateTime aDate = DateTime.Now;
            string macp = txtmacp1.Text.Trim();
            string ngay = aDate.ToString("yyyy-MM-dd HH:mm:ss");
            string loaigd = "M";
            string soluongmb = txtsoluong.Text.Trim();
            string giadat = txtgia.Text.Trim();

            if (soluongmb.Length < 1 || giadat.Length<1 || int.Parse(giadat)<1)
            {

                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
          
           // MessageBox.Show(chuoi);
            Exchange(macp, ngay, loaigd,int.Parse(soluongmb),double.Parse(giadat));
        

        }

        private void Txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



   

     

        private void Txtgia_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string ax = txtgia.Text;
              //  MessageBox.Show(ax);
                double gia = int.Parse(txtsoluong.Text) * double.Parse(ax);
                txttongtien.Text = gia.ToString();
            }
            catch { }
        }

        private void Txtgia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
               // MessageBox.Show("k");
                e.Handled = true;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Loadlenhdat();

        }

        void Loadlenhdat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlConnection conn = new SqlConnection(conns);
            DateTime aDate = DateTime.Now;
            string ngay = aDate.ToString("yyyy-MM-dd");
            try
            {
                var dap = new SqlDataAdapter("select * from LENHDAT where CONVERT(VARCHAR(25), NGAYDAT, 126) LIKE '" + ngay + "%'", conn);
                var table = new DataTable();
                dap.Fill(table);

                dataGridView1.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Lỗi connect tới database");
            }
            conn.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            string macp = comboBox4.Text.Trim();
            string ngay = aDate.ToString("yyyy-MM-dd HH:mm:ss");
            string loaigd = "B";
            string soluongmb = textBox6.Text.Trim();
            string giadat = textBox5.Text.Trim();

            if (soluongmb.Length < 1 || giadat.Length < 1 || int.Parse(giadat) < 1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }

            // MessageBox.Show(chuoi);
            Exchange(macp, ngay, loaigd, int.Parse(soluongmb), double.Parse(giadat));
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                // MessageBox.Show("k");
                e.Handled = true;
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                // MessageBox.Show("k");
                e.Handled = true;
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ax = textBox5.Text;
                //  MessageBox.Show(ax);
                double gia = int.Parse(textBox6.Text) * double.Parse(ax);
                textBox4.Text = gia.ToString();
            }
            catch { }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                    try
                    {

                        string uid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                      //  MessageBox.Show(uid);
                        int cid = int.Parse(uid);
                    string sql = "DELETE FROM LENHDAT WHERE ID = "+ cid + "";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                       
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thành Công");
                   


                    }

                      }
                    catch
                    {
                    MessageBox.Show("Có lỗi xảy ra !", "Thông Báo");
                    }

                
            }
            conn.Close();
            Loadlenhdat();




        }
    }
}
