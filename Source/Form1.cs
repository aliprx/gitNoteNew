using SQLite;
using System;
using System.IO;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Exception = System.Exception;
using SQLiteConnection = SQLite.SQLiteConnection;

namespace WindowsFormsApp38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Check()
        {
            if (txtText.Text == "")
            {
                MessageBox.Show("نمیتواند خالی باشد");
                return false;
            }
            if (txtTitle.Text == "")
            {
                MessageBox.Show("نمیتواند خالی باشد");
                return false;
            }
            return true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "MyNote.csv");
            var db = new SQLiteConnection(databasePath);
            try
            {
                dgvShowTexts.DataSource = db.Table<Note>().ToList();
            }
            catch
            {
            }
            lblDate.Text = DateTime.Now.ToString();
        }
        private void BtnAddText_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (cbSqLite.Checked == true)
                {
                    var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "MyNote.csv");
                    var db = new SQLiteConnection(databasePath);
                    db.CreateTable<Note>();
                    var notes = new Note()
                    {
                        Title = txtTitle.Text,
                        Text = txtText.Text,
                        Date = DateTime.Now
                    };
                    db.Insert(notes);
                    dgvShowTexts.DataSource = db.Table<Note>().ToList();
                    txtTitle.Text = "";
                    txtText.Text = "";
                }
                else
                {
                    MessageBox.Show("ابتدا باید دیتابیس مورد نظر خود را انتخاب کنید");
                }

            }

        }

        private void BtnDeleteText_Click(object sender, EventArgs e)
        {
            if (dgvShowTexts.CurrentRow != null)
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "MyNote.csv");
                var db = new SQLiteConnection(databasePath);
                if (MessageBox.Show("آیا از حذف یادداشت خود مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    int selectedId = int.Parse(dgvShowTexts.CurrentRow.Cells[0].Value.ToString());
                    db.Delete<Note>(selectedId);
                }
                dgvShowTexts.DataSource = db.Table<Note>().ToList();
            }
        }

        private void BtnOpenText_Click(object sender, EventArgs e)
        {
            if (dgvShowTexts.CurrentRow != null)
            {
                try
                {
                    txtTitle.Text = dgvShowTexts.CurrentRow.Cells[1].Value.ToString();
                    txtText.Text = dgvShowTexts.CurrentRow.Cells[2].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("ابتدا باید یک یادداشت را انتخاب بکنید");
                }
            }
        }

        private void BtnEditText_Click(object sender, EventArgs e)
        {
            if (dgvShowTexts.CurrentRow != null)
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "MyNote.csv");
                var db = new SQLiteConnection(databasePath);
                int selectedId = int.Parse(dgvShowTexts.CurrentRow.Cells[0].Value.ToString());
                var edit=new Note()
                {
                    Id=selectedId,
                    Title = txtTitle.Text,
                    Text = txtText.Text,
                    Date = DateTime.Now

                };
                db.Update(edit);
                dgvShowTexts.DataSource = db.Table<Note>().ToList();
                txtTitle.Text = "";
                txtText.Text = "";

            }
        }
    }
}
