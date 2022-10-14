namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Console.WriteLine("Choose a option");

            Console.WriteLine("1. Insert contact");
            Console.WriteLine("2. Update contact");
            Console.WriteLine("3. Delete contact");
            int option=Convert.ToInt32(Console.ReadLine());

            ContactModel contact = new ContactModel();
            switch (option)
            {
                case 1:
                    InsertContact insert = new InsertContact();
                    
                    contact.FirstName = "Muskan";
                    contact.LastName = "Pathak";
                    contact.Address = "Ujjain";
                    contact.City = "Ujjain";
                    contact.State = "Madhya Pradesh";
                    contact.Zip = 456601;
                    contact.PhoneNumber = 7755869423;
                    contact.Email = "muskan@gmail.com";
                    
                    insert.AddContact(contact);
                    break;

                 case 2:
                    EditContact edit = new EditContact();
                    contact.FirstName = "Muskan";
                    contact.Address = "Indore";
                    contact.City = "Indore";
                    contact.Zip = 456661;
                    edit.UpdateContact(contact);
                    break;
                case 3:
                    DeleteContact delete = new DeleteContact();
                    delete.DeleteContactDetails();
                    break;
                default:
                    Console.WriteLine("choose correact option");
                    break;
            }


            
        }
    }
}