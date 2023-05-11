//Initializing variables
decimal[] hedgehogArr = new decimal[3];

Random rand = new Random();
int pickedColor = -1;
decimal totalHedgehogs = 0;
int numEncounters = 0;

//Loop for user input , if user picked not existing color
while (pickedColor < 0 || pickedColor > 2)
{
    Console.WriteLine("Input your color: \n" 
                      + "0 - red \n" +
                      "1 - green \n" +
                      "2 - blue");
    pickedColor = int.Parse(Console.ReadLine());
}


//Creating random number of hedgehoss
for (int i = 0; i < hedgehogArr.Length; i++)
{
    hedgehogArr[i] = Math.Floor((decimal)rand.Next(0, int.MaxValue));
}

//Show what we have
Console.WriteLine("Red = " + hedgehogArr[0] + "\nGreen = " + hedgehogArr[1] + "\nBlue = " + hedgehogArr[2]);

//Get sum of all headgehogs
totalHedgehogs = hedgehogArr.Sum();

//Check if all headgehogs already have one color && if sum of hedgehogs == 0
if (totalHedgehogs == hedgehogArr[pickedColor])
{
    if (totalHedgehogs == 0)
    {
        numEncounters = -1;
    }
    numEncounters = 0;
}

//Looping till all hedgehogs become all color if this is possible
while (hedgehogArr[pickedColor] != totalHedgehogs)
{
    int firstColor = -1;
    int secondColor = -1;

    for (int i = 0; i < 3; i++)
    {
        if (i != pickedColor && hedgehogArr[i] > 0)
        {
            if (firstColor == -1)
                firstColor = i;
            else
            {
                secondColor = i;
                break;
            }
        }
    }

    if (firstColor == -1 || secondColor == -1)
    {
        numEncounters = -1;
        break;
    }

    hedgehogArr[firstColor]--;
    hedgehogArr[secondColor]--;
    hedgehogArr[pickedColor] += 2;
    numEncounters++;
}

//Output number of meetings
Console.WriteLine("Number of meetings = " + numEncounters);
return 0;


