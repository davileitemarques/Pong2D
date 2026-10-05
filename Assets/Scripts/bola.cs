using UnityEngine;

public class bola : MonoBehaviour
{
    public float velocidadeBola;
    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;
    public Rigidbody2D rb;
    public AudioSource somDaBola;
    private Vector3 posicaoInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void MoverBola()
    {
        velocidadeBola = 6f;

        if (Random.Range(0, 2) == 0)
        {
            direcaoAleatoriaX = -1;
        }
        else
        {
            direcaoAleatoriaX = 1;
        }
        if (Random.Range(0, 2) == 0)
        {
            direcaoAleatoriaY = -1;
        }
        else
        {
            direcaoAleatoriaY = 1;
        }
        Vector2 direcaoInicial = new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
        rb.linearVelocity = direcaoInicial * velocidadeBola;
    }
    public void ReiniciarBola()
    {
        transform.position = posicaoInicial;
        rb.linearVelocity = Vector2.zero;
        MoverBola();

    }
    void OnCollisionEnter2D(Collision2D colisao)
    {   if (somDaBola != null)
        {
          somDaBola.Play();  
        }
        rb.linearVelocity = rb.linearVelocity * 1.02f;
    }   
}
