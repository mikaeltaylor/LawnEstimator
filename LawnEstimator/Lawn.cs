using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnEstimator
{
    class Lawn
    {
        public int lawnLength;
        public int lawnBase;
        public int lawnArea;

        public int LawnLength
        {
            get { return lawnLength; }
            set { this.lawnLength = lawnLength; }
        }
        public int LawnBase
        {
            get { return lawnBase; }
            set { this.lawnBase = lawnBase; }
        }
        public int LawnArea
        {
            get { return lawnBase; }
            set { this.lawnArea = lawnArea; }
        }
    }
}
