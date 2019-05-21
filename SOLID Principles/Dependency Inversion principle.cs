namespace DIP
{
    public class SmartPhone {
       public void fingerprintSensor(){

       }
    }
    public class User{
        private SmartPhone phone;
        public void setPhone(){
            this.phone = new SmartPhone(100);
        }
        public void featureUpdates(){
            phone.fingerprintSensor();
        }
    }
    
}

//fix violation

namespace DIP{
    public interface IPhone
    {
        void fingerprintSensor(){

        }
    }
    public class SmartPhone : IPhone{
        public override void fingerprintSensor(){

        }
    }
    public class User{
        private IPhone phone;
        public setPhone(final IPhone phone){
            this.phone = phone;
        }
        public void featureUpdates(){
            phone.fingerprintSensor();
        }
    }
}