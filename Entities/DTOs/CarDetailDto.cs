﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IEntity
    {
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
    }
}
