using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public float velocidade = 10;

    // Start is called before the first frame update
    void Start()
    {
        float velocidade = 10;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;

        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector2(velocidade * x, velocidade * y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
