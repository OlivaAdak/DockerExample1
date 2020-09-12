using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetHouseDockerEg.Models
{
    public class PetHouse
    {
        public int PetId { get; set; }
        public string PetType { get; set; }
        public string Age { get; set; }
        public int Price { get; set; }
    }
}
