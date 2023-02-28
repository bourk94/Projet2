using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attribut
    [SerializeField] private float _vitesse = 600;
    private Vector3 _positionDepart = new Vector3(-31f, 0.5f, -31f);
    private GestionFin _gestionFin;
    private Rigidbody _rb;

    //M�thodes priv�es
    private void Start()
    {
        //Postion de d�part du joueur
        this.transform.position = _positionDepart;
        _rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    // M�thode publiques
    public void FinPartie()
    {
        this.gameObject.SetActive(false);
    }

}
