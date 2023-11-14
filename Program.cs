// See https://aka.ms/new-console-template for more information
Console.WriteLine("********** Welcome to B.Hive! **********\n Please enter your name:  ");

string name = Convert.ToString(Console.ReadLine());
float PRICEA = 3.35f;
float PRICEB = 3.25f;
float PRICEC = 4.80f;
float PRICEWC = 0.75f;
char choiceBervarage;
char spanishLate;
char otherBervarage;
char whipped;
char confirmwc;
char otherDE;
int nturk = 0;
bool turkOk;
float sumOfTurk = 0;
float totalTurk = 0;
float sumOfDB = 0;
float sumOfEx = 0;
float sumSL = 0;
float totalSL = 0;
float totalDB = 0;
float sumTotalDB = 0;
float sumTotalEx = 0;
float totalBerverage = 0;
float taxa = 0.15f;
string cardC;
int mm = 0;
int yy = 0;
bool validCC = (mm >= 11 && yy == 23) || (mm >= 1 && mm <= 12 && yy >= 24 && yy <= 27) || (mm >= 1 && mm <= 11 && yy == 28);
int dig;


do
{


    Console.WriteLine($"What can I get you, {name}? \n a. Turkish Coffee ({PRICEA}$)\n b. Double Espresso ({PRICEB}$)\n c. Spanish Latte ({PRICEC}$))");
    choiceBervarage = Convert.ToChar(Console.ReadLine());


    switch (choiceBervarage)
    {

        case 'a':


            do
            {
                Console.WriteLine("How many Turkish Coffees would you like?(1-5)");

                nturk = Convert.ToInt16(Console.ReadLine());

                turkOk = nturk >= 1 && nturk <= 5;

            } while (turkOk == false);

            sumOfTurk += nturk;
            totalTurk = (sumOfTurk * PRICEA);

            break;

        case 'b':


            do
            {
                sumOfDB += 1;

                Console.WriteLine("Adding a Double Espresso to your order.\n Would you like some Whipped Cream with it? (y/n)");

                whipped = Convert.ToChar(Console.ReadLine());

                switch (whipped)
                {

                    case ('y'):

                        Console.WriteLine($"That’ll be an extra ({PRICEWC}$). Do you want to proceed with the extra charge? (y/n)");
                        confirmwc = Convert.ToChar(Console.ReadLine());

                        switch (confirmwc)
                        {
                            case ('y'):
                                sumOfEx += 1;
                                break;
                        }
                        break;
                }

                Console.WriteLine(" Would you like to add another Double Espresso (y/n)?");

                otherDE = Convert.ToChar(Console.ReadLine());

            } while (otherDE == 'y');
            sumTotalDB = (sumOfDB * PRICEB);
            sumTotalEx = (sumOfEx * PRICEWC);
            totalDB = (sumTotalDB + sumTotalEx);

            break;


        case 'c':


            Console.WriteLine("Adding a Spanish Latte to your order.\n ");

            do
            {
                sumSL += 1;

                Console.WriteLine("Would you like to add another Spanish Latte?(y/n)");
                spanishLate = Convert.ToChar(Console.ReadLine());

            } while (spanishLate != 'n');

            Console.WriteLine($" You have added {sumSL} Spanish Latte(s) to your order");

            totalSL = (sumSL * PRICEC);
            break;
    }

    do
    {
        Console.WriteLine("Would you like to add another beverage to your order?(y/n)");
        otherBervarage = Convert.ToChar(Console.ReadLine());
        if (otherBervarage != 'n' && otherBervarage != 'y')
        {

            Console.WriteLine("Sorry, I don't recognize this answer.");

        }
    } while (otherBervarage != 'n' && otherBervarage != 'y');

} while (otherBervarage != 'n');

totalBerverage = (totalTurk + totalSL + totalDB);

Console.WriteLine($" Your order summary:\n {sumOfTurk} Turkish Coffees @ {totalTurk}\n {sumSL} Spanish Latte @ {totalSL}\n {sumOfDB}  Double Espresso with Whipped Cream @{totalDB} \n Total {totalBerverage * taxa + totalBerverage}$");

Console.WriteLine("Please enter your 16 - digits credit card number: ");
cardC = Convert.ToString(Console.ReadLine());

do
{
    Console.WriteLine("Please enter the month (MM) and year (YY) of expiration – on separate lines:");
    mm = Convert.ToInt32(Console.ReadLine());
    yy = Convert.ToInt32(Console.ReadLine());

    validCC = (mm >= 11 && yy == 23) || (mm >= 1 && mm <= 12 && yy >= 24 && yy <= 27) || (mm >= 1 && mm <= 11 && yy == 28);

    if (validCC == false)
    {
        Console.WriteLine("Sorry, this is invalid.\nValid expiration range between November 2023 and November 2028");
    }
} while (validCC == false);

Console.WriteLine("Please enter your 3-digits CCV: ");
dig = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Thank you for visiting B.Hive, {name}! We will call your name\nwhen your order is ready. Have a great day!");


