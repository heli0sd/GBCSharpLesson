Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 20, ya = 1, 
    xb = 40, yb = 1,
    xc = 1, yc = 1,
    xd = 20, yd = 50,
    xe = 20, ye = 40,
    xf = 40, yf = 40;

int x = xa, y = xb;
int count = 0;

while(count < 100000)
{
    int what = new Random().Next(0, 6);
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if(what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if(what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    if(what == 3)
    {
        x = (x+xd)/2;
        y = (y+yd)/2;
    }
        if(what == 4)
    {
        x = (x+xe)/2;
        y = (y+ye)/2;
    }
        if(what == 5)
    {
        x = (x+xf)/2;
        y = (y+yf)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}