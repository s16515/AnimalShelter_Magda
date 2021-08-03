﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    public class Treatment:BaseEntity
    {
        public string Name { get; set; }
       

        public virtual ICollection<PerformedTreatment> PerformedTreatments { get; set; }

    }
}
