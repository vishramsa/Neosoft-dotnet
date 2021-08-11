namespace PetStore
{
    class Cat : Pet
    {
        public CatType CatType { get; set; } = CatType.Abyssian; //autonomous property
        public double Weight { get; set; } = 7.0; // C# 7.0 and above allows initializing properties not earlier versions allows it.
        /// <summary>
        /// This method is shadowing its parent' method by hiding its implementation
        /// </summary>
        /// <returns>string format</returns>
        internal new string GetDetails(){
            string result = base.GetDetails();
            return result + $" \nCat type: {CatType} \n Cat Weight: {Weight} pounds";
        }

    }
    enum CatType{
        Abyssian, Persian, Himalayan, American_Bobtail, Balinese_Javanese, Bengal, Bombay,British_Shorthair
    }
}