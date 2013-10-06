using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour {

	public Vector3 LazerPos = new Vector3(1,1,-3);
	
	// Use this for initialization
	void Start () {
		//LazerPos = new Vector3(1,1,-3);
		transform.localPosition = LazerPos;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Debug.Log(Time.deltaTime);
		
		transform.Translate(Vector3.back * 0.1f, Space.World);
		//transform.Translate(Vector3.back * 0.1f);
		
		if(transform.localPosition.z < -9)
			DestroyObject(this.gameObject);
			
	}
}
