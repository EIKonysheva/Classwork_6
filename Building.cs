using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_6
{
    class Building
    {
        Random rnd = new Random();
        private int number, height,  floors, apartments, entrances, num, ApartInEachFloor, ApartInEachEntrance;

        public void GiveNumber()
        {
            bool b = Int32.TryParse(Console.ReadLine(), out number);            
            Console.WriteLine("Номер: " + number);
        }

        public void GenerateNumber()
        {

            number = rnd.Next(1, 20);          
            Console.WriteLine("Сгенерированный номер: " + number);
        }

        public void GiveFloors(int floors)
        {
            this.floors = floors;
            Console.WriteLine("Количество этажей: " + floors);
        }

        public void GiveEntrances(int entrances)
        {
            this.entrances = entrances;
            Console.WriteLine("Количество подъездов: " + entrances);
        }

        public void GiveFlats(int apartments)
        {
            this.apartments = apartments;
            Console.WriteLine("Количество квартир: " + apartments);
        }

        public void Calculate()
        {
            height = floors * 3;
            ApartInEachEntrance = apartments / entrances;
            ApartInEachFloor = ApartInEachEntrance / floors;

            Console.WriteLine($"Высота здания: {height} метров.\n" +
                $"Квартир в каждом подъезде: {ApartInEachEntrance} \n" +
            $"Квартир на этаже: {ApartInEachFloor} ");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nВысота здания: {height} метров.\n" +
            $"Квартир в каждом подъезде: {ApartInEachEntrance}\n" +
            $"Квартир на этаже: {ApartInEachFloor}\n" +
            $"Номер дома: {number}\n" +
            $"Количество квартир: {apartments}\n" +
            $"Количество этажей: {floors}\n" +
            $"Количество подъездов: {entrances}\n");
        }
    
}
}
