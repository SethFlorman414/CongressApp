using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SimplySave : MonoBehaviour {
	//Assumption: All objects with this script have unique names
	public int hp = 10;
	// Use this for initialization
	void Start () {
		//Load our data using the stored playerpref!
		Load(PlayerPrefs.GetString("Save"));

		//if we wanna reset the playerpref, we do this:
		PlayerPrefs.SetString("String", "");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Save ("state1");
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Save ("state2");
		}

		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			Load ("state1");
		}
		if (Input.GetKeyDown (KeyCode.Keypad2)) {
			Load ("state2");
		}
	}

	public void Save(string state) {
		BassSaveObj myData = new BassSaveObj (hp, transform.position.x, transform.position.y, transform.position.z);
		BinaryFormatter bf = new BinaryFormatter (); 
		//Assumption: All objects with this script have unique names
		FileStream file = File.Open (Application.persistentDataPath + "/" + state + gameObject.name + ".dat", FileMode.OpenOrCreate);
		//magic
		bf.Serialize(file, myData);
		file.Close();
	}

	public void Load(string state){
		if (File.Exists (Application.persistentDataPath + "/" + state + gameObject.name + ".dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/" + state + gameObject.name + ".dat", FileMode.Open);
			BassSaveObj myData = (BassSaveObj)bf.Deserialize (file);
			hp = myData.hp;
			transform.position = new Vector3 (myData.x, myData.y, myData.z);
			file.Close ();
		}
	}

}
[System.Serializable]
public class BassSaveObj{
	public int hp;
	public float x;
	public float y;
	public float z; 

	public BassSaveObj(int newHP, float newX, float newY, float newZ){
		hp = newHP;
		x = newX;
		y = newY;
		z = newZ;
	}
}