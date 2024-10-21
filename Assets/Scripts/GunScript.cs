using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public int maxAmmo;
    public int currentAmmo;
    private float lastFireTime;
    public float fireGap;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // shoot when left mouse button is clicked and once a second
        if (Input.GetMouseButton(0)){
            if (Time.time >= lastFireTime + fireGap){
            Shoot();
            lastFireTime = Time.time;
            }
        }
    }

    void Shoot(){
        Vector3 spawnPosition = transform.position + transform.right * 1f;
        Instantiate(bullet, spawnPosition, transform.rotation);
    }
}
