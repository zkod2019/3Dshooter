using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=LNLVOjbrQj4 6:57
public class Gun : MonoBehaviour
{
    public Transform BulletPlacement;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    public float moveSpeed = 5f;
    public Rigidbody rb;
    public Camera cam;

    Vector3 movement;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Space)){
            var bullet = Instantiate(bulletPrefab, BulletPlacement.position, BulletPlacement.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletPlacement.forward * bulletSpeed;
        }
        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector3 lookDir = mousePos - rb.position;
    }
}
