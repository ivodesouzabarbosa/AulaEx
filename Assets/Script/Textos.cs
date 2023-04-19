using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    // Declarações de texto
    [SerializeField] string _nome = "Fredy";
    [SerializeField] string _sobreNome;
    [SerializeField] string _nomeCompleto;
    [SerializeField] Text _text;



    // Start is called before the first frame update
    void Start()
    {
        _nome = "Jorge";
        _nomeCompleto = _nome + " " + "de" + " " + _sobreNome;
        _text.text = _nomeCompleto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
