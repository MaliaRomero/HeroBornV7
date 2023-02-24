using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class IManager : MonoBehaviour
public interface IManager
{
    string State { get; set; }
    void Initialize();
}
