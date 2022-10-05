using BaseballGame;

Solution game = new Solution();
char[] space = new char[]{ ' ' };
string[] ops = Console.ReadLine().Split(space);
int output = game.CalPoints(ops);
Console.WriteLine(output.ToString());

