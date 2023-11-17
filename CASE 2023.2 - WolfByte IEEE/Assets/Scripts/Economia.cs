using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Economia : MonoBehaviour
{
    public Text txt_dinheiro;//texto da ui
    public int dinheiroInicial;
    public int dinheiro;// valor atual do dinheiro

    //coloca os valores iniciais
    public void Init()
    {
        dinheiro = dinheiroInicial;
        UpdateUI();
    }
  //ganha dinheiro
    public void Gain(int valor)
    {
        dinheiro += valor;
        UpdateUI();
    }
    //usa
    public bool Use(int valor)
    {
        if (DinheiroSuficiente(valor))
        {
            dinheiro -= valor;
            return true;
        }else
            return false;
    }
    //checar se tem dinheiro suficiente
    bool DinheiroSuficiente(int valor)
    {
        //checa se o valor é menor ou igual ao dinheiro
        if (valor <= dinheiro)
        {
            return true;
        }else
            return false;
    }


    void UpdateUI()
    {
        txt_dinheiro.text = dinheiro.ToString();
    }
    public void USE_TEST()
    {
        Debug.Log(Use(3));
        UpdateUI();
    }

}

