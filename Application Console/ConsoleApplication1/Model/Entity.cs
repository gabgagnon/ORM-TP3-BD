﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1.Model
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
