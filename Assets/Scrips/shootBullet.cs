using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullet : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;

            clone = Instantiate(prefab, transform.position, transform.rotation);

            clone.velocity = transform.TransformDirection(Vector3.forward * 100);
        }
    }
}
