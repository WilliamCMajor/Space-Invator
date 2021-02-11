using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    protected bool maxRight = false;
    protected bool maxLeft = false;

    protected bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        float xTranslation = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float yTranslation = speed * Time.deltaTime * Input.GetAxis("Vertical");

        //transform.Translate(new Vector3(xTranslation, yTranslation, 0), Space.Self);
        if(canShoot && Input.GetButtonDown("Fire1"))/*C# excute bool value first*/
        {
            canShoot = false;
            Debug.Log("Shoooooooooot");
            StartCoroutine(ShootDelay());
        }
        
        if((xTranslation < 0) && !maxLeft)
        {
          
            maxLeft = false;
            transform.Translate(new Vector3(xTranslation, 0, 0), Space.Self);
        }

        if((xTranslation > 0) && !maxRight)
        {
            
            maxRight = false;
            transform.Translate(new Vector3(xTranslation, 0, 0), Space.Self);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("WallLeft"))
        {
            maxLeft = true;
   
        }

        if(collider.gameObject.CompareTag("WallRight"))
        {
            maxRight = true;
           
        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(1);
        canShoot = true;

    }
}
