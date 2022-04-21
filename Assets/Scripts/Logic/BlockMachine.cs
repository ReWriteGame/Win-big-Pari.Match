using UnityEngine;
using UnityEngine.Events;


public class BlockMachine : MonoBehaviour
{
    public UnityEvent takeBlockRightEvent;
    public UnityEvent takeBlockNotRightEvent;

    [SerializeField] private Blocks currnetBlock;

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Block>())
        {
            switch (currnetBlock)
            {
                case Blocks.Block1:
                    break;
                case Blocks.Block2:
                    break;
                case Blocks.Block3:
                    break;
            }

            if (currnetBlock == other.gameObject.GetComponent<Block>().CurrnetBlock)
            {
                takeBlockRightEvent?.Invoke();
            }
            else
            {
                takeBlockNotRightEvent?.Invoke(); 
            }
        }
    }
}
