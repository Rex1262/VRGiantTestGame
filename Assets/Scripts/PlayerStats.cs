using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace stats_System
{
    
    public class PlayerStats : MonoBehaviour
    {
        public string[] StrVars = {"Low", "Medium", "Heavy"};
    
        [SerializeField] private string currentPlayerStr;
    
        private void Awake()
        {
            SetPlayerStr(StrVars[0]);
        }
    
        public void SetPlayerStr(string str)
        {
            currentPlayerStr = str;
        }
    
        public string GetStr()
        {
            return currentPlayerStr;
        }
    }
}