using UnityEngine;
using UnityEngine.UI;

public class EnemyExist : MonoBehaviour
{
    int shipNum;

    GameObject[] EnemyNumber;
    // Update is called once per frame
    void Update()
    {
        EnemyNumber = GameObject.FindGameObjectsWithTag("ShipAllien");
        shipNum = EnemyNumber.Length - 3;

        GetComponent<Text>().text = shipNum.ToString();
    }
}
