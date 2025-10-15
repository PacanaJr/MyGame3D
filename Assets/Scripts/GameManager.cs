using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text TextoPunto;
    private int puntos;
    private int totalCubos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        puntos = 0;
        TextoPunto.text = puntos.ToString();
        totalCubos = GameObject.FindGameObjectsWithTag("Cubo").Length;

    }

    void Update()
    {
        if (puntos >= 6)
        {
            Debug.Log("Todos los puntos");
            SceneManager.LoadScene(3);
        }
    }
    public void SumarPuntos()
    {
        puntos++;
        TextoPunto.text = puntos.ToString();
        Debug.Log("Punto sumado!");


    }


}