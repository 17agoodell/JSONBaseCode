using UnityEngine;
using System.Collections;
using System.IO;
using LitJson;

public class ReadJson : MonoBehaviour {
	private string jsonstring;
	private JsonData itemData;

	// Use this for initialization
	void Start () {
		jsonstring = File.ReadAllText (Application.dataPath + "/JsonText.json");
		itemData = JsonMapper.ToObject(jsonstring);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
