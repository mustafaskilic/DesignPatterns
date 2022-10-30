using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalLibrary
{
    public class House
    {
        public int WindowCount { get; set; }
        public string Name { get; set; }
        public bool HasPool { get; set; }
        public bool HasGarage { get; set; }
        public bool HasGarden { get; set; }
    }

    public abstract class HouseBuilder
    {
        public House _house;

        public abstract void GetHouse();
        public abstract void SetWindows();
        public abstract void SetPool();
        public abstract void SetGarage();
        public abstract void SetGarden();
        public abstract House GetResult();
    }

    public class BasicHouseBuilder : HouseBuilder
    {
        public override void GetHouse()
        {
            _house = new House();
            _house.Name = "Basic House in Bağcılar";
        }

        public override void SetGarage() => _house.HasGarage = true;

        public override void SetGarden() => _house.HasGarden = false;

        public override void SetPool() => _house.HasPool = false;

        public override void SetWindows() => _house.WindowCount = 4;

        public override House GetResult() => _house;
    }

    public class LuxuryHouseBuilder : HouseBuilder
    {
        public override void GetHouse()
        {
            _house = new House();
            _house.Name = "Luxury House in Sultanbeyli";
        }

        public override void SetGarage() => _house.HasGarage = true;

        public override void SetGarden() => _house.HasGarden = true;

        public override void SetPool() => _house.HasPool = true;

        public override void SetWindows() => _house.WindowCount = 8;

        public override House GetResult() => _house;
    }

    public class HouseDirector
    {
        private HouseBuilder _houseBuilder;

        public HouseDirector(HouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void Build()
        {
            _houseBuilder.GetHouse();
            _houseBuilder.SetWindows();
            _houseBuilder.SetGarden();
            _houseBuilder.SetGarage();
        }
    }
}
