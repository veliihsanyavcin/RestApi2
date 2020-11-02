using RestApi2.Controllers;
using RestApi2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestApi2
{
    public class Park
    {

        public int id { get; set; }

        private static Slot TrackSlot;
        private static Slot BusSlot;
        private static Slot CarSlot;
        private static Slot MotorbikeSlot;
        //private static List<Ticket> ticketList = new List<Ticket>();

        public Park()
        {
            TrackSlot = new Slot(50, new List<Recipe> { new Recipe(5, 0), new Recipe(1500, 30) });
            BusSlot = new Slot(50, new List<Recipe> { new Recipe(2, 0), new Recipe(1500, 25) });
            CarSlot = new Slot(50, new List<Recipe> { new Recipe(2, 0), new Recipe(1500, 20) });
            MotorbikeSlot = new Slot(50, new List<Recipe> { new Recipe(3, 0), new Recipe(1500, 15) });
        }


        public void ParkIn(Vehicle vehicle, RestApiContext _restApiContext) //Parka giriş için kullnılan metod.
        {

            vehicle.CheckPlate();

            switch (vehicle.type)
            {
                case "Truck":
                    TrackSlot.SlotIn(vehicle, _restApiContext);
                    break;
                case "Bus":
                    BusSlot.SlotIn(vehicle, _restApiContext);
                    break;
                case "Car":
                    CarSlot.SlotIn(vehicle, _restApiContext);
                    break;
                case "Motorbike":
                    MotorbikeSlot.SlotIn(vehicle, _restApiContext);
                    break;
            }

        }

        public List<Ticket> GetParkIn(RestApiContext _restApiContext)
        {
            var ticketList = new List<Ticket>();
            ticketList.AddRange(TrackSlot.GetSlotIn(_restApiContext));
            ticketList.AddRange(BusSlot.GetSlotIn(_restApiContext));
            ticketList.AddRange(CarSlot.GetSlotIn(_restApiContext));
            ticketList.AddRange(MotorbikeSlot.GetSlotIn(_restApiContext));
            return ticketList;
        }


        public void ParkOut(Vehicle vehicle, RestApiContext _restApiContext)//Parktan çıkış için kullnılan metod.
        {
            switch (vehicle.type)
            {
                case "Truck":
                   TrackSlot.SlotOut(vehicle.plate, _restApiContext);
                    break;
                case "Bus":
                    BusSlot.SlotOut(vehicle.plate, _restApiContext);
                    break;
                case "Car":
                    CarSlot.SlotOut(vehicle.plate, _restApiContext);
                    break;
                case "Motorbike":
                    MotorbikeSlot.SlotOut(vehicle.plate, _restApiContext);
                    break;
            }

        }
        public List<Ticket> GetParkOut(RestApiContext _restApiContext)
        {
            var ticketList = new List<Ticket>();
            ticketList.AddRange(TrackSlot.GetSlotOut(_restApiContext));
            ticketList.AddRange(BusSlot.GetSlotOut(_restApiContext));
            ticketList.AddRange(CarSlot.GetSlotOut(_restApiContext));
            ticketList.AddRange(MotorbikeSlot.GetSlotOut(_restApiContext));
            return ticketList;
        }



        //public void ParkIn(Vehicle vehicle) //Parka giriş için kullnılan metod.
        //{

        //    //Vehicle newVehicle = new Vehicle(vehicle.plate,vehicle.type);
        //    vehicle.CheckPlate();



        //    switch (vehicle.type)
        //    {
        //        case "Truck":
        //            ticketList = ticketList.Concat(this.TrackSlot.SlotIn(vehicle)).ToList();
        //            break;
        //        case "Bus":
        //            ticketList = ticketList.Concat(this.BusSlot.SlotIn(vehicle)).ToList();
        //            break;

        //        case "Car":
        //            ticketList = ticketList.Concat(this.CarSlot.SlotIn(vehicle)).ToList();
        //            break;

        //        case "Motorbike":
        //            ticketList = ticketList.Concat(this.MotorbikeSlot.SlotIn(vehicle)).ToList();
        //            break;

        //    }


        //}

        //public List<Ticket> GetParkIn()
        //{

        //    ticketList.AddRange(TrackSlot.GetSlotIn());
        //    ticketList.AddRange(BusSlot.GetSlotIn());
        //    ticketList.AddRange(CarSlot.GetSlotIn());
        //    ticketList.AddRange(MotorbikeSlot.GetSlotIn());
        //    return ticketList;
        //}



    }
}

