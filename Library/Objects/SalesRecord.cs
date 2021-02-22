using System;
using System.Collections.Generic;
using GC.Library.Objects.SubObjects.SalesRecord;
using GC.Library.Files;
using GC.Library.Entities;

namespace GC.Library.Objects
{
    /// <summary>
    /// All the data from this class aren't ready do be delivered to the user. You need to use Linq, Sort(), etc... Use the TOP lists to make the WORST lists
    /// </summary>
    internal class SalesRecord
    {
        //GLOBAL ----------------------------------------
        internal double Profits_amount { get; set; }

        //Hour
        internal double Average_profits_amount_hour { get; set; }

        //Daily
        internal double Average_profits_amount_daily { get; set; }

        //Weekly
        internal double Average_profits_amount_weekly { get; set; }

        //Monthly
        internal double Average_profits_amount_monthly { get; set; }

        //Yearly
        internal double Average_profits_amount_yearly { get; set; }

        //REQUESTS ----------------------------------------------------
        //Generic 
        internal int Requests_done_counter_total { get; set; }
        internal double Requests_done_amount_total { get; set; }

        //Hour
        internal double Average_requests_done_counter_hour { get; set; }
        internal double Average_requests_done_amount_hour { get; set; }

        //Daily
        internal double Average_requests_done_counter_daily { get; set; }
        internal double Average_requests_done_amount_daily { get; set; }

        //Weekly
        internal double Average_requests_done_counter_weekly { get; set; }
        internal double Average_requests_done_amount_weekly { get; set; }

        //Monthly
        internal double Average_requests_done_counter_monthly { get; set; }
        internal double Average_requests_done_amount_monthly { get; set; }

        //PRODUCTS ------------------------------------------------------------------
        //Generic 
        internal int Products_sales_counter_total { get; set; }
        internal double Products_sales_amount_total { get; set; }

        //Hour
        internal double Average_products_SalesCounter_hour { get; set; }
        internal double Average_products_SalesAmount_hour { get; set; }

        //Daily
        internal double Average_products_SalesCounter_daily { get; set; }
        internal double Average_products_SalesAmount_daily { get; set; }

        //Weekly
        internal double Average_products_SalesCounter_weekly { get; set; }
        internal double Average_products_SalesAmount_weekly { get; set; }

        //Monthly
        internal double Average_products_SalesCounter_monthly { get; set; }
        internal double Average_products_SalesAmount_monthly { get; set; }

        //JOBS ---------------------------------------------------------------------
        //Generic
        internal int Jobs_sales_counter_total { get; set; }
        internal double Jobs_sales_amount_total { get; set; }

        //Hour
        internal double Average_jobs_SalesCounter_hour { get; set; }
        internal double Average_jobs_SalesAmount_hour { get; set; }

        //Daily
        internal double Average_jobs_SalesCounter_daily { get; set; }
        internal double Average_jobs_SalesAmount_daily { get; set; }

        //Weekly
        internal double Average_jobs_SalesCounter_weekly { get; set; }
        internal double Average_jobs_SalesAmount_weekly { get; set; }

        //Monthly
        internal double Average_jobs_SalesCounter_monthly { get; set; }
        internal double Average_jobs_SalesAmount_monthly { get; set; }

        //TOPS ---------------------------------------------------------------
        internal List<Costumers> top_costumers = new List<Costumers>();
        internal List<Products> top_products = new List<Products>();
        internal List<Jobs> top_jobs = new List<Jobs>();
        internal List<int> top_payment_methods = new List<int>();

        public SalesRecord(double profits_amount, int requests_done_counter_total, double requests_done_amount_total, int products_SalesCounter_total, double products_SalesAmount_total, int jobs_SalesCounter_total, double jobs_SalesAmount_total)
        {
            this.Profits_amount = profits_amount;
            this.Requests_done_counter_total = requests_done_counter_total;
            this.Requests_done_amount_total = requests_done_amount_total;
            this.Products_sales_counter_total = products_SalesCounter_total;
            this.Products_sales_amount_total = products_SalesAmount_total;
            this.Jobs_sales_counter_total = jobs_SalesCounter_total;
            this.Jobs_sales_amount_total = jobs_SalesAmount_total;
        }

        internal void UpdateSRAllData()
        {
            this.top_costumers.Clear();
            this.top_products.Clear();
            this.top_jobs.Clear();
            this.top_payment_methods.Clear();

            int totalDays = (DateTime.Now - GlobalVariables.User.Joined).Days;

            //TOTAL COMMERCE PROFITS
            this.Average_profits_amount_daily = (double)this.Profits_amount / totalDays;
            this.Average_profits_amount_hour = this.Average_profits_amount_daily / 24;
            this.Average_profits_amount_weekly = this.Average_profits_amount_daily * 7;
            this.Average_profits_amount_monthly = this.Average_profits_amount_daily * 30;
            this.Average_profits_amount_yearly = this.Average_profits_amount_daily * 365;

            //REQUESTS
            this.Average_requests_done_amount_daily = (double)this.Requests_done_amount_total / totalDays;
            this.Average_requests_done_amount_hour = this.Average_requests_done_amount_daily / 24;
            this.Average_requests_done_amount_weekly = this.Average_requests_done_amount_daily * 7;
            this.Average_requests_done_amount_monthly = this.Average_requests_done_amount_daily * 30;

            this.Average_requests_done_counter_daily = (double)this.Requests_done_counter_total / totalDays;
            this.Average_requests_done_counter_hour = this.Average_requests_done_counter_daily / 24;
            this.Average_requests_done_counter_weekly = this.Average_requests_done_counter_daily * 7;
            this.Average_requests_done_counter_monthly = this.Average_requests_done_counter_daily * 30;

            //PRODUCTS
            this.Average_products_SalesAmount_daily = (double)this.Products_sales_amount_total / totalDays;
            this.Average_products_SalesAmount_hour = this.Average_products_SalesAmount_daily / 24;
            this.Average_products_SalesAmount_weekly = this.Average_products_SalesAmount_daily * 7;
            this.Average_products_SalesAmount_monthly = this.Average_products_SalesAmount_daily * 30;

            this.Average_products_SalesCounter_daily = (double)this.Products_sales_counter_total / totalDays;
            this.Average_products_SalesCounter_hour = this.Average_products_SalesCounter_daily / 24;
            this.Average_products_SalesCounter_weekly = this.Average_products_SalesCounter_daily * 7;
            this.Average_products_SalesCounter_monthly = this.Average_products_SalesCounter_daily * 30;

            //JOBS
            this.Average_jobs_SalesAmount_daily = (double)this.Jobs_sales_amount_total / totalDays;
            this.Average_jobs_SalesAmount_hour = this.Average_jobs_SalesAmount_daily / 24;
            this.Average_jobs_SalesAmount_weekly = this.Average_jobs_SalesAmount_daily * 7;
            this.Average_jobs_SalesAmount_monthly = this.Average_jobs_SalesAmount_daily * 30;

            this.Average_jobs_SalesCounter_daily = (double)this.Jobs_sales_counter_total / totalDays;
            this.Average_jobs_SalesCounter_hour = this.Average_jobs_SalesCounter_daily / 24;
            this.Average_jobs_SalesCounter_weekly = this.Average_jobs_SalesCounter_daily * 7;
            this.Average_jobs_SalesCounter_monthly = this.Average_jobs_SalesCounter_daily * 30;

            //TOPS    
            //Assemblying lists
            foreach (Costumer costumer in GlobalVariables.Costumers)
            {
                this.top_costumers.Add(new Costumers(costumer.Id));
            }

            foreach (Job job in GlobalVariables.Jobs)
            {
                this.top_jobs.Add(new Jobs(job.Id));
            }

            foreach (Product product in GlobalVariables.Products)
            {
                this.top_products.Add(new Products(product.Id));
            }

            for (int i = 0; i < 6; i++)
            {
                this.top_payment_methods.Add(0);
            }

            int index = 0;

            //Collecting data from **OLD REQUESTS**
            if (GlobalVariables.OldRequests.Count > 0)
            {
                foreach (Request oldRequest in GlobalVariables.OldRequests)
                {
                    if (oldRequest.Status != 'F') continue;

                    //Collecting data for **PAYMENT METHOD**
                    this.top_payment_methods[oldRequest.PaymentType]++;

                    //Collecting data for **COSTUMERS**
                    index = this.top_costumers.FindIndex(x => x.Id_Costumer == oldRequest.Id_Costumer);
                    if (index < 0) continue;
                    this.top_costumers[index].ShoppingCounter++;
                    this.top_costumers[index].ShoppingAmount += oldRequest.Value;

                    //Collecting data for **PRODUCTS**
                    foreach (Library.Objects.SubObjects.Request.Request_Products req_prod in oldRequest.Products)
                    {
                        index = this.top_products.FindIndex(x => x.Id_Product == req_prod.Id_Product);
                        if (index < 0) continue;
                        this.top_products[index].SalesCounter++;
                        this.top_products[index].SalesAmount += req_prod.Price * req_prod.Quantity;
                    }

                    //Collecting data for **JOBS**
                    foreach (Library.Objects.SubObjects.Request.Request_Jobs req_job in oldRequest.Jobs)
                    {
                        index = this.top_jobs.FindIndex(x => x.Id_Job == req_job.Id_Job);
                        if (index < 0) continue;
                        this.top_jobs[index].SalesCounter++;
                        this.top_jobs[index].SalesAmount += req_job.Price;
                    }
                }
            }

            //collecting data from **REQUESTS**
            if (GlobalVariables.Requests.Count > 0)
            {
                foreach (Request request in GlobalVariables.Requests)
                {
                    if (request.Status != 'F') continue;

                    //Collecting data for **PAYMENT METHOD**
                    this.top_payment_methods[request.PaymentType]++;

                    //Collecting data for **COSTUMERS**
                    index = this.top_costumers.FindIndex(x => x.Id_Costumer == request.Id_Costumer);
                    if (index < 0) continue;
                    this.top_costumers[index].ShoppingCounter++;
                    this.top_costumers[index].ShoppingAmount += request.Value;

                    //Collecting data for **PRODUCTS**
                    foreach (Library.Objects.SubObjects.Request.Request_Products req_prod in request.Products)
                    {
                        index = this.top_products.FindIndex(x => x.Id_Product == req_prod.Id_Product);
                        if (index < 0) continue;
                        this.top_products[index].SalesCounter++;
                        this.top_products[index].SalesAmount += req_prod.Price * req_prod.Quantity;
                    }

                    //Collecting data for **JOBS**
                    foreach (Library.Objects.SubObjects.Request.Request_Jobs req_job in request.Jobs)
                    {
                        index = this.top_jobs.FindIndex(x => x.Id_Job == req_job.Id_Job);
                        if (index < 0) continue;
                        this.top_jobs[index].SalesCounter++;
                        this.top_jobs[index].SalesAmount += req_job.Price;
                    }
                }
            }
        }
    }
}
