namespace Strategy
{
    public class Fighter
    {

        public void ChangeMood(IFighter fighter)
        {

            fighter.Fight();
        }

        public int Health { get; set; }
    }
}