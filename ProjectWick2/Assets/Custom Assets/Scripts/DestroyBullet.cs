using System.Collections;

using UnityEngine;

public class DestroyBullet : MonoBehaviour {
    public Rigidbody BulletPrefabs;

    public GameObject projectile;

    void Update ()
    {

    }

    void OnCollisionEnter(Collision Col)
        {
            Destroy(gameObject);
        }
		
	}



