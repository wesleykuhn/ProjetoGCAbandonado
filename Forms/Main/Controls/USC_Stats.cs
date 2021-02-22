using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Translators;
using GC.Library.Objects;
using GC.Library;
using GC.Library.Files;
using GC.Library.Checkers;
using GC.Library.Entities;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Stats : UserControl
    {
        internal bool AlreadyBuilt = false;
        internal bool CanAnimate = false;
        private int AnimAuxInt = 1;
        private double AnimAuxDouble = 0;

        private Timer Timer;

        public USC_Stats()
        {
            InitializeComponent();

            chtGeneralDaysOfWeek.ChartAreas[0].BackColor = SystemColors.Window;

            btnUpdateAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                //Animations
                if (GlobalVariables.Configuration.Enable_animations)
                {
                    this.tbcTabs.SelectedIndexChanged += new System.EventHandler(this.GeneralTotalProfitAnimation);

                    this.CanAnimate = true;

                    this.Timer = new Timer();
                    this.Timer.Interval = 15;
                    this.Timer.Tick += Timer200T_Tick;
                }
            }            
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            UpdateAllData();
        }

        // UI UPDATES ----------------------------------------------------------------------------------------------->    
        private void TbcTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcTabs.SelectedIndex)
            {
                case 1:
                    UpdateRequest();
                    break;
                case 2:
                    UpdateCostumer();
                    break;
                case 3:
                    UpdateProduct();
                    break;
                case 4:
                    UpdateJob();
                    break;
            }
        }

        internal void UpdateAllData()
        {           
            if(GlobalVariables.OldRequests.Count < 1)
            {
                SeekFor.OldRequest();
            }

            GlobalVariables.SalesRecords.UpdateSRAllData();

            UpdateGeneral();
            UpdateRequest();
            UpdateCostumer();
            UpdateProduct();
            UpdateJob();

            if (!this.AlreadyBuilt) this.AlreadyBuilt = true;
        }

        private void UpdateGeneral()
        {
            //Daily Sales
            lvlDailySales.Items.Clear();
            chtGeneralDaysOfWeek.Series[0].Points.Clear();

            int index = -1;

            chtGeneralDaysOfWeek.Titles[0].Visible = true;

            List<DayRecord> daysRecord = SeekFor.OldDaysRecords();
            daysRecord.AddRange(GlobalVariables.DaysRecords);
            daysRecord.Sort((x, y) => DateTime.Compare(x.Date, y.Date));

            foreach (DayRecord item in daysRecord)
            {
                ListViewItem lvi = lvlDailySales.Items.Add(ObjectToListView.ToDateListView(item.Date));
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_TwoDecimals(item.Profit));

                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }
            }

            if (daysRecord.Count > 1)
            {
                double profit = daysRecord.Min(x => x.Profit);
                index = daysRecord.FindIndex(x => x.Profit == profit);
                lblGeneralWorstDailySale.Text = "Pior lucro em ";
                lblGeneralWorstDailySale.Text += daysRecord[index].Date.ToString("dd/MM/yyyy") + " com " + ObjectToDetailLabel.ToMoneyLabel(daysRecord[index].Profit) + ".";

                profit = daysRecord.Max(x => x.Profit);
                index = daysRecord.FindIndex(x => x.Profit == profit);
                lblGeneralBestDailySale.Text = "Melhor lucro em ";
                lblGeneralBestDailySale.Text += daysRecord[index].Date.ToString("dd/MM/yyyy") + " com " + ObjectToDetailLabel.ToMoneyLabel(daysRecord[index].Profit) + ".";
            }

            //Chart assembly              
            double[] mondays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Monday).Select(x => x.Profit).ToArray();
            double[] tuesdays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Tuesday).Select(x => x.Profit).ToArray();
            double[] wednesdays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Wednesday).Select(x => x.Profit).ToArray();
            double[] thursdays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Thursday).Select(x => x.Profit).ToArray();
            double[] fridays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Friday).Select(x => x.Profit).ToArray();
            double[] saturdays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Saturday).Select(x => x.Profit).ToArray();
            double[] sundays = daysRecord.Where(x => x.Date.DayOfWeek == DayOfWeek.Sunday).Select(x => x.Profit).ToArray();

            //Taking the average value
            double averageMondaysProfits = 0;
            double averageTuesdaysProfits = 0;
            double averageWednesdaysProfits = 0;
            double averageThursdaysProfits = 0;
            double averageFridaysProfits = 0;
            double averageSaturdaysProfits = 0;
            double averageSundaysProfits = 0;

            if (mondays.Length > 0) averageMondaysProfits = mondays.Average();
            if (tuesdays.Length > 0) averageTuesdaysProfits = tuesdays.Average();
            if (wednesdays.Length > 0) averageWednesdaysProfits = wednesdays.Average();
            if (thursdays.Length > 0) averageThursdaysProfits = thursdays.Average();
            if (fridays.Length > 0) averageFridaysProfits = fridays.Average();
            if (saturdays.Length > 0) averageSaturdaysProfits = saturdays.Average();
            if (sundays.Length > 0) averageSundaysProfits = sundays.Average();

            double daysAverageCombined = 0;

            if (averageMondaysProfits > 0) daysAverageCombined += averageMondaysProfits;
            if (averageTuesdaysProfits > 0) daysAverageCombined += averageTuesdaysProfits;
            if (averageWednesdaysProfits > 0) daysAverageCombined += averageWednesdaysProfits;
            if (averageThursdaysProfits > 0) daysAverageCombined += averageThursdaysProfits;
            if (averageFridaysProfits > 0) daysAverageCombined += averageFridaysProfits;
            if (averageSaturdaysProfits > 0) daysAverageCombined += averageSaturdaysProfits;
            if (averageSundaysProfits > 0) daysAverageCombined += averageSundaysProfits;

            if (mondays.Length > 0 && (averageMondaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Seg", averageMondaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Seg(R$ " + averageMondaysProfits.ToString("n2") + ").";
            }
            if (tuesdays.Length > 0 && (averageTuesdaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Ter", averageTuesdaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Ter(R$ " + averageTuesdaysProfits.ToString("n2") + ").";
            }
            if (wednesdays.Length > 0 && (averageWednesdaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Qua", averageWednesdaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Qua(R$ " + averageWednesdaysProfits.ToString("n2") + ").";
            }
            if (thursdays.Length > 0 && (averageThursdaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Qui", averageThursdaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Qui(R$ " + averageThursdaysProfits.ToString("n2") + ").";
            }
            if (fridays.Length > 0 && (averageFridaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Sex", averageFridaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Sex(R$ " + averageFridaysProfits.ToString("n2") + ").";
            }
            if (saturdays.Length > 0 && (averageSaturdaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Sab", averageSaturdaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Sab(R$ " + averageSaturdaysProfits.ToString("n2") + ").";
            }
            if (sundays.Length > 0 && (averageSundaysProfits * 100 / daysAverageCombined) > 0)
            {
                chtGeneralDaysOfWeek.Series[0].Points.AddXY("Dom", averageSundaysProfits * 100 / daysAverageCombined);
                chtGeneralDaysOfWeek.Series[0].Points[chtGeneralDaysOfWeek.Series[0].Points.Count - 1].LegendText = "Dom(R$ " + averageSundaysProfits.ToString("n2") + ").";
            }            

            //Speedometers of General
            lblGeneralProfitPerHourValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_profits_amount_hour) + "/h";

            lblGeneralProfitPerDayValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_profits_amount_daily) + "/dia";

            lblGeneralProfitPerWeekValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_profits_amount_weekly) + "/sem";

            lblGeneralProfitPerMonthValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_profits_amount_monthly) + "/mês";

            lblGeneralProfitPerYearValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_profits_amount_yearly) + "/ano";

            //Todays profit and total profit
            double value = 0;
            if (daysRecord.Exists(x => Structs.IsDateSameThanToday(x.Date)))
            {
                index = daysRecord.FindIndex(x => Structs.IsDateSameThanToday(x.Date));
                value = daysRecord[index].Profit;
            }

            lblGeneralTodaysProfit.Text = ObjectToDetailLabel.ToMoneyLabel(value);

            if (!this.CanAnimate || GlobalVariables.SalesRecords.Profits_amount < 100)
            {
                lblGeneralTotalProfit.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Profits_amount);
            }

            if(GlobalVariables.DaysRecords.Count < 1)
            {
                lblGeneralWorstDailySale.Hide();
                lblGeneralBestDailySale.Hide();
                pnlGeneralChartBack.Hide();
                pnlGeneralSpeedometersBack.Hide();
            }
            else
            {
                lblGeneralWorstDailySale.Show();
                lblGeneralBestDailySale.Show();
                pnlGeneralChartBack.Show();
                pnlGeneralSpeedometersBack.Show();
            }
        }

        private void UpdateRequest()
        {
            //Speedometers
            //Amount
            lblRequestProfitPerHourValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_requests_done_amount_hour) + "/h";

            lblRequestProfitPerDayValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_requests_done_amount_daily) + "/dia";

            lblRequestProfitPerWeekValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_requests_done_amount_weekly) + "/sem";

            lblRequestProfitPerMonthValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Average_requests_done_amount_monthly) + "/mês";

            //Counter
            lblRequestDonePerHourValue.Text = ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(GlobalVariables.SalesRecords.Average_requests_done_counter_hour) + "/h";

            lblRequestDonePerDayValue.Text = ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(GlobalVariables.SalesRecords.Average_requests_done_counter_daily) + "/dia";

            lblRequestDonePerWeekValue.Text = ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(GlobalVariables.SalesRecords.Average_requests_done_counter_weekly) + "/sem";

            lblRequestDonePerMonthValue.Text = ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(GlobalVariables.SalesRecords.Average_requests_done_counter_monthly) + "/mês";

            //Total
            lblRequestTotalProfitValue.Text = ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.SalesRecords.Requests_done_amount_total);

            lblRequestTotalDoneValue.Text = ObjectToDetailLabel.ToIntLabel(GlobalVariables.SalesRecords.Requests_done_counter_total);
        }

        private void UpdateCostumer()
        {
            //Top profits
            lvlTopCostumersProfit.Items.Clear();
            
            if (GlobalVariables.SalesRecords.top_costumers.Count > 0)
            {
                GlobalVariables.SalesRecords.top_costumers.Sort((x, y) => y.ShoppingAmount.CompareTo(x.ShoppingAmount));

                foreach (Library.Objects.SubObjects.SalesRecord.Costumers item in GlobalVariables.SalesRecords.top_costumers)
                {
                    Library.Entities.Costumer costumer = Library.Entities.Costumer.CloneCostumer(item.Id_Costumer);

                    ListViewItem lvi = lvlTopCostumersProfit.Items.Add(costumer.Name);

                    if (ObjectToListView.ToStringListView(costumer.Street) == "")
                    {
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ""));
                    }
                    else
                    {
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Street + ", " + costumer.Number)));
                    }

                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.PhoneNumber)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Email)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.ShoppingAmount)));

                    if(lvi.Index % 2 != 0)
                    {
                        lvi.BackColor = Color.FromArgb(200, 200, 200);
                    }
                }                
            }

            //Top counters
            lvlTopCostumersCounter.Items.Clear();      

            if (GlobalVariables.SalesRecords.top_costumers.Count > 0)
            {
                GlobalVariables.SalesRecords.top_costumers.Sort((x, y) => y.ShoppingCounter.CompareTo(x.ShoppingCounter));

                foreach (Library.Objects.SubObjects.SalesRecord.Costumers item in GlobalVariables.SalesRecords.top_costumers)
                {
                    Library.Entities.Costumer costumer = Library.Entities.Costumer.CloneCostumer(item.Id_Costumer);

                    ListViewItem lvi = lvlTopCostumersCounter.Items.Add(costumer.Name);

                    if (ObjectToListView.ToStringListView(costumer.Street) == "")
                    {
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ""));
                    }
                    else
                    {
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Street + ", " + costumer.Number)));
                    }

                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.PhoneNumber)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Email)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView(item.ShoppingCounter)));

                    if (lvi.Index % 2 != 0)
                    {
                        lvi.BackColor = Color.FromArgb(200, 200, 200);
                    }
                }
            }
        }

        private void UpdateProduct()
        {
            //Top profits
            lvlTopProductsProfit.Items.Clear();

            if (GlobalVariables.SalesRecords.top_products.Count > 0)
            {
                GlobalVariables.SalesRecords.top_products.Sort((x, y) => y.SalesAmount.CompareTo(x.SalesAmount));

                foreach (Library.Objects.SubObjects.SalesRecord.Products item in GlobalVariables.SalesRecords.top_products)
                {
                    Product product = Product.CloneProduct(item.Id_Product);

                    ListViewItem lvi = lvlTopProductsProfit.Items.Add(product.Code);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.SalesAmount)));

                    if (lvi.Index % 2 != 0)
                    {
                        lvi.BackColor = Color.FromArgb(200, 200, 200);
                    }
                }
            }
        }

        private void btnAllProductsConsumption_Click(object sender, EventArgs e)
        {
            Modals.Stats.FRM_ProductsConsumption productsConsumption = new Modals.Stats.FRM_ProductsConsumption();
            productsConsumption.ShowDialog();
        }

        private void UpdateJob()
        {
            //Top profits
            lvlTopJobsProfit.Items.Clear();
         
            if (GlobalVariables.SalesRecords.top_jobs.Count > 0)
            {
                GlobalVariables.SalesRecords.top_jobs.Sort((x, y) => y.SalesAmount.CompareTo(x.SalesAmount));

                foreach (Library.Objects.SubObjects.SalesRecord.Jobs item in GlobalVariables.SalesRecords.top_jobs)
                {
                    Job job = Job.CloneJob(item.Id_Job);

                    ListViewItem lvi = lvlTopJobsProfit.Items.Add(job.Name);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, job.Description));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(job.Price)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.SalesAmount)));

                    if (lvi.Index % 2 != 0)
                    {
                        lvi.BackColor = Color.FromArgb(200, 200, 200);
                    }
                }
            }

            //Top counters
            lvlTopJobsCounter.Items.Clear();

            if (GlobalVariables.SalesRecords.top_jobs.Count > 0)
            {
                GlobalVariables.SalesRecords.top_jobs.Sort((x, y) => y.SalesCounter.CompareTo(x.SalesCounter));

                foreach (Library.Objects.SubObjects.SalesRecord.Jobs item2 in GlobalVariables.SalesRecords.top_jobs)
                {
                    Job job = Job.CloneJob(item2.Id_Job);

                    ListViewItem lvi = lvlTopJobsCounter.Items.Add(job.Name);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, job.Description));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(job.Price)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView(item2.SalesCounter)));

                    if (lvi.Index % 2 != 0)
                    {
                        lvi.BackColor = Color.FromArgb(200, 200, 200);
                    }
                }
            }
        }     

        //ANIMATIONS -------------------------------------------------------------------------------------------->
        internal void GeneralTotalProfitAnimation(object sender, EventArgs e)
        {
            if (GlobalVariables.SalesRecords.Profits_amount < 100) return;

            if (tbcTabs.SelectedIndex == 0 && !Timer.Enabled)
            {
                this.Timer.Interval = 15;
                this.AnimAuxInt = 1;
                this.AnimAuxDouble = GlobalVariables.SalesRecords.Profits_amount / 200;

                this.Timer.Start();
            }
        }

        private void Timer200T_Tick(object sender, EventArgs e)
        {
            if (this.AnimAuxInt == 100)
            {
                this.Timer.Interval = 25;
            }
            if (this.AnimAuxInt == 150)
            {
                this.Timer.Interval = 40;
            }
            if (this.AnimAuxInt == 175)
            {
                this.Timer.Interval = 65;
            }
            if (this.AnimAuxInt == 185)
            {
                this.Timer.Interval = 75;
            }
            if (this.AnimAuxInt == 190)
            {
                this.Timer.Interval = 85;
            }
            if (this.AnimAuxInt == 195)
            {
                this.Timer.Interval = 100;
            }
            if (this.AnimAuxInt == 198)
            {
                this.Timer.Interval = 150;
            }
            if (this.AnimAuxInt == 201)
            {
                this.Timer.Stop();
            }
            else
            {
                lblGeneralTotalProfit.Text = ObjectToDetailLabel.ToMoneyLabel(this.AnimAuxDouble * this.AnimAuxInt);
                this.AnimAuxInt++;
            }
        }
        // <------------------------------------------------------------------------------------------------------
    }
}
