namespace DSS.Models2
{
    public enum gender {Male, Female};

    public class Man
    {
        public string LastName = "" ;

        public string FirstName = "" ;

        public Gender Gender = Gender.Male;

        public string Nationality = "";

        public PostalAdress Address = new PostalAdress() {
            Street = "",
            City = "",
            PostalCode = "",
            State = ""
        };

    
    }
}