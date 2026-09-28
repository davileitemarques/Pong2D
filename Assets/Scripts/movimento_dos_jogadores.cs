using UnityEngine;
using UnityEngine.InputSystem;

public class movimento_dos_jogadores : MonoBehaviour
{
    public float velocidade = 10f;
    public float yMinimo, yMaximo;
    public bool jogador1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if (jogador1 == true)
        {
           MoverJogador1(); 
        }
        else
        {
            MoverJogador2();
        }
    }
    private void MoverJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }
    private void MoverJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }

}
