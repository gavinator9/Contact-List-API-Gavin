namespace Contact_List_API_Gavin.Server.Models
{
    public class Customer
    {
        public int customerid { get; set; }
        public string phonenumber { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public ICollection<Contact> contacts { get; set;}
    }
}
