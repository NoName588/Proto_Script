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
    private int actualPositionX;
    private int actualPositionY;

    private SpaceMovementGrid gridMovement;
    public GameObject spaceMovement;
    //private Rigidbody2D rb;
    
    //private Vector3 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        gridMovement = spaceMovement.GetComponent<SpaceMovementGrid>();
        SetUpGridMovement();
        StartPosition();

        actualPositionX = startPositionX;
        actualPositionY = startPositionY;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))    
        {
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 0;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = null;
            gameObject.transform.position = new Vector3((actualPositionX + 1) - (widht - 0.5f), actualPositionY - (height - 0.5f));
            actualPositionX += 1;
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 1;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = this;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 0;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = null;
            gameObject.transform.position = new Vector3(actualPositionX - (widht - 0.5f), (actualPositionY + 1) - (height - 0.5f));
            actualPositionY += 1;
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 1;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = this;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 0;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = null;
            gameObject.transform.position = new Vector3((actualPositionX - 1) - (widht - 0.5f), actualPositionY - (height - 0.5f));
            actualPositionX -= 1;
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 1;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = this;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 0;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = null;
            gameObject.transform.position = new Vector3(actualPositionX - (widht - 0.5f), (actualPositionY - 1) - (height - 0.5f));
            actualPositionY -= 1;
            gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 1;
            gridMovement.playerPosition[actualPositionX, actualPositionY] = this;
        }

        //AddObject();
    }
    /*
    private void FixedUpdate()
    {
        rb.velocity = movementDirection;
    }*/

    private void SetUpGridMovement()
    {
        height = (int)Camera.main.orthographicSize;
        widht = height * (Screen.width / Screen.height);

        columns = widht * 2;
        rows = height * 2;

        gridMovement.playerPosition = new Player[columns, rows];
        gridMovement.playerPositionActive = new int[columns, rows];

    }

    private void StartPosition()
    {
        gridMovement.playerPosition[startPositionX, startPositionY] = this;
        gridMovement.playerPositionActive[startPositionX, startPositionY] = 1;
        gameObject.transform.position = new Vector3(startPositionX - (widht - 0.5f), startPositionY - (height - 0.5f));
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
