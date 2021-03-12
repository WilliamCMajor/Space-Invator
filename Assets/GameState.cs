using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public int score;

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
        score = 0;

    }

    public void updateScore()
    {
        score += 100;
    }

    public void resetScore()
    {
        score = 0;
    }
}
