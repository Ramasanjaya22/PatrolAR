using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{

    public Transform arCamera;
    public GameObject projectile;

    public float shootForce = 700.0f;

    private Button shootButton;

    private void Start()
    {
        shootButton = GetComponent<Button>();
        shootButton.onClick.AddListener(ShootProjectile);
    }

    private void ShootProjectile()
    {
        GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootForce);
    }
}


