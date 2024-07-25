using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;

    public Text TextoDaPontuacao;

    public AudioSource somDoGol;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            Reiniciar();
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Fechar();
        }
    }

    public void AumentarPontuacaoDoJogador1() {
        pontuacaoDoJogador1 += 1;
        AtualizarTextoDePontuacao();
    }

    public void AumentarPontuacaoDoJogador2() {
        pontuacaoDoJogador2 += 1;
        AtualizarTextoDePontuacao();
    }

    public void AtualizarTextoDePontuacao() {
        TextoDaPontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
        somDoGol.Play();
    }

    private void Reiniciar() {     
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Fechar() {
       Application.Quit();
    }
}
