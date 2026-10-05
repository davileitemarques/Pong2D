using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    public int ptsJogador1;
    public int ptsJogador2;

    public TMP_Text texto_ponto_j1;
    public TMP_Text texto_ponto_j2;
    public int pts_vitoria = 5;
    public GameObject texto_vitoria;

    void Start()
    {
        Time.timeScale = 1f;
        if (texto_vitoria != null)
        {
            texto_vitoria.SetActive(false);
        }
        atualizartexto();
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            reiniciarPartida();
        }
    }

    public void aumentarptsjogador1()
    {
        if (ptsJogador1 >= pts_vitoria || ptsJogador2 >= pts_vitoria) return;
        ptsJogador1++;
        atualizartexto();
        VerificarVitoria();
    }

    public void aumentarptsjogador2()
    {   
        if (ptsJogador1 >= pts_vitoria || ptsJogador2 >= pts_vitoria) return;
        ptsJogador2++;
        atualizartexto();
        VerificarVitoria();
    }

    public void atualizartexto()
    {
        texto_ponto_j1.text = ptsJogador1.ToString();
        texto_ponto_j2.text = ptsJogador2.ToString();
    }

    void reiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    void VerificarVitoria()
    {
        if (ptsJogador1 >= pts_vitoria || ptsJogador2 >= pts_vitoria)
        {
            if (texto_vitoria != null)
            {
                texto_vitoria.SetActive(true);
            }
            Time.timeScale = 0f;
        }
    }
}