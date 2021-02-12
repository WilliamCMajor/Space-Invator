using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if((collider.gameObject.tag == "ProjectileAlien") || (collider.gameObject.tag == "ProjectilePlayer"))
        {
            Destroy(collider.gameObject); // we can destroy certain object with tag

        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(transform.position, transform.localScale);
    }



}
