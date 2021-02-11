using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipParent : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.5f);
    }
}
