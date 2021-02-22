using Microsoft.VisualBasic.Devices;
using System;

namespace GC.Forms.Main.Modals.Main
{
    public partial class FRM_MemoryUsage : Bases.FRM_Default
    {
        public FRM_MemoryUsage()
        {
            InitializeComponent();

            this.ReadyForm();

            ComputerInfo info = new ComputerInfo();

            ulong used = info.TotalPhysicalMemory - info.AvailablePhysicalMemory;

            PGB_Bar.Value = Convert.ToInt32(used * 100 / info.TotalPhysicalMemory);

            LBL_Details.Text = Library.Converters.Data.BytesToMegabytes(used) + "MB / " + Library.Converters.Data.BytesToMegabytes(info.TotalPhysicalMemory) + "MB";
            LBL_Details.Left = (this.Width - LBL_Details.Width) / 2;

            LBL_Free.Text += Library.Converters.Data.BytesToMegabytes(info.AvailablePhysicalMemory) + "MB";
            LBL_Free.Left = (this.Width - LBL_Free.Width) / 2;
        }
    }
}
