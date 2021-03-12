using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    //protected bool changeColor = true;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag != "Player" && collider.gameObject.tag != "ShipLv2")
        {
            Destroy(collider.gameObject);
            this.GetComponent<MeshRenderer>().material.color = Color.red;

        }

        Invoke("OnTriggerExit2D", 0.2f);
        
    }

    private void OnTriggerExit2D()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(transform.position, transform.localScale);
    }


}
