using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.Playables;
using System.Runtime.Serialization;
using UnityEngine.SceneManagement;
using UnityEditor;

[System.Serializable]
public class SaveSystem : MonoBehaviour
{




    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";
    const string scene_stile = "/scene.stile";
    const string folder1 = "/save1";
    const string folder2 = "/save2";
    const string folder3 = "/save3";
    const string tempfolder = "/tempfolder";

    public void Start()
    {
        string path1 = Application.persistentDataPath + folder1;
        string path2 = Application.persistentDataPath + folder2;
        string path3 = Application.persistentDataPath + folder3;
        string temp = Application.persistentDataPath + tempfolder;
        Directory.CreateDirectory(path1);
        Directory.CreateDirectory(path2);
        Directory.CreateDirectory(path3);
        Directory.CreateDirectory(temp);


    }


    public void SaveFileSlot1()
    {
        string[] listafile = Directory.GetFiles(Application.persistentDataPath + folder1);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }

        BinaryFormatter bf = new BinaryFormatter();

        string path = Application.persistentDataPath + folder1 + obj_path_sub;
        string countpath = Application.persistentDataPath + folder1 + obj_count_path_sub;
        string stilepath = Application.persistentDataPath + folder1 + scene_stile;



        FileStream countStream = new FileStream(countpath, FileMode.Create);
        bf.Serialize(countStream, ObjSpawn.integer);
        countStream.Close();

        Scene currentScene = SceneManager.GetActiveScene();
        FileStream stileStream = new FileStream(stilepath, FileMode.Create);
        bf.Serialize(stileStream, currentScene.buildIndex);
        stileStream.Close();


        for (int i = 0; i < ObjSpawn.integer; i++)
        {
            string tempPathFile = Application.persistentDataPath + tempfolder + obj_path_sub;
            File.Copy(tempPathFile + i, path + i, true);
        }
        Debug.Log(path);
    }
    public void SaveFileSlot2()
    {
        string[] listafile = Directory.GetFiles(Application.persistentDataPath + folder2);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }

        BinaryFormatter bf = new BinaryFormatter();

        string path = Application.persistentDataPath + folder2 + obj_path_sub;
        string countpath = Application.persistentDataPath + folder2 + obj_count_path_sub;
        string stilepath = Application.persistentDataPath + folder2 + scene_stile;



        FileStream countStream = new FileStream(countpath, FileMode.Create);
        bf.Serialize(countStream, ObjSpawn.integer);
        Debug.Log(ObjSpawn.integer);

        countStream.Close();
        Scene currentScene = SceneManager.GetActiveScene();

        FileStream stileStream = new FileStream(stilepath, FileMode.Create);
        bf.Serialize(stileStream, currentScene.buildIndex);
        stileStream.Close();


        for (int i = 0; i < ObjSpawn.integer; i++)
        {
            string tempPathFile = Application.persistentDataPath + tempfolder + obj_path_sub;
            File.Copy(tempPathFile + i, path + i, true);
        }

    }
    public void SaveFileSlot3()
    {
        string[] listafile = Directory.GetFiles(Application.persistentDataPath + folder3);
        foreach (string file in listafile)
        {
            File.Delete(file);
        }

        BinaryFormatter bf = new BinaryFormatter();

        string path = Application.persistentDataPath + folder3 + obj_path_sub;
        string countpath = Application.persistentDataPath + folder3 + obj_count_path_sub;
        string stilepath = Application.persistentDataPath + folder3 + scene_stile;



        FileStream countStream = new FileStream(countpath, FileMode.Create);
        bf.Serialize(countStream, ObjSpawn.integer);
        Debug.Log(ObjSpawn.integer);

        countStream.Close();
        Scene currentScene = SceneManager.GetActiveScene();

        FileStream stileStream = new FileStream(stilepath, FileMode.Create);
        bf.Serialize(stileStream, currentScene.buildIndex);
        stileStream.Close();


        for (int i = 0; i < ObjSpawn.integer; i++)
        {
            string tempPathFile = Application.persistentDataPath + tempfolder + obj_path_sub;
            File.Copy(tempPathFile + i, path + i, true);
        }

    }



}

