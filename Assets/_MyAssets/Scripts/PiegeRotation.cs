using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeRotation : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRotation = 1800f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        _rb.angularVelocity = Vector3.up * _vitesseRotation * Time.deltaTime;
    }
}
