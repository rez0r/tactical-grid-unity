public interface IDamageable<T>
{
    void Damage(T damageTaken);

    void Break(); //TODO: Consider implemeting a IBreakable and IExplodable interfaces.
}
