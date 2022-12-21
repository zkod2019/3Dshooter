using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletPlacement;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            var bullet = Instantiate(bulletPrefab, BulletPlacement.position, BulletPlacement.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletPlacement.forward * bulletSpeed;
        }
        
    }
}
