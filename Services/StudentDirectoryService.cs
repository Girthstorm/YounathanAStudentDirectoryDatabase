
using YounathanAStudentDirectoryDatabase.Data;
using YounathanAStudentDirectoryDatabase.Models;

namespace YounathanAStudentDirectoryDatabase.Services;

    public class StudentDirectoryService : IStudentDirectoryService
    {
    private readonly DataContext _db;

    public StudentDirectoryService(DataContext db)
    {
        
        _db = db;
    }
        //change from string to name of database or whatver
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            Student newStudent = new();
            newStudent.firstName = firstName;
            newStudent.lastName = lastName;
            newStudent.hobby = hobby;
            _db.Students.Add(newStudent);
            _db.SaveChanges();
            return _db.Students.ToList();
        }

        public List<Student> DeleteStudent(string firstName)
        {
            var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.firstName == firstName);
            if(student != null) {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            return _db.Students.ToList();
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }


        public List<Student> UpdateStudent(string oldFirstName, string newFirstName, string newLastName, string newHobby)
        {
            var foundStudent = _db.Students.FirstOrDefault(foundStudent => foundStudent.firstName == oldFirstName);
            if(foundStudent != null) {
                foundStudent.firstName = newFirstName;
                foundStudent.lastName = newLastName;
                foundStudent.hobby = newHobby;
            _db.SaveChanges();
            }
            return _db.Students.ToList();
        }
    
}
