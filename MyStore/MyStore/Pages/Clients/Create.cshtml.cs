using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo=new ClientInfo();
        public string em = "";
        public string sm = "";
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            //clientInfo.id =Convert.ToInt32( Request.Form["Studentid"]);
            clientInfo.name = Request.Form["studentname"];
           
           
            clientInfo.Mobilenumber = Request.Form["mobilenumber"];
           
           

            if(clientInfo.name==null || clientInfo.Mobilenumber==null)
            {
                em = "All fields should be filled";
                return;
            }

            try
            {
                String cs = "Data Source=NLTI155\\SQLEXPRESS;Initial Catalog=StudentInformation;Integrated Security=True";
                using (SqlConnection c = new SqlConnection(cs))
                {
                    c.Open();
                    String sql = "insert into Studentdetails (studentname,phone)\r\nvalues (@studentname,@mobilenumber);";
                    using (SqlCommand cmd = new SqlCommand(sql, c))
                    {
                       // cmd.Parameters.AddWithValue("@studentid", clientInfo.id);
                        cmd.Parameters.AddWithValue("@studentname", clientInfo.name);
                      
                        cmd.Parameters.AddWithValue("@mobilenumber", clientInfo.Mobilenumber);
                     
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {
                em = e.Message;
                return;
            }
          //  clientInfo.id = "";
            clientInfo.name = "";
           
            clientInfo.Mobilenumber = "";
           
           sm ="New Client Added";

        }
    }
}
