using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Domain;
using System.Collections.Generic;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
        

       

       
    }
}
