using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_project_fr
{
    public class Booking: Video
    {
        public String VideoID { get; set; }
        public String MemberID { get; set; }
        public String BookingDate { get; set; }
        public String ReturnStatus { get; set; }

        //default constructur
        public Booking() {

        }

        //parameterized constructor
        public Booking(String V_ID,String M_ID,String Booking_Date,String Return_Status) {
            VideoID = V_ID;
            MemberID = M_ID;
            BookingDate = Booking_Date;
            ReturnStatus = Return_Status;
        }


        //before the booking we must have chk further things like customer booking 
        public Boolean BookVideo() {
            //check the booking of the Cutomer
            if (countBooking(Convert.ToInt32(MemberID)) < 2)
            {
                if (countBookingVideo(Convert.ToInt32(VideoID)) < countCopy(Convert.ToInt32(VideoID)))
                {

                    databaseOperation("insert into Booking(VID,MID,BookingDate,ReturnStatus) values('" + VideoID + "','" + MemberID + "','" + BookingDate + "','" + ReturnStatus + "')");
                    MessageBox.Show("Video is Booked ");
                    return true;
                }
                else {
                    MessageBox.Show("All Copies are booked ");
                    return false;
                }
            }
            else {
                MessageBox.Show("Sorry you can't book moree videos ");
                return false;
                
            }

        }

        //delete the rental booking 
        public Boolean deleteBooking(int Rental_ID) {
            databaseOperation("delete from Booking where ID=" + Rental_ID + "");
            MessageBox.Show("Select Rental video record is deleted ");
            return true;
        }


        public Boolean ReturnBooking(int Rental_ID) {

            DateTime curnt_date = DateTime.Now;


            //convert the old date from string to Date fromat
            DateTime old_date = Convert.ToDateTime(BookingDate);


            //get the difference in the days fromat
            String Daysdiff = (curnt_date - old_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

            int cost = countCost(Convert.ToInt32(VideoID));


            int Charges = Convert.ToInt32(DaysInterval) * cost;



            databaseOperation("Update Booking set VID='"+VideoID+"',MID='"+MemberID+"',BookingDate='"+BookingDate+"',ReturnStatus='"+ReturnStatus+"' where ID="+Rental_ID+"");
            MessageBox.Show("Video is Retruned and Charges is $"+Charges);
            return true;


        }

        //get the record from the table 
        public void GetBookingRecord(DataGridView dgv)
        {
            DataTable table = new DataTable();
            table = searchOperation("select * from Booking");
            dgv.Refresh();
            dgv.DataSource = table;
        }


    }

}
