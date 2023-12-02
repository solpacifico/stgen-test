   public class Animal
    {
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

        public Animal(){}

        public int AnimalID  {get; set;}
        public string Name {get; set;}
        public string Breed{get; set;}
        public DateTime DOB {get; set;}
        public string Sex {get; set;}
        public decimal Price {get; set;}
        public string Status {get; set;}

        public static List<Animal>GetAnimals()
        {
            List<Animal> animals =  new List<Animal>();
            
            for(int i=1; i<5;i++)
            {
                animals.Add(new Animal(1000 + 10*i+5, "Bully" + (1000 + 1*i).ToString(),"Holstein", new DateTime(2023,11,23), "Female", 5000 + i*1, "Active"));
                animals.Add(new Animal(1000 + 20*i+4, "Bully" + (1000 + 2*i).ToString(), "Brahma",new DateTime(2023,1,3), "Female", 5000 + i*2,"Active"));
                animals.Add(new Animal(1000 + 30*i+3, "Bully" + (1000 + 3*i).ToString(), "Angus",new DateTime(2023,10,2), "Male", 5000 + i*3,"Active"));
                animals.Add(new Animal(1000 + 40*i+2, "Bully" + (1000 + 4*i).ToString(), "Simmental",new DateTime(2023,3,2), "Female", 5000 + i*4,"Active"));
                animals.Add(new Animal(1000 + 50*i+1, "Bully" + (1000 + 5*i).ToString(), "Angus",new DateTime(2023,5,5), "Male", 5000 + i*5,"Active"));

            }


            return animals;

        } 
    }