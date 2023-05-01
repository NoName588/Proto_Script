using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacteP
{
    private Player player;

    public GameObject playerGmObjct;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        player = playerGmObjct.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CompareLvl();
        }
    }

    private void CompareLvl()
    {
        if (powerLvl >= player.powerLvl)
        {
            playerGmObjct.SetActive(false);
            Destroy(playerGmObjct);
        }
        else
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
