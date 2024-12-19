using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;



public class Caricamento_industriale : MonoBehaviour
{

    const string tempfolder = "/tempfolder";
    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";

    public GameObject muro;
    public GameObject pavimento;
    public GameObject porta;
    public GameObject finestra;
    public GameObject luci;
    public GameObject lavandino;
    public GameObject vasca;
    public GameObject doccia;
    public GameObject water;
    public GameObject uccello;
    public GameObject robot;
    public GameObject tv;
    public GameObject quadro;
    public GameObject mobilevini;
    public GameObject lampada;
    public GameObject tavolosed;
    public GameObject divano;
    public GameObject armadio;
    public GameObject scrivania;
    public GameObject comodino;
    public GameObject letto;
    



    public void Awake()
    {
        if (Menu.carica)
        {
            string countpath = Application.persistentDataPath + Menu.folder + obj_count_path_sub;
            BinaryFormatter bf = new BinaryFormatter();
            

            if (File.Exists(countpath))
            {
                FileStream countStream = new FileStream(countpath, FileMode.Open);
                ObjSpawn.integer = (int)bf.Deserialize(countStream);
                countStream.Close();


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

                    GameObject newGameObj = Instantiate(muro, vector3_pos, quaternione);
                }

                if (dato.nome == "pavimento")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(pavimento, vector3_pos, quaternione);
                }
                if (dato.nome == "muro_porta")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(porta, vector3_pos, quaternione);
                }
                if (dato.nome == "muro_finestra")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(finestra, vector3_pos, quaternione);
                }
                if (dato.nome == "luci")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(luci, vector3_pos, quaternione);
                }
                if (dato.nome == "vasca")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(vasca, vector3_pos, quaternione);
                }
                if (dato.nome == "lavandino")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(lavandino, vector3_pos, quaternione);
                }
                if (dato.nome == "doccia")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(doccia, vector3_pos, quaternione);
                }
                if (dato.nome == "water")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(water, vector3_pos, quaternione);
                }
                if (dato.nome == "scultura_uccello")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(uccello, vector3_pos, quaternione);
                }
                if (dato.nome == "scultura_robot")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(robot, vector3_pos, quaternione);
                }

                if (dato.nome == "tv_mobile")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(tv, vector3_pos, quaternione);
                }
                if (dato.nome == "quadro")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(quadro, vector3_pos, quaternione);
                }
                if (dato.nome == "mobile_vini")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(mobilevini, vector3_pos, quaternione);
                }
                if (dato.nome == "lampada")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(lampada, vector3_pos, quaternione);
                }
                if (dato.nome == "tavolo_sedie")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(tavolosed, vector3_pos, quaternione);
                }
                if (dato.nome == "divano")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(divano, vector3_pos, quaternione);
                }
                if (dato.nome == "letto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(letto, vector3_pos, quaternione);
                }
                if (dato.nome == "comodino")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(comodino, vector3_pos, quaternione);
                }
                if (dato.nome == "armadio")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(armadio, vector3_pos, quaternione);
                }
                if (dato.nome == "scrivania")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject newGameObj = Instantiate(scrivania, vector3_pos, quaternione);
                }
            }
        }
        
        
    }
}
