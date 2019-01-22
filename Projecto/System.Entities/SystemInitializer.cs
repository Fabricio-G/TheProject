using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities
{
    public class SystemInitializer //: IDatabaseInitializer<SystemContext>
    {
        public bool nueva=false;
        public void InitializeDatabase(SystemContext context)
        {
            bool dbExists;
            dbExists = context.Database.EnsureCreated();
            /*if (dbExists)
            {
                try
                {
                    if (!context.Database.CompatibleWithModel(true))
                    {
                        throw new Exception("La base de datos existe y no es compatible...");
                    }
                }
                catch
                {
                    return;
                }
            }
            else
            {
                context.Database.Create();
                context.SaveChanges();
                nueva = true;
                return;
            }*/
            return;
        }

       
        public void CreateUser(SystemContext context)
        {
            
        }

        protected void Seed(SystemContext context)
        
        {

        }
    }
}