using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public class ComplexNumber: IComparable<ComplexNumber>
    {
        public double Real { get;  }
        public double Image { get; }

        public ComplexNumber(double real, double image)
        {
            this.Real = real;
            this.Image = image;
        }

        public ComplexNumber()
        {
            Real = 0.0;
            Image = 0.0;
        }
        
        public override string ToString()
        {
            return Real.ToString("##.000") + (Image>=0? "+":"") + Image.ToString("##.000") + "i";
        }

      

        public int CompareTo(ComplexNumber other)
        {
            if (this.ToString()==other.ToString()) return 0;
            else if(this.Real*this.Real+ this.Image*this.Image > other.Real*other.Real+other.Image* other.Image)
                return 1;
            else return -1;
        }
    }

    
}
