using System;

namespace SelfTrainingProject.InterviewExcesize.ReversingAString
{
    class Program
    {
        static void Main(string[] args)
        {
            // entered backwards string that will show in reverse and be readable on the console.
            string StringExample = "noitartsnomed lasrever gnirts rof sdrow fo gnirts gnoL";

            char[] ChararrayExample = StringExample.ToCharArray();
            Array.Reverse(ChararrayExample);
            string ReversedStringExample = new string(ChararrayExample);

            Console.Write(ReversedStringExample);
        }
    }
}
