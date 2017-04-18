using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInOneDirection : MonoBehaviour
{

    private Vector2 StartLocation;
    public Vector2 Direction;
    public float MoveSpeed;
    public float RestartAfterXSeconds = -1f;

	// Use this for initialization
	void Start () {
		StartLocation = new Vector2(transform.position.x, transform.position.y);
        if (RestartAfterXSeconds > 0)
        {
            //while(true)
            { 
            StartCoroutine(SetLocation(StartLocation, RestartAfterXSeconds));
               // break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Direction* MoveSpeed, Space.Self);
	}

    IEnumerator SetLocation(Vector2 location, float interval)
    {
        print(Time.time);
        yield return new WaitForSeconds(interval);
        transform.position = new Vector3(location.x, location.y, transform.position.z);
    }
}
