using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float ejeH;
    public float ejeV;
    public float velocidad;
    Transform t;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
        t = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        velocidad = 5;
    }

    // Update is called once per frame
    void Update()
    {
        ejeH = Input.GetAxis("Horizontal");
        ejeV = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(ejeH,ejeV) * velocidad;
       


    }
}
