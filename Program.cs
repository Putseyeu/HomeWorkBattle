using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            float healthBoss = 500;
            float healthPlayer = 300;
            string nameBoss = "Boss";
            string namePlayer;
            float fireBall = 50;
            float iceArrow = 30;
            float electricWhip = 20;
            Random random = new Random();
            Random randomDamageBoss = new Random();
            Random randomMagic = new Random();
            int randomMagicMin = 20;
            int randomMagicMax = 41; 
            float amplifyMagic;
            string inputPlayer;
            float damageBoss;
            float damagePlayer;
            int damageBossMin = 30;
            int damageBossMax = 50;
            Random randomPercentageCold = new Random();
            int percentageColdMin = 25;
            int percentageColdMax = 50;
            int conversionInterest = 100;
            Console.WriteLine("Здравствуй путник! Назови своё имя, сразившись со мной и победив меня " +
                "сможешь пройти дальше!");
            namePlayer = Console.ReadLine();
            Console.WriteLine($"Ну что {namePlayer} я великий {nameBoss} и сегодня ты почувствуешь горечь поражения!!!");

            while (healthBoss > 0 && healthPlayer > 0)
            {
                Console.WriteLine($"Уровень здоровья {namePlayer} {healthPlayer}, здоровье {nameBoss} {healthBoss}");
                Console.WriteLine("Выберети заклинания из вашей книги заклинаний!!!\n" +
                    "1 - Огненый шар. Не возможно уклониться, но может нанести урон на заклинателя\n" +
                    "2 - Ледяная Стрела. Противник может уклониться, будьте внимательны частично урон может попасть по вам.\n" +
                    "3 - Электрический кнут.Безопастно для заклинателя, но наносит меньший урон. Может ослепить противника.\n");
                
                string spellPlayer = Console.ReadLine();

                if (spellPlayer == "1")
                {
                    Console.WriteLine("Хотите усилить заклинание? произнесите святое заклинание ЯЮНИОР ");
                    inputPlayer = Console.ReadLine();
                    if (inputPlayer == "ЯЮНИОР")
                    {
                        amplifyMagic = randomMagic.Next(randomMagicMin, randomMagicMax);
                        Console.WriteLine($"{namePlayer} сила вашего заклинания увеличина на {amplifyMagic} едениц");
                    }
                    else
                    {
                        amplifyMagic = 0;
                    }

                    Console.WriteLine("Произносите заклинания и на противника летит огненый шар!");
                    int battle = random.Next(0, 2);
                    if (battle == 0)
                    {
                        damagePlayer = fireBall + amplifyMagic;
                        healthBoss -= damagePlayer;                        
                        Console.WriteLine($"{namePlayer} нанес урон {nameBoss} {damagePlayer} единиц урона");
                        damageBoss = randomDamageBoss.Next(damageBossMin, damageBossMax);
                        healthPlayer -= damageBoss;
                        Console.WriteLine($"{nameBoss} наносит ответный урон {damageBoss}");
                    }
                    else
                    {
                        float damageFireBAll = fireBall + amplifyMagic;
                        healthBoss -= damageFireBAll;
                        healthPlayer -= damageFireBAll;
                        Console.WriteLine($"{namePlayer} нанес урон {damageFireBAll} единиц урона, " +
                            $"но огонь зацепил и вас!" +
                            $"вы также получили {damageFireBAll} единиц урона");
                    }

                }
                else if (spellPlayer == "2")
                {
                    Console.WriteLine("Хотите усилить заклинание? произнесите святое заклинание ЯЮНИОР ");
                    inputPlayer = Console.ReadLine();
                    if (inputPlayer == "ЯЮНИОР")
                    {
                        amplifyMagic = randomMagic.Next(randomMagicMin, randomMagicMax);
                        Console.WriteLine($"{namePlayer} сила вашего заклинания увеличина на {amplifyMagic} едениц");
                    }
                    else
                    {
                        amplifyMagic = 0;
                    }

                    Console.WriteLine("Произносите заклинания и на противника летит ледяная стрела!");
                    int battle = random.Next(0, 2);
                    if (battle == 0)
                    {
                        damagePlayer = iceArrow + amplifyMagic;
                        healthBoss -= damagePlayer;
                        Console.WriteLine($"{namePlayer} нанёс урон {nameBoss} {damagePlayer} единиц урона");
                        Console.WriteLine($"{nameBoss} холодно, противник замедлился и вы увернулись от урона. ");
                    }
                    else
                    {
                        damagePlayer = iceArrow + amplifyMagic;
                        healthBoss -= damagePlayer;
                        int percentageCold = randomPercentageCold.Next(percentageColdMin, percentageColdMax);
                        float damagIceArrowFoPlayer = damagePlayer * (percentageCold / conversionInterest);
                        healthPlayer -= damagIceArrowFoPlayer;
                        Console.WriteLine($"{namePlayer} нанес урон {nameBoss} {damagePlayer} единиц урона, " +
                            $"но холод зацепил и  вас!" +
                            $"нанеся  {damagIceArrowFoPlayer} единиц урона");
                        damageBoss = randomDamageBoss.Next(damageBossMin, damageBossMax);
                        Console.WriteLine($"{nameBoss} наносит по {namePlayer} ответный урон {damageBoss} единиц урона");
                    }
                }

                else if (spellPlayer == "3")
                {
                    Console.WriteLine("Хотите усилить заклинание? произнесите святое заклинание ЯЮНИОР ");
                    inputPlayer = Console.ReadLine();
                    if (inputPlayer == "ЯЮНИОР")
                    {
                        amplifyMagic = randomMagic.Next(randomMagicMin, randomMagicMax);
                        Console.WriteLine($"{namePlayer} сила вашего заклинания увеличина на {amplifyMagic} едениц");
                    }
                    else
                    {
                        amplifyMagic = 0;
                    }
                    Console.WriteLine("Произносите заклинания и бьёте противника электрическим кнутом.");
                    int battle = random.Next(0, 2);
                    if (battle == 0)
                    {
                        damagePlayer = electricWhip + amplifyMagic;
                        healthBoss -= damagePlayer;
                        Console.WriteLine($"{namePlayer} наносит {damagePlayer} урона!");
                        battle = random.Next(0, 2);
                        if(battle == 0)
                        {
                            Console.WriteLine($"{nameBoss} ослеплен и не может нанести урон {namePlayer}");
                        }
                        else
                        {
                            damageBoss = randomDamageBoss.Next(damageBossMin, damageBossMax);
                            healthPlayer -= damageBoss;
                            Console.WriteLine($"{nameBoss} наносит ответный удар и нанёс {damageBoss} единиц урона!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{nameBoss} увернулся и готов нанести ответный удар!");
                        battle = random.Next(0, 2);
                        if (battle == 0)
                        {
                            damageBoss = randomDamageBoss.Next(damageBossMin, damageBossMax);
                            healthPlayer -= damageBoss;
                            Console.WriteLine($"{nameBoss} наносит {namePlayer}  {damageBoss} урона.");
                        }
                        else
                        {
                            Console.WriteLine($"{namePlayer} увернулся от удара и не получает урон!");
                        }
                    }
                }
            }

            if (healthBoss <= 0 && healthPlayer <=0)
            {
                Console.WriteLine($"{nameBoss} и  {namePlayer} пали в бою. Побидителя нету! ");
            }
            else if(healthPlayer <= 0)
            {
                Console.WriteLine($"{nameBoss} сразил {namePlayer}.");
            }
            else if(healthBoss <= 0)
            {
                Console.WriteLine($"{namePlayer} победил {nameBoss} в этой битве.");
            }
        }
    }
}

