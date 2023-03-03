using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeRotation : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRotation = 4f;

    void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseRotation, 0f);
    }
}
