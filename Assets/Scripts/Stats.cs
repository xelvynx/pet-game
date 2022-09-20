using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{
    [SerializeField] private string _name;
    [SerializeField] private int _value;
    public int Value
    {
        get { return _value; }
    }

    public virtual void AddValue()
    {
        _value++;
    }
    public virtual bool MinusValue()
    {
        _value--;
        if (_value < 0)
        {
            _value = 0;
            return true;
        }
        return false;
    }
}
