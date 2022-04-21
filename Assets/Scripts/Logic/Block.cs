using System;
using UnityEngine;
using UnityEngine.Events;

public enum Blocks {Block1,Block2,Block3}
public class Block : MonoBehaviour
{
   public UnityEvent takeBlockMachineEvent;

   [SerializeField] private Blocks currnetBlock;

   public Blocks CurrnetBlock => currnetBlock;

   
   private void OnCollisionEnter2D(Collision2D other)
   {
      if(other.gameObject.GetComponent<BlockMachine>())
         takeBlockMachineEvent?.Invoke();
   }
}
