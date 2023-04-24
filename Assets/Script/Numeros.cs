using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numeros : MonoBehaviour
{
    [SerializeField] int _gForte;
    [SerializeField] int _gFraca;
    [SerializeField] float _gravidade;
    [SerializeField] GameObject _bola;
    [SerializeField] Rigidbody _rig;
    [SerializeField] Text _tex;

    // Start is called before the first frame update
    void Start()
    {
        _rig.mass= _gravidade;
        _gravidade = _gFraca;
        _gravidade = _gravidade * 3;
        _tex.text = "Valor da gravidade é " + _gravidade ;
    }

    // Update is called once per frame
    void Update()
    {
        _rig.mass = _gravidade;
    }
}
