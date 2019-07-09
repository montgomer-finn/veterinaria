using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class DataBaseCreate
    {
        public static void CreateDataBase()
        {

            using (var context = new EFContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
