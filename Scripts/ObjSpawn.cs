using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;


public class ObjSpawn : MonoBehaviour
{
    public GameObject game_obj;



    public static int integer = 0;

    public Button avanti_btn;
    public Button destra_btn;
    public Button sinistra_btn;
    public Button indietro_btn;
    public Button ruota_btn;
    public Button alza_btn;
    public Button abbassa_btn;
    public Button rimuovi_btn;

    public Button conferma_btn;

    public float[] posizione = new float[3];
    public float[] rotazione = new float[4];

    public string nome;

    string temp;

    private void Start()
    {
        temp = Application.persistentDataPath + tempfolder;
        var folder = Directory.CreateDirectory(temp);
    }

    const string tempfolder = "/tempfolder";
    const string obj_path_sub = "/obj";
    public void Spawn()
    {

        BinaryFormatter bf = new BinaryFormatter();

        GameObject new_game_obj = Instantiate(game_obj, new Vector3(0, 0, 0), Quaternion.identity);

        avanti_btn.onClick.AddListener(delegate { Avanti(new_game_obj); });
        destra_btn.onClick.AddListener(delegate { Destra(new_game_obj); });
        sinistra_btn.onClick.AddListener(delegate { Sinistra(new_game_obj); });
        indietro_btn.onClick.AddListener(delegate { Indietro(new_game_obj); });
        ruota_btn.onClick.AddListener(delegate { Ruota(new_game_obj); });
        alza_btn.onClick.AddListener(delegate { Alza(new_game_obj); });
        abbassa_btn.onClick.AddListener(delegate { Abbassa(new_game_obj); });
        rimuovi_btn.onClick.AddListener(delegate { Rimuovi(new_game_obj); });

        conferma_btn.onClick.AddListener(delegate
        {

            avanti_btn.onClick.RemoveAllListeners();
            destra_btn.onClick.RemoveAllListeners();
            sinistra_btn.onClick.RemoveAllListeners();
            indietro_btn.onClick.RemoveAllListeners();
            ruota_btn.onClick.RemoveAllListeners();
            alza_btn.onClick.RemoveAllListeners();
            abbassa_btn.onClick.RemoveAllListeners();
            rimuovi_btn.onClick.RemoveAllListeners();


            posizione[0] = new_game_obj.transform.position.x;
            posizione[1] = new_game_obj.transform.position.y;
            posizione[2] = new_game_obj.transform.position.z;



            rotazione[0] = new_game_obj.transform.rotation.x;
            rotazione[1] = new_game_obj.transform.rotation.y;
            rotazione[2] = new_game_obj.transform.rotation.z;
            rotazione[3] = new_game_obj.transform.rotation.w;

            nome = game_obj.name;
            Dati dato = new Dati(posizione, rotazione, nome);



            string path = Application.persistentDataPath + tempfolder + obj_path_sub;
            Debug.Log(path);
            FileStream Stream = new FileStream(path + integer, FileMode.Create);
            bf.Serialize(Stream, dato);
            Stream.Close();



            conferma_btn.onClick.RemoveAllListeners();
            Debug.Log(integer);
            integer++;
        }
        );


    }

    public void Avanti(GameObject game_obj)
    {
        game_obj.transform.localPosition += new Vector3(0.5f, 0, 0);

    }
    public void Indietro(GameObject game_obj)
    {
        game_obj.transform.localPosition += new Vector3(-0.5f, 0, 0);

    }
    public void Destra(GameObject game_obj)
    {
        game_obj.transform.localPosition += new Vector3(0, 0, 0.5f);

    }
    public void Sinistra(GameObject game_obj)
    {
        game_obj.transform.localPosition += new Vector3(0, 0, -0.5f);

    }
    public void Ruota(GameObject game_obj)
    {
        game_obj.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
    }
    public void Alza(GameObject game_obj)
    {
        game_obj.transform.localPosition += new Vector3(0, 0.5f, 0);
    }
    public void Abbassa(GameObject game_obj)
    {
        game_obj.transform.localPosition -= new Vector3(0, 0.5f, 0);
    }
    public void Rimuovi(GameObject game_obj)
    {
        Destroy(game_obj);
        avanti_btn.onClick.RemoveAllListeners();
        destra_btn.onClick.RemoveAllListeners();
        sinistra_btn.onClick.RemoveAllListeners();
        indietro_btn.onClick.RemoveAllListeners();
        ruota_btn.onClick.RemoveAllListeners();
        alza_btn.onClick.RemoveAllListeners();
        abbassa_btn.onClick.RemoveAllListeners();
        rimuovi_btn.onClick.RemoveAllListeners();
        conferma_btn.onClick.RemoveAllListeners();
    }

}