using System;

namespace MachineGun
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineGunClass gun = new MachineGunClass();
            while (true)
            {
                Console.WriteLine($"{gun.Bullets} bullets, {gun.BulletsLoaded} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING: You're out of ammo");
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.Bullets += gun.MagazineSize;
                else if (key == 'q') return;
            }
        }
    }
}
