using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class EditModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public String em = "";
        public String sm = "";
      
        public void OnGet()
        {
            int id = Convert.ToInt32(Request.Query["studentid"]);
            String name = Request.Query["studentname"];
           // String phone = Request.Query["phone"];
            try
            {
                String cs = "Data Source=NLTI155\\SQLEXPRESS;Initial Catalog=StudentInformation;Integrated Security=True";
                using (SqlConnection c = new SqlConnection(cs))
                {
                    c.Open();
                    String sql = "SELECT * FROM Studentdetails WHERE studentid=@studentid";
                    using (SqlCommand cmd = new SqlCommand(sql, c))
                    {
                        cmd.Parameters.AddWithValue("@studentid", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clientInfo.id =  reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                              
                             
                                clientInfo.Mobilenumber = reader.GetString(2);
                               
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                em = ex.Message;
            }

        }
        public void OnPost()
        {
           clientInfo.id =Convert.ToInt32( Request.Form["studentid"]);
            clientInfo.name = Request.Form["studentname"];
            clientInfo.Mobilenumber = Request.Form["mobilenumber"];
           
            //if (clientInfo.id == null || clientInfo.name == null || clientInfo.Mobilenumber == null)
            //{
            //    em = "All fields should be filled";
            //    return;
            //}
            try
            {
                String cs = "Data Source=NLTI155\\SQLEXPRESS;Initial Catalog=StudentInformation;Integrated Security=True";
                using (SqlConnection c = new SqlConnection(cs))
                {
                    c.Open();
                    String sql = "UPDATE Studentdetails" +
                        " SET studentname=@studentname, phone=@mobilenumber" + " WHERE studentid=@studentid";
                    using (SqlCommand cmd = new SqlCommand(sql, c))
                    {
                        cmd.Parameters.AddWithValue("@Studentid", clientInfo.id);
                        cmd.Parameters.AddWithValue("@studentname", clientInfo.name);
                        
                        cmd.Parameters.AddWithValue("@mobilenumber", clientInfo.Mobilenumber);
                      


                        cmd.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception ex)
            {
                em = ex.Message;
                return;
            }
            Response.Redirect("/Clients/Index");
        }
    }
}
        