﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDAOJuego
    {
        List<DTOJuego> ListarTodosJuegos();
    }
}