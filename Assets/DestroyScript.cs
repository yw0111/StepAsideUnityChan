using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
private GameObject MyCamera;

	// Use this for initialization
	void Start () {
        this.MyCamera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
		if (this.MyCamera.transform.position.z >= this.transform.position.z)
        Destroy(gameObject);
    }
}
