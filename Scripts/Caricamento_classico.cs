using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;



public class Caricamento_classico : MonoBehaviour
{

    const string tempfolder = "/tempfolder";
    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";

    public GameObject parete;
    public GameObject pavimento;
    public GameObject porta;
    public GameObject finestra;
    public GameObject armadio;
    public GameObject comodino;
    public GameObject divano;
    public GameObject poltrona;
    public GameObject sedia;
    public GameObject sofa;
    public GameObject tavolino;
    public GameObject specchio;
    public GameObject tavolo;

    public void Awake()
    {
        if(Menu.carica)
        {
            string countpath = Application.persistentDataPath + Menu.folder + obj_count_path_sub;
            BinaryFormatter bf = new BinaryFormatter();


            if (File.Exists(countpath))
            {
                FileStream countStream = new FileStream(countpath, FileMode.Open);
                ObjSpawn.integer = (int)bf.Deserialize(countStream);
                countStream.Close();
                Debug.Log(ObjSpawn.integer);

            }

            for (int i = 0; i < ObjSpawn.integer; i++)
            {
                string savePath = Application.persistentDataPath + Menu.folder + obj_path_sub;
                string tempPathFile = Application.persistentDataPath + tempfolder + obj_path_sub;
                File.Copy(savePath + i, tempPathFile + i, true);

                FileStream Stream = new FileStream(tempPathFile + i, FileMode.Open);
                Dati dato = bf.Deserialize(Stream) as Dati;


                if (dato.nome == "parete")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(parete, vector3_pos, quaternione);
                }
                if (dato.nome == "pavimento")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(pavimento, vector3_pos, quaternione);
                }
                if (dato.nome == "porta_parete")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(porta, vector3_pos, quaternione);
                }
                if (dato.nome == "parete_finestra")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(finestra, vector3_pos, quaternione);
                }
                if (dato.nome == "armadio")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(armadio, vector3_pos, quaternione);
                }
                if (dato.nome == "comodino")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(comodino, vector3_pos, quaternione);
                }
                if (dato.nome == "divano")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(divano, vector3_pos, quaternione);
                }
                if (dato.nome == "poltrona")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(poltrona, vector3_pos, quaternione);
                }
                if (dato.nome == "sedia")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sedia, vector3_pos, quaternione);
                }
                if (dato.nome == "sofa")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sofa, vector3_pos, quaternione);
                }
                if (dato.nome == "tavolino")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tavolino, vector3_pos, quaternione);
                }
                if (dato.nome == "specchio")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(specchio, vector3_pos, quaternione);
                }
                if (dato.nome == "tavolo")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tavolo, vector3_pos, quaternione);
                }
            }
        }
        

    }
}