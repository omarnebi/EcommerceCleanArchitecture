using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceCleanArchitecture.Domain.Entities
{
    public class Produit
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public decimal Prix { get; set; }
        public int Quantite { get; set; }
    }
}
