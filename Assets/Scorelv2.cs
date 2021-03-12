using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scorelv2 : MonoBehaviour
{
    GameState gameState;

    private void Awake()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
        
    }

    private void Update()
    {
        GameObject[] findAlienShip;
        GameObject[] findPlayerShip;

        findAlienShip = GameObject.FindGameObjectsWithTag("ShipAllien");
        //Debug.Log("Alien number:"+findAlienShip.Length);
        findPlayerShip = GameObject.FindGameObjectsWithTag("Player");

        if (findAlienShip.Length == 5)
        // parent ship has tag "ShipAllien", It is invisible gameObject
        {
            SceneManager.LoadScene(4);
        }
        else if (findPlayerShip.Length == 0)
        {
            SceneManager.LoadScene(3);
            gameState.resetScore();
        }

        GetComponent<Text>().text = gameState.score.ToString();
    }
}
