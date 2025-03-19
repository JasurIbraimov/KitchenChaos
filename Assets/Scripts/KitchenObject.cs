using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO _kitchenObjectSO;

    private IKitchenObjectParent _kitchenObjectParent;

    public KitchenObjectSO KitchenObjectSO { get => _kitchenObjectSO; private set => _kitchenObjectSO = value; }
    public IKitchenObjectParent KitchenObjectParent
    {
        get => _kitchenObjectParent;
        set
        {
            _kitchenObjectParent?.ClearKitchenObject();

            _kitchenObjectParent = value;
            if (_kitchenObjectParent.HasKitchenObject())
            {
                Debug.LogError("Counter already has a KitchenObject!");
            }
            _kitchenObjectParent.SetKitchenObject(this);
            transform.parent = _kitchenObjectParent.GetKitchenObjectFollowTransform();
            transform.localPosition = Vector3.zero;
        }
    }

    public void DestroySelf()
    {
        KitchenObjectParent.ClearKitchenObject();
        Destroy(gameObject);
    }


    // Helper method to spawn kitchen objects
    public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
    {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
        KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();
        kitchenObject.KitchenObjectParent = kitchenObjectParent;
        return kitchenObject;

    }
}
