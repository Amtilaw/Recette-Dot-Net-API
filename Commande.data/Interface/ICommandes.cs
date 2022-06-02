using System.Collections.Generic;
using Commande.Data.Model;

namespace Commandes.Data.Interface
{
    public interface ICommandes
    {
        List<Commande> GetAllCommande();
        Commande GetCommande(int id);
    }
}