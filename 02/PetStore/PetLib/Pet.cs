using System;

namespace PetLib
{
    public class Pet
    {
        int id;
        /// <summary>
        /// This property is returing the value of private field 'id' and also allows to set its value
        /// </summary>
        /// <value>int id</value>
        public int Id{
            get{
                return id;
            }
            set{
                id=value;
            }
        }
        Gender gender;
        public Gender Gender { 
            get{
                return gender;
            }
            set{
                gender = value;
            } 
            }
        DateTime dob;
        public DateTime Dob { 
            get{
                return dob;
            } 
            set{
                dob=value;
                }
            }
        string name;
        public string Name { 
            get{return name;} 
            set{name = value;}
        }
        /// <summary>
        /// This method returns the formatted string with all details of a pet, name, id, gender, dob
        /// </summary>
        /// <returns>string</returns>
        public string GetDetails()
        {
            return $"without any params Pet name : {name}\n Pet ID: {id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        } 
        public string GetDetails(string name ="Feline"){
            return $"With string param Pet name : {this.name =name}\n Pet ID: {id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        }
        public string GetDetails(string name, int id){
            return $" Pet name : {this.name =name}\n Pet ID: {this.id =id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        }
        public string GetDetails(string name, int id, DateTime dob){
            return $" Pet name : {this.name =name}\n Pet ID: {id}\n Pet Birthday : {this.dob=dob}\n Pet Gender : {gender}"; 
        }
        public string GetDetails(string name, int id, DateTime dob, Gender gender){
            return $" Pet name : {this.name =name}\n Pet ID: {id}\n Pet Birthday : {this.dob=dob}\n Pet Gender : {this.gender=gender}"; 
        }

        public virtual void GetMeal(Gender gender){
            if(gender == Gender.Male){
                Console.Write("\n200 gms of wet food");
            }
            else
                Console.Write("\n125 gms of wet food");
        }
    }   
    public enum Gender
    {
        Male =0, Female
    }
}
