using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
    public GameObject player_obj;
    //public GameObject camer_obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //get sidewards movement
        float x_player = Input.GetAxis("Vertical");
        float z_player = Input.GetAxis("Horizontal");
        
        //get new pos
        Vector3 newPos = player_obj.transform.position;
        newPos.x += x_player;
        newPos.z += z_player;

        //move player
        player_obj.transform.position = newPos;
        //move camera
        //Vector3 newCam = camer_obj.transform.position;
        //newCam.x += x_player;
        //camer_obj.transform.position = newCam;
		
	}
}
