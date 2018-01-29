using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Ki
    {
        public string GetNextStep(string[] buttonStates)
        {
            for (int i = 0; i < buttonStates.Length; i++)
            {
                if (buttonStates[i] == null)
                {
                    i = i + 1;
                    return i.ToString();
                }
                if (i == 9)
                {
                    i = 0;
                }
            }
            return null;
        }
    }
}
