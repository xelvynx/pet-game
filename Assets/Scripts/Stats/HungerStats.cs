using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class HungerStats
{
    [SerializeField] private Stats[] _hungerStats; //Hunger,MaxHunger
    [SerializeField] private bool _isSick;


    [SerializeField] private int _feedCount;
    [SerializeField] private int _feedToNextLevel;
    
    
    
    
    
    
    //public int FeedCount
    //{
    //    get { return _feedCount; }
    //    set { _feedCount = value; }
    //}

    public void Feed()
    {
        _feedCount++;
        if (_feedCount >= _feedToNextLevel)
        {
            _feedToNextLevel += _feedCount;
            _feedCount = 0;
            //IncreaseSize();
        }
    }

    //public void IncreaseSize()
    //{
    //    transform.localScale += Vector3.one;
    //}

    //[SerializeField] private int _hungryTimer;
    //[SerializeField] private bool _isHungry;

    //public void Update()
    //{

    //    if (Time.time % _hungryTimer == 0 && !_isHungry)
    //    {
    //        Hungry();
    //        _isHungry = true;
    //        Invoke("DisableHungry", 3);
    //    }
    //}

    public void Hungry()
    {
        //if (stats[0].MinusValue())
        //{
        //    SickChance();
        //}
    }

    public void GetFed()
    {
        //stats.Feed();
        //if (stats.stats)
        //{
        //    _nextLevel += _feedCount;
        //    _feedCount = 0;
        //    _level++;
        //    IncreaseSize();
        //}
    }

    //public void Feed()
    //{
    //    //if (stats[0].Value < 4)
    //    //{
    //    //    stats[0].AddValue();
    //    //    return;
    //    //}
    //    //Debug.Log("FULL");
    //}

    public void DisableHungry()
    {
        //_isHungry = false;
    }
    public void SickChance()
    {
        //_sickChance += .25f;
        //Debug.Log("I'm like super like hungry like right like now");
        //if (_sickChance >= 1)
        //{
        //    Debug.Log("I'M SO FUCKING SICK RIGHT NOW JUST HELP ME AND FEED ME YOU POS!");
        //}
    }
}
