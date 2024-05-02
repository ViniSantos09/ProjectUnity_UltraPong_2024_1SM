using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class bola : MonoBehaviour
{
    public float velocidade = 10;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;

        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector2((velocidade * x)*(velocidade * x),(velocidade * y)*(velocidade * y));
        Debug.Log(GetComponent<Rigidbody>().velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)
    {
        if ((batida.gameObject.name == "BEsquerda") || (batida.gameObject.name == "BDireita")) 
        {
            transform.position = new Vector3((float)-0.4, (float)1.7, -7);
            Start();
        }
    }
}
