using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs
    private bool _estActive = false;
    //[SerializeField] private GameObject _piege = default;
    [SerializeField] private List�<GameObject> _listePieges = new List<GameObject>();
    [SerializeField] private float _force;
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    //private Rigidbody _rb;
    

    private void Start()
    {
        foreach(var piege in _listePieges)
        {
            piege.GetComponent<Rigidbody>().useGravity = false;
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_estActive && other.gameObject.tag == "Player")
        {
            foreach (var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.back * _force);
            }

            _estActive = true;
        }     
    }
}
