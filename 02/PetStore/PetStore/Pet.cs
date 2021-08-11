using System;

namespace PetStore
{
    /// <summary>
    /// This class is generic for all types of pets and can be extended
    /// </summary>
    class Pet
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
        protected internal string GetDetails()
        {
            return $" Pet name : {name}\n Pet ID: {id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        }

    }   
    enum Gender
    {
        Male =0, Female
    }
}
