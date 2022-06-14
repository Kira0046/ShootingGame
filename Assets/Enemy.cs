using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHp;

    public void Damage()
    {
        enemyHp = enemyHp - 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        enemyHp = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
