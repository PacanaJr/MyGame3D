using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Esfera : MonoBehaviour
{
    public Rigidbody rb;
    public Vector2 mov;
    private float movimientoX;
    private float movimientoY;
    public float velocidad = 5;

    // L�mites del plano
    public float minX = -15f;
    public float maxX = 15f;
    public float minZ = -15.296f;
    public float maxZ = 14.704f;

    void Update()
    {
        Vector3 p = transform.position;
        if (p.x < minX || p.x > maxX || p.z < minZ || p.z > maxZ)
            SceneManager.LoadScene("Nivel1");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene("Nivel1");
        }
    }

    private void OnMove(InputValue movimientos)
    {
        var v = movimientos.Get<Vector2>();
        movimientoX = v.x;
        movimientoY = v.y;
    }

    private void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(movimientoX, 0f, movimientoY);
        rb.linearVelocity = movimiento * velocidad; // importante: velocity (no linearVelocity)
    }
}

