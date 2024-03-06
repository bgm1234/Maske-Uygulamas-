using Business.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class PharmacyManager : ISupplierService
    {
        private IApplicantService _applicationservice;

        public PharmacyManager(IApplicantService applicationservice)
        {
            _applicationservice = applicationservice;
        }
        public void GiveMask(Person person)
        {
            Console.WriteLine(person.FirstName + " icin eczane maske verdi.");
        }
    }
}
