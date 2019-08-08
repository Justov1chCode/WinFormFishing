using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Assembly
    {
        public Road proad;
        public Reel reel;
        public FLine fLine;
        public Lure lure;
        public ROAD_TYPE roadType;
        public string name;
        public Assembly(string name, Road road, Reel reel, FLine fLine, Lure lure, ROAD_TYPE roadType)
        {
            this.proad = road;
            this.reel = reel;
            this.fLine = fLine;
            
            this.lure = lure;
            this.roadType = roadType;
            this.name = name;

        }
        private static List<Assembly> assemblies = new List<Assembly>();

        public static void addAssembly(Assembly assembly)
        {
            assemblies.Add(assembly);
        }
        public static List<Assembly> GetAssemblies()
        {
            return assemblies;
        }
    }
}
