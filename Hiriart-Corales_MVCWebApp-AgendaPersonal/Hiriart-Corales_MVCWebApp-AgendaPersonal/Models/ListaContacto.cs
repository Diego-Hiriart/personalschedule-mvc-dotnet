﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hiriart_Corales_MVCWebApp_AgendaPersonal.Models
{
    public class ListaContacto
    {
        public int ListaContactoID { get; set; }
        public int IDEvento { get; set; }
        public int IDContacto { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}