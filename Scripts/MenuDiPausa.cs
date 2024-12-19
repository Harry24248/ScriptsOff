using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDiPausa : MonoBehaviour
{
    

    public void TornaAlMenu()
    {
        string temp = Application.persistentDataPath + "/tempfolder";
        Menu.carica = false;
        SceneManager.LoadScene(0);
        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
}
