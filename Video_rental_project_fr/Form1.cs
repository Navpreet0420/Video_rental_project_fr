using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_project_fr
{
    public partial class Form1 : Form
    {
        Member member = new Member();

        Video video = new Video();

        Booking booking = new Booking();

        public Form1()
        {
            InitializeComponent();
        }

        private void add_c_Click(object sender, EventArgs e)
        {
            member = new Member(name_c.Text, email_c.Text, address_c.Text);
            if (member.RegisterMember()) {

            }
            rental_cus_ID.Text = "";
            name_c.Text = "";
            email_c.Text = "";
            address_c.Text = "";
        }

        private void delete_c_Click(object sender, EventArgs e)
        {
            if (member.DeleteMember(Convert.ToInt32(rental_cus_ID.Text.ToString()))) {
                MessageBox.Show("Memeber is deleted from the Database ");
            }
            rental_cus_ID.Text = "";
            name_c.Text = "";
            email_c.Text = "";
            address_c.Text = "";
        }

        private void update_c_Click(object sender, EventArgs e)
        {
            //calling the constructor member of the member class 
            member = new Member(name_c.Text, email_c.Text, address_c.Text);
            if (member.UpdateMember(Convert.ToInt32(rental_cus_ID.Text.ToString()))) {
                MessageBox.Show("Member record is updated from the Database ");
            }
            rental_cus_ID.Text = "";
            name_c.Text = "";
            email_c.Text = "";
            address_c.Text = "";
        }

        private void show_cust_Click(object sender, EventArgs e)
        {
            //get the record from the table of Member
            member.GetRecord(dataTable);
            lblOption.Text = "member";
        }

        private void V_add_Click(object sender, EventArgs e)
        {
            video = new Video(title_v.Text,rating_v.Text,year_v.Text,copy_v.Text,plot_v.Text,genre_v.Text);
            if (video.InsertVideo()) {
                MessageBox.Show("Video is stored ");
            }

            Rental_V_ID.Text = "";
            title_v.Text = "";
            rating_v.Text = "";
            year_v.Text = "";
            copy_v.Text = "";
            plot_v.Text = "";
            genre_v.Text = "";
        }

        private void v_delete_Click(object sender, EventArgs e)
        {

            if (!Rental_V_ID.Text.ToString().Equals(""))
            {
                if (video.deleteVideo(Convert.ToInt32(Rental_V_ID.Text.ToString())))
                {
                    MessageBox.Show("Video record is deleted");
                }
                else
                {
                    MessageBox.Show("Video is booked by Member ");
                }
            }
            else {
                MessageBox.Show("select video to delete");
            }

            Rental_V_ID.Text = "";
            title_v.Text = "";
            rating_v.Text = "";
            year_v.Text = "";
            copy_v.Text = "";
            plot_v.Text = "";
            genre_v.Text = "";

        }

        private void v_update_Click(object sender, EventArgs e)
        {
            video = new Video(title_v.Text, rating_v.Text, year_v.Text, copy_v.Text, plot_v.Text, genre_v.Text);

            if (!Rental_V_ID.Text.ToString().Equals(""))
            {
                if (video.updateVideo(Convert.ToInt32(Rental_V_ID.Text.ToString())))
                {
                    MessageBox.Show("Video record is Updated");
                }
                else
                {
                    MessageBox.Show("select video to Update");
                }
            }

            Rental_V_ID.Text = "";
            title_v.Text = "";
            rating_v.Text = "";
            year_v.Text = "";
            copy_v.Text = "";
            plot_v.Text = "";
            genre_v.Text = "";

        }

        private void del_btn_rental_Click(object sender, EventArgs e)
        {
            if (lblRental_ID.Text.ToString().Equals(""))
            {
                MessageBox.Show("select the rental video to delete ");
                
            }
            else {
                booking.deleteBooking(Convert.ToInt32(lblRental_ID.Text.ToString()));
            }

            Rental_V_ID.Text = "";
            title_v.Text = "";
            rating_v.Text = "";
            year_v.Text = "";
            copy_v.Text = "";
            plot_v.Text = "";
            genre_v.Text = "";

            rental_cus_ID.Text = "";
            name_c.Text = "";
            email_c.Text = "";
            address_c.Text = "";

            lblRental_ID.Text = "";

        }

        private void Issue_btn_Click(object sender, EventArgs e)
        {
            if (!rental_cus_ID.Text.ToString().Equals("") && !Rental_V_ID.Text.ToString().Equals(""))
            {
                booking = new Booking(Rental_V_ID.Text,rental_cus_ID.Text,BookingDate.Text,"Book");
                booking.BookVideo();
                
            }
            else {
                MessageBox.Show("select the video or member for the booking ");
            }


            Rental_V_ID.Text = "";
            title_v.Text = "";
            rating_v.Text = "";
            year_v.Text = "";
            copy_v.Text = "";
            plot_v.Text = "";
            genre_v.Text = "";

            rental_cus_ID.Text = "";
            name_c.Text = "";
            email_c.Text = "";
            address_c.Text = "";

            lblRental_ID.Text = "";
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (lblRental_ID.Text.ToString().Equals(""))
            {
                MessageBox.Show("select the rental video to return  ");
                
            }
            else
            {
                booking = new Booking(Rental_V_ID.Text, rental_cus_ID.Text, BookingDate.Text,ReturnDate.Text);
                booking.ReturnBooking(Convert.ToInt32(lblRental_ID.Text.ToString()));
            }


            Rental_V_ID.Text = "";
            title_v.Text = "";
            rating_v.Text = "";
            year_v.Text = "";
            copy_v.Text = "";
            plot_v.Text = "";
            genre_v.Text = "";

            rental_cus_ID.Text = "";
            name_c.Text = "";
            email_c.Text = "";
            address_c.Text = "";

            lblRental_ID.Text = "";
        }

        private void show_video_Click(object sender, EventArgs e)
        {
            //get the record from the table of movie
            video.GetVideoRecord(dataTable);
            lblOption.Text = "movie";
        }

        private void show_rental_Click(object sender, EventArgs e)
        {
            //get the record from the table of booking
            booking.GetBookingRecord(dataTable);
            lblOption.Text = "rental";
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblOption.Text.Equals("rental"))
            {
                lblRental_ID.Text = dataTable.CurrentRow.Cells[0].Value.ToString();
                Rental_V_ID.Text = dataTable.CurrentRow.Cells[1].Value.ToString();
                rental_cus_ID.Text = dataTable.CurrentRow.Cells[2].Value.ToString();
            }
            else if (lblOption.Text.Equals("movie"))
            {
                Rental_V_ID.Text = dataTable.CurrentRow.Cells[0].Value.ToString();
                title_v.Text = dataTable.CurrentRow.Cells[1].Value.ToString();
                rating_v.Text = dataTable.CurrentRow.Cells[2].Value.ToString();
                year_v.Text = dataTable.CurrentRow.Cells[3].Value.ToString();
                copy_v.Text = dataTable.CurrentRow.Cells[5].Value.ToString();
                plot_v.Text = dataTable.CurrentRow.Cells[6].Value.ToString();
                genre_v.Text = dataTable.CurrentRow.Cells[7].Value.ToString();

            }
            else if (lblOption.Text.Equals("member"))
            {
                rental_cus_ID.Text= dataTable.CurrentRow.Cells[0].Value.ToString();
                name_c.Text= dataTable.CurrentRow.Cells[1].Value.ToString();
                email_c.Text= dataTable.CurrentRow.Cells[2].Value.ToString();
                address_c.Text= dataTable.CurrentRow.Cells[3].Value.ToString();
            }
            else {

            }

            lblOption.Text = "";
        }

        private void good_cus_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData =member.searchOperation("select * from Member");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 =member.searchOperation("select * from Booking where MID=" + Convert.ToInt32(tblData.Rows[x]["MID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Most Movies Booked By Cusotmer  :" + Title);

        }

        private void high_rented_v_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData = member.searchOperation("select * from Movie");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = member.searchOperation("select * from Booking where VID=" + Convert.ToInt32(tblData.Rows[x]["VID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Best Movie of the store is  :" + Title);

        }
    }
}
