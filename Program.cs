using System;
using System.Collections.Generic;
using System.Linq;

Main();



void Main() 
{
  List<string> insults = new List<string>
  {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
  };

  // This code ensures we don't end up with duplicate insults
  List<string> indexes = new List<string>();
  var random = new Random();
  while (indexes.Count < 3) {
    int candidate = random.Next(insults.Count);
    if (!indexes.Contains(insults[candidate])) {
      indexes.Add(insults[candidate]);
    }
  }

  foreach (string index in indexes)
{
    Console.WriteLine(index);
}
}

// Remember getting a random integer in C# is different
// int getRandomInt(min, max) {
//   min = Math.ceil(min);
//   max = Math.floor(max);
//   return Math.floor(random.Next() * (max - min + 1)) + min;
// }
