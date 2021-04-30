using AWSPractico1.Data;
using AWSPractico1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSPractico1.Repositories
{
    public class RepositoryCoches
    {
        CochesContext Context;

        public RepositoryCoches(CochesContext context)
        {
            this.Context = context;
        }

        public List<Coche> GetCoches()
        {
            return this.Context.Coches.ToList();
        }

        public Coche FindCoche(int id)
        {
            return this.Context.Coches.SingleOrDefault(x => x.IdCoche == id);
        }
    }
}
