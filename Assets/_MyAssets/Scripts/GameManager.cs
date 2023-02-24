using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs
    private int _pointage;

    private void Start()
    {
        _pointage = 0;
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
        _pointage++;
        Debug.Log("Nombres d'accrochages : " + _pointage);
    }

    public void TerminerPartie()
    {
        Debug.Log("Temps de la partie : " + Time.time);
        Debug.Log("Nombre d'obstacles touchés" + _pointage);
        Debug.Log("Score : " + Math.Round(Time.time) + _pointage);
    }
}
