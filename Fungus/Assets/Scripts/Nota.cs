﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nota : MonoBehaviour
{
    public string titulo;
    public string texto;
    public Text bloco;

    public void InsereNoBloco () {
        bloco.text = bloco.text + "\n" + titulo + "\n" + texto;
        TextoDoBloco.textoDoBloco = bloco.text;
        gameObject.SetActive(false);
    }
}
