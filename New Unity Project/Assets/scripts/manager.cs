using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public static manager Instance
    {
        get;
        set;
    }

    public float g_score = 0.0f;




    public void startGame()
    {
        SceneManager.LoadScene("level");
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }




 
}