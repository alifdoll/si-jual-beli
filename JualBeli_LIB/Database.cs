using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public abstract class Database
    {
        public abstract void Insert();

        public abstract void Update();

        public abstract string Delete();
    }
}
