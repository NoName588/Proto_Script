using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class SpaceMovementGrid : MonoBehaviour
{
    public Sprite sprite;

    private Player player;
    private Enemy enemy;
    

    private ObjectBonus objectP;

    public GameObject playerT;
    public GameObject enemyT;

    private GameObject objectT;

    public Player[,] playerPosition;
    public Enemy[,] enemyPosition;

    public ObjectBonus[,] objectPosition;

    public int[,] playerPositionActive;
    public int[,] enemyPositionActive;

    public int[,] objectPositionActive;

    public int[,] size;
    private int widht;
    private int height;
    private int columns;
    private int rows;
    private int room = 0;

    
    void Start()
    {
        SetUpGrid();

    }

    private void Awake()
    {
        //CreatingSize(Random.Range(0, 10), Random.Range(0, 10));

        player = playerT.GetComponent<Player>();
        enemy = enemyT.GetComponent<Enemy>();
        objectP = objectT.GetComponent<ObjectBonus>();
        
        //objectP = objectT.GetComponent<ObjectP>();
    }


    void Update()
    {
        RoomClear();
        EntityPosition(player.updatePositionX, player.updatePositionY);
    }

    private void SetUpGrid()
    {
        height = (int)Camera.main.orthographicSize;
        widht = height * (Screen.width / Screen.height);

        columns = widht * 2;
        rows = height * 2;

        size = new int[columns, rows];

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                size[i, j] = Random.Range(0, 10);
                SpawnTile(i, j);
            }
        }
    }

    private void SpawnTile(int x, int y)
    {
        GameObject gmObjct = new GameObject($"X: {x} Y: {y}");

        gmObjct.transform.position = new Vector3(x - (widht - 0.5f), y - (height - 0.5f));

        //var s = gmObjct.AddComponent<SpriteRenderer>();
        var t = gmObjct.AddComponent<BoxCollider2D>();

        t.isTrigger = true;
    }


    /*
    public void CreatingSize(int height, int widht)
    {
        size = new int[height, widht];
        this.height = height;
        this.widht = widht;

        for (int i = 0; i < widht; i++)
        {
            for (int j = 0; j < height; j++)
            {
                size[i, j] = 0;
            }
        }
    }*/

    public bool RoomClear()
    {
        if (room == 0)
            return true;
        else
            return false;
    }

    private void EntityPosition(int positionX, int positionY)
    {
        
        if (playerPositionActive[positionX, positionY] == enemyPositionActive[positionX, positionY])
        {

            if (player.powerLvl >= enemy.powerLvl)
            {
                Destroy(enemy.gameObject);
                player.powerLvl+= enemy.powerLvl;
            }
            else
            {
                Destroy(player.gameObject);
            }

        }

        if (playerPositionActive[positionX, positionY] == objectPositionActive[positionX, positionY])
        {

                player.powerLvl += objectP.powerLvl;
           
        }

    }
}
