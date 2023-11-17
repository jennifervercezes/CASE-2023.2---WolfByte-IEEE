using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Caldeirao : MonoBehaviour
{
    public int vida;
    public int producao = 50;//quanto que o caldeirao produz
    public float tempo;
    public GameObject obj_doce;
    public int custo = 50;

    public void Init()
    {
        StartCoroutine(Tempo());
        
    }
    IEnumerator Tempo()
    {
        yield return new WaitForSeconds(tempo);
        AumentaDinheiro();
    }
    public void AumentaDinheiro()
    {
        GameManager.Instance.economia.Gain(producao);
        StartCoroutine(Doce());
    }
    IEnumerator Doce()
    {
        obj_doce.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        obj_doce.SetActive(false);
    }
    public void perdevida()
    {
        vida--;
        if (vida < 0) 
        {
            Morre();
        }
    }
    public void Morre()
    {
        Debug.Log("Torre destruída");
        Destroy(gameObject);
    }
}
