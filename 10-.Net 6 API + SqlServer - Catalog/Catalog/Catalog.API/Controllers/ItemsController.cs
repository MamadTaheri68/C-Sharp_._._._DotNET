﻿using Catalog.API.Dtos;
using Catalog.API.Entities;
using Catalog.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController: ControllerBase
    {
        private readonly IItemsRepository _repository;

        public ItemsController(IItemsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = _repository.GetItems().Select(q => q.AsDto()).ToList();

            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = _repository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return Ok(item.AsDto());
        }

        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };


            _repository.CreateItem(item);

            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item.AsDto());
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDto itemDto)
        {
            var exisingItem = _repository.GetItem(id);

            if(exisingItem is null)
            {
                return NotFound();
            }

            Item updatedItem = exisingItem with
            {
                Name = itemDto.Name,
                Price = itemDto.Price,
            };

            _repository.UpdateItem(updatedItem);

            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id)
        {
            var existingItem = _repository.GetItem(id);

            if(existingItem is null)
            {
                return NotFound();
            }

            _repository.DeleteItem(id);

            return Ok("Deleted Successfully");
        }

    }
}
