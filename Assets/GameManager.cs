using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    private int selectedZombiePosition = 0;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;
    // Start is called before the first frame update
    void Start()
    {
        //selected zombie will be 
        //passed in this function when game starts
        SelectZombie(selectedZombie);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left")) {
            GetZombieLeft(); 
        }
        if (Input.GetKeyDown("right"))
        {
            GetZombieRight();
        }
        if (Input.GetKeyDown("up"))
        {

        }
    }

    void GetZombieLeft() { 
        //if the select zombie is first in the list
        //move all the way to the right.
        if(selectedZombiePosition == 0) {
            selectedZombiePosition = 3;
            SelectZombie(zombies[3]);
        }
        else {
            selectedZombiePosition = selectedZombiePosition - 1;
            //moving to the left is one less.
            GameObject newZombie = zombies[selectedZombiePosition];
            SelectZombie(newZombie);
        }
    }

    void GetZombieRight()
    {
        //if the select zombie is last in the list
        //move all the way to the left.
        if (selectedZombiePosition == 3)
        {
            selectedZombiePosition = 0;
            SelectZombie(zombies[0]);
        }
        else
        {
            selectedZombiePosition = selectedZombiePosition + 1;
            //moving to the right is plus one.
            GameObject newZombie = zombies[selectedZombiePosition];
            SelectZombie(newZombie);
        }
    }


    void SelectZombie(GameObject newZombie)
    {
        //the head of the list is on previous zombie
        //before we traverse list transform the previous zombie to
        //previous size
        selectedZombie.transform.localScale = defaultSize;
        //now the head is on the new zombie in the list
        selectedZombie = newZombie;
        //will transform size to the selectedSize 1.4
        newZombie.transform.localScale = selectedSize;
    }
}
