using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : Slot
{
    public GameObject thisSlotObject;

    public virtual void CreateThisObject(){}

    //onde cada sapo pode ser arrastado para ser gerado seu objeto de fato no unity
}
