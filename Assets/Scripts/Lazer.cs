using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour {

	public Vector3 LazerPos;// = new Vector3(1,1,-3);
	
	// Use this for initialization
	void Start ()
	{
		transform.localPosition = LazerPos;
	}
	
	
	// Update is called once per frame
	void Update ()
	{		
		// 
		if(gameObject.activeSelf){				
			transform.Translate(Vector3.back * 0.1f, Space.World);
		}
		else {			
			transform.localPosition = LazerPos;
			gameObject.SetActive(true);
		}
		
		// Destroy Object when localPosition transfers to this part
		/*if(	transform.localPosition.z < -9){
			DestroyObject(this.gameObject);
			gameObject.SetActive(false);
		}*/
	}
}
