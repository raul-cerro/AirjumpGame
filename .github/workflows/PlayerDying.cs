using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dying : MonoBehaviour
{
    void Update()
    {
        if( transform.position.y <= -30 ){
           Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
        if(Input.GetKeyDown(KeyCode.R)){
             Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
         }
    
    }
}
        
