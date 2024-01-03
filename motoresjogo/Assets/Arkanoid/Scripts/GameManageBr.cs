using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerB : MonoBehaviour
{
    public static GameManagerB instance;
    public int vidas = 2;
    public int tijolosRestantes;


    public GameObject playerPrefab;
    public GameObject ballPrefab;
    public Transform playerSpawnPoint;
    public Transform ballSpawnPoint;

    public PlayerB playerAtual;
    public BallB ballAtual;

    public TextMeshProUGUI contador;
    public TextMeshProUGUI msgFinal;

    public bool segurando;
    private Vector3 offset;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
      SpawnarNovoJogador();
      AtualizarContador();
    }

    public void AtualizarContador()
    {
        contador.text = $"Vidas:{vidas}"; 
    }

    public void spawnarNovoJogador()
    {
        GameObject playerObj = Instantiate(playerPrefab,playerSpawnPoint.position, Quaternion.Identity);
        GameObject ballObj = Instatiate(ballPrefab,ballSpawnPoint.position, Quaternion.Identity);
    }


    void Update()
    {
        
    }
}
