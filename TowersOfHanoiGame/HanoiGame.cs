using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    public class HanoiGame
    {
        private int disk;
        private int from;
        private int to;
        private int aux;




        public void Setup()
        {

            string input = "";
            do
            {
                Console.WriteLine("請輸入河內塔的高度：");
                input = Console.ReadLine();
                if (int.TryParse(input, out disk))
                {
                    break;
                }
                Console.WriteLine("輸入錯誤，請重新輸入:");
                                

            } while (true);

            do
            {
                Console.WriteLine("請輸入起始地的柱子：");
                input = Console.ReadLine();
                if (int.TryParse(input, out from))
                {
                    break;
                }
                Console.WriteLine("輸入錯誤，請重新輸入:");





            } while (true);

            do
            {
                Console.WriteLine("請輸入目的地的柱子：");
                input = Console.ReadLine();
                if (int.TryParse(input, out to))
                {
                    break;
                }
                Console.WriteLine("輸入錯誤，請重新輸入:");


            } while (true);

            

        }

        public void Play()
        {
            #region // 取得 第三柱子
            /* 例如 輸入 1 3  得到  2
             *      輸入 1 2  得到  3
             *      輸入 2 3  得到  1
             */
            int aux = 0;
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    aux = item;
                    break;
                }
            }
            #endregion

            Hanoi(disk, from, to, aux);
            Console.ReadKey();

        }

        public void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }

        }


    }
}



