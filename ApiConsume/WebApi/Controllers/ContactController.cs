using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteContact(Contact contact)
        {
            _contactService.TDelete(contact);
            return Ok();
        }

        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult InboxGetByIdContact(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }

        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            var values = _contactService.TGetContactCount();
            return Ok(values);
        }
    }
}
