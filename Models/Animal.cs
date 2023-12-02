   /// <summary>
   /// Main class to store and manage the aaplication data
   /// </summary>
   public class Animal
    {
        /// <summary>
        /// Constructor for mock data
        /// </summary>
        /// <param name="animalID"></param>
        /// <param name="name"></param>
        /// <param name="breed"></param>
        /// <param name="dOB"></param>
        /// <param name="sex"></param>
        /// <param name="price"></param>
        /// <param name="status"></param>
        public Animal( int animalID, string name,  string breed, DateTime dOB ,string sex, decimal price, string status)
        {   
            this.AnimalID=animalID;
            this.Name = name;
            this.Breed = breed;
            this.DOB = dOB;
            this.Sex = sex;
            this.Price = price;
            this.Status = status;

        }
    /// <summary>
    /// Constructor 
    /// </summary>
        public Animal(){}
         
        
        /// <summary>
        /// Primary Key of Data
        /// </summary>
        public int AnimalID  {get; set;}
        /// <summary>
        /// Name of animal
        /// </summary>
        public string Name {get; set;}
        /// <summary>
        /// breed of Animal
        /// </summary>
        public string Breed{get; set;}
        /// <summary>
        /// DateTime of Animal
        /// </summary>
        public DateTime DOB {get; set;}
        /// <summary>
        /// Sex of animal;
        /// </summary>
        public string Sex {get; set;}
        /// <summary>
        /// Price of animal
        /// </summary>
        public decimal Price {get; set;}
        /// <summary>
        /// Status: active or inactive
        /// </summary>
        public string Status {get; set;}

    /// <summary>
    /// Generate fake data for playground 
    /// </summary>
    /// <returns>List of Animals</returns>
        public static List<Animal>GetAnimals()
        {
            List<Animal> animals =  new List<Animal>();
            
            for(int i=1; i<5;i++)
            {
                animals.Add(new Animal(1000 + 10*i+5, "Bully" + (1000 + 1*i).ToString(),"Holstein", new DateTime(2023,11,23), "Female", 5000 + i*1, "Active"));
                animals.Add(new Animal(1000 + 20*i+4, "Bully" + (1000 + 2*i).ToString(), "Brahma",new DateTime(2023,1,3), "Female", 5000 + i*2,"Active"));
                animals.Add(new Animal(1000 + 30*i+3, "Bully" + (1000 + 3*i).ToString(), "Angus",new DateTime(2023,10,2), "Male", 5000 + i*3,"Inactive"));
                animals.Add(new Animal(1000 + 40*i+2, "Bully" + (1000 + 4*i).ToString(), "Simmental",new DateTime(2023,3,2), "Female", 5000 + i*4,"Active"));
                animals.Add(new Animal(1000 + 50*i+1, "Bully" + (1000 + 5*i).ToString(), "Angus",new DateTime(2023,5,5), "Male", 5000 + i*5,"Active"));

            }


            return animals;

        } 
    }