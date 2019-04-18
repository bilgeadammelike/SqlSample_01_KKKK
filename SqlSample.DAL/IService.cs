using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    public interface IService<T>
    {
        List<T> Select();

        T SelectByID(object ID);

        int Insert(T inserted);

        int Update(T updated);

        int Delete(object ID, bool isHardDelete);
    }
}
