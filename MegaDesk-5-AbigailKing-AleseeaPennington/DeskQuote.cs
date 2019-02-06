using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_3_AbigailKing
{
    public class DeskQuote
    {

        public static int[ , ] rushAmount = GetRushOrder();

        //constants
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;
        decimal RUSH_3DAY_LESS_THAN_1000 = rushAmount[0,0];
        decimal RUSH_3DAY_1000_TO_2000 = rushAmount[0,1];
        decimal RUSH_3DAY_GREATER_THAN_2000 = rushAmount[0,2];
        decimal RUSH_5DAY_LESS_THAN_1000 = rushAmount[1,0];
        decimal RUSH_5DAY_1000_TO_2000 = rushAmount[1,1];
        decimal RUSH_5DAY_GREATER_THAN_2000 = rushAmount[1,2];
        decimal RUSH_7DAY_LESS_THAN_1000 = rushAmount[2,0];
        decimal RUSH_7DAY_1000_TO_2000 = rushAmount[2,1];
        decimal RUSH_7DAY_GREATER_THAN_2000 = rushAmount[2,2];

        //enums
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        // properties
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Delivery DeliveryType { get; set; }
        public decimal QuoteAmount { get; set; }

        //methods
        public decimal GetQuotePrice()
        {
            decimal basePrice = BASE_DESK_PRICE;

            decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

            decimal surfacePrice = 0.00M;
            decimal materialPrice = 0.00M;
            decimal deliveryPrice = 0.00M;

            //handle for surface area over 1000 charge
            if (surfaceArea > 1000M)
            {
                decimal diff = surfaceArea - 1000M;
                surfacePrice = (diff * SURFACE_AREA_COST);
            }

            decimal drawerPrice = this.Desk.Drawers * DRAWER_COST;

            //handle surface area charge
            switch(this.Desk.SurfaceMaterial)
            {
                case Desk.Surface.Laminate:
                    materialPrice = LAMINATE_COST;
                    break;

                case Desk.Surface.Oak:
                    materialPrice = OAK_COST;
                    break;

                case Desk.Surface.Rosewood:
                    materialPrice = ROSEWOOD_COST;
                    break;

                case Desk.Surface.Veneer:
                    materialPrice = VENEER_COST;
                    break;

                case Desk.Surface.Pine:
                    materialPrice = PINE_COST;
                    break;
            }

            //handle shipping charge
            switch(this.DeliveryType)
            {
                //3 day
                case Delivery.Rush3Days:
                    if(surfaceArea <= 1000)
                    {
                        deliveryPrice = RUSH_3DAY_LESS_THAN_1000;
                    } else if (surfaceArea > 1000 && surfaceArea <= 2000) {
                        deliveryPrice = RUSH_3DAY_1000_TO_2000;
                    } else
                    {
                        deliveryPrice = RUSH_3DAY_GREATER_THAN_2000;
                    }
                break;

                //5 day
                case Delivery.Rush5Days:
                    if (surfaceArea < 1000)
                    {
                        deliveryPrice = RUSH_5DAY_LESS_THAN_1000;
                    } else if (surfaceArea >= 2000) {
                        deliveryPrice = RUSH_5DAY_1000_TO_2000;
                    } else
                    {
                        deliveryPrice = RUSH_5DAY_GREATER_THAN_2000;
                    }
                 break;

                //7 day
                case Delivery.Rush7Days:
                    if (surfaceArea < 1000)
                    {
                        deliveryPrice = RUSH_7DAY_LESS_THAN_1000;
                    } else if (surfaceArea >= 2000) {
                        deliveryPrice = RUSH_7DAY_1000_TO_2000;
                    } else
                    {
                        deliveryPrice = RUSH_7DAY_GREATER_THAN_2000;
                    }
                break;
                    
            }

            decimal FINAL_PRICE = basePrice + surfacePrice + deliveryPrice + drawerPrice + materialPrice;

            return FINAL_PRICE;
        }

        public static int[ , ] GetRushOrder()
        {
           string[] shipping = File.ReadAllLines(@"rushOrderPrices.txt");

            int[,] price = new int[3, 3];

            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    price[i, j] = Int32.Parse(shipping[k]);
                    k++;
                }
            }

            return price;
        }
    }
}
