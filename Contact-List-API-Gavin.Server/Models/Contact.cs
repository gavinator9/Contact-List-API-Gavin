namespace Contact_List_API_Gavin.Server.Models
{
    public class Contact
    {
        public int contactid { get; set; }
        public int customerid { get; set; }
        public Customer customer { get; set; }
        public string calldate { get; set; }
        public string notes { get; set; }
    }
}
