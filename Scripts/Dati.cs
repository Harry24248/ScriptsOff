using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dati
{
    public float[] posizione=new float[3];
    public float[] rotazione=new float[4];
    public string nome;



    public Dati(float[] pos, float[] rot, string nom)
    {
        posizione=pos;
        rotazione = rot;
        nome=nom;
    }
}
