using UnityEngine;

public class Wall : MonoBehaviour, IDamageable<float>
{
    public void Damage(float damage)
    {
        //TODO: Implement a damage scale.
    }

    public void Break()
    {
        Destroy(gameObject); //TODO: Implement breaking animation. 
        Debug.Log("Break!");
    }
}
