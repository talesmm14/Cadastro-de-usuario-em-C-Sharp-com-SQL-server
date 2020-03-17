﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    interface IDaoUsuario <T>
    {
        void create();
        void update();
        void delete();
        T findById();
    }
}
