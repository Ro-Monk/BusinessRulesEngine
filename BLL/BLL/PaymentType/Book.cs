using BLL.Interfaces;
using System;
using System.Collections.Generic;

namespace BLL.PaymentType
{
    public class Book : IPayment, ISlip, ICommission
    {
        /// <summary>
        /// Processing for Book type Payment
        /// </summary>
        /// <param name="input"></param>
        public string Process(Dictionary<string, string> input)
        {
            string status = "Failed";
            try
            {
                string slipContent = string.Empty;
                string slipContentForRoyalty = string.Empty;
                string commissionPaymentData = string.Empty;

                GenerateSlip(slipContent);
                GenerateSlip(slipContentForRoyalty);
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
