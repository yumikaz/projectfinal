using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour
{
    public GameObject CartridgeHightPrefabs;
    public GameObject shootPoint;
    public int CartridgeHightForce;

    // Use this for initialization
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = transform.forward * CartridgeHightForce;
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
