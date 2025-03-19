using UnityEngine;

public class ClearCounter : BaseCounter
{


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


}
