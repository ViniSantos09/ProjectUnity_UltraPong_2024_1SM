using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Vertical2") > 0) && (transform.position.y < 4.5))
        {
            transform.Translate(0, 0.01f, 0);
        }
        else if ((Input.GetAxisRaw("Vertical2") < 0) && (transform.position.y > -0.6))
        {
            transform.Translate(0, -0.01f, 0);
        }
    }
}
