using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBehaviour : MonoBehaviour
{
    [SerializeField] public Transform destination;

    public Transform GetDestination(){

        return destination;
    }
}
