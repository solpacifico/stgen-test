 public class ShoppingCart
{
    public List<Animal> Content {get; set;}
    public ShoppingCart(){
        this.Content=new List<Animal>();
    }

    public ShoppingCart(List<Animal> content)
    {
        this.Content = content;
    }



}