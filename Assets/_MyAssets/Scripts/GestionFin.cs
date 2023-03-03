using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (!_toucher && collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            _player.FinPartie();
            _toucher = true;

            if (indexScene == 1)
            {
                _gameManager.TerminerPartie(); 
            }
            else
            {
                SceneManager.LoadScene(indexScene + 1);
            }

        }      
    }
}
