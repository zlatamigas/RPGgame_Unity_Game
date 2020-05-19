using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mana : MonoBehaviour
{
    public void ManUp(GameObject mana)
    {
        mana.GetComponent<Slider>().value -= 30;        
    }
    public void Oneww(GameObject sword)
    {
        sword.GetComponent<Damage>().damtoEnemy += 15;
    }
    public void twooww(GameObject hammer)
    {
        hammer.GetComponent<Damage>().damtoEnemy += 15;
    }

}
