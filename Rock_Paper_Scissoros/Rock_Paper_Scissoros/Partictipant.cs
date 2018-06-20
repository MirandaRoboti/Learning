using Rock_Paper_Scissoros.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissoros
{
    abstract class Partictipant
    {
        public int wins { get; set; }
        float _winRate;
        protected Options selection;

        protected float winRate
        {
            get
            {
                return _winRate;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("value cannot be less than or greater than ");
                }
                _winRate = value;
            }
        }

        public abstract Options Select();

    }
}
