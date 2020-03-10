using System;

namespace DnD_Random_Loot
{
    class Program
    {
        static void Main(string[] args)
        {
           int coins = 0;
            int itemChoice = 0;
            var itemTier1 = new Random();
            bool Run = true;
            ItemList item; //The full Item List?
            item = new ItemList();
            
            //Maybe need new variables later, will find out
            do
            {
                try
                {
                    
                    Console.WriteLine("Enter the coins to be eaten by the loot bot");
                    coins = int.Parse(Console.ReadLine());
                    //Negative throw
                    if (coins < 0)
                    {
                        throw new NegativeNumberExeption();
                    }
                    //Exit clause
                    else if (coins == 0)
                    {
                        throw new IsZero();
                    }
                    //Actually do the work now
                    LootGeneration items = new LootGeneration(coins, itemChoice);
                    itemChoice = items.Tier;
                    coins = items.coinConverter(coins);
                    Console.WriteLine($"You have inserted {coins} at value of Y"); //Must choose teir
                    itemChoice = RandomItem(coins);
                    Console.WriteLine($"Your item is 'item_hex' {itemChoice} '{item.items1[itemChoice]}'");
                }
                //Catching time

                catch (NegativeNumberExeption negativeNumberException)
                {
                    Console.WriteLine($"You put in {coins} in here? {negativeNumberException.Message}");
                }
                catch (IsZero is0)
                {
                    Console.WriteLine(is0.Message);
                    char cont = char.Parse(Console.ReadLine());
                    if ((cont == 'y') || (cont == 'Y'))
                    {
                        Run = false;
                    }
                    else
                    {
                        Console.WriteLine("Aw sheit, here we go again.");
                    }
                }
                //End?
            } while (Run == true);




            //Coin stuff
             int RandomItem(int loot)
            {
                if (loot > 49)
                {
                    goodChances(loot);
                }
                if (loot <= 49)
                {
                    badChances(loot);
                }
                itemChoice = itemTier1.Next(loot, itemChoice);
                return itemChoice;
            }


            int goodChances(int loot)
            {
                if (coins == 99)
                {
                    coins = (coins + (itemChoice / 2));
                }
                if (coins <= 98 && coins >= 74)
                {
                    coins = (coins + (itemChoice / 4));
                }
                if (coins <= 55 && coins >= 50)
                {
                    coins = (coins + (itemChoice / 10) - 10);
                }
                return coins;
                
            }

            int badChances(int items)
            {

                if (coins <= 17)
                {
                    items -= itemTier1.Next(0, (items / 10));
                    items -= itemTier1.Next(0, (items / 10));
                    items -= itemTier1.Next(0, (items / 10));
                }
                if (coins < 34 && coins > 17)
                {
                    items -= itemTier1.Next(0, (items / 10));
                    items -= itemTier1.Next(0, (items / 10));
                }
                if (coins <= 49 && coins > 34)
                {
                    items -= itemTier1.Next(0, (items / 10));
                }

                return items;
            }

        }

    }
}
