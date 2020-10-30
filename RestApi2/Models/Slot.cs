using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RestApi2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace RestApi2
{
    public class Slot 
    {
        public int Id { get; set; }

        private int Capacity;
        private List<Recipe> RecipeList; //Araçların ücret tarifesi listesi.
        private List<Ticket> TicketList;//Giriş-Çıkış yapan araçların listesi.
        
        //public RestApiContext _restApiContext;


        public Slot()
        {

        }

        public Slot(int capacity, List<Recipe> recipeList)
        {
            this.Capacity = capacity;
            this.TicketList = new List<Ticket>();
            this.RecipeList = recipeList;

        

        }

        public void SlotIn(Vehicle vehicle, RestApiContext _restApiContext)
        {
            Ticket ticket = new Ticket();
            ticket.Vehicle = vehicle;
            ticket.TimeIn = DateTime.Now;

            _restApiContext.Tickets.Add(ticket);
            _restApiContext.SaveChanges();

            if (!IsEmpty(_restApiContext))
            {
                throw new Exception("Otopark Dolu!");
            }

            if (IsAlreadyIn(vehicle.plate, _restApiContext))
            {
                throw new Exception("Araç İçerde");
            }

        }

        // Giriş yapan araçların listesinin tutulduğu metod.
        public List<Ticket> GetSlotIn(RestApiContext _restApiContext) 
        {
            ///return TicketList.FindAll(x => x.TimeOut == DateTime.MinValue);
           
           return _restApiContext.Tickets.Where(x => x.TimeOut == DateTime.MinValue).ToList();

        }

        public void SlotOut(string plate)
        {
            int index = TicketList.FindIndex(x => x.Vehicle.plate == plate);
            if(index != -1)
            {
                TicketList[index].TimeOut = DateTime.Now;
                double cost = CalcPayment(TicketList[index]);
                TicketList[index].Cost = cost;
            }
            
            //MessageBox.Show("Tutar:" + cost.ToString(), "Ücretiniz");
            //return TicketList;
        }
        // Çıkış yapan araçların listesinin tutulduğu metod.
       
        public List<Ticket> GetSlotOut() 
        {
            return TicketList.FindAll(x => x.TimeOut != DateTime.MinValue);
           
            
        }

        // Araçlarımız için yer kontrolünün sağlandığı meytod.
        private bool IsEmpty(RestApiContext _restApiContext)
        {
            return this.Capacity - GetSlotIn(_restApiContext).Count > 0;
        }

        // Plaka kontrolünün sağlandığı listede olup-olmadığının kontrol edildiği metod.
        private bool IsAlreadyIn(string plate, RestApiContext _restApiContext)
        {
            return GetSlotIn(_restApiContext).Exists(x => x.Vehicle.plate == plate);
        }

        // Araç otopark ücret hesaplama metodu
        private double CalcPayment(Ticket ticket) //Ödeme
        {

            TimeSpan fark = ticket.TimeOut - ticket.TimeIn;
            double saniye = fark.TotalSeconds;

            RecipeList.Sort((x, y) => (int)(x.Period - y.Period));
            var maxPeriod = RecipeList[RecipeList.Count - 1].Period;

            double totalCost = 0;
            double remaininSecond = saniye;
            double currentPeriodCost = 0;
            Recipe previousRecipe = null;

            for (int i = 0; i < Math.Ceiling(saniye / maxPeriod); i++)
            {
                currentPeriodCost = 0d;

                RecipeList.ForEach(recipe =>
                {
                    if (previousRecipe != null && previousRecipe.Period < remaininSecond &&
                        remaininSecond <= recipe.Period)
                    {
                        currentPeriodCost = recipe.Cost;
                    }
                    else if (remaininSecond >= recipe.Period)
                    {
                        currentPeriodCost = recipe.Cost;
                    }

                    previousRecipe = recipe;
                });
                totalCost += currentPeriodCost;
                remaininSecond -= maxPeriod;
            }

            return totalCost;
        }

    }
}
