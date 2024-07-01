using Microsoft.VisualBasic.FileIO;
using Warhammer_Combat_Simulator;
class index
{
    public static void Main(String[] args)
    {
        mathcore math = new mathcore();
        int n = 0, x = 5, y = 4, z = 10;
        while (true)
        {
            Console.WriteLine("Which choice would you like to make.");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Thank you for using this program.");
                    break;
                case 1:
                    Console.WriteLine("Shoot = ", z * math.shoot(x/6,y/6));
                    break;
                case 2:
                    Console.WriteLine("Shoot rr hit = ", z*math.shootplusrrhit(x/6,y/6));
                    break;
                case 3:
                    Console.WriteLine("Shoot rr wound = ", z*math.shootplusrrwound(n/6,y/6));
                    break;
                case 4:
                    Console.WriteLine("Shoot rr full = ", z*math.shootplusrrfull(n/6,y/6));
                    break;
                default:
                    break;
            }
        }
    }
}