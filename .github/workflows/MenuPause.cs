using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Player;
    public GameObject Timer;
    public static bool Finished = false;

    // Update is called once per frame
    void Update()
    {   if( Finished == true){
            
        }else{
            if(Input.GetKeyDown(KeyCode.Escape))
            {  
             Pause ();
            }
        }
    }
    
    public void Resume (){
        pauseMenuUI.SetActive(false);
        Player.SetActive(true);
        Timer.SetActive(true);
    
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Pause (){ 
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Player.SetActive(false);
        Timer.SetActive(false);        
        Time.timeScale = 0f;
        GameIsPaused = true; 
        Cursor.lockState = CursorLockMode.None;
    }

}
