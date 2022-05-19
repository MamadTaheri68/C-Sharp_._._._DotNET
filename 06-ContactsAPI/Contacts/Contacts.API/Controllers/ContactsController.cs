using Contacts.API.DataAccessLayer;
using Contacts.API.Models.DTOs;
using Contacts.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contacts.API.Controllers
{
    [ApiController]
    [Route("api/v2020/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactAPIDbContext _dbContext;

        public ContactsController(ContactAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(_dbContext.Contacts.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpGet]
        [Route("getAsync")]
        public async Task<IActionResult> GetContactsAsync()
        {
            return Ok(await _dbContext.Contacts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddContat(AddContactRequest addContactRequest)
        {
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                Address = addContactRequest.Address,
                Email = addContactRequest.Email,
                FullName = addContactRequest.FullName,
                Phone = addContactRequest.Phone,
            };
            await _dbContext.Contacts.AddAsync(contact);
            _dbContext.SaveChanges();

            return Ok(contact);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest updateContactRequest)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);
            if (contact != null)
            {
                contact.FullName = updateContactRequest.FullName;
                contact.Address = updateContactRequest.Address;
                contact.Phone = updateContactRequest.Phone;
                contact.Email = updateContactRequest.Email;

                await _dbContext.SaveChangesAsync();

                return Ok(contact);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletContact([FromRoute] Guid id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                _dbContext.Contacts.Remove(contact);
                await _dbContext.SaveChangesAsync();
                return Ok("deleted succesfully");
            }
            return NotFound();
        }
    }
}
