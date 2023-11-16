using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisProjectile : Projectile
{
    public PlayerChars thisProjectileFont;

    // Start is called before the first frame update
    void Start()
    {
        dmgP = thisProjectileFont.dmg;
    }

    // Update is called once per frame
    void Update()
    {
        //criar e mover num velocidade x os projéteis a cada n segundos
    }
}
