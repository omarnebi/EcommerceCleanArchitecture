using EcommerceCleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceCleanArchitecture.Application.Interfaces
{
    public interface IProduitRepository
    {
        IEnumerable<Produit> GetAll();
        Produit GetById(int id);
        void Add(Produit produit);
        void Update(Produit produit);
        void Delete(int id);
    }
}
