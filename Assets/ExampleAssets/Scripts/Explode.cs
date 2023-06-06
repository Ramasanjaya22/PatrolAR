using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;
    public float explosionDuration = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Car")
        {
            Destroy(collision.transform.gameObject); // destroy Car
            GameObject explosionObj = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(explosionObj, explosionDuration);
        }
    }
}
