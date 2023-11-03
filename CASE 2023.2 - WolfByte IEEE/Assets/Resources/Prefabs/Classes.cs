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

    public GameObject thisOne, thisOneProjectile;
    public thisProjectile projectile;

    public virtual void Damage(){}
    public virtual void TakeDamage(){}
    
    //classe generalizada de animais do bem, no modelo base, sapos :)
}

public class EnemyChars : PlayerChars
{
    public int velocity;
    public virtual void Move(){}

    //classe generalizada de inimigos.
}

public class Projectile : MonoBehaviour
{
    public Sprite sprtP;
    public BoxCollider2D collP;
    public int dmgP, velocityP; // == dmg no player char

    //os projéteis que darão dano aos inimigos, sendo disparados pelos sapos.
}

public class Spawn
{
    public int minNum, maxNum, timeSpan, numSpawnerSlot;
    public Slot slotSpawn;
    public Transform transfSpawned;

    //permite spawnar inimigos x num espaço de tempo de n segundos.
}

public class Candies
{
    public int numBoost, velocityBoost;
    public Slot slotBoost;

    //criar o sistema de cair balas a cada n segundos que valem x num de Boost,
    // este boost me garantirá comprar mais sapos em campo :)
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

    //sistema de que se os inimigos atravesssarem os colisores das casas, eles venceram o jogo.
    // o num incial é 0 e o final para gameOver é 1.
}

public class Slot : MonoBehaviour
{
    public Transform transf, whereToMove;

    //localizações no tabuleiro para cada objeto/personagem.
}
