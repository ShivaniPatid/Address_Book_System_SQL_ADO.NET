namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            ContactModel contact = new ContactModel();
            InsertContact insert = new InsertContact();
            /*
            contact.FirstName = "Muskan";
            contact.LastName = "Pathak";
            contact.Address = "Ujjain";
            contact.City = "Ujjain";
            contact.State = "Madhya Pradesh";
            contact.Zip = 456601;
            contact.PhoneNumber = 7755869423;
            contact.Email = "muskan@gmail.com";
            */
            //insert.AddContact(contact);

            EditContact edit = new EditContact();
            contact.FirstName = "Muskan";
            contact.Address = "Indore";
            contact.City = "Indore";
            contact.Zip = 456661;
            edit.UpdateContact(contact);
        }
    }
}