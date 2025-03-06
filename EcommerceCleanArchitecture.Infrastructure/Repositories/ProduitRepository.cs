using EcommerceCleanArchitecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EcommerceCleanArchitecture.Application.Interfaces;
using EcommerceCleanArchitecture.Domain.Entities;
using EcommerceCleanArchitecture.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceCleanArchitecture.Infrastructure.Repositories
{
    public class ProduitRepository : IProduitRepository
    {
        private readonly ApplicationDbContext _context;

        public ProduitRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produit> GetAll()
        {
            return _context.Produits.ToList();
        }

        public Produit GetById(int id)
        {
            return _context.Produits.Find(id);
        }

        public void Add(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
        }

        public void Update(Produit produit)
        {
            _context.Produits.Update(produit);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
                _context.SaveChanges();
            }
        }
    }
}
