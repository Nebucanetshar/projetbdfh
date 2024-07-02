namespace assembly.Pages
{
    public partial class Counter
    {
        public int currentCount = 0;
        public void IncrementCount()
        {
            currentCount++;
            if (currentCount >= 5)
                throw new Exception("les valeur sont trop haute!");
            
         
                
        }

    }
}