using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;



        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            int size = 8;

            if(name.Length < size)
            {
                this.name = name;
            }
            else
            {
                this.name = name.Substring(0, size);
            }
        }

        public void PickupPowerUp(PowerUp power, float powerUp)
        {
            if(power == PowerUp.Health)
            {
                this.health += powerUp;
                if(this.health > 100) this.health = 100;
            }

            if(power == PowerUp.Shield)
            {
                this.shield += powerUp;
                if(this.shield > 100) this.shield = 100;
            }
        }
    }
}