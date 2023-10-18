namespace WinFormsAnket
{
    public class Worker
    {
        public string Surname { get;set;}
        public string Name { get;set;}
        public string FatherName { get;set;}
        public string Country { get;set;}
        public string City { get;set;}
        public string Phone {  get;set;}
        public string Mail { get;set;}
        public DateTime Date { get;set;}
        public Worker() { }
        public Worker(string surname, string name, string fatherName, string country, string city, string phone, DateTime date, string mail)
        {
            Surname = surname;
            Name = name;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Date = date;
            Mail = mail;
        }
    }
}
