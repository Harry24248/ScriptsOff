using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attivazione : MonoBehaviour
{
    public GameObject oggetto;
    
    public void Attiva()
    {
        oggetto.SetActive(true);
    }
    public void Disattiva()
    {
        oggetto.SetActive(false);
    }
}
