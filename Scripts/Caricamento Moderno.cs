using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;



public class Caricamento_Moderno : MonoBehaviour
{

    const string tempfolder = "/tempfolder";
    const string obj_path_sub = "/obj";
    const string obj_count_path_sub = "/obj.count";


    public GameObject finestra;
    public GameObject parete;
    public GameObject porta;
    public GameObject pavimento;
    public GameObject wc;
    public GameObject tv;
    public GameObject tavolo;
    public GameObject tappeto;
    public GameObject tappeto_bagno;
    public GameObject specchio;
    public GameObject sofa;
    public GameObject sedia;
    public GameObject sedia_pc;
    public GameObject scrivania;
    public GameObject scacchiera;
    public GameObject quadro;
    public GameObject poltrona;
    public GameObject letto;
    public GameObject lavatrice;
    public GameObject lavandino;
    public GameObject lampada;
    public GameObject doccia;
    public GameObject arcade;

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

                if (dato.nome == "Finestra")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(finestra, vector3_pos, quaternione);
                }
                if (dato.nome == "Parete")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(parete, vector3_pos, quaternione);
                }
                if (dato.nome == "Porta")
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
                if (dato.nome == "wc")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(wc, vector3_pos, quaternione);
                }
                if (dato.nome == "Tv")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tv, vector3_pos, quaternione);
                }
                if (dato.nome == "Tavolo")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tavolo, vector3_pos, quaternione);
                }
                if (dato.nome == "Tappeto bagno")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tappeto_bagno, vector3_pos, quaternione);
                }
                if (dato.nome == "Tappeto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(tappeto, vector3_pos, quaternione);
                }
                if (dato.nome == "Specchio")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(specchio, vector3_pos, quaternione);
                }
                if (dato.nome == "Sofa giusto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sofa, vector3_pos, quaternione);
                }
                if (dato.nome == "Sedia Pc")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sedia_pc, vector3_pos, quaternione);
                }
                if (dato.nome == "Sedia")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(sedia, vector3_pos, quaternione);
                }
                if (dato.nome == "Scrivania")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(scrivania, vector3_pos, quaternione);
                }
                if (dato.nome == "Scacchiera")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(scacchiera, vector3_pos, quaternione);
                }
                if (dato.nome == "Quadro")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(quadro, vector3_pos, quaternione);
                }
                if (dato.nome == "Poltrona")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(poltrona, vector3_pos, quaternione);
                }
                if (dato.nome == "Letto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(letto, vector3_pos, quaternione);
                }
                if (dato.nome == "Lavatrice")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(lavatrice, vector3_pos, quaternione);
                }
                if (dato.nome == "Lavandino")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(lavandino, vector3_pos, quaternione);
                }
                if (dato.nome == "Lampada")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(lampada, vector3_pos, quaternione);
                }
                if (dato.nome == "Doccia")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(doccia, vector3_pos, quaternione);
                }
                if (dato.nome == "Arcade giusto")
                {
                    Vector3 vector3_pos = new Vector3(dato.posizione[0], dato.posizione[1], dato.posizione[2]);
                    Quaternion quaternione = new Quaternion(dato.rotazione[0], dato.rotazione[1], dato.rotazione[2], dato.rotazione[3]);

                    GameObject Muro = Instantiate(arcade, vector3_pos, quaternione);
                }

            }
        }
        
        
    }
}
