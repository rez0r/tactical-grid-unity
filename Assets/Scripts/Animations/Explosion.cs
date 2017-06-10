using UnityEngine;

public class Explosion : MonoBehaviour // The reason that I'm implementing the explosion behaviour outside of the Bomb script it's because I want to re-use it for other weapons.
{
    public float explosionSpeed = 1.0f;
    public float maxExplosionMagnitude = 20.0f;

    private bool isExploding = false;
    private IDamageable<float> damageable;

	void Update ()
    {
		if (isExploding == true)
        {
            this.transform.localScale += this.transform.localScale * (Time.deltaTime * this.explosionSpeed); //TODO: The explosion animation should be handled as a particle or by the Tween engine.
            Debug.Log("Exploding!");

            if (this.transform.localScale.magnitude > this.maxExplosionMagnitude)
            {
                this.StopExplosion();
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        this.damageable = (IDamageable<float>)collision.gameObject.GetComponent(typeof(IDamageable<float>));
        if (this.damageable == null)
        {
            Debug.Log("Not damageable!");
        }
        else
        {
            this.damageable.Break();
            Debug.Log("Damageable!");
        }
    }

    public void StartExplosion()
    {
        this.isExploding = true;
    }

    private void StopExplosion()
    {
        this.isExploding = false;
        Destroy(transform.parent.gameObject); //TODO: Temporary, calling parent should destroy itself after spawning the gameobject responsible to play the explosion.
    }
}
