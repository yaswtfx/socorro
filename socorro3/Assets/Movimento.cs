using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = 0f;
        if (Input.GetKey((KeyCode.RightArrow)))
        {
            movimentoHorizontal = 1f;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimentoHorizontal = -1f;
        }

        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;
        
        float movimentoVertical = 0f;
        
        if (Input.GetKey((KeyCode.UpArrow)))
        {
            movimentoVertical = 1f;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movimentoVertical = -1f;
        }
        
        transform.position += new Vector3(0f, movimentoVertical,0f) * velocidade * Time.deltaTime;
    }
}
