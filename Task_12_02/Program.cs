using Task_12_02.Publications;

namespace Task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat() { name = "Снежка", age = "3 года", breed = "Мейн-кун", color = "белый" };
            var cat2 = new Cat() { name = "Луна", color = "серый", breed = "Русская голубая", age = "5 лет" };

            cat1.CatInfo(); 
            cat1.IsMother(); 
            cat2.CatInfo(); 
            cat2.IsChildFree(); 

            var dog1 = new Dog() { name = "Арчи", age = "8 лет", breed = "такса", color = "черный" };
            var dog2 = new Dog() { name = "Эльза", breed = "бульдог", age = " 4 года", color = "серый" };

            dog1.DogInfo(); 
            dog1.IsNotVaccine(); 

            dog2.DogInfo(); 
            dog2.IsVaccine();  
        }
    }
}
