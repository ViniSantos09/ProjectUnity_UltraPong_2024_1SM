using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using Random = UnityEngine.Random;

public class ball : MonoBehaviour
{
    public float velocidade = 1;

    void Start()
    {
        // float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float x;

        if (Random.Range(0, 2) != 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        // float y = Random.Range(0, 2) == 0 ? -1 : 1;
        float y;

        if (Random.Range(0, 2) != 0)
        {
            y = 1;
        }
        else
        {
            y = -1;
        }

        GetComponent<Rigidbody>().velocity = new Vector2((velocidade * x),(velocidade * y));
        Debug.Log(GetComponent<Rigidbody>().velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)    
    {
        if (batida.gameObject.name == "ParedeEsquerda")
        {
            transform.position = new Vector3(0, (float)3.403538, 0);
            Start();
        }
        else if (batida.gameObject.name == "ParedeDireita")
        {
            transform.position = new Vector3(0, (float)3.403538, 0);
            Start();
        }
    }

}
