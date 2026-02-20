using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace Assets.Scripts.Controllers
{
    class GameController : MonoBehaviour
    {

        void Start()
        {
            Debug.Log("Player Name : " + PlayerPrefs.GetString("PlayerName"));
        }

    }
}
