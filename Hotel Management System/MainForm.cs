using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class MainForm : Form
    {
        GuestClass guest = new GuestClass();
        RoomClass room = new RoomClass();
        ReservationClass reservation = new ReservationClass();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = guest.getGuest();

            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DataSource = reservation.getReserv();

            dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView3.DataSource = room.getRoomList();


        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_dashboard.Height;
            panel_slide.Top = button_dashboard.Top;

            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel_cover);
            //panel_main.Visible = true; 
            
        }

        private void button_guest_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_guest.Height;
            panel_slide.Top = button_guest.Top;

            panel_main.Controls.Clear();
            GuestForm guest = new GuestForm();
            guest.TopLevel = false;
            guest.Dock = DockStyle.Fill;
            guest.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(guest);
            guest.Show();
        }

        private void button_reception_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_reception.Height;
            panel_slide.Top = button_reception.Top;

            panel_main.Controls.Clear();
            ReservationForm reservation = new ReservationForm();
            reservation.TopLevel = false;
            reservation.Dock = DockStyle.Fill;
            reservation.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(reservation);
            reservation.Show();
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_room.Height;
            panel_slide.Top = button_room.Top;

            panel_main.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(room);
            room.Show();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_logout.Height;
            panel_slide.Top = button_logout.Top;

            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adduser adduser = new adduser();
            this.Hide();
            adduser.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
