using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEnd : MonoBehaviour
{
    public void LoadMenu(){
        SceneManager.LoadScene("StartMenu");
    }   
}
