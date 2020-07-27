using System;
using System.Collections.Generic;

namespace RPG
{

    class Character 
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public Character(string thename, int thestrength, int theintelligence)
        {
            Name = thename;
            Strength = thestrength;
            Intelligence = theintelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} has {Strength} strength and {Intelligence} intelligence.");
        }
    }

    class Warrior : Character
    { 
    
        public string Weapon { get; set; }

        public Warrior(string thename, string theweapon, int thestrength, int theintelligence) 
        :base(thename,thestrength,theintelligence)
        {
            Weapon = theweapon;
            Name = thename;
            Strength = thestrength;
            Intelligence = theintelligence;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} has a {Weapon}, boasting a {Strength} for strength and a {Intelligence} in intelligence.");
        }
    }

    class MagicUsingCharacter : Character
    {

        public int MagicalEnergy;

    public MagicUsingCharacter(string thename, int themagicalenergy, int thestrength, int theintelligence) 
    :base(thename,thestrength,theintelligence)
        {
            Name = thename;
            MagicalEnergy = themagicalenergy;
            Strength = thestrength;
            Intelligence = theintelligence;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} has a pool of Magic Energy {MagicalEnergy} nethers deep, boasting a {Strength} for strength and a {Intelligence} in intelligence.");
        }

    }

    class Wizard : MagicUsingCharacter
    {
        int SpellNumber;

    public Wizard(string thename, int thespellnumber, int themagicalenergy, int thestrength, int theintelligence)
    :base(thename,themagicalenergy,thestrength,theintelligence)
        {
            Name = thename;
            SpellNumber = thespellnumber;
            MagicalEnergy = themagicalenergy;
            Strength = thestrength;
            Intelligence = theintelligence;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} has a pool of Magic Energy {MagicalEnergy} nethers deep with the potential of casting {SpellNumber} spells while boasting a {Strength} for strength and a {Intelligence} in intelligence.");
        }
    }

    //make another class like repairshop and make it like a universe or planet, 
    //add the heroes to the planet in the list
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> myList = new List<Character>();

            myList.Add(new Warrior("Miguel & Tulio","person to blame for any situation",16,16));
            myList.Add(new Warrior("Kolchek the Wise", "pair of boulders tied together with something incredibly durable",18,6));
            myList.Add(new Warrior("Sir Garrus", "finely calibrated Auto-Crossbow", 15, 19));
            myList.Add(new Warrior("D'artagnan the Hero", "French Épée and a hidden sidearm he would never use", 17, 17));
            myList.Add(new Warrior("Vaeliux the Daring", "Katana", 16, 20));
            myList.Add(new Wizard("Rayth Stalewind the Necromantic", 100, 200, 9, 25));
            myList.Add(new Wizard("Ihron Ekk", 1, 2, 18, 4));
            myList.Add(new Wizard("Doomthought the Frivelous", 10, 20, 16, 15));
            myList.Add(new Wizard("Gandalf - whom needs no further introduction", 42, 84, 16, 18));
            myList.Add(new Wizard("Merlin the Prophetic", 112, 224, 10, 21));

            Adventure(myList);

        }

        public static void Adventure(List<Character> myList)
        {
            Console.WriteLine($"Here are the heroes in your party.");
            foreach (Character thecharacter in myList)
            {
                thecharacter.Play();
                Console.WriteLine("");
            }
        }

    }
}
