using System;

namespace PetStore
{
    class Pet
    {
        //Values type
        // numbers - Signed (sbyte, short, int, long), unsigned (byte, ushort, uint, ulong), float, double, decimal
        internal int id;
        internal Gender gender;
        internal DateTime dob;
        // reference type
        internal string name;

        internal string GetDetails()
        {
            return $" Pet name : {name}\n Pet ID: {id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        }

    }   
    // enums are named constants like days of a week, month of year, color etc...
    enum Gender
    {
        Male =0, Female
    }
}
