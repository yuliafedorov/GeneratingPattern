using System;

namespace StructuralPatterns
{
    interface ILion
    {
        void Roar();
    }

    class AfricanLion : ILion
    {
        public void Roar()
        {

        }
    }

    class AsiaLion : ILion
    {
        public void Roar()
        {

        }
    }
    class Hunter
    {
        public void Hunt(ILion lion)
        {

        }
    }// This needs to be added to the game
    class WildDog
    {
        public void bark()
        {
        }
    }

    // Adapter around wild dog to make it compatible with our game
    class WildDogAdapter : ILion
    {
        private WildDog mDog;
        public WildDogAdapter(WildDog dog)
        {
            this.mDog = dog;
        }
        public void Roar()
        {
            mDog.bark();
        }
    }
    class UsageFactoryMethod
    {
        public void use()
        {
            var wildDog = new WildDog();
            var wildDogAdapter = new WildDogAdapter(wildDog);

            var hunter = new Hunter();
            hunter.Hunt(wildDogAdapter);
        }
    }
}
