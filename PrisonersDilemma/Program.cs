using System;

namespace PrisonersDilemma
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prisonerParameters = new PrisonerParamters(args);

            // If our opponent is .NET, I like .NET - let's not rat them out.
            if (prisonerParameters.PartnersDiscipline == ".net")
                Console.WriteLine("silent");
            // Except Jonathan Dexter, screw that guy
            else if (prisonerParameters.PartnersName == "jonathan dexter")
                Console.WriteLine("confess");
            // If I've confessed the previous time OR the opponent confessed the previous time, retaliate. We'll keep on retaliating forever.
            else if (prisonerParameters.MyPreviousResponse == "confess" || prisonerParameters.PartnerPreviousResponse == "confess")
                Console.WriteLine("confess");
            // Otherwise, let's live and let live.
            else
                Console.WriteLine("silent");
        }
    }

    public class PrisonerParamters
    {
        public PrisonerParamters(string[] incomingArgs)
        {
            PartnersName = TryGetValue(incomingArgs, 0);
            PartnersDiscipline = TryGetValue(incomingArgs, 1);
            PartnerPreviousResponse = TryGetValue(incomingArgs, 2);
            MyPreviousResponse = TryGetValue(incomingArgs, 3);
        }

        public string PartnersName { get; }

        public string PartnersDiscipline { get; }

        public string MyPreviousResponse { get; }

        public string PartnerPreviousResponse { get; }

        private static string TryGetValue(string[] incomingArgs, int index)
        {
            return incomingArgs?.Length > index ? incomingArgs[index]?.ToLowerInvariant() : null;
        }
    }
}
