using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_project_fr
{
    public class Video : Member
    {
        public String Title { get; set; }
        public String Ratting { get; set; }
        public String Year { get; set; }
        public String Copies { get; set; }
        public String Plot { get; set; }
        public String Genre { get; set; }
        public String Cost { get; set; }






        //default constructor 
        public Video() {

        }
        //parameterized constructor
        public Video(String vTitle, String vRatting, String vYear, String vCopies, String vPlot, String vGenre) {
            Title = vTitle;
            Ratting = vRatting;
            Year = vYear;
            Copies = vCopies;
            Plot = vPlot;
            Genre = vGenre;
            //dislay the cost of the price of the video after adding the year of the video
            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Convert.ToInt32(Year);
            int cost = 0;
            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                cost = 2;
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                cost = 5;

            }
            Cost = cost.ToString();
        }

        //pass the values to store into the database
        public Boolean InsertVideo() {
            databaseOperation("insert into Movie (Title,Point,Year,Cost,Copies,Plot,Genre) values('" + Title + "','" + Ratting + "','" + Year + "','" + Cost + "','" + Copies + "','" + Plot + "','" + Genre + "')");
            return true;
        }


        //code to delete the video from teh record 
        public Boolean deleteVideo(int MovieID) {
            if (countBookingVideo(MovieID) == 0)
            {
                databaseOperation("delete from Movie where VID=" + MovieID + "");
                return true;
            }
            else {
                return false;
            }
            
        }

        public Boolean updateVideo(int MovieID) {
            databaseOperation("Update Movie set Title='"+Title+"',Point='"+Ratting+"',Year='"+Year+"',Cost='"+Cost+"',Copies='"+Copies+"',Plot='"+Plot+"',Genre='"+Genre+"' where VID="+MovieID+"");
            return true;
        }

        public int countBookingVideo(int MovieID) {
            DataTable table = new DataTable();
            table = searchOperation("select * from Booking where VID=" + MovieID + " and ReturnStatus='Book'");
            return table.Rows.Count;
        }

        //count how much copies we have 
        public int countCopy(int MovieID)
        {
            DataTable table = new DataTable();
            table = searchOperation("select * from Movie where VID=" + MovieID + " ");
            return Convert.ToInt32(table.Rows[0]["Copies"].ToString());
        }


        //count how much copies we have 
        public int countCost(int MovieID)
        {
            DataTable table = new DataTable();
            table = searchOperation("select * from Movie where VID=" + MovieID + "");
            return Convert.ToInt32(table.Rows[0]["Cost"].ToString());
        }

        //get the record from the table 
        public void GetVideoRecord(DataGridView dgv)
        {
            DataTable table = new DataTable();
            table = searchOperation("select * from Movie");
            dgv.Refresh();
            dgv.DataSource = table;
        }

    }
}
