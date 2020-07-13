using BLL.Interfaces;
using System;
using System.Collections.Generic;

namespace BLL.PaymentType
{
    /// <summary>
    /// Processing for any physical product type Payment
    /// </summary>
    public class Product : IPayment, ISlip, ICommission
    {
        public string Process(Dictionary<string, string> input)
        {
            string status = "Failed";
            try
            {
                string slipContent = string.Empty;
                string commissionPaymentData = string.Empty;
                GenerateSlip(slipContent);
                MakeCommissionPayment(commissionPaymentData);

                status = "success";
            }
            catch (Exception ex)
            {
                // log the exception
                status = status + ex.Message;
            }

            return status;
        }

        public void GenerateSlip(string content)
        {
            // Functionality for generating slip
        }

        public void MakeCommissionPayment(string data)
        {
            // Functionality for making payment
        }
    }
}
