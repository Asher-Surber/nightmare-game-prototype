using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHandler : MonoBehaviour
{
    public Transform player;
    private Vector2 playerPos;
    public int speed = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.position;
        var mouse = Mouse.current;
        var kb = Keyboard.current;

        if(kb == null || mouse == null)
        {
            print("Mouse or Keyboard not found");
            return;
        }

        if (kb.wKey.isPressed && !kb.sKey.isPressed)
        {
            //Jump
            print("w key pressed");
        }

        if(kb.aKey.isPressed && !kb.dKey.isPressed)
        {
            playerPos.x -= speed * Time.deltaTime;
            player.position = playerPos;
            print("a key pressed");
        }

        if(kb.dKey.isPressed && !kb.aKey.isPressed)
        {
            playerPos.x += speed * Time.deltaTime;
            player.position = playerPos;
            print("d key pressed");
        }

        if (kb.sKey.isPressed)
        {
            //Crouch?
        }

    }

    void Move(){
        
    
    }


}
