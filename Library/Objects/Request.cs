using System;
using System.Collections.Generic;
using System.Drawing;
using GC.Library.Objects.SubObjects.Request;

namespace GC.Library.Objects
{
    public class Request
    {
        public int Id { get; set; }
        public string Number { get; set; }//
        public double Value { get; set; }//
        public double Discount { get; set; }//
        public double Addition { get; set; }//
        public string Observations { get; set; }//
        public string Occurrences { get; set; }//
        public char Status { get; set; }//
        public DateTime StartedIn { get; set; }//
        public DateTime ExpiresIn { get; set; }//
        public DateTime DoneIn { get; set; }//
        public bool IsDelivery { get; set; }//
        public byte PaymentType { get; set; }//
        public List<Request_Jobs> Jobs = new List<Request_Jobs>();
        public List<Request_Products> Products = new List<Request_Products>();
        public int Id_Costumer { get; set; }
        public int Id_User { get; set; }
        //Payment type: 0 - Dinheiro, 1 - Cartão Débito, 2 - Cartão Crédito, 
        //3 - Cheque, 4 - Boleto, 5 - Débito recorrente and 6 - Fiado.

        public Request(){}

        public Request(int id, string number, double value, double discount, double addition, string observations, string occurrences, char status, DateTime started_in, DateTime expires_in, DateTime done_in, bool is_delivery, byte payment_type, int id_costumer, int id_user)
        {
            this.Id = id;
            this.Number = number;
            this.Value = value;
            this.Discount = discount;
            this.Addition = addition;
            this.Observations = observations;
            this.Occurrences = occurrences;
            this.Status = status;
            this.StartedIn = started_in;
            this.ExpiresIn = expires_in;
            this.DoneIn = done_in;
            this.IsDelivery = is_delivery;
            this.PaymentType = payment_type;
            this.Id_Costumer = id_costumer;
            this.Id_User = id_user;
        }

        internal bool IsEqual(Request request)
        {
            if (this.Number == request.Number) return true;
            else return false;
        }

        //Payment type: 0 - Dinheiro, 1 - Cartão Débito, 2 - Cartão Crédito, 
        //3 - Cheque, 4 - Boleto, 5 - Débito recorrente and 6 - Fiado.
        internal string PaymentTypeToString()
        {
            switch (this.PaymentType)
            {
                case 0:
                    return "Dinheiro";
                case 1:
                    return "Cartão de Débito";
                case 2:
                    return "Cartão de Crédito";
                case 3:
                    return "Cheque";
                case 4:
                    return "Boleto";
                case 5:
                    return "Débito Recorrente";
                default:
                    return "Fiado";
            }
        }

        internal static string GetStatusString(Request request)
        {
            if (request.Status == 'P') return "Pendente";
            else if (request.Status == 'F') return "Finalizado";
            else if (request.Status == 'A') return "Atrasado";
            else return "Cancelado";
        }

        internal static Color GetStatusColor(Request request)
        {
            if (request.Status == 'P') return Color.FromArgb(0, 33, 149, 170);
            else if (request.Status == 'C') return Color.FromArgb(0, 194, 43, 70);
            else if (request.Status == 'F') return Color.FromArgb(0, 70, 159, 120);
            else return Color.FromArgb(0, 230, 181, 34);
        }   

        internal static void SortGlobalRequests()
        {
            GlobalVariables.Requests.Sort((x, y) => DateTime.Compare(x.StartedIn, y.StartedIn));
        }

        internal static void SortGlobalOldRequests()
        {
            GlobalVariables.OldRequests.Sort((x, y) => DateTime.Compare(x.StartedIn, y.StartedIn));
        }

        internal static void SortGlobalCancelledRequests()
        {
            GlobalVariables.CancelledRequests.Sort((x, y) => DateTime.Compare(x.StartedIn, y.StartedIn));
        }

        /// <summary>
        /// If the request has the started_in 120 late than DateTime.Now it will return -1, the same returns 0 else returns 1;
        /// </summary>
        /// <param name="request">The request to be comparated and selected.</param>
        /// <returns>The comparator result of the request.StartedIn.</returns>
        internal static int CompareStartedToOld(Request request)
        {            
            DateTime old = DateTime.Now.AddDays(GlobalVariables.FragileData.RequestDaysOnDb * -1);
            return DateTime.Compare(request.StartedIn, old);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="started_in"></param>
        /// <returns></returns>
        internal static bool RequestIsOld(DateTime started_in)
        {            
            DateTime old = DateTime.Now.AddDays(GlobalVariables.FragileData.RequestDaysOnDb * -1);
            if (started_in.CompareTo(old) <= 0) return true;
            else return false;
        }      
    }
}
