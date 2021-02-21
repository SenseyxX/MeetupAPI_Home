﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mag.Entities
{
        public class Quality
        {
                public int Id { get; set; }
                public int QualityNumber { get; set; }
                public string Description { get; set; }


                public virtual Item Item { get; set; }
        }
}
