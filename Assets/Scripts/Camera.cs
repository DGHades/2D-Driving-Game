using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;
    
    public float size;

    Camera cam;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = gameObject.GetComponent<Camera>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x,  player.transform.position.y, -10);
        cam.size = size;
    }
}
