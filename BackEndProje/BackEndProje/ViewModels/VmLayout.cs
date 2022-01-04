﻿using BackEndProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.ViewModels
{
    public class VmLayout
    {
        public Setting Setting { get; set; }
        public List<Social> Socials { get; set; }
        public Banner Banner { get; set; }
    }
}
