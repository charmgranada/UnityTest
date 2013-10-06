using UnityEngine;
using System.Collections;

public class iTween_MoveTo : MonoBehaviour {
	
	public GameObject cube;
	private int x,y,z;
	private Vector3 initialPos;
	
	public GameObject Lazer;
	
	private Vector3 newPos;
	
	// Use this for initialization
	void Start () {
		cube = GameObject.Find("Cube_green");
		initialPos = transform.position;
		newPos = initialPos;
		x = (int)initialPos.x;
		y = (int)initialPos.y;
		z = (int)initialPos.z;
	}
	
	// Update is called once per frame
	void Update () {
		
		CubePosition();
		ShootAction ();
	}
	
	// Cube Left - Right
	void CubePosition () {	
		
		if(Input.GetKey(KeyCode.RightArrow)){
			x++;
		}		
		else if(Input.GetKey(KeyCode.LeftArrow)){
			x--;
		}
		
		newPos = new Vector3(x, y, z);
		cube.transform.position = newPos;
	}
	
	// Cube Shoots
	void ShootAction () {
		
		//GameObject Lazers = GameObject.Find("Cube_lazer");
		
		if(Input.GetKeyDown(KeyCode.A)){
			Vector3 newPosA = new Vector3(1,1,-3);
			
			if(Lazer != null){
				Debug.Log("HI" + Lazer);			
			}
			else{
				Debug.Log("NO LAZER");
				Instantiate(Lazer, newPosA, Quaternion.identity);
			}
		}
	}
}
