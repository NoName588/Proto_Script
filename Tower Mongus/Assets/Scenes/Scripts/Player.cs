using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacteP
{
    //private ObjectBonus objectP;
    //private Enemy enemyP;

    public int startPositionX;
    public int startPositionY;
    private int widht;
    private int height;
    private int columns;
    private int rows;

    private SpaceMovementGrid gridMovement;
    public GameObject spaceMovement;


    // Start is called before the first frame update
    void Start()
    {
        gridMovement = spaceMovement.GetComponent<SpaceMovementGrid>();
        SetUpGridMovement();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        //AddObject();
    }

    private void SetUpGridMovement()
    {
        height = (int)Camera.main.orthographicSize;
        widht = height * (Screen.width / Screen.height);

        columns = widht * 2;
        rows = height * 2;

        gridMovement.playerPosition = new Player[columns, rows];

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                gridMovement.playerPosition[i, j] = gameObject.GetComponent<Player>();
            }
        }
    }

    private void StartPosition()
    {

    }

    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        
    }*/

    /*public void AddObject()
    {
        PowerLvl += objectP.PowerLvl;
    }*/

    /*public bool CompareLvl()
    {
        if (PowerLvl >= enemyP.PowerLvl)
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/
}
