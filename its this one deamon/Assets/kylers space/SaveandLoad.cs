using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine;

public class SaveandLoad : MonoBehaviour {

    // Use this for initialization

    public List<int> list1 = new List<int>();

    private savedata data;


        public Vector3 xyz = new Vector3();

	void Start () {

        Load();
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Save();

        }

	}

    public void Save()
    {

        if(!Directory.Exists(Application.dataPath + "/saves"))
        {

            Directory.CreateDirectory(Application.dataPath + "/saves");

            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Create(Application.dataPath + "/saves/SaveData.dat");

            CopySaveData();

            bf.Serialize(file, data);
            file.Close();


        }

    }


    public void CopySaveData()
    {

        data.list1.Clear();

        foreach (int i in list1);
        {

            int i = 0;
            data.list1.Add(i);

        }


        data.position = Vector3ToSerVector3(xyz);


    }

    public static SerVector3 Vector3ToSerVector3(Vector3 V3)
    {

        SerVector3 SV1 = new SerVector3();

        SV1.x = SV1.x;
        SV1.y = SV1.y;
        SV1.z = SV1.z;

        return SV1;

    }


    public void Load()
    {

        if (File.Exists(Application.dataPath + "/saves/SaveData.dat"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.dataPath + "/saves/SaveData.dat", FileMode.Open);
            data = (savedata)bf.Deserialize(file);

            CopyLoadData();

            file.Close();

        }

    }


    public void CopyLoadData()
    {

        list1.Clear();
        foreach(int i in data.list1)
        {

            list1.Add(i);

        }

        xyz = SerVector3ToVector(data.position);

    }


    public static Vector3 SerVector3ToVector(SerVector3 SV1)
    {

        Vector3 V3 = new Vector3();

        V3.x = SV1.x;
        V3.y = SV1.y;
        V3.z = SV1.z;

        return V3;

    }


}

[System.Serializable]
public class savedata
{
    public SerVector3 position;

    public List<int> list1 = new List<int>();


}

[System.Serializable]

public class SerVector3
{

    public float x;
    public float y;
    public float z;


}

