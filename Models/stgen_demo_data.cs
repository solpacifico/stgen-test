#region 
//General clases and enums
// applicable laws. 
#endregion


namespace stgen_demo_data
{
    public enum Sex 
    {
        Male,
        Female
    }

    public enum Status
    {
        Active,
        Inactive
    }

    public enum Breed
    {
        Angus,
        Brahma,
        Holstein,
        Simmental

    }


    public class StatusData
    {
        public int StatusID {get; set;}
        public string Status {get; set;}

    }



}


  
  