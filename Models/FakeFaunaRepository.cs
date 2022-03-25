using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubnauticaMVC.Models
{
    public class FakeFaunaRepository : IFaunaRepository
    {
        private readonly ICategoryRepository categoryRepository = new FakeCategoryRepository();

        public IEnumerable<Fauna> GetAllFauna =>
            new List<Fauna>
            {

            };

        public IEnumerable<Fauna> GetHerbivoresFauna => throw new NotImplementedException();

        public Fauna GetFauna(int faunaId)
        {
            throw new NotImplementedException();
        }
    }
}
