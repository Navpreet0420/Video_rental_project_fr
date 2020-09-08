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
  public  class Member
    {
        //Conn Instance Object of SQl Connection Class
        SqlConnection conn;
        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=VideoCafe;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand cmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader DReader;


        public String Name { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }

        public void databaseOperation(String query)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //method to get the data from the database table and return in the table format     
        public DataTable searchOperation(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }


        //default constructor 
        public Member() {
                
        }
        //paramerterized Constructor
        public Member(String Mem_Name, String Mem_Email, String Mem_Address) {
            Name = Mem_Name;
            Email = Mem_Email;
            Address = Mem_Address;
        }

        //register the member into the database 
        public Boolean RegisterMember() {
            databaseOperation("insert into Member(Name,Email,Address) values ('"+Name+"','"+Email+"','"+Address+"')");
            MessageBox.Show("Member is registered ");
            return true;
        }
        //select the  member to delete from the database 
        public Boolean DeleteMember(int MemberID) {
            if (countBooking(MemberID) == 0)
            {
                databaseOperation("delete from Member where MID=" + MemberID + "");
                return true;
            }
            else {
                MessageBox.Show("You alrady book video so return first");
                return false;
            }
            
            
        }
        public Boolean UpdateMember(int MemberID) {
            databaseOperation("update Member set Name='" + Name + "',Email='"+Email+"',Address='"+Address+"' where MID="+MemberID+"");
            return true;
        }
        //get the record from the table 
        public void GetRecord(DataGridView dgv) {
            DataTable table = new DataTable();
            table = searchOperation("select * from Member");
            dgv.Refresh();
            dgv.DataSource = table;
        }

        //method to chk the booking of the customer how much booking he has done 
        public int countBooking(int MemberID) {
            DataTable table = new DataTable();
            table = searchOperation("select * from Booking where MID="+MemberID+" and ReturnStatus='Book'");
            return table.Rows.Count;
        }
    }
}
