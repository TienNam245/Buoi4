using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Buoi4
{
    public partial class Form1 : Form
    {
        private BindingList<Student> students = new BindingList<Student>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            
            bindingSource.DataSource = students;
            dgvStudents.DataSource = bindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbKhoa.Items.Clear();
            cbKhoa.Items.AddRange(new object[] { "QTKD", "CNTT", "NNA" });
            cbKhoa.SelectedIndex = 0;

            
            rbNu.Checked = true;

            
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoGenerateColumns = true; 

            UpdateCount();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = txtMSSV.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
                string diemText = txtDiem.Text.Trim();
                string khoa = cbKhoa.SelectedItem?.ToString() ?? "";

                
                if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(diemText))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(diemText, out double diem))
                {
                    MessageBox.Show("Điểm TB không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var exist = students.FirstOrDefault(s => s.MSSV == mssv);
                if (exist == null)
                {
                    
                    students.Add(new Student(mssv, hoten, gioitinh, diem, khoa));
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    exist.HoTen = hoten;
                    exist.GioiTinh = gioitinh;
                    exist.DiemTB = diem;
                    exist.Khoa = khoa;
                    bindingSource.ResetBindings(false);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                UpdateCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = txtMSSV.Text.Trim();
                if (string.IsNullOrEmpty(mssv))
                {
                    MessageBox.Show("Vui lòng nhập MSSV cần xóa hoặc chọn 1 dòng trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var exist = students.FirstOrDefault(s => s.MSSV == mssv);
                if (exist == null)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dr = MessageBox.Show($"Bạn có chắc muốn xóa MSSV: {mssv} ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    students.Remove(exist);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudents.Rows.Count)
            {
                var row = dgvStudents.Rows[e.RowIndex];
                var sv = row.DataBoundItem as Student;
                if (sv != null)
                {
                    txtMSSV.Text = sv.MSSV;
                    txtHoTen.Text = sv.HoTen;
                    if (sv.GioiTinh == "Nam") rbNam.Checked = true;
                    else rbNu.Checked = true;
                    txtDiem.Text = sv.DiemTB.ToString();
                    cbKhoa.SelectedItem = sv.Khoa;
                }
            }
        }

        private void UpdateCount()
        {
            int nam = students.Count(s => s.GioiTinh == "Nam");
            int nu = students.Count(s => s.GioiTinh == "Nữ");
            lblNam.Text = nam.ToString();
            lblNu.Text = nu.ToString();
        }
    }
}