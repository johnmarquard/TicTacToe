using System;

namespace TicTacToe
{
    class FirstFreeFieldKi : IKi
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

            }
            throw new Exception("No Fields left");
        }
    }
}

