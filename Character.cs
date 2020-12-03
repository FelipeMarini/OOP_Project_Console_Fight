namespace First_OOP_Project
{
    public class Character
    {
        public string name;
        public int age;
        public string armor;
        public string AI = "Jarvis";

        public int HP = 100;

// System.Console.WriteLine("Hello World!");   

// aqui podemos "puxar" o comando WriteLine que é originário de System usando ".System" 

// ou "ctrl + ." acessa um menu para corrigir alguns bugs e comandos como colocar "using System" para usar WriteLine

        public int AttackA() {

            return 100;
        
        }
        
        public int AttackB() {

            return 20;
        
        }
        
        public int Defend(int attack) {     // o void não fornece nenhum "return"

            
            this.HP = this.HP - attack;
            
            return this.HP = this.HP - attack;

        }




    }
}