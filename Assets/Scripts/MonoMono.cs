using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The only MonoBehaviour file.
/// </summary>
public class MonoMono : MonoBehaviour
{
    private void Awake()
    {
	DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
