using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float timer=0;
    private PlayerStats stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<PlayerStats>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

    }
}
