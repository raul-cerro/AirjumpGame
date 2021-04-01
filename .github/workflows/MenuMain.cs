using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{

   public void PlayGame()
   {
       SceneManager.LoadScene("Tutorial");
   }
    public void Nivel1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
    public void Nivel2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
    public void Nivel3(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }
    public void Nivel4(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }

    public void LoadMenu(){
        SceneManager.LoadScene("StartMenu");
    }
   public void QuitGame(){
       Application.Quit();
   }
   public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

   }
   
   
}
