using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IPayment
    {
        string Process(Dictionary<string, string> input);
    }
}
