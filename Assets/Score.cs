using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int updatedScore;

    private void Start()
    {
        score = 0;
        
    }

    private void Update()
    {
        GameObject[] findAlienShip;
        GameObject[] findPlayerShip;

        findAlienShip = GameObject.FindGameObjectsWithTag("ShipAllien");
        //Debug.Log("Alien number:"+findAlienShip.Length);
        findPlayerShip = GameObject.FindGameObjectsWithTag("Player");

        if (findAlienShip.Length == 3)
            // parent ship has tag "ShipAllien", It is invisible gameObject
        {
            SceneManager.LoadScene(4);
        }

        if (findPlayerShip.Length == 0)
        {
            SceneManager.LoadScene(3);
        }

        GetComponent<Text>().text = score.ToString();
        updatedScore = score;
        Debug.Log("updated Score:" + updatedScore);
    }
    
    public void updateScore()
    {
        score += 100;
    }


}
