using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarBandera : MonoBehaviour
{
public int cambiaMeta = 1;

 void OnTriggerEnter(Collider other){
     if (other.CompareTag("Player")){
      cambiaMeta = 2;
      Tiempo.Meta = cambiaMeta;
       }
     }
     
}
