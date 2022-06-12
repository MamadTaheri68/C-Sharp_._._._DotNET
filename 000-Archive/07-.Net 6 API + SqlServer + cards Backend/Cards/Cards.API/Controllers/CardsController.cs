using Cards.API.DataAccessLayer;
using Cards.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cards.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        private readonly CardsDbContext _dbContext;

        public CardsController(CardsDbContext cardsDbContext)
        {
            _dbContext = cardsDbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var cards = await _dbContext.Cards.ToListAsync();
            return Ok(cards);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetCard")]
        public async Task<IActionResult> GetCard([FromRoute] Guid id)
        {
            var card = await _dbContext.Cards.FirstOrDefaultAsync(x => x.Id == id);
            if(card != null)
            {
                return Ok(card);
            }
            return NotFound("Card not found");
        }

        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] Card card)
        {
            card.Id = Guid.NewGuid();
            await _dbContext.Cards.AddAsync(card);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCard), new { id = card.Id }, card);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateCard([FromRoute] Guid id, [FromBody] Card card)
        {
            var _card = await _dbContext.Cards.FirstOrDefaultAsync(q => q.Id == id);
            if(_card != null)
            {
                _card.CardHolderName = card.CardHolderName;
                _card.CardNumber = card.CardNumber;
                _card.ExpiryMonth = card.ExpiryMonth;
                _card.ExpiryYear = card.ExpiryYear;
                _card.CVC = card.CVC;
                await _dbContext.SaveChangesAsync();
                return Ok(_card);
            }
            return NotFound("Card Not Found");
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteCard([FromRoute] Guid id)
        {
            var _card = await _dbContext.Cards.FirstOrDefaultAsync(q => q.Id == id);
            if (_card != null)
            {
                _dbContext.Cards.Remove(_card);
                await _dbContext.SaveChangesAsync();
                return Ok(_card);
            }
            return NotFound("Card Not Found");
        }

    }
}
