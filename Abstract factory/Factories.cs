using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class RedFactory : InterfaceFactory
    {
        public Interface CreateFigures() => new FiguresR(); 
    }

    public class BlueFactory : InterfaceFactory
    {
        public Interface CreateFigures() => new FiguresB(); 
    }
    public class GreenFactory : InterfaceFactory
    {
        public Interface CreateFigures() => new FiguresG(); 
    }
    public class YellowFactory : InterfaceFactory
    {
        public Interface CreateFigures() => new FiguresY();
    }
}
