using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endlevelUImanager : MonoBehaviour
{
    public Text highscoreref;

    public void startGame()
    {
        manager.Instance.g_score = 0.0f;
        SceneManager.LoadScene("level");
    }

    // Start is called before the first frame update
    void Start()
    {
        highscoreref.text = "Your Score: " + manager.Instance.g_score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
