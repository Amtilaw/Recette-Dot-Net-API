using Commandes.Data.Interface;
using Commande.Data.Model;
using Commande.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CommandeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {
        private ICommandes commandes = new CommandesRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Commandes>> GetAllCommandes()
        {
            return commandes.GetAllCommande();
        }
        [HttpGet]
        public ActionResult<Commandes> GetCommandeById(int id)
        {
            return commandes.GetCommande(id);
        }
    }
}