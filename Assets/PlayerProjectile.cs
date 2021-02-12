using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(projectilePrefab);
            projectile.transform.position = new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z);

        }
    }

    

}
