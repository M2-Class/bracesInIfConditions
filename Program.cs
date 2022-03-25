using static System.Console;

double myPay, myBills, raiseAmount;

myPay = 500.00;
myBills = 750.00;

if (myPay < myBills)
    WriteLine("I need a raise!");

WriteLine("-------------------------------------------------");

//If you have multiple statements, then braces are needed as the initial semicolon terminates the statement:
myPay = 1000.00;
myBills = 750.00;
if (myPay < myBills)
    WriteLine("I need a raise!");
//the next 2 statements below should not be executed as the pay is more than the bills, however
//the semicolon at the end of the WriteLine above terminates the if statement and the WriteLine
//below will always be displayed, even when logically it should not.
raiseAmount = myBills - myPay;
WriteLine("My raise amount: {0}...It's negative! Not a reduction please!!", raiseAmount.ToString("C"));

WriteLine("-------------------------------------------------");
//As you can see below, the brakets group multiple statements in a logical unit, in 
//spite of the semicolons terminiating each statement.
myPay = 500.00;
myBills = 750.00;
if (myPay < myBills)
{
    WriteLine("I need a raise!");
    raiseAmount = myBills - myPay;
    WriteLine("My raise amount: {0}", raiseAmount.ToString("C"));
}

WriteLine("-------------------------------------------------");
//Now, none of the statements will be executed in the if condition
myPay = 1000.00;
myBills = 750.00;
if (myPay < myBills)
{
    WriteLine("I need a raise!");
    raiseAmount = myBills - myPay;
    WriteLine("My raise amount: {0}", raiseAmount.ToString("C"));
}