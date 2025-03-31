using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Weapon deyə class yaradılır.
//Darağın güllə tutumu, Daraqdakı güllə sayı, atış modu (təkli və ya avtomatik) propertileri verilir.
//Shoot() -  metodu hər çağırıldıqda fire moduna gore ya 1 güllə atır yada avtomatik gulleni bosaldir.(Ekranda bunu bildirir)
//GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
//Reload() - darağı yenidən doldurur.
//ChangeFireMode() - Atış modunu dəyişir.
//Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
//0 - İnformasiya almaq üçün
//1 - Shoot metodu üçün (hazirki moda uygun gulle atacaq)
//2 - GetRemainBulletCount metodu üçün
//3 - Reload metodu üçün
//4 - ChangeFireMode metodu üçün
//5 - Proqramdan dayandırmaq üçün
//qısayoldur.
namespace Weapon
{
    public class FireMode
    {
        public static readonly string singleShot = "singleshot mode";
        public static readonly string multiShot = "multisshot mode";
    }

    public class Weapon : FireMode
    {
        public string name { get; set; }
        public int bulletCapacity { get; set; }
        public int currentBullets { get; set; }
        public string currentFireMode = singleShot;

        public Weapon(string name,int bulletCapacity)
        {
            this.name = name;
            this.bulletCapacity = bulletCapacity;
          
        }

        public void GetInfo()
        {
            
            Console.WriteLine(name);
            Console.WriteLine($"Weapons Bullet Capacity:{bulletCapacity}");
            Console.WriteLine($"Weapon Fire Mode:{currentFireMode}");
            Console.WriteLine($"Remaining bullets:{currentBullets}");
        }

        public void Shoot()
        {
            if (currentBullets > 0)
            {
                if (currentFireMode == singleShot)
                {
                    currentBullets--;
                    Console.WriteLine("A bullet has been shot.");
                }
                else
                {
                    currentBullets = 0;
                    Console.WriteLine("All bullets have been shot.");
                }
            }
            else
            {
                Console.WriteLine("There are no bullets in the shell.Please reload first.");
            }
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine($"Need {bulletCapacity - currentBullets} more bullets to fill the shell.");
        }
        public void Reload()
        {
            currentBullets = bulletCapacity;
            Console.WriteLine("Weapon reloaded ready to fire.");
        }
        public void ChangeFireMode()
        {
            if (currentFireMode == singleShot)
            {
                currentFireMode = multiShot;
                Console.WriteLine("Firemode:multishot");
            }
            else
            {
                currentFireMode = singleShot;
                Console.WriteLine("Firemode:singleshot");
            }
        }
    }
}  