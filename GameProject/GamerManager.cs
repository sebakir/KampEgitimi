using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Dogrulama basarisiz . Kayit basarisiz..");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }
    }
}
