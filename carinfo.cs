using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carinfo
{
   
        public interface IInteriorDesign
        {
            void getIInteriorDesign();
        }
        public interface EexteriorDesign
        {
            void getexteriorDesign();
        }
        public enum VehicleType
        {
            car,motorcycle
        }
        public abstract class Vehicle
        {
            public string ModelNo { get; set; }
            public int YearMake { get; set; }
            public VehicleType VehicleType { get; set; }

        }
        public abstract class fourwheeler : Vehicle, IInteriorDesign
        {
            public int NumberOfSeat { get; set; }
            public int NumberOfgear { get; set; }
            public int NumberOfDour { get; set; }
            public float EangineCapacityCC { get; set; }
            public string InteriorDesign { get; set; }


            public void getIInteriorDesign()
            {
                Console.WriteLine($"Car Model: {ModelNo}\n Year: {YearMake}\n " +
                    $"Seats: {NumberOfSeat}\n Gears: {NumberOfgear}\n" +
                    $" Doors: {NumberOfDour}\n Engine: {EangineCapacityCC}CC\n InteriorDesign{InteriorDesign} Type: {VehicleType}\n");
            }
            public abstract class TwoWheeler : Vehicle, EexteriorDesign
            {
                public int NumberOfGears { get; set; }
                public string StartingMethod { get; set; }
                public float EngineCapacityCC { get; set; }
                public float MaxPowerBPH { get; set; }
                public float MaxTorqueNM { get; set; }
                public float MileageKMPL { get; set; }
                public string Cooling { get; set; }
                public string FrontBrake { get; set; }
                public string RearBrake { get; set; }
                public string exteriorDesign { get; set; }
                public void getexteriorDesign()
                {
                    Console.WriteLine($"Car Model: {ModelNo}\n Year: {YearMake}\n " +
                    $"Gears: {NumberOfGears}\n StartingMethod:{StartingMethod}\nEngineCapacityCC:{StartingMethod}\n" +
                    $"MaxPowerBPH:{MaxPowerBPH}\nMaxTorqueNM:{MaxTorqueNM}\nMileageKMPL:{MileageKMPL}\n" +
                    $"Cooling:{Cooling}\nFrontBrake:{FrontBrake}\nRearBrake:{RearBrake}\nExteriorDesign:{exteriorDesign}");
                }
            }
            public sealed class car:fourwheeler
            {
                public car(string m, int year, int NOS,int g,int d,float ecc, string Ind) {
                    ModelNo = m;
                    YearMake=year;
                    NumberOfSeat=NOS;
                    NumberOfgear = g;
                    NumberOfDour = d;
                    EangineCapacityCC=ecc;
                    InteriorDesign = Ind;
                    VehicleType = VehicleType.car;
                }


            }
            public sealed class motorcycle : TwoWheeler
            {
                public motorcycle(string m, int year, int g, string sm, float ecc, float mp,float mt,float mk, string cool, string fb, string rb, string exd)
                {
                    ModelNo = m;
                    YearMake = year;
                    NumberOfGears = g;
                    StartingMethod = sm;
                    EngineCapacityCC = ecc;
                    MaxPowerBPH = mp;
                    MaxTorqueNM=mt;
                    MileageKMPL=mk;
                    Cooling = cool;
                    FrontBrake=fb;
                    RearBrake=rb;
                    exteriorDesign = exd;
                    VehicleType = VehicleType.motorcycle;
                }
            }

            }
       
    
}
