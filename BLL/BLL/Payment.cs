using BLL.Interfaces;
using BLL.PaymentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Based on client input, will return specific object
    /// </summary>
    /// <param name="paymentFor"></param>
    /// <returns></returns>
    public class Payment
    {
        public IPayment GetObject(string paymentFor)
        {
            IPayment obj = null;

            try
            {
                switch (paymentFor.ToLower())
                {
                    case "book":
                        obj = new Book();
                        break;
                    case "membership":
                        obj = new Membership();
                        break;
                    case "product":
                        obj = new Product();
                        break;
                    case "videolearning":
                        obj = new VideoLearning();
                        break;
                }
            }
            catch (Exception ex)
            {
                // log the exception
            }

            return obj;
        }
    }
}
