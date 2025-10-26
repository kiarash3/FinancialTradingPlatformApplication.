using System;
using System.Collections.Generic;
using System.Buffers;
using System.Linq;


namespace financialTradingPlatformApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine($"Methode name: Main, ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            StockMarketTechnicalAnalysisData stockMarketTechnicalAnalysisData = new StockMarketTechnicalAnalysisData("Btc",new DateTime(2012,10,10),new DateTime(2022,10,10));
            
            DateTime dateTimeBefore = DateTime.Now;
            /*
            decimal[] data1 = StockMarketTechnicalAnalysisData.GetOpeningPrice();
            decimal[] data2 = StockMarketTechnicalAnalysisData.GetClosingPrice();
            decimal[] data3 = StockMarketTechnicalAnalysisData.GetPriceLow();
            decimal[] data4 = StockMarketTechnicalAnalysisData.GetPriceHeight();
           // decimal[] data5 = StockMarketTechnicalAnalysisData.GetOpeningPrice();
            */
            
            List<Task<decimal[]>> tasks = new List<Task<decimal[]>>();

            Task<decimal[]> getOpeningPriceTask = Task.Run(() => StockMarketTechnicalAnalysisData.GetOpeningPrice());
            Task<decimal[]> getClosningPriceTask = Task.Run(() => StockMarketTechnicalAnalysisData.GetClosingPrice());
            Task<decimal[]> getPriceHeightTask = Task.Run(() => StockMarketTechnicalAnalysisData.GetPriceHeight());
            Task<decimal[]> getPriceLowTask = Task.Run(() => StockMarketTechnicalAnalysisData.GetPriceLow());
            Task<decimal[]> getCalculateStocktist = Task.Run(() => StockMarketTechnicalAnalysisData.CalculateStocktist());
            Task<decimal[]> getCalculateFastMovingAverage = Task.Run(() => StockMarketTechnicalAnalysisData.CalculateFastMovingAverage());
            Task<decimal[]> getCalculateSlowMovingAverage = Task.Run(() => StockMarketTechnicalAnalysisData.CalculateSlowMovingAverage());
            Task<decimal[]> getCalculateUpperBoundbollingerban = Task.Run(() => StockMarketTechnicalAnalysisData.CalculateUpperBoundbollingerban());
            Task<decimal[]> getCalculateLowerBoundbollingerban = Task.Run(() => StockMarketTechnicalAnalysisData.CalculateLowerBoundbollingerban());
            
            DateTime dateTimeAfter = DateTime.Now;
            
            TimeSpan timespand = dateTimeAfter.Subtract(dateTimeBefore);
            
            tasks.Add(getOpeningPriceTask);
            tasks.Add(getClosningPriceTask);
            tasks.Add(getPriceHeightTask);
            tasks.Add(getPriceLowTask);
            tasks.Add(getCalculateFastMovingAverage);
            tasks.Add(getCalculateSlowMovingAverage);
            tasks.Add(getCalculateUpperBoundbollingerban);
            tasks.Add(getCalculateStocktist);
            tasks.Add(getCalculateLowerBoundbollingerban);
            
            
            
            Task.WaitAll(tasks.ToArray());
            
            decimal[] data1 = tasks[0].Result;
            decimal[] data2 = tasks[1].Result;
            decimal[] data3 = tasks[2].Result;
            decimal[] data4 = tasks[3].Result;
            decimal[] data5 = tasks[4].Result;
            decimal[] data6 = tasks[5].Result;
            decimal[] data7 = tasks[6].Result;
            decimal[] data8 = tasks[7].Result;
            decimal[] data9 = tasks[8].Result;
            
            Console.WriteLine((object?)$"total time for operations complete took:{timespand.Seconds} {(timespand.Seconds > 1?"seconce":"seconce")}");
            DisplayDataOnchart(data1, data2, data3, data4);
            
            Console.ReadKey();
        }
        public static void DisplayDataOnchart(decimal[] data1, decimal[] data2, decimal[] data3, decimal[] data4)
        {
            //code goes  here to  add  data  to the chart
            Console.WriteLine($"Data is display on the chart.");
        }
        
        
        
        
        public class StockMarketTechnicalAnalysisData
        {
            public  StockMarketTechnicalAnalysisData(string stockSymbol,DateTime startDate,DateTime endDate)
            {
                //code here gets stock Market data from remote server
                
                
            }

            public static decimal[] GetOpeningPrice()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(GetOpeningPrice)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(1000);  //represents the time it takes for the operation to complete
                data = new decimal[] { }; //in the real world data variable word would contusion decimal data 
                
                return data;
            }
            public static decimal[] GetClosingPrice()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(GetClosingPrice)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(1000);
                data = new decimal[] { };
                
                return data;
            }
            public static decimal[] GetPriceHeight()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(GetPriceHeight)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(1000);
                data = new decimal[] { };
                
                return data;
            }
            
            public static decimal[] GetPriceLow()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(GetPriceLow)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(1000);
                data = new decimal[] { };
                
                return data;
            }
            
            public static decimal[] CalculateStocktist()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(CalculateStocktist)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(10000);
                data = new decimal[] { };
                
                return data;
            }
            
            public static decimal[] CalculateFastMovingAverage()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(GetOpeningPrice)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(6000);
                data = new decimal[] { };
                
                return data;
            }
            
            public static decimal[] CalculateSlowMovingAverage()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(GetOpeningPrice)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(2000);
                data = new decimal[] { };
                
                return data;
            }
            //CalculateUpperBoundbollingerban
            public static decimal[] CalculateUpperBoundbollingerban()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(CalculateUpperBoundbollingerban)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(5000);
                data = new decimal[] { };
                
                return data;
            }
            
            public static decimal[] CalculateLowerBoundbollingerban()
            {
                decimal[] data;
                Console.WriteLine($"Methode Name :{nameof(CalculateLowerBoundbollingerban)},ThreadId:{Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(5000);
                data = new decimal[] { };
                
                return data;
            }
            
        }
    }
}