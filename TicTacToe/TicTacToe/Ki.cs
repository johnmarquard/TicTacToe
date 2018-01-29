
namespace TicTacToe
{
    public class Ki
    {
        public string GetNextStep(string[] buttonStates)
        {
            int turn = 0;
            for (int i = 0; i < buttonStates.Length; i++)
            {
                if (buttonStates[i] == "X")
                {
                    turn = turn + 1;
                }

                if (buttonStates[i] == "Y")
                {
                    turn = turn + 1;
                }

            }
                if (turn == 1)
            {
                if (buttonStates[4] == "X")
                {
                    return 3.ToString();
                }
            }
            else
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
            }
            return null;
        }
    }
}
