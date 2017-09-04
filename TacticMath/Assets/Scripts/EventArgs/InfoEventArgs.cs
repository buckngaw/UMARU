using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//http://theliquidfire.com/2015/05/24/user-input-controller/
public class InfoEventArgs<T> : EventArgs
{
    public T info;

    public InfoEventArgs()
    {
        info = default(T);
    }

    public InfoEventArgs(T info)
    {
        this.info = info;
    }
}
