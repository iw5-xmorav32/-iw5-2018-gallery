﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Galerry.App.Models.Base;

namespace Galerry.App.Models
{
    public class Album : IBaseModel
    {
        public string Name { get; set; }
    }
}
