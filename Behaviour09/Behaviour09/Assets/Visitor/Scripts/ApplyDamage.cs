using UnityEngine;

namespace Visitor.Scripts
{
    public class ApplyDamage : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision infoCollision)
        {
            hit.Health -= infoCollision.Damage;
            Debug.Log($"ApplyDamage.Visit: Health = {hit.Health}");
        }

        public void Visit(Knight hit, InfoCollision infoCollision)
        {
            var armor = hit.Armor;
            var damage = infoCollision.Damage;

            if (Random.Range(0, 100) <= 85)
            {
                if (armor <= infoCollision.Damage)
                {
                    damage = 0;
                }
                else
                {
                    damage = infoCollision.Damage - armor;
                }
            }

            hit.Health -= damage;
            Debug.Log($"ApplyDamage.Visit: Health = {hit.Health}");
        }
    }
}