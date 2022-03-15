using System;

class MainClass {
  public static void Main (string[] args) {
    if (args.Length != 0)
      Environment.Exit(testBench());

    Console.WriteLine ("Welcome to C Sharp Cricket");

    int innings1 = innings ("WCGS", 3);
    int innings2 = innings ("Wilsons", 3);

    /*
     * Task Three
     * Work our the winner and display the result
     */
  }

  /*
  * Task One
  * Innings. An innings in cricket a number of overs bowled to a team.
  * limited overs, the bowling team bowls a limited/set number of 
  * overs, e.g. 20 overs or 50 overs.
  *
  * Write a routine called innings() which:
  * Takes 2 parameters:
  *    Parameter 1: team_name - the name of the team that is playing
  *    Parameter 1: novers - the number of overs to be bowled in the 
  *    innings
  *
  * Returns: 
  *    The total number of runs scored by the team in the innings
  
  * The routine should call the routine over() for each over in the innings
  * For example, innings ("WCGS", 3) will return the number of runs scored
  * by WCGS in their 3 over innings
  */

  public static int innings (string team_name, int numOvers) {
  
  // Add validation for numOvers here

  /*
   * Call over() for each over in the innings
   */

    Console.WriteLine ("Implement innings() here...");
    return -1; // replace this with 
  }

  /*
   * Task Two
   * over() - an over in cricket is 6 balls bowled by the batting team
   *
   * Complete the subroutine over() which
   * - Takes a single parameter - the number of the current over
   *
   * Returns an integer - the total number of runs scored in that over
   *
   * The routine should prompt the user for the number of runs scored
   * on each ball of the over.
   */

  public static int over (int overNumber) {

    // Add validation on the overNumber here
    Console.WriteLine ("Implement over() here...");
    return -1;    // Replace this with your code
  }

 

  /*
  * Run the validation tests
  */

  public static int testBench() {
    Console.WriteLine ("over(-1): {0}", over (-1));
    Console.WriteLine ("innings (WCGS, -1): {0}", innings ("A", -1));
    return 0;
  } 
}
