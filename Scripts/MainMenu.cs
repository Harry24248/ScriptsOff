using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;



public class Menu : MonoBehaviour
{
    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";
    const string scene_stile = "/scene.stile";
    public static string folder;
    int buildDesiderata = -1;
    const string tempfolder = "/tempfolder";
    string temp;
    static public bool carica;




    public void Start()
    {

        temp = Application.persistentDataPath + tempfolder;
    }


    public void ProgettoNuovoClassico()
    {
        carica = false;
        SceneManager.LoadScene(1);

        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
    public void ProgettoNuovoModerno()
    {
        carica = false;
        SceneManager.LoadScene(2);

        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
    public void ProgettoNuovoNordico()
    {
        carica = false;
        SceneManager.LoadScene(3);

        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
    public void ProgettoNuovoIndustriale()
    {
        carica = false;
        SceneManager.LoadScene(4);

        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
    public void ProgettoNuovoUfficio()
    {
        carica = false;
        SceneManager.LoadScene(5);

        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
    public void MenuPrincipale()
    {
        SceneManager.LoadScene(0);

        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }
    }
    public void CaricaProgetto1()
    {
        carica = true;
        folder = "/save1";
        
        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }

        BinaryFormatter bf = new BinaryFormatter();
        string stilepath = Application.persistentDataPath + folder + scene_stile;

        if (File.Exists(stilepath))
        {
            FileStream stileStream = new FileStream(stilepath, FileMode.Open);
            buildDesiderata = (int)bf.Deserialize(stileStream);
            stileStream.Close();


        }
        else
        {
            Debug.LogError("stile path not found");
        }     

        SceneManager.LoadScene(buildDesiderata);
    }
    public void CaricaProgetto2()
    {
        carica = true;
        folder = "/save2";
        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }

        BinaryFormatter bf = new BinaryFormatter();
        string stilepath = Application.persistentDataPath + folder + scene_stile;

        if (File.Exists(stilepath))
        {
            FileStream stileStream = new FileStream(stilepath, FileMode.Open);
            buildDesiderata = (int)bf.Deserialize(stileStream);
            stileStream.Close();


        }
        else
        {
            Debug.LogError("stile path not found");
        }
        SceneManager.LoadScene(buildDesiderata);
    }
    public void CaricaProgetto3()
    {
        carica = true;
        folder = "/save3";
        ObjSpawn.integer = 0;
        string[] listafile = Directory.GetFiles(temp);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }

        BinaryFormatter bf = new BinaryFormatter();
        string stilepath = Application.persistentDataPath + folder + scene_stile;

        if (File.Exists(stilepath))
        {
            FileStream stileStream = new FileStream(stilepath, FileMode.Open);
            buildDesiderata = (int)bf.Deserialize(stileStream);
            stileStream.Close();


        }
        else
        {
            Debug.LogError("stile path not found");
        }

        SceneManager.LoadScene(buildDesiderata);
    }
    public void Quit()
    {
        Application.Quit();
    }
}