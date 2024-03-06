

using Business.Concrate;
using Entities.Concrate;

public class Program
{
    private static void Main(string[] args)
    {
        Person person2 = new Person();
        person2.FirstName = "Muharrem";
        person2.LastName = "Gündoğan";
        person2.DateOfBirthYear = 1993;
        person2.NationalIdentity = 62536723;

        PharmacyManager pharmacyManager = new PharmacyManager(new ForeignerManager());
        pharmacyManager.GiveMask(person2);

        Person person1 = new Person();
        person1.FirstName = "begüm";
        person1.LastName = "gündoğan";
        person1.NationalIdentity = 672340;
        person1.DateOfBirthYear = 1993;
       PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
}



// pttmanager dan bir yeni bir nesne oluşturulurken bizden bunun person mı yoksa foreiner olup olmadıgını belirtmemizi istiyor.
// sonrasında bunu dependency injection ile ptt manager da belirtiyoruz ve sonrasın metot burdan gelen veriler dogrultusunda çalışıyor.