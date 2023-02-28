using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionFin : MonoBehaviour
{
    // Attributs
    private GameManager _gameManager;
    private bool _toucher;
    private Player _player;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _toucher = false;
        _player = FindObjectOfType<Player>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!_toucher && collision.gameObject.tag != "Player") 
            return;

        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        _gameManager.TerminerPartie();    
        _toucher = true;
        _player.FinPartie();
    }
}
