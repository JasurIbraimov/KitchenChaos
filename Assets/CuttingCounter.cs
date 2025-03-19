using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no kitchen object here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
                player.GetKitchenObject().KitchenObjectParent = this;
            }
            else
            {
                // Player not carrying anothing 
            }
        }
        else
        {
            // There is a kitchen object here
            if (!player.HasKitchenObject())
            {
                // Player is not carrying something
                GetKitchenObject().KitchenObjectParent = player;
            }
            else
            {
                // Player is carrying something
            }
        }

    }

    public override void InteractAlternative(Player player)
    {
        if (HasKitchenObject())
        {
            // There is some kitchen object on the counter


            // Destroy kitchen object
            GetKitchenObject().DestroySelf();

            // Spawn cut version
            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);

        }
    }
}
