using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System.Collections;

public class game_manager : MonoBehaviour
{
    public int ptsJogador1;
    public int ptsJogador2;

    public TMP_Text texto_ponto_j1;
    public TMP_Text texto_ponto_j2;
    public int pts_vitoria = 5;
    public GameObject texto_vitoria;
    public AudioSource marcando_ponto;
    public GameObject indicadorJogador1;
    public GameObject indicadorJogador2;
    private float cooldown = 2f;

    void Start()
    {
        Time.timeScale = 1f;
        if (texto_vitoria != null)
        {
            texto_vitoria.SetActive(false);
        }
        if (indicadorJogador1 != null)
        {
            indicadorJogador1.SetActive(true);
        }
        if (indicadorJogador2 != null)
        {
            indicadorJogador2.SetActive(true);
        }
        atualizartexto();
        StartCoroutine(EsconderIndicadores());
    }
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            reiniciarPartida();
        }
    }
    IEnumerator EsconderIndicadores()
    {
        yield return new WaitForSeconds(cooldown);

        if (ptsJogador1 < pts_vitoria && ptsJogador2 < pts_vitoria)
        {
            if (indicadorJogador1 != null)
            {
                indicadorJogador1.SetActive(false);
            } 
            if (indicadorJogador2 != null)
            {
                indicadorJogador2.SetActive(false);
            }
        }
    }


    public void aumentarptsjogador1()
    {
        if (ptsJogador1 >= pts_vitoria || ptsJogador2 >= pts_vitoria) return;
        ptsJogador1++;
        atualizartexto();
        VerificarVitoria();
        Marcandoponto();
    }

    public void aumentarptsjogador2()
    {   
        if (ptsJogador1 >= pts_vitoria || ptsJogador2 >= pts_vitoria) return;
        ptsJogador2++;
        atualizartexto();
        VerificarVitoria();
        Marcandoponto();
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
            if (indicadorJogador1 != null)
            {
                indicadorJogador1.SetActive(true);
            }
            if (indicadorJogador2 != null)
            {
                indicadorJogador2.SetActive(true);
            }
            Time.timeScale = 0f;
        }
    }
    void Marcandoponto()
    {
        if (marcando_ponto != null)
        {
            marcando_ponto.Play();
        }
    }
}