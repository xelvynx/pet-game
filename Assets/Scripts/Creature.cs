using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    [SerializeField] private HungerStats _hungerStats;
    [Space(10)]
    [SerializeField] private HealthStats _healthStats;
    [Space(10)]
    [SerializeField] private CreatureStats _creatureStats;
    [Header("Other stuff here")]

    #region Variables
    //[SerializeField] private Stats[] _hungerStats; //Hunger,MaxHunger
    public int _health;
    public int _maxHealth;
    [SerializeField] private bool _isSick;
    [SerializeField] private bool _isHungry;
    [SerializeField] private int _level = 1;
    [SerializeField] private int _feedCount = 0;
    [SerializeField] private int _nextLevel = 2;
    [SerializeField] private float _sickChance = 0;
    [SerializeField] private int hungryTimer;

    public int tempTime;
    public readonly int nextLevel;
    private Transform creatureTransform;

    [SerializeField] private int _hungry;
    [SerializeField] private int _hungryCount;
    [SerializeField] private int _happy;
    [SerializeField] private int _happyMax;
    [SerializeField] private int _strength;
    [SerializeField] private int _strengthCount;
    [SerializeField] private int _stamina;
    [SerializeField] private int _staminaMax;
    #region Examples For Editor
    public bool hasMagic;
    public int mana;
    public enum MagicElementType { Fire, Water, Earth, Air };
    public MagicElementType magicType;
    public int magicDamage;
    #endregion
    #endregion



    // Start is called before the first frame update
    void Start()
    {
        creatureTransform = GetComponentInChildren<Transform>();
        if (creatureTransform == null)
        {
            Debug.LogError("Creature transform is null");
        }
    }


}
