namespace Visitor.Scripts
{
    public class Knight : Hit
    {
        public float Armor;


        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}