using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public List<Character> Characters { get; set; }
        public int CurrentTurn { get; set; }
        public int TurnTime { get; set; }
        public bool IsRunning { get; set; }

        public Game(List<Character> characters, int turnTime)
        {
            Characters = characters;
            TurnTime = turnTime;
            IsRunning = true;
        }

        public void Start()
        {
            while (IsRunning)
            {
                Console.WriteLine("--- Tour " + (CurrentTurn + 1) + " ---");

                // Exécution des actions de chaque personnage
                foreach (Character character in Characters)
                {
                    character.TakeAction();
                }

                CurrentTurn++;

                // Attente avant le prochain tour
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public bool IsAlive { get; set; }

        public Character(string name, int health, int attack, int defense, int speed)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            IsAlive = true;
        }

        public virtual void TakeAction()
        {
            // Implémentation de l'action à exécuter au tour par tour
        }
    }

    public class Player : Character
    {
        public Player(string name, int health, int attack, int defense, int speed) : base(name, health, attack, defense, speed)
        {
        }

        public override void TakeAction()
        {
            // Implémentation de l'action du joueur
        }
    }

    public class Enemy : Character
    {
        public Enemy(string name, int health, int attack, int defense, int speed) : base(name, health, attack, defense, speed)
        {
        }

        public override void TakeAction()
        {
            // Implémentation de l'action de l'ennemi
        }
    }
}