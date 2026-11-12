using DbBroker;

namespace SistemskeOperacije
{
    public abstract class ApstraktnaSO
    {
        protected GenerickiBroker broker;

        public ApstraktnaSO()
        {
            broker = new GenerickiBroker();
        }

        public void Izvrsi()
        {
            try
            {
                broker.OtvoriKonekciju();
                broker.ZapocniTransakciju();

                IzvrsiKonkretnuOperaciju();

                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        protected abstract void IzvrsiKonkretnuOperaciju();
    }
}
