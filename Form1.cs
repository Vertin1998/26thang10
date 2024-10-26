namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class SinhVien
        {
            public string MaSinhVien { get; set; }
            public string Ten { get; set; }
            public double Diem { get; set; }
        }
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = danhSachSinhVien;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = txtMaSinhVien.Text,
                Ten = txtTen.Text,
                Diem = double.Parse(txtDiem.Text)
            };
            danhSachSinhVien.Add(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSinhVien;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSinhVientc.Text;
            var sinhVien = danhSachSinhVien.FirstOrDefault(sv => sv.MaSinhVien == maSV);

            if (sinhVien != null)
            {
                MessageBox.Show($"Ten: {sinhVien.Ten} \nDiem: {sinhVien.Diem}");
            }
            else
            {
                MessageBox.Show("Khong tim thay sinh vien.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var sv = (SinhVien)dataGridView1.SelectedRows[0].DataBoundItem;
                danhSachSinhVien.Remove(sv);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSachSinhVien;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var sv = (SinhVien)dataGridView1.SelectedRows[0].DataBoundItem;
                sv.Ten = txtTen.Text;
                sv.Diem = double.Parse(txtDiem.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSachSinhVien;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}