using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessBackGround : MonoBehaviour
{

    public Transform[] BackGrounds;
   
    public Transform Player;


    [SerializeField]
    private float currentXpos = 11.99f;

    [SerializeField]
    private float layerWidth = 11.99f;
    [SerializeField]
    private float spawnOffset = 2.3f;

    private int index = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawLine(new Vector3(spawnOffset, -10, 0), new Vector3(spawnOffset, 10, 0));
        if (Player.position.x >= spawnOffset)
        {
            MoveBackGround();
        }
        /*
        if (currentXpos < Cam.position.x + 20)
        {
            if (OneOrTwo)
            {
                BackGround1.localPosition = new Vector2(BackGround1.localPosition.x + currentXpos, 0);
            }
            else
            {
                BackGround2.localPosition = new Vector2(BackGround2.localPosition.x + currentXpos, 0);
            }

            currentXpos += currentXpos;
            OneOrTwo = !OneOrTwo;
        }


        if (currentXpos > Cam.position.x + 15)
        {
            if (OneOrTwo)
            {
                BackGround2.localPosition = new Vector2(BackGround2.localPosition.x - currentXpos, 0);
            }
            else
            {
                BackGround1.localPosition = new Vector2(BackGround1.localPosition.x - currentXpos, 0);
            }

            currentXpos -= currentXpos;
            OneOrTwo = !OneOrTwo;
        }
        */
    }

    public void MoveBackGround()
    {
        int modulodedIndex = index % BackGrounds.Length;
        Vector3 newPosition = new Vector3(BackGrounds[modulodedIndex].position.x + (layerWidth * BackGrounds.Length),
            BackGrounds[modulodedIndex].position.y, BackGrounds[modulodedIndex].position.z);
        print(newPosition);

        BackGrounds[modulodedIndex].position = newPosition;

        index++;

        spawnOffset += layerWidth;
    }
}
