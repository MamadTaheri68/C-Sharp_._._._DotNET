using Catalog.API.Entities;
using Catalog.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController: ControllerBase
    {
        private readonly InMemItemsRepository _repository;

        public ItemsController()
        {
            _repository = new InMemItemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = _repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = _repository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return Ok(item);
        }


    }
}
