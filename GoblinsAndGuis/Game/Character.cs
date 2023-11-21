
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class Character : GameObject
    {

        public Move[] moves = new Move[4];
        public List<string> dialogueOptions = new List<string>();

        // Attributes
        public string name { get; set; }
        public int speed { get; set; } // For npc, how many seconds between their move attempts, for player, reduces cooldown times
        public int maxHealth { get; set; }
        public int health { get; set; }
        public int power { get; set; }

        public int level = 1;
        public int experience = 0;

        public Character(string name = "Unnamed", int speed = 1, int health = 1, int power = 1)
        {
            this.name = name;
            this.speed = speed;
            this.maxHealth = health;
            this.health = maxHealth;
            this.power = power;
        }

        public void UseMove(Character target, int moveNum)
        {
            if (moves[moveNum].ready)
            {
                // Apply damage to opponent
                int damage = 0;
                if (moves[moveNum].damage > 0) damage = moves[moveNum].damage + power * 2;

                if (target.health - damage < 0) target.health = 0;
                else target.health -= damage;
                // Apply healing to user
                if (health + moves[moveNum].healing > maxHealth) health = maxHealth;
                else health += moves[moveNum].healing;
                //

                moves[moveNum].cooldownTimer = moves[moveNum].cooldownTime;
                moves[moveNum].ready = false;
            }
        }

        public void GainExperience(int amount)
        {
            experience += amount;
            if (experience > 25 * (level*level)) LevelUp();
        }

        public void LevelUp()
        {
            level++;
        }
    }
}
