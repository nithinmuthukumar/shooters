using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + initPos ;
        
    }
}
