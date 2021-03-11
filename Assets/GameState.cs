using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public int gameStateScore;
    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("GameState");
        // is there already one of me in the game? self destruct
        if (objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        //keep this object alive between scenes
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        //score = FindObjectOfType<Score>().updatedScore;
        //GameObject gameState = GameObject.Find("GameState");
        //Score score = gameState.GetComponent<Score>();
        gameStateScore = GameObject.Find("ScoreObj").GetComponent<Score>().updatedScore;
        Debug.Log("Game State score:" + gameStateScore);

    }
}
