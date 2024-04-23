using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTraffic : MonoBehaviour
{
    // Declare player and main camera
    public GameObject player;
    public GameObject altCamera;
    // Declare movement speed
    private float speed = 5.0f;

    private bool cameraInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraInput = Input.GetButton("Fire1");
        transform.Translate (Vector3.forward * speed * Time.deltaTime);
    }
}
