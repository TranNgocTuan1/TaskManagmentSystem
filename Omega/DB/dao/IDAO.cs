using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega.DB.dao
{
    public interface IDAO<T>
    {
        public void Insert(T obj);
        public void Update(T obj);
        public void Delete(int id);
        public T GetById(int id);
        public List<T> Select();
    }
}
