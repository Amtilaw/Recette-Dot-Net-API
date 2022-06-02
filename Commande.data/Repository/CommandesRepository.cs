using Commandes.Data.Interface;
using Commande.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Commande.Data.Repository
{
    public class CommandesRepository : ICommandes
    {
        List<Commandes> lisCommandes = new List<Commandes>
        {
            new Commandes{CommandeId=1, Entree="Salade", plat="Tomate farci", Dessert="Tarte", Boisson="Coca", Situation="Enregistrer" },
            new Commandes{CommandeId=2, Entree="Cocombre", plat="Tomate farci", Dessert="Banane", Boisson="sprite", Situation="Enregistrer" },
            new Commandes{CommandeId=3, Entree="Charcuterie", plat="Boef Bourgignon", Dessert="Cerise", Boisson="Bierre", Situation="Enregistrer" },
        };
        public List<Commandes> GetAllCommande()
        {
            return lisCommandes;
        }

        public Commandes GetCommande(int id)
        {
            return lisCommandes.FirstOrDefault(x=>x.Commande==id);
        }
    }
}