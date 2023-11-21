using KCrud.Models;
using Microsoft.AspNetCore.Mvc;


namespace KCrud.Controllers
{
    [Route("contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private List<Contact> contacts = new List<Contact> {
            new Contact { Id = 1, FirstName = "Prakash", LastName = "K", NickName = "DP", Age = 22 },
            new Contact { Id = 2, FirstName = "Vamsi", LastName = "K", NickName = "Sai", Age = 20 },
            new Contact { Id = 3, FirstName = "Hari", LastName= "B",NickName = "Hari",Age=30 },
             new Contact { Id = 4, FirstName = "Vamsi", LastName = "KA", NickName = "Vamsi", Age = 40 },
              new Contact { Id = 5, FirstName = "Krishna", LastName = "A", NickName = "Krishn", Age = 25 }
        };



        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            return contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound(new { Message = "Contact has not been found." });
            }

            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public ActionResult<IEnumerable<Contact>> Post(Contact newContact)
        {
            newContact.Id = contacts.Count+1;
            contacts.Add(newContact);
            return contacts;
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contact>> Put(int id, Contact updatedContact)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.NickName = updatedContact.NickName;
            contact.IsDeleted = updatedContact.IsDeleted;

            return contacts;
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contact>> Delete(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            contacts.Remove(contact);

            return contacts;
        }

      
    }
}
