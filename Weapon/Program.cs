namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon primaryWeapon1 = new Weapon("Bulldog", 24);
            //primaryWeapon1.GetInfo();
            //primaryWeapon1.Reload();
            //primaryWeapon1.GetInfo();
            //primaryWeapon1.Shoot();
            //primaryWeapon1.Shoot();
            //primaryWeapon1.Shoot();
            //primaryWeapon1.GetInfo();
            //primaryWeapon1.ChangeFireMode();
            //primaryWeapon1.Shoot();
            //primaryWeapon1.GetInfo();
            //primaryWeapon1.Reload();
            //primaryWeapon1.GetInfo();
            while (true)
            {
                Console.WriteLine("Enter a command:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "/0":
                        primaryWeapon1.GetInfo();
                        break;

                    case "/1":
                        primaryWeapon1.Shoot();
                        break;

                    case "/2":
                        primaryWeapon1.GetRemainBulletCount();
                        break;

                    case "/3":
                        primaryWeapon1.Reload();
                        break;

                    case "/4":
                        primaryWeapon1.ChangeFireMode();
                        break;

                    case "/5":
                        Console.WriteLine("Program stopped.");
                        return;

                    default:
                        Console.WriteLine("Invalid command.Try again.");
                        break;
                }

            }
        }
    }
}
