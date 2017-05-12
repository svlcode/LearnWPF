namespace DataTemplateDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}