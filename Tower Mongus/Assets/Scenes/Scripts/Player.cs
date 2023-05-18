using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacteP
{
    public int updatePositionX, updatePositionY;
    public int startPositionX;
    public int startPositionY;
    private int width;
    private int height;
    private int columns;
    private int rows;
    private int actualPositionX;
    private int actualPositionY;

    private SpaceMovementGrid gridMovement;
    public GameObject spaceMovement;

    void Start()
    {
        gridMovement = spaceMovement.GetComponent<SpaceMovementGrid>();
        SetUpGridMovement();
        StartPosition();

        actualPositionX = startPositionX;
        actualPositionY = startPositionY;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && actualPositionX < columns - 1)
        {
            MoveToPosition(actualPositionX + 1, actualPositionY);
        }
        else if (Input.GetKeyDown(KeyCode.W) && actualPositionY < rows - 1)
        {
            MoveToPosition(actualPositionX, actualPositionY + 1);
        }
        else if (Input.GetKeyDown(KeyCode.A) && actualPositionX > 0)
        {
            MoveToPosition(actualPositionX - 1, actualPositionY);
        }
        else if (Input.GetKeyDown(KeyCode.S) && actualPositionY > 0)
        {
            MoveToPosition(actualPositionX, actualPositionY - 1);
        }

        updatePositionX = actualPositionX;
        updatePositionY = actualPositionY;
        //Debug.Log($"Player's updated position in array: {actualPositionX} {actualPositionY}");
    }

    private void SetUpGridMovement()
    {
        height = (int)Camera.main.orthographicSize;
        width = height * (Screen.width / Screen.height);

        columns = width * 2;
        rows = height * 2;

        gridMovement.playerPosition = new Player[columns, rows];
        gridMovement.playerPositionActive = new int[columns, rows];
    }

    private void StartPosition()
    {
        gridMovement.playerPosition[startPositionX, startPositionY] = this;
        gridMovement.playerPositionActive[startPositionX, startPositionY] = 1;
        gameObject.transform.position = new Vector3(startPositionX - (width - 0.5f), startPositionY - (height - 0.5f));

        Debug.Log($"Start position of player in array: {startPositionX} {startPositionY}");
    }

    private void MoveToPosition(int targetX, int targetY)
    {
        gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 0;
        gridMovement.playerPosition[actualPositionX, actualPositionY] = null;

        actualPositionX = targetX;
        actualPositionY = targetY;

        gridMovement.playerPositionActive[actualPositionX, actualPositionY] = 1;
        gridMovement.playerPosition[actualPositionX, actualPositionY] = this;

        gameObject.transform.position = new Vector3(actualPositionX - (width - 0.5f), actualPositionY - (height - 0.5f));

        Debug.Log($"Player moved to position in array: {actualPositionX} {actualPositionY}");
    }
}
