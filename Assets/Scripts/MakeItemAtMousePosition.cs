using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeItemAtMousePosition : MonoBehaviour
{

    public GameObject Item;
    public string KeyToPressForSpawning;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyToPressForSpawning))
	    {
	        Debug.Log(KeyToPressForSpawning + " is pressed");
	        var explosion = Instantiate(Item, null, false);
            explosion.SetActive(true);
	        Vector2 coords = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	        explosion.transform.position = coords;
	    }
	}
}
