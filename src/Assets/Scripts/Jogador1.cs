using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador1 : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Vertical") > 0) && (transform.position.y < 4.5))
        {
            transform.Translate(0, 0.05f, 0);
        }
        else if ((Input.GetAxisRaw("Vertical") < 0) && (transform.position.y > -0.6))
        {
            transform.Translate(0, -0.05f, 0);
        }
        
    }
}
