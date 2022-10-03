using RPG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Data.Common
{
    public class RPGRepository : Repository, IRPGRepository
    {
        public RPGRepository(RPGContext context)
        {
            this.Context = context;
        }
    }
}
