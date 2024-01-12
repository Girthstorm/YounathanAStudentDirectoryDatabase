
using YounathanAStudentDirectoryDatabase.Models;

namespace YounathanAStudentDirectoryDatabase.Services;

    public interface IStudentDirectoryService
    {
        List<Student> UpdateStudent(string oldFirstName, string newFirstName, string newLastName, string newHobby);

        List<Student> AddStudent(string firstName, string lastName, string hobby);

        List<Student> DeleteStudent(string firstName);

        List<Student> GetStudents();
    }
