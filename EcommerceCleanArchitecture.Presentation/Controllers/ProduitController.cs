using EcommerceCleanArchitecture.Application.Interfaces;
using EcommerceCleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCleanArchitecture.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IProduitRepository _produitRepository;
        public ProduitController(IProduitRepository produitRepository)
        {
            _produitRepository = produitRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produit>> GetAll()
        {
            return Ok(_produitRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Produit> GetById(int id)
        {
            var produit = _produitRepository.GetById(id);
            if (produit == null)
            {
                return NotFound();
            }
            return Ok(produit);
        }

        [HttpPost]
        public IActionResult Add(Produit produit)
        {
            _produitRepository.Add(produit);
            return CreatedAtAction(nameof(GetById), new { id = produit.Id }, produit);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Produit produit)
        {
            if (id != produit.Id)
            {
                return BadRequest();
            }

            _produitRepository.Update(produit);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _produitRepository.Delete(id);
            return NoContent();
        }
    }
}
