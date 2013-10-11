using UnityEngine;
using System.Collections;

public class Practice2 : MonoBehaviour {
	
	private float xPos;
	private float yPos;
	private float zPos;
	
	public GameObject obj;
	
	// Use this for initialization
	void Start () {
		Vector3 objPos = gameObject.transform.localPosition;
		xPos = objPos.x;
		yPos = objPos.y;
		zPos = objPos.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){
			xPos++;
		}
		else if(Input.GetKey(KeyCode.LeftArrow)){
			xPos--;
		}
		
		//Vector3 n = new Vector3(0.1f,0.0f,0.0f);
		//gameObject.transform.Translate(n);
		
        //transform.Translate(Vector3.forward * Time.deltaTime);
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		
        transform.Translate(Vector3.right * Time.deltaTime, obj.transform);
	}
}
