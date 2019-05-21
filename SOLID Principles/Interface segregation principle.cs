namespace ISP
{
    public interface ITelephone
    {
        void Call();

        void Message();

        void playMusic();    
    }

    public class MobileDevice : ITelephone{
        public void Call(){
            console.log('Call everyone');
        }
        public void Message(){
            console.log('Message everyone');
        }
        public void playMusic(){
            console.log('Mobile can play music');
        }

    }
    public class LandlineDevice : ITelephone{
         public void Call(){
            console.log('Call everyone');
        }
        public void Message(){
            throw new NotSupportedException()
        }
        public void playMusic(){
            throw new NotSupportedException()
        }

    }
}

// fix violation
namespace ISP
{
    public interface ICall
    {
        void Call();
           
    }
    public interface IMessage
    {
        void Message();
           
    }
    public interface IPlayMusic{
        void playMusic();
    }

    public class MobileDevice : ICall,IMessage,IPlayMusic{
        public void Call(){
            console.log('Call everyone');
        }
        public void Message(){
            console.log('Message everyone');
        }
        public void playMusic(){
            console.log('Mobile can play music');
        }

    }
    public class LandlineDevice : ICall{
         public void Call(){
            console.log('Call everyone');
        }
    }
}
