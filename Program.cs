// Write code that generates three random numbers and displays them in output 
// What is a Boolean expression?

/*
 A Boolean expression is any code that returns a Boolean value, either true or false. The simplest Boolean expressions are simply the values true and false. Alternatively, a Boolean expression could be the result of a method that returns the value true or false.
*/

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox")){
    Console.WriteLine("What does the fox says?");
}


///// Write code that generates three random numbers and displays them in output 
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//Add an if statement to display different messages based on the value of the total variable

/*if(total > 14){
     Console.WriteLine("You win!");
}
if(total < 15){
    Console.WriteLine("You lose.");
}*/

// Add another if statement to implement the doubles bonus
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// Add another if statement to implement the triples bonus
if ((roll1 == roll2)  && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
