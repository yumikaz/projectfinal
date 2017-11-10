using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souris : MonoBehaviour
{
    public GameObject shootPoint;
    //public ParticleSystem;
    
    GameObject CartridgeHightPrefabsClone;
    

    GameObject CartridgeHight;
    GameObject CartridgeHightClone;

    // Use this for initialization
    void Start()
    {
        CartridgeHight = Resources.Load("Prefabs/CartridgeHight") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

            
        {
            CartridgeHightClone = Instantiate(CartridgeHight, shootPoint.transform.position, Quaternion.identity);
            CartridgeHightClone.GetComponent<Rigidbody>().AddForce(shootPoint.transform.forward * 1500);

            //Destroy(CartridgeHightClone, 2f);
        }
    }
}

