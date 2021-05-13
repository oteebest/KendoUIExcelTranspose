using KendoUIGridProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIGridProject.Util
{
    public static class Mapper
    {
        public static void Map(this ExcelRequestModel model,string Label,int columnNo, ref Financials financials)
        {

            if (columnNo == 1)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32( model.Col1 );
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col1;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col1;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col1;
                }         

            }

            if (columnNo == 2)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col2);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col2;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col2;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col2;
                }

            }

            if (columnNo == 3)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col3);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col3;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col3;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col3;
                }

            }

            if (columnNo == 4)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col4);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col4;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col4;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col4;
                }

            }

            if (columnNo == 5)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col5);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col5;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col5;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col5;
                }

            }


            if (columnNo == 6)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col6);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col6;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col6;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col6;
                }

            }

            if (columnNo == 7)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col7);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col7;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col7;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col7;
                }

            }

            if (columnNo == 8)
            {
                if (Label.Equals("Year"))
                {
                    financials.Year = Convert.ToInt32(model.Col8);
                }
                else if (Label.Equals("Sales"))
                {
                    financials.Sales = model.Col8;
                }
                else if (Label.Equals("Cost"))
                {
                    financials.Costs = model.Col8;
                }
                else if (Label.Equals("Profit"))
                {
                    financials.Profit = model.Col8;
                }

            }


        }

        public static List<Financials> GetFinancials(this List<ExcelRequestModel> items)
        {
           
            List<Financials> list = new List<Financials>();

            for (int j = 1; j <= 8; j++)
            {

                Financials financials = new Financials();

                for (int i = 0; i < items.Count; i++)
                {


                    if (i == 0)
                    {
                        items.ElementAt(i).Map("Year", j, ref financials);
                    }

                    if (i == 1)
                    {
                        items.ElementAt(i).Map("Sales", j, ref financials);
                    }

                    if (i == 2)
                    {
                        items.ElementAt(i).Map("Cost", j, ref financials);
                    }

                    if (i == 3)
                    {
                        items.ElementAt(i).Map("Profit", j, ref financials);
                    }


                }


                if (financials.Year != 0)
                {
                    list.Add(financials);
                }


            }

            return list;
        }
    }
}