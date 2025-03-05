using KretaProject.Models;

namespace KretaProject.Repos
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> schoolClasses = new List<SchoolClass>();

        public void AddClass(SchoolClass schoolClass)
        {
            if (schoolClass == null)
                throw new ArgumentNullException(nameof(schoolClass));

            schoolClasses.Add(schoolClass);
        }

        public bool UpdateClassName(int id, string newClassId)
        {
            var schoolClass = schoolClasses.FirstOrDefault(sc => sc.Id == id);
            if (schoolClass == null || string.IsNullOrWhiteSpace(newClassId))
                return false;

            schoolClass.ClassId = newClassId;
            return true;
        }

        public List<SchoolClass> GetAllClasses()
        {
            return schoolClasses;
        }
    }
}
