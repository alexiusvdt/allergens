using System;
using Test;

namespace MyProgram {
  class Program {
    static void Main(){
      Console.WriteLine("Please enter your allergen score:");
      int input = int.Parse(Console.ReadLine());
      Console.WriteLine(AllergenTest.YourAllergens(input));
    }

  }

}
