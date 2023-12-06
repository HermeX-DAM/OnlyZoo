using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo_Project.Data
{
    public interface IData<T>
    {
        public List<T> GetAll();
    }
}
