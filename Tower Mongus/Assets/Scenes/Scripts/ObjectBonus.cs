using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBonus : MonoBehaviour
{
    public int powerLvl;


    private Player player;

    public GameObject playerGmObjct;

    private int widht;
    private int height;
    private int columns;
    private int rows;

    public int startPositionX;
    public int startPositionY;

    private int actualPositionX;
    private int actualPositionY;


    private SpaceMovementGrid gridMovement;
    public GameObject spaceMovement;


    // Start is called before the first frame update
    void Start()
    {
        gridMovement = spaceMovement.GetComponent<SpaceMovementGrid>();
        SetUpGridMovement();
        StartPosition();
    }

    private void Awake()
    {
        player = playerGmObjct.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /* public void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.CompareTag("Player"))
         {
             CompareLvl();
         }
     }*/

    /*(private void CompareLvl()
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
    }*/

    private void SetUpGridMovement()
    {
        height = (int)Camera.main.orthographicSize;
        widht = height * (Screen.width / Screen.height);

        columns = widht * 2;
        rows = height * 2;

        gridMovement.objectPosition = new ObjectBonus[columns, rows];
        gridMovement.objectPositionActive = new int[columns, rows];

    }
    private void StartPosition()
    {
        gridMovement.objectPosition[startPositionX, startPositionY] = this;
        gridMovement.objectPositionActive[startPositionX, startPositionY] = 1;
        gameObject.transform.position = new Vector3(startPositionX - (widht - 0.5f), startPositionY - (height - 0.5f));
    }
}
