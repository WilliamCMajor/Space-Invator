using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int currentScore;

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
            SceneManager.LoadScene(2);
        }

        if (findPlayerShip.Length == 0)
        {
            SceneManager.LoadScene(3);
            FindObjectOfType<GameState>().resetScore();
        }

        currentScore = FindObjectOfType<GameState>().score;
        GetComponent<Text>().text = currentScore.ToString();

    }
    



}
