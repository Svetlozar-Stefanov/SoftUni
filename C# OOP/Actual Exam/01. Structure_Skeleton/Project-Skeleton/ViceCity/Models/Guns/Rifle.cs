namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int DefaultBulletsPerBarrel = 50;
        private const int DefaultTotalBullets = 500;


        public Rifle(string name)
            : base(name, DefaultBulletsPerBarrel, DefaultTotalBullets)
        {
        }

        protected override int BulletsOnTrigger => 5;

        public override int Fire()
        {
            int bulletsShot = 0;

            if (BulletsPerBarrel >= 5)
            {
                BulletsPerBarrel -= 5;
                bulletsShot += 5;
                return bulletsShot;
            }

            if (BulletsPerBarrel <= 0 && TotalBullets > DefaultBulletsPerBarrel)
            {
                TotalBullets -= DefaultBulletsPerBarrel;

                BulletsPerBarrel += DefaultBulletsPerBarrel;
            }

            return bulletsShot;
        }
    }
}
