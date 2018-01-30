
using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class RandomKi : IKi
    {
        static Random rnd = new Random();
        public string GetNextStep(string[] buttonStates)
        {
            var emptyFields = new List<int>();
            for (int i = 0; i < buttonStates.Length; i++)
            {
                if (buttonStates[i] == null)
                {
                    emptyFields.Add(i + 1);
                }
            }
            int r = rnd.Next(emptyFields.Count);
            return emptyFields[r].ToString();
        }
    }
}
