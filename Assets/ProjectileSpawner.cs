using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectilePrefab;
    public int upperRandomRange;


    // Update is called once per frame
    void Update()
    {
        

        int rando = Random.Range(1, upperRandomRange);
        if(rando == 1)
        {
            GameObject projectile = Instantiate(projectilePrefab);
            projectile.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("WallLeft") || collider.gameObject.CompareTag("WallRight"))
        {
            this.transform.parent.GetComponent<ShipParent>().direction.x *= -1;
            //this.direction.x *= -1;

        }
    }
}
