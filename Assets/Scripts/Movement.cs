using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private PlayerStats stats;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<PlayerStats>();

        rb = GetComponent<Rigidbody2D>();
        
        
        


    }

    // Update is called once per frame
    void Update()
    {
        Move();
        FaceMouse();
    }
    void Move()
    {
        Vector2 dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        Debug.Log(dir);
        rb.AddForce(dir * stats.moveSpeed);

    }
    void FaceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;

    }
}
