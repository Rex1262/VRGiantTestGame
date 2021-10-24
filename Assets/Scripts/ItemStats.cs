using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


namespace stats_System
{
    [RequireComponent(typeof(XRGrabInteractable))]
    public class ItemStats : MonoBehaviour
    {
        public string strStat;
        [SerializeField] private PlayerStats player;

        private void Start()
        {
            CompareStats(player);
        }

        public void CompareStats(PlayerStats player)
        {
            if (strStat != player.GetStr())
            {
                this.GetComponent<XRGrabInteractable>().enabled = false;
            }
            else
            {
                this.GetComponent<XRGrabInteractable>().enabled = true;
            }
        }
    }
}