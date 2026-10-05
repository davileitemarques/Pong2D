using UnityEngine;

public class detectar_gol : MonoBehaviour
{
    public bool isGolJogador1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bola"))
        {
            game_manager manager = FindAnyObjectByType<game_manager>();

            if (isGolJogador1)
            {
                manager.aumentarptsjogador2();
            }
            else
            {
                manager.aumentarptsjogador1();
            }
        }
        bola scriptbola = collision.GetComponent<bola>();
        if (scriptbola != null)
        {
            scriptbola.ReiniciarBola();
        }
    }   

}