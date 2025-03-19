using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO _kitchenObjectSO;
    [SerializeField] private Transform _counterTopSide;
    private KitchenObject _kitchenObject;

    public KitchenObjectSO KitchenObjectSO { get => _kitchenObjectSO; private set => _kitchenObjectSO = value; }

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
    public bool HasKitchenObject()
    {
        return _kitchenObject != null;
    }

    public void ClearKitchenObject()
    {
        _kitchenObject = null;
    }

    public virtual void Interact(Player player)
    {

    }
    public virtual void InteractAlternative(Player player)
    {

    }
}
