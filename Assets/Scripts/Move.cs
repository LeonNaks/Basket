using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;

    bool isRight;
    bool isLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector3.right * 1 * Speed * Time.deltaTime,0);
        }
        else if (isLeft)
        {
            transform.Translate(Vector3.right* -1 * Speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left*Time.deltaTime*Speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(Vector3.right*Time.deltaTime*Speed);}
    }
    public void LeftButton()
    {
        isLeft = true;
        isRight = false;
    }
    public void RightButton()
    {
        isRight = true;
        isLeft = false;
    }
}
