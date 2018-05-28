using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public interface IUser
    {
        int IncreaseAddTime();
        int IncreaseSubctractTime();
        int IncreaseMultiplyTime();
        int IncreaseDivideTime();

        decimal CalculateServiceFee();
    }
}
