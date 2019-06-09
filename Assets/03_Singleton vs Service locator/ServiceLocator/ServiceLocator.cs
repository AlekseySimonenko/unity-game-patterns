using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : MonoBehaviour
{
    static public ServiceLocator Instance;

    [SerializeField] private GameObject LogManagerPrefab;//ILogManager
    [SerializeField] private GameObject LocalisationManagerPrefab;//ILocalisationManager
    [SerializeField] private GameObject AnalyticsManagerPrefab;//IAnalyticsManager
    [SerializeField] private GameObject AdsManagerPrefab;//IAdsManager
    [SerializeField] private GameObject SaveManagerPrefab;//ISaveManager

    public ILogManager LogManager;//ILogManager
    public ILogManager LocalisationManager;//ILocalisationManager
    public ILogManager AnalyticsManager;//IAnalyticsManager
    public ILogManager AdsManager;//IAdsManager
    public ILogManager SaveManager;//ISaveManager


    void Awake()
    {
        Instance = this;

        LogManager = LogManagerPrefab.GetComponent<ILogManager>();//Take first component with interface
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
