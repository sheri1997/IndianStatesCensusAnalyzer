using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer.POCO
{
    public class CensusDTO
    {
        //defining class members which will be similar as entries in csv file.
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;
        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;
        }
        public CensusDTO(CensusDataDAO censusDao)
        {
            this.state = censusDao.state;
            this.population = censusDao.population;
            this.area = censusDao.area;
            this.density = censusDao.density;
        }
    }
}
