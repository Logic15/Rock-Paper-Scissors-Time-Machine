using System;

//MIT 2022 Martin//

namespace RockPaperScissorsTimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, Computer;
            int randomnum;
            string loop;
            bool keepPlaying = true;
            int inputPlayerint;
            int[,] truetable = new int[3, 3] { { 3, 2, 1 }, { 1, 3, 2, }, { 2, 1, 3} };
            string[] choices = { "Rock", "Scissors", "Paper", "Time Machine" };

            int wins = 0;
            int Loses = 0;
            int ties = 0;
            inputPlayerint = 0;
            int ComputerLastPlay = -1;
            int PlayerLastPlay = -1;

            while (keepPlaying)
            {

                Random myRandomObject = new Random();
                randomnum = myRandomObject.Next(0, 2);
                Console.Write("To play: enter R for Rock, S for Scissors, P for Paper, T for Time Machine. ");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();

                if (inputPlayer == "R") inputPlayerint = 0;
                if (inputPlayer == "S") inputPlayerint = 1;
                if (inputPlayer == "P") inputPlayerint = 2;
                if (inputPlayer == "T") inputPlayerint = 3;


                if (inputPlayerint == 3)
                    inputPlayerint = ComputerLastPlay;

                if (randomnum == 3) 
                    randomnum = PlayerLastPlay;
                
                PlayerLastPlay = inputPlayerint;
                ComputerLastPlay = randomnum;
               
                    // Console.WriteLine("{0}, {1}, {2}", choices[inputPlayerint], choices[randomnum], truetable[inputPlayerint, randomnum]);

                if (truetable[randomnum, inputPlayerint] == 1) 
                {
                    Console.WriteLine("Player played: {0}, Computer played: {1}, Player win", choices[inputPlayerint], choices[randomnum]);
                }
                if (truetable[randomnum, inputPlayerint] == 2)
                {
                    Console.WriteLine("Player played: {0}, Computer played: {1}, Computer win", choices[inputPlayerint], choices[randomnum]);
                }
                if (truetable[randomnum, inputPlayerint] == 3)
                {
                    Console.WriteLine("Player played: {0}, Computer played: {1}, Tie", choices[inputPlayerint], choices[randomnum]);
                }
                
            }
        }
    }
}