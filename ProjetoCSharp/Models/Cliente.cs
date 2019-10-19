﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Models
{

    [Table("Cliente")]
    public partial class Cliente : Usuario
    {
        public Cliente()
        {   
            CriadoEm = DateTime.Now;
        }

    }
}
