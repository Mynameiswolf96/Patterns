namespace Visitor.Scripts
{
    public interface IDealingDamage
    {
        void Visit(Enemy hit, InfoCollision infoCollision);

        void Visit(Knight hit, InfoCollision infoCollision);
    }
}