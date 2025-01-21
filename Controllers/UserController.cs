using AJAX_CRUD_Create_WEBAPI.Data;
using AJAX_CRUD_Create_WEBAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AJAX_CRUD_Create_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<UserRegistration>> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        // GET: api/User/{id}
        [HttpGet("{id}")]
        public ActionResult<UserRegistration> GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/User
        [HttpPost]
        public ActionResult<UserRegistration> AddUser([FromBody] UserRegistration user)
        {
            if (user == null)
            {
                return BadRequest("User data is required.");
            }

            bool result = _userRepository.AddUser(user.Name, user);

            if (result)
            {
                return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
            }

            return BadRequest("Error adding user.");
        }

        // PUT: api/User/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] UserRegistration user)
        {
            if (id != user.Id)
            {
                return BadRequest("User ID mismatch.");
            }

            bool result = _userRepository.UpdateUser(user);

            if (result)
            {
                return NoContent();
            }

            return NotFound();
        }

        // DELETE: api/User/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            bool result = _userRepository.DeleteUser(id);

            if (result)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
