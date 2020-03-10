using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * 
 *         THERE ARE 619 ITEMS
 *              CALCULATE AS NEEDED
 * 
 */
namespace DnD_Random_Loot
{
    class LootGeneration
    {
        private int coin = 0;
        private int tier = 0;
        //Maybe add more later
        public LootGeneration(int coin, int tier)
        {
            Coin = coin;
            Tier = tier;
        }

        public int Coin
        {
            get
            {
                return coin;

            }
            private set
            {
                if (value >= 1)
                {
                    coin = value;
                }

            }
        }

        public int Tier
        {
            get
            {
                return tier;
            }
            private set
            {
                if (Coin >= 1 && Coin <= 99)// Actually is "258" items
                {
                    tier = 259;
                }
                if (Coin >= 100 && Coin <= 499)// Actually is "125" items; Items are labled '259-383'
                {
                    tier = 383;
                }
                if (Coin >= 500 && Coin <= 999)// Actually is "23" items; Items are labled '384-406'
                {
                    tier = 406;
                }
                if (Coin >= 1000 && Coin <= 4999)// Actually is "171" items; Items are labled '407-577'
                {
                    tier = 577;
                }
                if (Coin >= 5000)// Actually is "43" items; Items are labled '578-620'
                {
                    tier = 620;
                }
            }
        }
        public int coinConverter(int coins)//Coin value is as follows: 100 copper = 1 silver, 100 silver = 1 gold, 100 gold = 1 electrum, 100 electrum = 1 platinun
        {
            while (coins >= 100000)
            {
                coins = (coins - 100000);
                coins += 10000;
            }

            while (coins >= 10000 && coins < 100000)
            {
                coins = (coins - 10000);
                coins += 1000;
            }

            while (coins >= 1000 && coins < 10000)
            {
                coins = (coins - 1000);
                coins += 100;
            }

            while (coins >= 100 && coins < 1000)
            {
                coins = coins - 100;
                coins++;
            }
            return coins;
        }
    }
}

 