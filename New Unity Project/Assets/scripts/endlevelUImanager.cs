using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endlevelUImanager : MonoBehaviour
{
    public Text highscoreref; // holds the referance tothe ui text box that shows the players score

    public void startGame() // restarts the level as well as resetting the score
    {
        manager.Instance.g_score = 0.0f;
        SceneManager.LoadScene("level");
    }
    public void leaveGame() // allows the player to leave the game from the end game screen
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        highscoreref.text = "Your Score: " + manager.Instance.g_score; // places the players score into the text box on the UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
