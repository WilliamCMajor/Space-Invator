using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    //protected bool maxRight = false;
    //protected bool maxLeft = false;

    protected bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        float xTranslation = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float yTranslation = speed * Time.deltaTime * Input.GetAxis("Vertical");

        if(canShoot && Input.GetButtonDown("Fire1"))/*C# excute bool value first*/
        {
            canShoot = false;
            //Debug.Log("Shoooooooooot");
            StartCoroutine(ShootDelay());
        }

        transform.Translate(new Vector3(0, yTranslation, 0), Space.Self);

        if(xTranslation < 0)
        {
          
            //maxLeft = false;
            transform.Translate(new Vector3(xTranslation, 0, 0), Space.Self);
            
        }

        //if(!maxRight && (xTranslation > 0))
        if(xTranslation > 0)
        {
            
            //maxRight = false;
            transform.Translate(new Vector3(xTranslation, 0, 0), Space.Self);
         
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("WallLeft"))
        {
            //maxLeft = true;           
            transform.position = transform.position - new Vector3(-0.5f, 0, 0);



        }

        if(collider.gameObject.CompareTag("WallRight"))
        {
            //maxRight = true;
            transform.position = transform.position - new Vector3(0.5f, 0, 0);

        }

        if(collider.gameObject.CompareTag("DeathZoneTop"))
        {
            transform.position = transform.position - new Vector3(0, 0.5f, 0);
        }

        if (collider.gameObject.CompareTag("DeathZoneBottom"))
        {
            transform.position = transform.position + new Vector3(0, 0.5f, 0);
        }

        if (collider.gameObject.CompareTag("Barrier"))
        {
            transform.position = transform.position + new Vector3(0, -0.5f, 0);
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(1);
        canShoot = true;

    }
}
