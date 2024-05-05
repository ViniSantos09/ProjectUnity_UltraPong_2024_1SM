using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class bola : MonoBehaviour
{
    public float velocidade = 10;

    public TMP_Text pontuacaoEsquerda;

    public TMP_Text pontuacaoDireita;

    int pontosDireita = 0;

    int pontosEsquerda = 0;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        
        GetComponent<Rigidbody>().velocity = new Vector2((velocidade * x)*(velocidade * x),(velocidade * y)*(velocidade * y));
        Debug.Log(GetComponent<Rigidbody>().velocity);

        pontuacaoDireita.SetText(pontosDireita.ToString());
        pontuacaoEsquerda.SetText(pontosEsquerda.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)
    {
        if (batida.gameObject.name == "BEsquerda")
        {
            transform.position = new Vector3((float)-0.4, (float)1.7, -7);
            pontosDireita++;
            Start();
        }

        else if (batida.gameObject.name == "BDireita")
        {
            transform.position = new Vector3((float)-0.4, (float)1.7, -7);
            pontosEsquerda++;
            Start();
        }
    }
}
