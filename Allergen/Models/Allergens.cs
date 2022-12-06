namespace Test
{
  public class AllergenTest
  {
    public static string YourAllergens(int score)
    { 
      if(score == 0){
        return null;
      }
      else {
        int highestScore = 1;
        string allergen = null;
        while(highestScore <= score){
          highestScore *= 2;
        }
        highestScore /= 2;
        int newScore = score - highestScore;

        switch(highestScore)
        {
          case 1:
            allergen = "eggs";
            break;
          case 2:
            allergen = "peanuts";
            break;
          case 4:
            allergen = "shellfish";
            break;
          case 8:
            allergen = "strawberries";
            break;
          case 16:
            allergen = "tomatoes";
            break;
          case 32:
            allergen = "chocolate";
            break;
          case 64:
            allergen = "pollen";
            break;
          case 128:
            allergen = "cats";
            break;
        }

        return allergen + ", " + YourAllergens(newScore);
      }
      
      
    } 
  }
}
