using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace metier_precis
{
    class Building
    {
        public double _hauteur;
        public int _nombreEtages;

        public Building(int nombreEtages) : this(nombreEtages, nombreEtages)
        {
            _nombreEtages = nombreEtages;
            _hauteur = 3 * nombreEtages;
        }
        public Building(int nombreEtages, double hauteur) 
        {
            _nombreEtages = nombreEtages;
            _hauteur = hauteur;
        }

      

        public double GetSize() {  return _hauteur; }
        public int GetFloorCount() { return _nombreEtages; }


        public double GetFloorMaxSize()
        {
            double heigth = GetSize();
            int nFloors = GetFloorCount();
            double floorSize = heigth/nFloors;
            return floorSize;
        }

        

    }
}
