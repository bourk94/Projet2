using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attribut
    [SerializeField] private float _vitesse = 15;
    private Vector3 _positionDepart = new Vector3(-31f, 0.5f, -31f);

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
