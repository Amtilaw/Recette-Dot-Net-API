using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commande.Data.Model
{
    public class Commande
    {
        public int CommandeId { get; set; }
        public string Entree { get; set; }
        public string  Plat { get; set; }
        public string Dessert { get; set; }
        public string Boisson { get; set; }
        public string Situation { get; set; }

    }
}