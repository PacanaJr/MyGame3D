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
        if (GameObject.FindGameObjectsWithTag("Cubo").Length == 0)
        {
            int actual = SceneManager.GetActiveScene().buildIndex;
            int siguiente = actual + 1;
            if (siguiente < SceneManager.sceneCountInBuildSettings)
                SceneManager.LoadScene(siguiente);
        }
    }


    public void SumarPuntos()
    {
        puntos++;
        TextoPunto.text = puntos.ToString();
        Debug.Log("Punto sumado!");


    }


}