using System;

namespace GC.Library.Objects
{
    internal class Configuration
    {
        //Global
        internal bool Enable_animations { get; set; }
        internal bool Enable_windows_voice_alerts { get; set; }
        internal bool Enable_modal_alerts { get; set; }
        internal DateTime Last_routine_operations_fortnight { get; set; }

        //Request
        internal bool Enable_request_products_separation_helper { get; set; }
        internal bool Auto_clear_cancelled_req { get; set; }

        //Products
        internal int Days_before_expiration { get; set; }
        internal bool Enable_critical_stock_system { get; set; }

        public Configuration(bool enable_animations, bool enable_windows_voice_alerts, bool enable_modal_alerts, DateTime last_routine_operations_fortnight, bool enable_request_products_separation_helper, bool auto_clear_cancelled_req, int days_before_expiration, bool enable_critical_stock_system)
        {
            this.Enable_animations = enable_animations;
            this.Enable_windows_voice_alerts = enable_windows_voice_alerts;
            this.Enable_modal_alerts = enable_modal_alerts;
            this.Last_routine_operations_fortnight = last_routine_operations_fortnight;
            this.Enable_request_products_separation_helper = enable_request_products_separation_helper;
            this.Auto_clear_cancelled_req = auto_clear_cancelled_req;
            this.Days_before_expiration = days_before_expiration;
            this.Enable_critical_stock_system = enable_critical_stock_system;
        }
    }
}
