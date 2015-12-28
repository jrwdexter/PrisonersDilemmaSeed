# PrisonersDilemmaSeed
A seed prisoner's dilemma bot to be played in the Nerdery open.

Basic bot has the logic:

```c#
// If our opponent is .NET, I like .NET - let's not rat them out.
  if (prisonerParameters.PartnersDiscipline == ".net")
      Console.WriteLine("silent");
  // If I've confessed the previous time OR the opponent confessed the previous time, retaliate. We'll keep on retaliating forever.
  else if (prisonerParameters.Response == "confess" || prisonerParameters.PartnerPreviousResponse == "confess")
      Console.WriteLine("confess");
  // Otherwise, let's live and let live.
  else
      Console.WriteLine("silent");
```
