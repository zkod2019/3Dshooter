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

    public float speed;
    public float rotationOffset;
 

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

        // if(Input.GetMouseButton(0)){
        //   transform.eulerAngles += moveSpeed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), z:0);
        //}        

        // Vector3 mousePos = Input.mousePosition;
        // mousePos.z = 0;
        // Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        // mousePos.x = mousePos.x - objectPos.x;
        // mousePos.y = mousePos.y - objectPos.y;

        // float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(new Vector3(0,0, angle + rotationOffset));

        // Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // targetPos.z = 0;
        // transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        public float mouseSensitivity = 100f;
        public Transform playerBody;
        float xRotation = 0f;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector.up * mouseX);
    }

   
}
