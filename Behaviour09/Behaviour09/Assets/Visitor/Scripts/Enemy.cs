namespace Visitor.Scripts
{
    public class Enemy : Hit
    {
        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}