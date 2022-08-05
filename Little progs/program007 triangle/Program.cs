Console.Clear();

int xa = 50, ya = 1;
int xb = 1, yb = 30;
int xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("x");
Console.SetCursorPosition(xb, yb);
Console.Write("x");
Console.SetCursorPosition(xc, yc);
Console.Write("x");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int newPlot = new Random().Next(0, 3);
    if (newPlot == 0) {
        x = (x + xa)/ 2;
        y = (y + ya)/ 2;
    }   
    if (newPlot == 1) {
        x = (x + xb)/ 2;
        y = (y + yb)/ 2;
    }   
    if (newPlot == 2) {
        x = (x + xc)/ 2;
        y = (y + yc)/ 2;
    }   
    Console.SetCursorPosition(x, y);
    Console.Write("x");
    count ++;

}