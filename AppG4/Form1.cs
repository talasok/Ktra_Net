using AppG4.DAO;
using AppG4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG4
{
    public partial class Form1 : Form
    {
        void loadDanhSachSinhVien()
        {
          
            string sql = "select * from sinhvien";
            DataTable data;
            data = DataProvider.Instance.ExcuteQuery(sql);
            dataBinding1.DataSource = data;
            dtgvListSV.DataSource = dataBinding1;
         
        }
        public Form1()
        {
            InitializeComponent();
            loadDanhSachSinhVien();
        }

        
        private void dtgvListSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var svCurrent = dataBinding1.Current as DataRowView;
            string id = svCurrent["id"].ToString();
            if (id == "")
                return;
            txtHoten.Text = svCurrent["hoten"].ToString();
            dtpkNgaysinh.Value = (DateTime)svCurrent["ngaysinh"];
            checkboxGioitinh.Checked = (bool)svCurrent["gioitinh"];
            lbDTB.Text = "";
            //string makhoa = svCurrent["makhoa"].ToString();
            //MessageBox.Show(svCurrent["makhoa"].ToString()+"cntt"+ktra(makhoa,"cntt").ToString());
            if (svCurrent["makhoa"].ToString().Contains("cntt"))
            {
                tabControl.SelectedTab = tabCntt;
               // MessageBox.Show(svCurrent["makhoa"].ToString()+"có");
                string sql = "select * from CNTT where id_sv = "+id;
                DataTable ls = DataProvider.Instance.ExcuteQuery(sql);
                if (ls.Rows.Count > 0)
                {
                    DataRow temp = ls.Rows[0];
                    txtPascal.Text = temp["pascal"].ToString();
                    txtSql.Text = temp["sql"].ToString();
                    txtCsharp.Text = temp["cshap"].ToString();
                    lbDTB.Text = ( float.Parse(txtPascal.Text) + float.Parse(txtSql.Text) + float.Parse(txtCsharp.Text)) / 3 + "";

                }
                else
                {
                    txtPascal.Text = "";
                    txtSql.Text = "";
                    txtCsharp.Text = "";
                }
            }
            else if (svCurrent["makhoa"].ToString().Contains("vatly"))
            {
                tabControl.SelectedTab = tabVatly;
                string sql = "select * from VatLy where id_sv = " + id;
                DataTable ls = DataProvider.Instance.ExcuteQuery(sql);
                if (ls.Rows.Count > 0)
                {
                    DataRow temp = ls.Rows[0];
                    txtCokhi.Text = temp["cokhi"].ToString();
                    txtQuanghoc.Text = temp["quanghoc"].ToString();
                    txtDien.Text = temp["dien"].ToString();
                    txtVLhatnhan.Text = temp["vlhatnhan"].ToString();
                    lbDTB.Text = (float.Parse(txtCokhi.Text) + float.Parse(txtQuanghoc.Text) + float.Parse(txtDien.Text) + float.Parse(txtVLhatnhan.Text)) / 4 + "";
                }
                else
                {
                    txtCokhi.Text = "";
                    txtQuanghoc.Text = "";
                    txtDien.Text = "";
                    txtVLhatnhan.Text = "";
                }
            }
            else
            {
                tabControl.SelectedTab = tabVan;
                string sql = "select * from Van where id_sv = " + id;
                DataTable ls = DataProvider.Instance.ExcuteQuery(sql);
                if (ls.Rows.Count > 0)
                {
                    DataRow temp = ls.Rows[0];
                    txtVanhoccd.Text = temp["vanhoccd"].ToString();
                    txtVanhochd.Text = temp["vanhochd"].ToString();
                    lbDTB.Text = (float.Parse(txtVanhoccd.Text) + float.Parse(txtVanhochd.Text)) / 2 + "";
                }
                else
                {
                    txtVanhoccd.Text = "";
                    txtVanhochd.Text = "";
                }

            }

        }

        private void sVVănToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ht = txtHoten.Text;
            bool gt = checkboxGioitinh.Checked;
            DateTime ns = dtpkNgaysinh.Value;
            
            string sql = "insert into SinhVien(hoten, gioitinh, ngaysinh,makhoa) values ( @ht , @gt , @ns , 'van' ) ";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ht,gt,ns});

            if (txtVanhoccd.Text!="" && txtVanhochd.Text != "")
            {
                float diemVanhoccd = float.Parse(txtVanhoccd.Text);
                float diemVanhochd = float.Parse(txtVanhochd.Text);
                sql = "SELECT MAX (id) as id FROM SinhVien";
                var id = DataProvider.Instance.ExcuteQuery(sql).Rows[0]["id"];
                sql = "insert into Van(id_sv, vanhoccd, vanhochd) values (" + id.ToString() + " , @d1 , @d2 ) ";
                DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemVanhoccd, diemVanhochd });
                
            }
            loadDanhSachSinhVien();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var svCurrent = dataBinding1.Current as DataRowView;
            string id = svCurrent["id"].ToString();
            string sql = "Delete from sinhvien where id = "+id;
            DataProvider.Instance.ExecuteNonQuery(sql);
            loadDanhSachSinhVien();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var svCurrent = dataBinding1.Current as DataRowView;
            string id = svCurrent["id"].ToString();

            string ht = txtHoten.Text;
            bool gt = checkboxGioitinh.Checked;
            DateTime ns = dtpkNgaysinh.Value;
            string sql = "update SinhVien SET  hoten = @ht , gioitinh = @gt , ngaysinh = @ns where id = @id ";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ht, gt, ns ,id });

            string khoa = svCurrent["makhoa"].ToString();
            // MessageBox.Show(ktra(khoa, "van")+""+khoa);
            if (khoa.Contains("van"))
            {
                if (txtVanhoccd.Text != "" && txtVanhochd.Text != "")
                {
                    float diemVanhoccd = float.Parse(txtVanhoccd.Text);
                    float diemVanhochd = float.Parse(txtVanhochd.Text);
                    sql = "SELECT * FROM Van where id_sv = " + id;

                    if (DataProvider.Instance.ExcuteQuery(sql).Rows.Count > 0)
                    {
                        sql = "UPDATE Van SET vanhoccd = @d1 , vanhochd= @d2 WHERE id_sv = @id ";
                        DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemVanhoccd, diemVanhochd, int.Parse(id) });
                    }
                    else
                    {
                        sql = "insert into Van(id_sv, vanhoccd, vanhochd) values (" + id.ToString() + " , @d1 , @d2 ) ";
                        DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemVanhoccd, diemVanhochd });
                    }
                }
            }
            else if (khoa.Contains("cntt"))
            {
                if (txtPascal.Text != "" && txtCsharp.Text != "" && txtSql.Text != "")
                {
                    float diemPascal = float.Parse(txtPascal.Text);
                    float diemCsharp = float.Parse(txtCsharp.Text);
                    float diemSql = float.Parse(txtSql.Text);

                    sql = "SELECT * FROM CNTT where id_sv = " + id;
                    if (DataProvider.Instance.ExcuteQuery(sql).Rows.Count > 0)
                    {
                        sql = "UPDATE CNTT SET pascal = @d1 , cshap= @d2 , sql= @d3 WHERE id_sv = @id ";
                        DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemPascal, diemCsharp, diemSql, int.Parse(id) });
                    }
                    else
                    {
                        sql = "insert into CNTT(id_sv, pascal, cshap,sql) values (" + id.ToString() + " , @d1 , @d2 , @d3 ) ";
                        DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemPascal, diemCsharp, diemSql });
                    }
                }
            }
            else
            {
                if (txtCokhi.Text != "" && txtQuanghoc.Text != "" && txtVLhatnhan.Text != "" && txtDien.Text != "")
                {
                    float diemCokhi = float.Parse(txtCokhi.Text);
                    float diemQuanghoc = float.Parse(txtQuanghoc.Text);
                    float diemVLhatnhan = float.Parse(txtVLhatnhan.Text);
                    float diemDien = float.Parse(txtDien.Text);

                    sql = "SELECT * FROM VatLy where id_sv = " + id;
                    if (DataProvider.Instance.ExcuteQuery(sql).Rows.Count > 0)
                    {
                        sql = "UPDATE VatLy SET cokhi = @d1 , quanghoc= @d2 , dien= @d3 , vlhatnhan = @d4 WHERE id_sv = @id ";
                        DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemCokhi, diemQuanghoc, diemDien, diemVLhatnhan, int.Parse(id) });
                    }
                    else
                    {
                        sql = "insert into VatLy(id_sv, cokhi, quanghoc,dien,vlhatnhan) values (" + id.ToString() + " , @d1 , @d2 , @d3 , @d4 ) ";
                        DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemCokhi, diemQuanghoc, diemDien, diemVLhatnhan });
                    }
                }
            }
            loadDanhSachSinhVien();
        }

        private void sVVậtLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ht = txtHoten.Text;
            bool gt = checkboxGioitinh.Checked;
            DateTime ns = dtpkNgaysinh.Value;

            string sql = "insert into SinhVien(hoten, gioitinh, ngaysinh,makhoa) values ( @ht , @gt , @ns , 'vatly' ) ";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ht, gt, ns });

            if (txtCokhi.Text != "" && txtQuanghoc.Text != "" && txtVLhatnhan.Text != "" && txtDien.Text != "")
            {
                float diemCokhi = float.Parse(txtCokhi.Text);
                float diemQuanghoc = float.Parse(txtQuanghoc.Text);
                float diemVLhatnhan = float.Parse(txtVLhatnhan.Text);
                float diemDien = float.Parse(txtDien.Text);
                sql = "SELECT MAX (id) as id FROM SinhVien";
                var id = DataProvider.Instance.ExcuteQuery(sql).Rows[0]["id"];
                sql = "insert into VatLy(id_sv, cokhi, quanghoc,dien,vlhatnhan) values (" + id.ToString() + " , @d1 , @d2 , @d3 , @d4 ) ";
                DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemCokhi, diemQuanghoc, diemVLhatnhan, diemDien });

            }
            loadDanhSachSinhVien();
        }

        private void sVCNTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ht = txtHoten.Text;
            bool gt = checkboxGioitinh.Checked;
            DateTime ns = dtpkNgaysinh.Value;

            string sql = "insert into SinhVien(hoten, gioitinh, ngaysinh,makhoa) values ( @ht , @gt , @ns , 'cntt' ) ";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ht, gt, ns });
            //MessageBox.Show(ktra(txtPascal.Text, "") + null+ txtPascal.Text);
            if (txtPascal.Text != "" && txtCsharp.Text != "" && txtSql.Text != "" )
            {
                //MessageBox.Show(ktra(txtPascal.Text, "") + "CÓ");
                float diemPascal = float.Parse(txtPascal.Text);
                float diemCsharp = float.Parse(txtCsharp.Text);
                float diemSql = float.Parse(txtSql.Text);
                sql = "SELECT MAX (id) as id FROM SinhVien";
                var id = DataProvider.Instance.ExcuteQuery(sql).Rows[0]["id"];
                sql = "insert into CNTT(id_sv, pascal, cshap,sql ) values (" + id.ToString() + " , @d1 , @d2 , @d3  ) ";
                DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diemPascal, diemCsharp, diemSql });

            }
            loadDanhSachSinhVien();
        }
       
    }
}
