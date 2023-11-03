using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChars : MonoBehaviour
{
    public int hlth, dmg;
    public Sprite sprt;
    public Animator anim;
    public Slot iniSlot;
    public BoxCollider2D coll;

    public GameObject thisOne;
    public Projectile projectile;

    public virtual void Damage(){}
    public virtual void TakeDamage(){}
    
}

public class EnemyChars : PlayerChars
{
    public int velocity;
    public virtual void Move(){}
}

public class Projectile 
{
    public Sprite sprtP;
    public Collider collP;
    public int dmgP, velocityP; // == dmg no player char
}

public class Spawn
{
    public int minNum, maxNum, timeSpan, numSpawnerSlot;
    public Slot slotSpawn;
    public Transform transfSpawned;
}

public class Candies
{
    public int numBoost, velocityBoost;
    public Slot slotBoost;
}

public class CandySystem
{
    public int iniNumC, actNumC;

    public virtual void SpendCandies(){}
    public virtual void GainCandies(){}
}

public class HouseSystem
{
    public int iniNumH, actNumH;
    public bool gameOver;
}

public class Slot : MonoBehaviour
{
    public Transform transf, whereToMove;
}
