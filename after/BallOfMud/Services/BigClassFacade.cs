namespace BallOfMud.Services
{
    public class BigClassFacade
    {
        private BigClass _bigClass;

        public BigClassFacade()
        {
            _bigClass = new BigClass();
            _bigClass.SetValueI(0);
        }

        public void Incrememnt()
        {
            _bigClass.IncrementI();
        }

        public void Decrement()
        {
            _bigClass.DecrememntI();
        }

        public int GetCurrentValue()
        {
            return _bigClass.GetValueA();
        } 
        
         
        
        
    }
}