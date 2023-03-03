using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs
    private int _accrochage;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GameManager>().Length;
        if (nbGestionJeu > 0)
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        _accrochage = 0;
        Instructions();
    }

    private static void Instructions()
    {
        Debug.Log("Course à obstacle");
        Debug.Log("Atteindre la fin du parcours le plus rapidement possible");
        Debug.Log("Chaque obstacle qui sera touché entraînera une pénalité");
    }

    // Méthode public
    public void AugmenterPointage()
    {
        _accrochage++;
        Debug.Log("Nombres d'accrochages : " + _accrochage);
    }

    public void TerminerPartie()
    {
        Debug.Log("Temps de la partie : " + Time.time.ToString("f2"));
        Debug.Log("Nombre d'obstacles touchés" + _accrochage);
        Debug.Log("Score : " + Time.time.ToString("f2") + _accrochage);
    }
}
