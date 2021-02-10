﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }

        public Pet(string bDay)
        {
            Birthday = bDay;
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap 
            {
                int hash = 17;
                hash = hash * 23 + (this.Name != null ? this.Name.GetHashCode() : 0); hash = hash * 23 + (this.Breed != null ? this.Breed.GetHashCode() : 0); return hash;
            }
        }
    }
}
