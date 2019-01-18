using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class FightingRobot
    {
        //Atributos
        private string name;
        private int maxHP;
        private int currentHP;
        private int maxEP;
        private int currentEP;
        private int attackPower;
        static Random r = new Random();

        //Propiedades
        public string Name
        {
            get
            {
                return name;
            }
        }

        public int MaxHp
        {
            get
            {
                return maxHP;
            }
        }

        public int CurrentHP
        {
            get
            {
                return currentHP;
            }
        }

        public int MaxEp
        {
            get
            {
                return maxEP;
            }
        }

        public int CurrentEP
        {
            get
            {
                return currentEP;
            }
        }

        public int AttackPower
        {
            get
            {
                return attackPower;
            }
        }

        //Constructores
        public FightingRobot(string name, int maxHP,int currentHP,int maxEP,int currentEP,int attackPower)
        {
            if(name == "" || maxHP < 0 || currentHP < 0 || maxEP < 0 ||currentEP < 0 || attackPower < 0)
            {
                throw new Exception("Nombre vacio o valores de vida y energia menores que 0");
            }
            else
            {
                this.name = name;
                this.maxHP = maxHP;
                this.currentHP = currentHP;
                this.maxEP = maxEP;
                this.currentEP = currentEP;
                this.attackPower = attackPower;
            }
        }

        public FightingRobot(string name)
        {
            if(name == "")
            {
                throw new Exception("Nombre vacio");
            }
            else
            {
                this.name = name;
                int[] valorV = new int[5] { 200, 225, 250, 275, 300 };
                int[] valorE = new int[4] { 50, 80, 120, 150 };
                int[] valorA = new int[6] { 25, 30, 35, 40, 45, 50 };
                int aleatorio = r.Next(0, 4 + 1);
                maxHP = valorV[aleatorio];
                aleatorio = r.Next(0, 3+1);
                maxEP = valorE[aleatorio];
                aleatorio = r.Next(0, 5 + 1);
                attackPower = valorA[aleatorio];
                currentEP = maxEP;
                currentHP = maxHP;
            }
        }

        //Metodos

        public override string ToString()
        {
            string cadena;

            cadena = name + ":[HP=" + currentHP + "/" + maxHP + "] [EP=" + currentEP + "/" + maxEP + "] [Attack=" + attackPower + "]";

            return cadena;
        }

        public void Attack(FightingRobot tarjet)
        {

            tarjet.currentHP = tarjet.currentHP - attackPower;
            if (tarjet.currentHP < 0)
            {
                tarjet.currentHP = 0;
            }

        }

        public void SpecialAttack(FightingRobot tarjet)
        {
            if (currentEP < 50)
            {
                tarjet.currentHP = currentHP;
                currentEP = 0;
            }
            else
            {
                tarjet.currentHP = tarjet.currentHP - (attackPower * 2);
                if (tarjet.currentHP < 0)
                {
                    tarjet.currentHP = 0;
                }
                currentEP = currentEP - 50;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            int turn = 0;
            ConsoleKeyInfo option;

            FightingRobot[] robots = { new FightingRobot("Megatrón"), new FightingRobot("Ultratrón") };

            Console.WriteLine("Today's Robot Fight:");
            Console.WriteLine(robots[0]);
            Console.WriteLine("vs.");
            Console.WriteLine(robots[1]);
            Console.WriteLine();
            Console.Write(new string('-', 120));

            while (robots[0].CurrentHP > 0 && robots[1].CurrentHP > 0)
            {
                Console.WriteLine("Round " + round);

                Console.WriteLine(robots[0]);
                Console.WriteLine(robots[1]);
                Console.WriteLine();
                Console.WriteLine(robots[turn].Name + ", is your turn!");
                Console.WriteLine("1-Attack");
                Console.WriteLine("2-Special Attack (needs 50 EP)");

                option = Console.ReadKey(true);
                while (option.KeyChar != '1' && option.KeyChar != '2')
                {
                    option = Console.ReadKey(true);
                }

                if (option.KeyChar == '1')
                {
                    robots[turn].Attack(robots[(turn + 1) % 2]);
                }
                else
                {
                    robots[turn].SpecialAttack(robots[(turn + 1) % 2]);
                }
                Console.Write(new string('-', 120));

                turn = (turn + 1) % 2;
                round++;
            }

            Console.WriteLine("FINAL RESULT:");
            Console.WriteLine(robots[0]);
            Console.WriteLine(robots[1]);
            Console.WriteLine();
            if (robots[0].CurrentHP > 0)
            {
                Console.WriteLine(robots[0].Name + " WINS!!!");
            }
            else
            {
                Console.WriteLine(robots[1].Name + " WINS!!!");
            }

            Console.ReadKey();
        }
    }
}
