
using Microsoft.AspNetCore.Mvc;
using YounathanAStudentDirectoryDatabase.Models;
using YounathanAStudentDirectoryDatabase.Services;

namespace YounathanAStudentDirectoryDatabase.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class StudentDirectoryController : ControllerBase
    {
        private readonly IStudentDirectoryService _studentDirectory;
        public StudentDirectoryController(IStudentDirectoryService studentDirectory)
        {
            _studentDirectory = studentDirectory;
        }
        

        [HttpGet] 
        [Route("GetStudents")]
        public List<Student> GetStudents()
        {
            return _studentDirectory.GetStudents();
        }

        [HttpPost]
        [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            return _studentDirectory.AddStudent(firstName, lastName, hobby);
        }

        [HttpPut] // use Put to update data
        [Route("EditStudent/{oldFirstName}/{newFirstName}/{newLastName}/{newHobby}")]
        public List<Student> UpdateStudent(string oldFirstName, string newFirstName, string newLastName, string newHobby)
        {
            return _studentDirectory.UpdateStudent(oldFirstName, newFirstName, newLastName, newHobby);
        }





        [HttpDelete] // use Delete to delete data - not really don't do this
        [Route("DeleteStudent/{firstName}")]
        public List<Student> DeleteStudent(string firstName)
        {
            return _studentDirectory.DeleteStudent(firstName);
        }
    }
