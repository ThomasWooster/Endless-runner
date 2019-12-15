using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public static manager Instance // this makes a get set static varable of the whole script 
    {
        get;
        set;
    }

    public float g_score = 0.0f; // holds the players score




    public void startGame() // as this manager is placed in the first level to enshue it exixts in all scenes 
    {
        SceneManager.LoadScene("level");
    }

    private void Awake() // when the script is loaded it sets the inastance variable to itsself as well as setting the game object it is attached to tonot be destroyed/cleaned up when loading a new level.
    {
        DontDestroyOnLoad(transform.gameObject);
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }


    

 
}