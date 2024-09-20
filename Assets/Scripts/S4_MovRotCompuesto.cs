using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_MovRotCompuesto : MonoBehaviour
{

    [SerializeField] float velocidad_rotacion = 10f;
    [SerializeField] float velocidad_movimiento = 10f;
    void Update()
    {

        float angulo = 5f * velocidad_rotacion * Time.deltaTime;

        //rotar
        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(0, angulo *-1, 0);
        }else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, angulo, 0);
        }
        
        //Arriba - abajo
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidad_movimiento * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * velocidad_movimiento * Time.deltaTime;
        }
        //izquierda - derecha
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -1 * velocidad_movimiento * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidad_movimiento * Time.deltaTime;
        }
    }
}
