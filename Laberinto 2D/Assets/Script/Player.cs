using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int vida = 100;
    public int puntuaje;
    public int monedas;

    // Start is called before the first frame update
    void Start()
    {
        vida += 5;
        monedas += 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
