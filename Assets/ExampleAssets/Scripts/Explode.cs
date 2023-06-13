using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;
    public float explosionDuration = 2f;
    bool bulletCollision = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Car" && bulletCollision == false)
        {
            Destroy(collision.transform.gameObject); // destroy Car
            bulletCollision = true;
            GameObject explosionObj = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Scoring.score += 5;
            Destroy(explosionObj, explosionDuration);
        }
    }
}
