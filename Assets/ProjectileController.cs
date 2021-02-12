using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.Self);
        //transform.Rotate(new Vector3(0, 0, 5));
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if ((collider.gameObject.tag != "DeathZoneBottom") && (collider.gameObject.tag != "ShipAllien") 
            && (collider.gameObject.tag != "ProjectileAlien") && (collider.gameObject.tag != "Barrier"))
        {

            Destroy(collider.gameObject);
        }
    }
}
