using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> ListClients = new List<ClientInfo>();
        public void OnGet()
        {
            try
            {
                string cs = "Data Source=NLTI155\\SQLEXPRESS;Initial Catalog=StudentInformation;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    String sql = "Select * From Studentdetails";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                              
                               clientInfo.Mobilenumber = reader.GetString(2);
                               
                                ListClients.Add(clientInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    public class ClientInfo
    {
        public int id;
        public string? name;
        public String? Mobilenumber;

    }
}
