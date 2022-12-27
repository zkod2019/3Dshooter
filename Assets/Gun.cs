using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=LNLVOjbrQj4 6:57

public class Gun : MonoBehaviour
{
    public Transform BulletPlacement;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    public float moveSpeed = 10;
 

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

        if(Input.GetMouseButton(0)){
            transform.eulerAngles += moveSpeed * new Vector3(x:-Input.GetAxis("Mouse Y"), y:Input.GetAxis("Mouse X"), z:0);
        }        

      
    }

   
}
