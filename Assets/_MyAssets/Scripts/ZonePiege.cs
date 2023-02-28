using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs
    private bool _estActive = false;
    [SerializeField] private GameObject _piege = default;
    [SerializeField] private float _force;
    private Rigidbody _rb;
    

    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
        _rb.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_estActive && other.gameObject.tag == "Player") 
            return;

        _estActive = true;

        if (!_estActive)
            return;

        _rb.useGravity = true;
        _rb.AddForce(Vector3.back * _force);
    }
}
