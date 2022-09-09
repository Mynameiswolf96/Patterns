using UnityEngine;

namespace Visitor.Scripts
{
    public class ConsoleDisplay : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision infoCollision)
        {
            Debug.Log($"ConsoleDisplay.Visit: {nameof(Enemy)}, Damage = {infoCollision.Damage}");
        }

        public void Visit(Knight hit, InfoCollision infoCollision)
        {
            Debug.Log($"ConsoleDisplay.Visit:  {nameof(Knight)}, Damage = {infoCollision.Damage}");
        }
    }
}