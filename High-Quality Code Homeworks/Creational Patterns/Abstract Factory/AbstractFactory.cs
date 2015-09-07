using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class GenericFactory<T> 
        where T : new()
    {
        public T CreateObject()
        {
            return new T();
        }
    }

    public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract FamilyCar CreateFamilyCar();
    }
    
    public abstract class FamilyCar
    {
        public abstract void Speed(SportsCar abstractSportsCar);
    }

    public abstract class SportsCar
    {
    }

    public class MercedesFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }

        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }
    }
    

     
    class MercedesSportsCar : SportsCar
    {
    }

    class MercedesFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
            Console.WriteLine(GetType().Name + " is slower than "
                + abstractSportsCar.GetType().Name);
        }
    }

    public class Driver
    {
        private CarFactory _carFactory;
        private SportsCar _sportsCar;
        private FamilyCar _familyCar;

        public Driver(CarFactory carFactory)
        {
            _carFactory = carFactory;
            _sportsCar = _carFactory.CreateSportsCar();
            _familyCar = _carFactory.CreateFamilyCar();
        }

        public CarFactory CarFactory
        {
            get { return _carFactory; }
            set { _carFactory = value; }
        }

        public SportsCar SportsCar
        {
            get { return _sportsCar; }
        }

        public FamilyCar FamilyCar
        {
            get { return _familyCar; }
        }

        public void CompareSpeed()
        {
            FamilyCar.Speed(SportsCar);
        }
    }
}