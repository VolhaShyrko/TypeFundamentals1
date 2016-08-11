namespace TypeFundamentals1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public bool Equals(Person obj)
        {
            if (obj == null) return false;

            return obj.FirstName == this.FirstName && obj.LastName == this.LastName;
        }

        public override int GetHashCode()
        {
            var a = this.FirstName.GetHashCode();
            var b = this.LastName.GetHashCode();
            return a ^ b;
        }
    }
}
