using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.GetComponent<Inventory>() != null)
        {
            collidedObject.gameObject.GetComponent<Inventory>().Add();
            Destroy(gameObject);
        }
    }
}
