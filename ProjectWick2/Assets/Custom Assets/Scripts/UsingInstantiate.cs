using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour {


    public Rigidbody BulletPrefabs;
    public Transform barrelEnd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire"))
        {
            Instantiate(BulletPrefabs, barrelEnd.position, barrelEnd.rotation);
        }
		
	}
}
