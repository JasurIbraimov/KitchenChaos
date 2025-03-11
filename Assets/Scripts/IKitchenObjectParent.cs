using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObjectParent
{
    public bool HasKitchenObject();

    public void ClearKitchenObject();

    public KitchenObject GetKitchenObject();

    public void SetKitchenObject(KitchenObject value);
    public Transform GetKitchenObjectFollowTransform();

}
