using APIT5MD2.Domain;
using System;
using System.Collections.Generic;

namespace APIT5MD2.Repository
{
    public interface IPersonRepository
    {
        public IEnumerable<Person> ListAll();
        public int Insert(long step);
    }
}
