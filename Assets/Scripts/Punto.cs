using UnityEngine;

public class Punto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Esfera"))
        {
            Debug.Log("Colisi�n con esfera!");
            FindAnyObjectByType<GameManager>().SumarPuntos();
            Destroy(gameObject);
            Debug.Log("Objeto destruido!");
        }
    }
}

