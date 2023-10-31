using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObtaculo : MonoBehaviour
{

    Transform t;
    bool haciaArriba = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
       if (transform.position.y > 9)
        {
            haciaArriba = false;
        }



       if(haciaArriba == true)
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.up * Time.deltaTime;

        }


    }
}
