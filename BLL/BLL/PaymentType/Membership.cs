using BLL.Interfaces;
using System;
using System.Collections.Generic;

namespace BLL.PaymentType
{
    public class Membership : IPayment, IEmail
    {
        public string Process(Dictionary<string, string> input)
        {
            string status = "Failed";
            try
            {
                if (input.ContainsKey("userType"))
                {
                    if (input["userType"].ToLower() == "new")
                        ActivateMemberShip();
                    else if (input["userType"].ToLower() == "old")
                        UpgradeMemberShip();

                }

                status = "success";
            }
            catch (Exception ex)
            {
                // log the exception
                status = status + ex.Message;
            }

            return status;
        }

        private void ActivateMemberShip()
        {
            // functionality for activating membership

            BuildMail("");
            SendMail("", "");
        }

        private void UpgradeMemberShip()
        {
            // functionality for activating membership

            BuildMail("");
            SendMail("", "");
        }

        public void BuildMail(string content)
        {
            // functionality for Building mail
        }

        public void SendMail(string receipient, string subject)
        {
            // functionality for sending mail
        }
    }
}
