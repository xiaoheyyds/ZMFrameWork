﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ZMGC.SK
{
    public class SKLogicCtrl : ILogicBehaviour
    {
        public void OnCreate()
        {
            Debug.Log("SKLogicCtrl  OnCreate>>>");
          
        }

        public void ExitbattleGame()
        {
            WorldManager.DestroyWorld<SKWorld>();
        }
        public void OnDestroy()
        {
            Debug.Log("SKLogicCtrl  OnDestroy>>>");
        }

    }
}
