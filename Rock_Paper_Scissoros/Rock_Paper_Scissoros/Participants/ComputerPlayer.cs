using Rock_Paper_Scissoros.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissoros
{
    public class ComputerPlayer
    {
        public void Different_Options_From_User_Computer(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Options theOption = randomOption();

                switch (theOption)
                {
                    case Options.Paper:
                       
                        break;
                    case Options.Rock:
                        
                        break;

                    case Options.Scissors:
                        
                        break;
                }
            }
        }

        private Options randomOption()
        {
            throw new NotImplementedException();
        }
    }
}
