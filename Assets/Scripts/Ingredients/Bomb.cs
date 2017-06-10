using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
    public Explosion explosion; //TODO: Explosion should be implemented as a component. 
    // public float sizeOfExplosion; //TODO: Expose explosion impact size and strength parameters later.

	void Start ()
    {
        StartCoroutine("LightFuse");
	}

    private IEnumerator LightFuse()
    {
        yield return new WaitForSeconds(0.0f); //TODO: Implement fuse countdown S&F.

        yield return new WaitForSeconds(1.0f);
        this.Explode();
    }
	
    private void Explode()
    {
        this.explosion.StartExplosion();
    }
}
