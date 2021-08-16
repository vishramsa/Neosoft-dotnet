using System.Collections.Generic;
namespace PetData
{
    public class FileRepo:IRepo
    {
        static List<Cat> cats=null;
        public IEnumerable<Cat> Init(){
            cats=new List<Cat>(){
                new Cat(){Id=100, CatType=CatType.Abyssian, Dob=new System.DateTime(2013,12,13),Gender=Gender.Female,Name="Kitty", Weight=7.5},
                new Cat(){Id=101, CatType=CatType.Balinese_Javanese, Dob=new System.DateTime(2016,02,23),Gender=Gender.Male,Name="Billy", Weight=8.5},
                new Cat(){Id=102, CatType=CatType.Bengal, Dob=new System.DateTime(2021,12,13),Gender=Gender.Female,Name="Snow", Weight=4.5}
            };
            return cats;
        }
        public Stack<Cat> Init_Stack(){
            Stack<Cat> cats=new Stack<Cat>();
            cats.Push( new Cat(){Id=100, CatType=CatType.Abyssian, Dob=new System.DateTime(2013,12,13),Gender=Gender.Female,Name="Kitty", Weight=7.5});
            cats.Push( new Cat(){Id=101, CatType=CatType.Balinese_Javanese, Dob=new System.DateTime(2016,02,23),Gender=Gender.Male,Name="Billy", Weight=8.5});
            cats.Push(new Cat(){Id=102, CatType=CatType.Bengal, Dob=new System.DateTime(2021,12,13),Gender=Gender.Female,Name="Snow", Weight=4.5});
            return cats;
        }

        public Dictionary<int, Cat> Init_Dictionary(){
            Dictionary<int,Cat> cats = new Dictionary<int, Cat>();
            cats.Add(1, new Cat(){Id=102, CatType=CatType.Bengal, Dob=new System.DateTime(2021,12,13),Gender=Gender.Female,Name="Snow", Weight=4.5});
            cats.Add(2,new Cat(){Id=101, CatType=CatType.Balinese_Javanese, Dob=new System.DateTime(2016,02,23),Gender=Gender.Male,Name="Billy", Weight=8.5});
            cats.Add(3,new Cat(){Id=100, CatType=CatType.Abyssian, Dob=new System.DateTime(2013,12,13),Gender=Gender.Female,Name="Kitty", Weight=7.5});
            return cats;
        }
    
    }
}