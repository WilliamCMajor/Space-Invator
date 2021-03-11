using UnityEngine;
using UnityEngine.UI;

public class Scorelv2 : MonoBehaviour
{
    GameState gameState;

    private void Awake()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
        GetComponent<Text>().text = gameState.gameStateScore.ToString();
    }
}
