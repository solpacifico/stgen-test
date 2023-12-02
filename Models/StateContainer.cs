public class StateContainer
{
    private ShoppingCart? savedSp;

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

    public void AddToSP(Animal item)
    {
        savedSp ??= new ShoppingCart();
        if(savedSp.Content.FindIndex(x => x.AnimalID == item.AnimalID) == -1) //Does no exist
        {
            savedSp?.Content.Add(item);
        }        
        
        NotifyStateChanged();

    }

    public void RemoveFromSP(Animal item)
    {        
        int? indx = savedSp?.Content.FindIndex(x => x.AnimalID == item.AnimalID);
        savedSp?.Content.RemoveAt(indx ?? -1);
        
        NotifyStateChanged();
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}