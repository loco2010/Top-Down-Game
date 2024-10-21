using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public int maxAmmo;
    public int currentAmmo;

    public float fireRate;
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
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
