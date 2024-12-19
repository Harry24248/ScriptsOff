using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    void Update()
    {
        Movimento_WASD();
        Rotazione();
    }

    private void Movimento_WASD()
    {
        Vector3 direzione = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W)) direzione.x = 1f;
        if (Input.GetKey(KeyCode.S)) direzione.x = -1f;
        if (Input.GetKey(KeyCode.D)) direzione.z = +1f;
        if (Input.GetKey(KeyCode.A)) direzione.z = -1f;
        if (Input.GetKey(KeyCode.Space)) direzione.y = 1f;
        if (Input.GetKey(KeyCode.LeftShift)) direzione.y = -1f;
        Vector3 spostamento = transform.forward * direzione.x + transform.right * direzione.z + transform.up * direzione.y;

        //qui per cambiare la velocità
        float velocita = 0.1f;
        transform.position += spostamento * velocita;

    }

    private void Rotazione()
    {
        float rot = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) rot = 1f;
        if (Input.GetKey(KeyCode.RightArrow)) rot = -1f;
        //qui per cambiare la velocità
        float velocita = 1f;
        transform.eulerAngles += new Vector3(0, rot * velocita, 0);

        float angl = 0;
        if (Input.GetKey(KeyCode.UpArrow)) angl = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) angl = -1f;
        transform.eulerAngles += new Vector3(angl * velocita, 0,0 );

    }



}