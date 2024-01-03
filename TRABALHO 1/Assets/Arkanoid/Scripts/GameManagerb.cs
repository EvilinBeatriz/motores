using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerb : MonoBehaviour
{
    public static GameManagerb instance;
        public int vidas = 2;
    public int tijolosRestantes;

    public GameObject playerPrefab;
    public GameObject ballprefab;
    public Transform playerSpawnpoint;
    public Transform ballSpawnpoint;

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
        contador.text = $"vidas: {vidas}";
    }

    public void SpawnarNovoJogador()
    {
        GameObject playerObj = Instantiate(playerPrefab,playerSpawnpoint.position,Quaternion.identity);
        GameObject ballObj = Instantiate(ballprefab, ballSpawnpoint.position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
