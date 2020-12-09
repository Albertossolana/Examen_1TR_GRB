using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorEnemigos : MonoBehaviour
{
    [SerializeField] GameObject Enemigo;
    [SerializeField] Transform InitPos;

    private float randomNumberX;
    private float randomNumberY;
    private float randomNumberZ;
    [SerializeField] float distanciaSeparacion = 5f;
    Vector3 RandomPos;
    // Start is called before the first frame update
    void Start()
    {
        for (int n = 1; n <= 20; n++)
        {
            GenerarEnemigo();
            
        }
        StartCoroutine("Aparecer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void GenerarEnemigo() 
    {
        randomNumberX = Random.Range(-40f, 40f);
        randomNumberY = Random.Range(0f, 20f);
        randomNumberZ = Random.Range(-40f, 40f);
        RandomPos = new Vector3(randomNumberX, randomNumberY, randomNumberZ);
        Vector3 FinalPos = InitPos.position + RandomPos * distanciaSeparacion;
        Instantiate(Enemigo, FinalPos, Quaternion.identity);
    }

    [SerializeField] float TiempoAparicion;
    IEnumerator Aparecer()
    {
        for (float n=0; ; n++ )
        {
            GenerarEnemigo();
           
            yield return new WaitForSeconds(TiempoAparicion);
        }
    }
}
