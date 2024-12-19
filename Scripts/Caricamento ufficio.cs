using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;



public class Caricamento_ufficio : MonoBehaviour
{

    const string tempfolder = "/tempfolder";
    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";

    public GameObject finestra;
    public GameObject macchinetta;
    public GameObject macchinetta_acqua;
    public GameObject libreria;
    public GameObject stampante;
    public GameObject scrivania;
    public GameObject sofa;
    public GameObject sedia;
    public GameObject orologio;
    public GameObject luci;
    public GameObject porta;
    public GameObject pavimento;
    public GameObject parete;
    public void Awake()
    {
        if(Menu.carica)
        {
            Debug.Log("csoso");
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

                Debug.Log(dato.nome);

                if (dato.nome == "Finestra giusta")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(finestra, vector3_pos, quaternione);
                }
                if (dato.nome == "Macchinetta")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(macchinetta, vector3_pos, quaternione);
                }
                if (dato.nome == "Macchinetta acqua")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(macchinetta_acqua, vector3_pos, quaternione);
                }
                if (dato.nome == "Libreria")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(libreria, vector3_pos, quaternione);
                }
                if (dato.nome == "Stampante")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(stampante, vector3_pos, quaternione);
                }
                if (dato.nome == "Scrivania")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(scrivania, vector3_pos, quaternione);
                }
                if (dato.nome == "Sofa")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sofa, vector3_pos, quaternione);
                }
                if (dato.nome == "Sedia")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sedia, vector3_pos, quaternione);
                }
                if (dato.nome == "Orologio parete")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(orologio, vector3_pos, quaternione);
                }
                if (dato.nome == "Luci")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(luci, vector3_pos, quaternione);
                }
                if (dato.nome == "Porta giusta")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(porta, vector3_pos, quaternione);
                }
                if (dato.nome == "Pavimento")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(pavimento, vector3_pos, quaternione);
                }
                if (dato.nome == "Muro giusto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(parete, vector3_pos, quaternione);
                }
            }

        }
    }
        
}
