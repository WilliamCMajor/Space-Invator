using UnityEngine;
using UnityEngine.UI;

public class VictoryMsg : MonoBehaviour
{
    GameObject gameState;
    public int score;
    void Start()
    {
        gameState = GameObject.Find("GameState");
    }

    // Update is called once per frame
    void Update()
    {
        score = gameState.GetComponent<GameState>().score;
        GetComponent<Text>().text = score.ToString(); ;
    }
}
