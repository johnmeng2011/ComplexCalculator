using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public class User:IUser
    {
        private int Id;
        private int AddRunTime;
        private int SubtractRunTime;
        private int MultiplyTime;
        private int DivideRunTime;
        public decimal ServiceFee { get; set; }

        public User()
        {
            AddRunTime = 0;
            SubtractRunTime = 0;
            MultiplyTime = 0;
            DivideRunTime = 0;
            ServiceFee = 0;
        }
        public int IncreaseAddTime()
        {
            throw new NotImplementedException();
        }

        public int IncreaseSubctractTime()
        {
            throw new NotImplementedException();
        }

        public int IncreaseMultiplyTime()
        {
            throw new NotImplementedException();
        }

        public int IncreaseDivideTime()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateServiceFee()
        {
            throw new NotImplementedException();
        }


    }
}
