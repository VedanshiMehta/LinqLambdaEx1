using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambaEx
{
    enum Color
    {
        Red, Blue, Green, Yellow, White, Orange, Black
    }

    class CarData
    {
       

        public int carId { get; set; }
        public string carName { get; set; }

        public Color carColors{ get; set; }

        public string carPrice { get; set; }
    }


    /* List<CarData> cars = new List<CarData>()
            {
                new CarData{carId = 01, carName="BMW X5" , carColors= Color.Blue, carPrice = "92.90Lakh"},
                new CarData{carId= 02, carName="Range Rover", carColors= Color.Blue, carPrice = "66.60Lakh"},
                new CarData{carId= 03, carName="Rolls Royce Dawn", carColors= Color.Black, carPrice = "7.64Crore"},
                new CarData{carId= 04, carName="Volvo X60", carColors= Color.White, carPrice = "1.2Crore"},
                new CarData{carId= 05, carName="Skoda Superb", carColors= Color.Red, carPrice = "32.85Lakh"},
                new CarData{carId= 06, carName="Volkswagen Taigun", carColors= Color.Yellow, carPrice = "17.99Lakh"},
                new CarData{carId= 07, carName="Mahindra XUV700", carColors= Color.Red, carPrice = "17.79Lakh"},
                new CarData{carId= 08, carName="Maruti Ertiga", carColors= Color.Orange, carPrice = "10.85Lakh"},
                new CarData{carId= 09, carName="Tata Altroz", carColors= Color.Yellow, carPrice = "8.99Lakh"},
                new CarData{carId= 10, carName="Maruti Alto", carColors= Color.Black, carPrice = "3.25Lakh"},
                new CarData{carId= 11, carName="Audi etron GT", carColors= Color.Blue, carPrice = "1.7Crore"},


            };*/
}
