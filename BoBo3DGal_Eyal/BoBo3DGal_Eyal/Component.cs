using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public abstract class Component : Icomponent
    {
        public abstract GameObject GetSetParentGameObject { get; set; }

    }
}