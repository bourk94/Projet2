using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attribut
    [SerializeField] private float _vitesse = 10;
    private Vector3 _positionDepart = new Vector3(-13f, 0.51f, -13f);

    //Méthodes privées
    private void Start()
    {
        //Postion de départ du joueur
        this.transform.position = _positionDepart;

    }

    private void Update()
    {
        MouvementsJoueur();

    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
