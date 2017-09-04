using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//it makes sense to track each one as a separate object
class Repeater_comment
{
    //the amount of pause to wait between an intial press of the button, and the point at which the input will begin repeating
    const float threshold = 0.5f;
    const float rate = 0.25f; //the speed that the input will repeat.
    float _next; //mark a target point in time which must be passed before new events will be registered 
    bool _hold; //user has continued pressing the same button since the last time an event fired
    string _axis; //store the axis that will be monitored through Unity’s Input Manager. 
    public Repeater_comment(string axisName)
    {
        _axis = axisName;
    }

    //the Update method wont be triggered by Unity – we will be calling it manually.
    //return int value (-1, 0, or 1)
    // 0 = user not press btn or wait for repeat event
    public int Update()
    {
        int retValue = 0;
        int value = Mathf.RoundToInt(Input.GetAxisRaw(_axis)); //get the value this object is tracking from the Unity’s Input Manager 
        //user is providing input: value != 0
        if (value != 0)
        {
            if (Time.time > _next)
            {
                retValue = value;
                _next = Time.time + (_hold ? rate : threshold);
                _hold = true;
            }
        }
        else
        {
            
               _hold = false;
            _next = 0;
        }
        return retValue;
    }

    public class InputController_withcomment : MonoBehaviour
    {
        public static event EventHandler<InfoEventArgs<Point>> moveEvent;
        public static event EventHandler<InfoEventArgs<int>> fireEvent;

        Repeater _hor = new Repeater("Horizontal");
        Repeater _ver = new Repeater("Vertical");
        string[] _buttons = new string[] { "Fire1", "Fire2", "Fire3" };

        void Update()
        {
            int x = _hor.Update();
            int y = _ver.Update();
            //check for movement,
            if (x != 0 || y != 0)
            {
                if (moveEvent != null)
                    moveEvent(this, new InfoEventArgs<Point>(new Point(x, y)));
            }
            //each of our Fire button checks:
            for (int i = 0; i < 3; ++i)
            {
                if (Input.GetButtonUp(_buttons[i]))
                {
                    if (fireEvent != null)
                        fireEvent(this, new InfoEventArgs<int>(i));
                }
            }
        }

    }
}
