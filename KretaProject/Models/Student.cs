namespace KretaProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsWoman { get; set; }
        public DateOnly BirthDay { get; set; }
        public int SchoolClassId { get; set; }

        public Student(string name, bool isWoman)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or null.");

            Name = name;
            IsWoman = isWoman;
        }

        public override string ToString()
        {
            return $"Student: Id={Id}, Name={Name}, IsWoman={IsWoman}, BirthDay={BirthDay}, SchoolClassId={SchoolClassId}";
        }
    }
}
