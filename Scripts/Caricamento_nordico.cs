using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;



public class Caricament : MonoBehaviour
{

    const string tempfolder = "/tempfolder";
    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";


    public GameObject muro;
    public GameObject pavimento;
    public GameObject luci;
    public GameObject porta;
    public GameObject finestra;
    public GameObject comodino;
    public GameObject letto;
    public GameObject tappeto;
    public GameObject specchio;
    public GameObject scrivania;
    public GameObject libreria;
    public GameObject quadro;
    public GameObject tv;
    public GameObject poltrona;
    public GameObject tavolo;
    public GameObject sofa;
    public GameObject tappeto_sog;
    public GameObject cucina;
    public GameObject sedia;


    public void Awake()
    {
        if (Menu.carica)
        {
            string countpath = Application.persistentDataPath + Menu.folder + obj_count_path_sub;
            BinaryFormatter bf = new BinaryFormatter();
            //int count = SaveSystem.list.Count;

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

                    GameObject Muro = Instantiate(muro, vector3_pos, quaternione);
                }
                if (dato.nome == "pavimento")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(pavimento, vector3_pos, quaternione);
                }
                if (dato.nome == "luci")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(luci, vector3_pos, quaternione);
                }
                if (dato.nome == "parete_porta")
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
                if (dato.nome == "comodino")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(comodino, vector3_pos, quaternione);
                }
                if (dato.nome == "letto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(letto, vector3_pos, quaternione);
                }
                if (dato.nome == "libreria")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(libreria, vector3_pos, quaternione);
                }
                if (dato.nome == "scrivania")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(scrivania, vector3_pos, quaternione);
                }
                if (dato.nome == "specchio")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(specchio, vector3_pos, quaternione);
                }
                if (dato.nome == "tappeto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tappeto, vector3_pos, quaternione);
                }
                if (dato.nome == "cucina")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(cucina, vector3_pos, quaternione);
                }
                if (dato.nome == "quadro")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(quadro, vector3_pos, quaternione);
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
                if (dato.nome == "tappeto_sog")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tappeto_sog, vector3_pos, quaternione);
                }
                if (dato.nome == "tavolo")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tavolo, vector3_pos, quaternione);
                }
                if (dato.nome == "tv")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tv, vector3_pos, quaternione);
                }
            }
        }    
       
       
    }
}
