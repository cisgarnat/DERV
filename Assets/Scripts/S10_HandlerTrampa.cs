using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S10_HandlerTrampa : MonoBehaviour
{

    float tiempo_en_trigger;
    float tiempo_para_nuevo_enemigo;
    Transform spawn;
    [SerializeField] List<GameObject> lista_enemigos;
    int contador_enemigo_actual;

    private void Awake()
    {
        spawn = GameObject.Find("Spawn").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        tiempo_para_nuevo_enemigo = 2;
        contador_enemigo_actual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        tiempo_en_trigger += Time.deltaTime;
        if (tiempo_en_trigger > tiempo_para_nuevo_enemigo)
        {
            lista_enemigos[contador_enemigo_actual].transform.position = spawn.position;

            lista_enemigos[contador_enemigo_actual].GetComponent<Rigidbody>().AddForce(
                -1 * 30f * transform.up, ForceMode.Impulse
                );

            contador_enemigo_actual++;
            contador_enemigo_actual %= contador_enemigo_actual;
            tiempo_en_trigger = 0;
        }
    }

}
