
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
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

        public bool stunned = false;
        public float stunTimer;

        public bool blocking = false;
        public float blockTimer;

        public Character(string name = "Unnamed", int speed = 1, int health = 1, int power = 1)
        {
            this.name = name;
            this.speed = speed;
            this.maxHealth = health;
            this.health = maxHealth;
            this.power = power;
        }

        public virtual void Update(double dt)
        {
            if (stunned) StunTimer(dt);
            if (blocking) BlockTimer(dt);
        }

        public virtual void UseMove(Character target, int moveNum)
        {
            Move move = moves[moveNum];

            if (move.ready)
            {
                // Apply damage to opponent
                int damage = 0;
                if (move.damage > 0) damage = move.damage + power * 2; // calculate damage for move only when damage on move is > 0
                target.TakeDamage(damage);

                // Apply healing to user
                if (health + move.healing > maxHealth) health = maxHealth;
                else health += move.healing;

                // Stun target
                if (move.stun > 0)
                {
                    target.GetStunned(move.stun);
                }

                // Blocking
                if (move.block > 0)
                {
                    Block(move.block);   
                }

                moves[moveNum].ready = false;
            }
        }

        public void TakeDamage(int damage)
        {
            if (!blocking)
            {
                if (health - damage < 0) health = 0; // drop to 0 if would otherwise result in negative health
                else health -= damage; // apply damage
            }
        }

        public void GetStunned(float time)
        {
            stunned = true;
            stunTimer = time;
        }

        public void StunTimer(double dt)
        {
            if (stunTimer > 0)
            {
                stunTimer -= (float)dt;
            }
            else
            {
                stunTimer = 0;
                stunned = false;
            }
        }

        public void Block(float time)
        {
            blocking = true;
            blockTimer = time;
        }

        public void BlockTimer(double dt)
        {
            if (blockTimer > 0)
            {
                blockTimer -= (float)dt;
            }
            else
            {
                blockTimer = 0;
                blocking = false;
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

        public void ForceEndBlock()
        {
            blocking = false;
            blockTimer = 0;
        }

        public void ForceEndStun()
        {
            stunned = false;
            stunTimer = 0;
        }
    }
}
