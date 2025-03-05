namespace KretaProject.Models
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string ClassId { get; set; }

        public SchoolClass(string classId)
        {
            if (string.IsNullOrWhiteSpace(classId))
                throw new ArgumentException("ClassId cannot be empty or null.");

            ClassId = classId;
        }

        public override string ToString()
        {
            return $"{Id}. {ClassId}";
        }
    }
}
