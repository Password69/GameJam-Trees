using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //START
    public void start()
    {
       
    }
    //SETTINGS
   public void settings()
    {
        SceneManager.LoadScene("settings");
    }
    //QUIT
    public void quit()
    {
        Application.Quit();
    }

}
