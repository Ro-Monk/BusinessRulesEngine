using BLL.Interfaces;
using System;
using System.Collections.Generic;

namespace BLL.PaymentType
{
    public class VideoLearning : IPayment, ISlip
    {
        public string Process(Dictionary<string, string> input)
        {
            string status = "Failed";
            try
            {
                string slipContent = string.Empty;
                GenerateSlip(slipContent);

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
    }
}
