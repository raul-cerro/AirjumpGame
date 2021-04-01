using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Tiempo : MonoBehaviour
{
    public float timeStart = 0;
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI TextPersonal;
    public GameObject Timer;
    public GameObject Record;
    public GameObject Personal;

    public bool llegarMeta = false;
    public GameObject FinalMenu;
    public static int Meta = 1;
    public GameObject Player;
    public bool newFinished = false;

 
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
        TextPersonal.text = timeStart.ToString("F2");
        
        FinalMenu.SetActive(false);
        Player.SetActive(true);       
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Timer.SetActive(true);
        Personal.SetActive(false);
        Record.SetActive(false);
        llegarMeta = false;
        Meta = 1;
        newFinished = false;
        PauseMenu.Finished = newFinished;
    }

   
    void Update()
    {
        if(llegarMeta)
            return;

        timeStart += Time.deltaTime;
        textBox.text = timeStart.ToString("F2");
        TextPersonal.text = timeStart.ToString("F2");

        if(Meta == 2){
            Cursor.visible = true;
            newFinished = true;
            llegarMeta = true;
            FinalMenu.SetActive(true);
            Player.SetActive(false);       
            Time.timeScale = 0f;
            PauseMenu.Finished = newFinished;
            Cursor.lockState = CursorLockMode.None;
            textBox = TextPersonal;
            Timer.SetActive(false);
            Personal.SetActive(true);
            Record.SetActive(true);
            }
        
    }
    
}
