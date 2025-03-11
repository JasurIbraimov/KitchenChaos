using UnityEngine;

public class ClearCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO _kitchenObjectSO;
    [SerializeField] private Transform _counterTopSide;

    private KitchenObject _kitchenObject;

    public KitchenObject GetKitchenObject()
    {
        return _kitchenObject;
    }

    public void SetKitchenObject(KitchenObject value)
    {
        _kitchenObject = value;
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return _counterTopSide;
    }


    public void Interact(Player player)
    {
        if (GetKitchenObject() == null)
        {
            Transform kitchenObjectTransform = Instantiate(_kitchenObjectSO.prefab, GetKitchenObjectFollowTransform());
            kitchenObjectTransform.GetComponent<KitchenObject>().KitchenObjectParent = this;
        }
        else
        {
            _kitchenObject.KitchenObjectParent = player;
        }
    }

    public bool HasKitchenObject()
    {
        return _kitchenObject != null;
    }

    public void ClearKitchenObject()
    {
        _kitchenObject = null;
    }
}
