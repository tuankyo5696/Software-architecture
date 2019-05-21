namespace LSP
{
    public abstract class Mammal {
        public virtual void Eat();
        public virtual void giveBirth();
        public virtual void Swim();
        public virtual void Walk()
    }
    public class Dolphin : Mammal{
        public override void Walk(){
            // Dolphin can't walk
        }
    }
    public class Pig : Mammal{
        public override void Swim(){
            // Pig can't swim
        }
    }
}
// fix violation

namespace LSP{
    public abstract class Mammal {
        public virtual void Eat();
        public virtual void giveBirth();
    }
    public class MammalCanSwim : Mammal{
        public virtual void Swim();
    }
    public class MammalCanWalk : Mammal{
        public virtual void Walk();
    }
}