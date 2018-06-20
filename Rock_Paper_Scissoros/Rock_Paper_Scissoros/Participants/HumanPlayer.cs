using Rock_Paper_Scissoros.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissoros
{
   public class HumanPlayer
    {
        public object selection;

        public void Check_Input_Of_Human_User(string input)
        {
            bool isValid;

            do
            { 
            Console.Write("Please enter a valid selection: ");
            input = Console.ReadLine().Trim();
            isValid = Enum.TryParse<Options>(input, true, out selection);
            } 
            while (!isValid);

        return selection;

        }
    }
}
