﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eshopsolution_data.entitys
{
    public class AppRole:IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
