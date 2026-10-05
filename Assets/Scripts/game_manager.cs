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

    void Start()
    {
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
        ptsJogador1++;
        atualizartexto();
    }

    public void aumentarptsjogador2()
    {
        ptsJogador2++;
        atualizartexto();
    }

    public void atualizartexto()
    {
        texto_ponto_j1.text = ptsJogador1.ToString();
        texto_ponto_j2.text = ptsJogador2.ToString();
    }

    void reiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}