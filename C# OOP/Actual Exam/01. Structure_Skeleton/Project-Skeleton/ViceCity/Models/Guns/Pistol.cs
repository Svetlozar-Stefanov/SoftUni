namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int DefaultBulletsPerBarrel = 10;
        private const int DefaultTotalBullets = 100;


        public Pistol(string name) 
            : base(name, DefaultBulletsPerBarrel, DefaultTotalBullets)
        {
        }

        protected override int BulletsOnTrigger => 1;

        public override int Fire()
        {
            int bulletsShot = 0;

            if (BulletsPerBarrel >= 1)
            {
                BulletsPerBarrel -= 1;
                bulletsShot++;
                return bulletsShot;
            }

            if (BulletsPerBarrel <= 0 && TotalBullets >= DefaultBulletsPerBarrel)
            {
                TotalBullets -= DefaultBulletsPerBarrel;

                BulletsPerBarrel += DefaultBulletsPerBarrel;
            }

            return bulletsShot;
        }
    }
}
