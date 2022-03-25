using System.Collections.Generic;

namespace SubnauticaMVC.Models
{
    public interface IFaunaRepository
    {
        IEnumerable<Fauna> GetAllFauna { get; }
        IEnumerable<Fauna> GetHerbivoresFauna { get; }
        Fauna GetFauna(int faunaId);
    }
}
