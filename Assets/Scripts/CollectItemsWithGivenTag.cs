using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemsWithGivenTag : MonoBehaviour
{

    public string TagToCollect;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(TagToCollect)) //Check if other was in correct layer.
        {
            Debug.Log("It was one of the correct tags");
            //Collect the item.
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
