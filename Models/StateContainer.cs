/**
This class is a service are injected as a singleton in the components for persist the state of the selected items
*/
public class StateContainer
{
    private ShoppingCart? savedSp;

    /// <summary>
    /// Singleton pattern applied
    /// </summary>
    public ShoppingCart SavedSP
    {
        get => savedSp ?? new ShoppingCart();
        set
        {            
            if(value == null)
            {
                savedSp = new ShoppingCart();
            }
            else {
                savedSp = value;
            } 
            NotifyStateChanged();
        }
    }
    /// <summary>
    /// *Adds new item to state
    /// </summary>
    /// <param name="item">Item to be added</param>
    public void AddToSP(Animal item)
    {
        savedSp ??= new ShoppingCart();
        if(savedSp.Content.FindIndex(x => x.AnimalID == item.AnimalID) == -1) //Does no exist
        {
            savedSp?.Content.Add(item);
        }        
        NotifyStateChanged();
    }
    /// <summary>
    /// Removes items when deselction action is performed
    /// </summary>
    /// <param name="item"></param>
    public void RemoveFromSP(Animal item)
    {        
        int? indx = savedSp?.Content.FindIndex(x => x.AnimalID == item.AnimalID);
        savedSp?.Content.RemoveAt(indx ?? -1);
        
        NotifyStateChanged();
    }

    /// <summary>
    /// On change notification
    /// </summary>
    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}